using Newtonsoft.Json.Linq; //Use Newtonsoft Json package

namespace webView2_Starter_Template
{
    public partial class webView : Form
    {
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
        //Method that loads the webpage
        private void LoadUrl()
        {
            //Checks to see if link is valid
            string address = AddressBox.Text;
            if (address.Length < 9 || address.Substring(0, 8) != "https://")
            {
                myWebView.CoreWebView2.ExecuteScriptAsync($"alert('Link is not valid, remember to start with https://')");
            }
            //Link is almost valid enough
            else
            {
                try
                {
                    //To check what browser type is set go to: https://www.deviceinfo.me/
                    //myWebView.CoreWebView2.Settings.UserAgent = Globals.edgeUA; //Change useragent to edge
                    myWebView.CoreWebView2.Navigate(AddressBox.Text);
                }
                //Catch any other errors we might not have accounted for
                catch (Exception)
                {
                    myWebView.CoreWebView2.ExecuteScriptAsync($"alert('Not a valid link')");
                }
            }
        }
        //Load the webpage when Go is clicked
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            LoadUrl();
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
            Image myImage = await TakeWebScreenshot();
            myImage.Save("Screenshot.jpg");
        }
        //Get the webpage bitmap and then save it as an image
        public async Task<Image> TakeWebScreenshot(bool currentControlClipOnly = false)
        {
            dynamic scl = null;
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
    }
}