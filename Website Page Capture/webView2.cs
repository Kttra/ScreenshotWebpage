using Newtonsoft.Json.Linq; //Use Newtonsoft Json package
using System.Diagnostics;

namespace webView2_Starter_Template
{
    public partial class webView : Form
    {
        public static CancellationTokenSource cts = new CancellationTokenSource();
        public webView()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(Form_Resize);
        }
        //Resize the webview2 page
        private void Form_Resize(object sender, EventArgs e)
        {
            myWebView.Size = this.ClientSize - new System.Drawing.Size(myWebView.Location);
        }
        //Method that loads the webpage, return false if link is not valid
        public bool LoadUrl()
        {
            //Checks to see if link is valid
            string address = AddressBox.Text;
            if (address.Length < 9 || address.Substring(0, 8) != "https://")
            {
                myWebView.CoreWebView2.ExecuteScriptAsync($"alert('Link is not valid, remember to start with https://')");
                return false;
            }
            //Link is almost valid enough
            else
            {
                try
                {
                    //To check what browser type is set go to: https://www.deviceinfo.me/
                    //myWebView.CoreWebView2.Settings.UserAgent = Globals.edgeUA; //Change useragent to edge
                    myWebView.CoreWebView2.Navigate(AddressBox.Text);
                    return true;
                }
                //Catch any other errors we might not have accounted for
                catch (Exception)
                {
                    myWebView.CoreWebView2.ExecuteScriptAsync($"alert('Not a valid link')");
                    return false;
                }
            }
        }
        //Load the webpage when Go is clicked
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            LoadUrl();
        }
        public int calMat(int num1, int num2)
        {
            return num1 + num2;
        }
        //Load the webpage when enter is pressed in the address bar
        private void AddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadUrl();
            }
        }
        //Take a screenshot of the webview2 page
        private async void BtnCapture_Click(object sender, EventArgs e)
        {
            string imageName = Properties.Settings.Default.PicName;
            string picExtension = Properties.Settings.Default.PicExtension;

            //Below is to save to specific directory or in current directory
            string fileName = imageName + "." + picExtension;

            //Create directory if it doesn't exist
            //string saveDirectory = @"images\"; //@"C:\images" if you want specific directory
            string saveDirectory = Properties.Settings.Default.FolderName + @"\";
            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }

            //Combine file name and path
            string fileSavePath = Path.Combine(saveDirectory, fileName);

            //Capture screenshot and save
            Image myImage = await TakeWebScreenshot();
            myImage.Save(fileSavePath, GetFileType());
        }
        //Return picture filetype
        private System.Drawing.Imaging.ImageFormat GetFileType()
        {
            System.Drawing.Imaging.ImageFormat fileType;

            switch (Properties.Settings.Default.PicExtension)
            {
                case "png":
                    fileType = System.Drawing.Imaging.ImageFormat.Png;
                    break;
                case "jpg":
                    fileType = System.Drawing.Imaging.ImageFormat.Jpeg;
                    break;
                case "bmp":
                    fileType = System.Drawing.Imaging.ImageFormat.Bmp;
                    break;
                default:
                    fileType = System.Drawing.Imaging.ImageFormat.Png;
                    break;
            }

            return fileType;
        }
        //Get the webpage bitmap and then save it as an image
        public async Task<Image> TakeWebScreenshot(bool currentControlClipOnly = false)
        {
            dynamic? scl = null;
            Size siz;

            if (!currentControlClipOnly)
            {
                var res = await myWebView.CoreWebView2.ExecuteScriptAsync(@"var v = {""w"":document.body.scrollWidth, ""h"":document.body.scrollHeight}; v;");
                try { scl = JObject.Parse(res); } catch { }
            }
            siz = scl != null ?
                        new Size((int)scl.w > myWebView.Width ? (int)scl.w : myWebView.Width,
                                    (int)scl.h > myWebView.Height ? (int)scl.h : myWebView.Height)
                        :
                        myWebView.Size;

            var img = await GetWebBrowserBitmap(siz);
            return img;
        }
        //Get the webpage bitmap
        private async Task<Bitmap> GetWebBrowserBitmap(Size clipSize)
        {
            dynamic clip = new JObject();
            clip.x = 0;
            clip.y = 0;
            clip.width = clipSize.Width;
            clip.height = clipSize.Height;
            clip.scale = 1;

            dynamic settings = new JObject();
            settings.format = "jpeg";
            settings.clip = clip;
            settings.fromSurface = true;
            settings.captureBeyondViewport = true;

            var p = settings.ToString(Newtonsoft.Json.Formatting.None);

            var devData = await myWebView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", p);
            var imgData = (string)((dynamic)JObject.Parse(devData)).data;
            var ms = new MemoryStream(Convert.FromBase64String(imgData));
            return (Bitmap)Image.FromStream(ms);
        }
        //Open settings form
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Form_Settings settingsForm = new Form_Settings();
            var result = settingsForm.ShowDialog();

            //If the form closed succesfully, tell the user about the made changes
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Settings saved. Image files name will now be \"" + Properties.Settings.Default.PicName
                    + "\", the new folder name has changed to \"" + Properties.Settings.Default.FolderName
                    + "\", and the file type will be changed to " + Properties.Settings.Default.PicExtension + ".", "Success");
            }
        }
        //Open Custom Screenshot Settings
        private void BtnCustom_Click(object sender, EventArgs e)
        {
            Form_CustomCapture Form = new Form_CustomCapture();
            var result = Form.ShowDialog();

            //If form close successfully, begin the screenshot process
            if (result == DialogResult.OK)
            {
                try
                {
                    AddressBox.Text = "Attempting Cleanup...";
                    cts.Cancel();
                    cts.Dispose();
                }
                catch (Exception err)
                {
                    //MessageBox.Show(err.ToString());
                }
                cts = new CancellationTokenSource();
                progressBar1.Maximum = Form.TimeInterval2 - Form.TimeInterval1 + 1;
                progressBar1.Value = 0;
                labelProgress.Text = "Progress: "+@"0/"+progressBar1.Maximum;
                CustomCapture(cts.Token, Form.TimeInterval1, Form.TimeInterval2, Form.Webpage, Form.Increment, Form.Pause, Form.Stop);
            }
            else
            {
                //If there are items existing in listview and a DialogResult.OK response was not received, capture the webpages in listview
                if (Form.listView1.Items.Count > 0)
                {
                    foreach (ListViewItem myItem in Form.listView1.Items)
                    {
                        try
                        {
                            cts.Cancel();
                            cts.Dispose();
                        }
                        catch (Exception err)
                        {
                            //MessageBox.Show(err.ToString());
                        }
                        cts = new CancellationTokenSource();
                        progressBar1.Maximum = Form.listView1.Items.Count;
                        progressBar1.Value = 0;
                        labelProgress.Text = "Progress: " + @"0/" + progressBar1.Maximum;
                        CustomCapture2(cts.Token, Form);
                    }
                }
            }
        }
        public async void CustomCapture2(CancellationToken cancellationToken, dynamic Form)
        {
            int picNum = 0;
            try
            {
                foreach (ListViewItem myItem in Form.listView1.Items)
                {
                    AddressBox.Text = myItem.SubItems[0].Text.ToString();
                    LoadUrl();
                    picNum++;
                    await Task.Delay(3500);
                    await DoCustomCapture(picNum);
                    labelProgress.Text = "Progress: " + picNum + @"/" + progressBar1.Maximum;
                    progressBar1.Value = picNum;
                    //Cancel when asked requested to
                    if (cancellationToken.IsCancellationRequested)
                    {
                        AddressBox.Text = "Cancel Success";
                        return;
                    }
                }
                cts.Dispose();
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.ToString());
            }
        }
        public async void CustomCapture(CancellationToken cancellationToken, int timeInterval1, int timeInterval2, string webPage, int increment, int pause, int stop)
        {
            try
            {
                int picNum = 0;

                for (int i = timeInterval1; i <= timeInterval2; i = i + increment)
                {
                    AddressBox.Text = webPage + i;
                    LoadUrl();
                    //Pause before capturing to allow webpage to load in time
                    await Task.Delay(pause * 1000);
                    picNum++;
                    await DoCustomCapture(picNum);
                    labelProgress.Text = "Progress: "+picNum + @"/" + progressBar1.Maximum;
                    progressBar1.Value = picNum;
                    //Pause a bit after screenshot
                    await Task.Delay(500);
                    //A second pause between the screenshot
                    if (stop != 0 && picNum % stop == 0)
                    {
                        //Messagebox asking whether to continue or not
                        await Task.Run(() =>
                        {
                            var dialogResult = MessageBox.Show("Waiting for user input. Click ok to continue.", "Continue?", MessageBoxButtons.OKCancel);
                            if (dialogResult == System.Windows.Forms.DialogResult.OK)
                            {
                                
                            }
                            else
                            {
                                MessageBox.Show("Canceled custom capture progress.", "Cancel");
                                return;
                            }
                        });
                    }
                    //Cancel when asked requested to
                    if (cancellationToken.IsCancellationRequested)
                    {
                        AddressBox.Text = "Cancel Success";
                        return;
                    }
                    Console.WriteLine("ok");
                }
                cts.Dispose();
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.ToString());
            }
        }
        private async Task DoCustomCapture(int picNum)
        {
            string imageName = Properties.Settings.Default.PicName;
            string picExtension = Properties.Settings.Default.PicExtension;

            //Below is to save to specific directory or in current directory
            string fileName = imageName + picNum + "." + picExtension;

            //string saveDirectory = @"images\"; //@"C:\images" if you want specific directory
            string saveDirectory = Properties.Settings.Default.FolderName + @"\";
            //Create directory if it doesn't exist
            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }

            //Combine file name and path
            string fileSavePath = Path.Combine(saveDirectory, fileName);

            //Capture screenshot and save
            Image myImage = await TakeWebScreenshot();
            myImage.Save(fileSavePath, GetFileType());
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Cancel all the async methods
            try
            {
                cts.Cancel();
            }
            //Error
            catch (Exception)
            {
                MessageBox.Show("Task has already been stopped!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AddressBox.Text = "Attempting to stop...";
            cts.Dispose();
        }
        //Open the project directory
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            Process.Start("explorer.exe", workingDirectory);
        }
    }
}

