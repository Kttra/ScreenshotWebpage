using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webView2_Starter_Template
{
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();
        }
        //Default selected item in combobox (selects the previously saved option)
        private int GetDefaultPicType()
        {
            int picType;

            //Get picture type from application settings
            switch (Properties.Settings.Default.PicExtension)
            {
                //If it's png, return 0 index, etc.
                case "png":
                    picType = 0;
                    break;
                case "jpg":
                    picType = 1;
                    break;
                case "bmp":
                    picType = 2;
                    break;
                default:
                    picType = 0;
                    break;
            }

            return picType;
        }
        //Load the form
        private void Form_Settings_Load(object sender, EventArgs e)
        {
            //Set the default select state to the 1st index
            comboBoxPicType.SelectedIndex = GetDefaultPicType();

            //Set the default picture name
            textBoxFileName.Text = Properties.Settings.Default.PicName;

            /*
            //A way to add combo box items
            comboBoxPicType.Items.Add("bmp");
            comboBoxPicType.Items.Add("jpg");
            comboBoxPicType.Items.Add("png");
            //Clear all
            comboBoxPicType.Items.Clear();
            */
        }
        //Confirm button click event
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //Remove any invalid characters from the file name
            textBoxFileName.Text = ReplaceInvalidChars(textBoxFileName.Text);

            //Check if file name is an empty string
            if (String.IsNullOrEmpty(textBoxFileName.Text))
            {
                MessageBox.Show("File name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SetProperties();
            }
        }
        //End of form, change the application settings
        private void SetProperties()
        {
            //Change the default picture type
            switch (comboBoxPicType.GetItemText(comboBoxPicType.SelectedItem))
            {
                case "PNG":
                    Properties.Settings.Default.PicExtension = "png";
                    break;
                case "JPEG":
                    Properties.Settings.Default.PicExtension = "jpg";
                    break;
                case "BMP":
                    Properties.Settings.Default.PicExtension = "bmp";
                    break;
                default:
                    Properties.Settings.Default.PicExtension = "png";
                    break;
            }

            Properties.Settings.Default.PicName = textBoxFileName.Text;

            //Save the settings
            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //Removing invalid characters in the file name
        public string ReplaceInvalidChars(string filename)
        {
            return string.Join("", filename.Split(Path.GetInvalidFileNameChars()));
        }
    }
}
