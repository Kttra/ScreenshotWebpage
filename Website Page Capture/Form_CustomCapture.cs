using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace webView2_Starter_Template
{
    public partial class Form_CustomCapture : Form
    {
        public int TimeInterval1 { get; set; }
        public int TimeInterval2 { get; set; }
        public string Webpage { get; set; }
        public int Increment { get; set; }
        public int Pause { get; set; }
        public int Stop { get; set; }
        public Form_CustomCapture()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Columns[0].Text = "Webpages:";
        }
        //Show information when mouse hovers over a label
        private void labelLink_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paste in the link you want to capture here", labelLink);
        }

        private void textBoxLink_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paste in the link you want to capture here", textBoxLink);
        }

        private void labelInterval_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Type in the numbers we should append to the link", labelInterval);
        }

        private void labelStep_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("The number we will increment by", labelStep);
        }

        private void labelPause_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("The amount of time between each screenshot. In seconds.", labelPause);
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("The amount of captures before we wait for userinput again. (0 means no pause)", labelPause);
        }
        //Prevents letters from being typed in these textboxes
        private void textBoxInterval1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxInterval2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxStep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxPause_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //If enter is pressed in the link textbox, do same thing as confirm button press
        private void textBoxLink_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (IsValid())
                {
                    //Set the return values for the main form
                    TimeInterval1 = int.Parse(textBoxInterval1.Text);
                    TimeInterval2 = int.Parse(textBoxInterval2.Text);
                    Webpage = textBoxLink.Text;
                    Increment= int.Parse(textBoxStep.Text);
                    Pause = int.Parse(textBoxPause.Text);
                    Stop = int.Parse(textBoxStop.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        //Confirm button is pressed, initiate check can capture if valid
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                //Set the return values for the main form
                TimeInterval1 = int.Parse(textBoxInterval1.Text);
                TimeInterval2 = int.Parse(textBoxInterval2.Text);
                Webpage = textBoxLink.Text;
                Increment = int.Parse(textBoxStep.Text);
                Pause = int.Parse(textBoxPause.Text);
                Stop = int.Parse(textBoxStop.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        //Checks if all input are valid
        private bool IsValid()
        {
            //Simple check, see if all textboxes are filled out
            if (string.IsNullOrEmpty(textBoxPause.Text) || string.IsNullOrEmpty(textBoxLink.Text) || string.IsNullOrEmpty(textBoxInterval1.Text)
                || string.IsNullOrEmpty(textBoxInterval2.Text) || string.IsNullOrEmpty(textBoxStep.Text) || string.IsNullOrEmpty(textBoxStop.Text))
            {
                MessageBox.Show("Invalid input. Textboxes must be filled out.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Check if valid website
            var mainForm = Application.OpenForms.OfType<webView>().Single();
            mainForm.AddressBox.Text = textBoxLink.Text;
            //LoadUrl returns false if link cannot load properly
            if (!mainForm.LoadUrl())
            {
                MessageBox.Show($"Invalid link. Remember to start with: \"https://\"", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            //If any one of the values are not valid numbers, this will become false
            bool correctNums = isValidNum(textBoxStop.Text, 0, "Stop") && isValidNum(textBoxStep.Text, 1, "Step") &&
                               isValidNum(textBoxInterval1.Text, 0, "Interval1") && isValidNum(textBoxInterval2.Text, 0, "Interval2") &&
                               isValidNum(textBoxPause.Text, 1, "Pause");
            if (!correctNums)
            {
                return false;
            }

            return true;
        }
        //Check the textbox values
        private bool isValidNum(string num, int minimum, string type)
        {
            //If true, become
            bool isNum = int.TryParse(num, out int temp);
            if (isNum)
            {
                if (temp < minimum)
                {
                    MessageBox.Show($"Invalid input. {type} value must be greater than {minimum-1}.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }

            MessageBox.Show($"Invalid input. {type} value must be a number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        //2nd tab close, we'll determine valid response in main form
        private void btnConfirm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add items in the listview
            string[] arr = new String[1];
            ListViewItem item;

            //Add first item to top
            arr[0] = textBoxURL.Text;

            item = new ListViewItem(arr);
            listView1.Items.Insert(0, item);
            textBoxURL.Text = "";
        }
        //When enter is pressed in the list tab for the link url, add the link to the list
        private void textBoxURL_KeyDown(object sender, KeyEventArgs e)
        {
            //Add items in the listview
            string[] arr = new String[1];
            ListViewItem item;

            //Add first item to top
            arr[0] = textBoxURL.Text;

            item = new ListViewItem(arr);
            listView1.Items.Insert(0, item);
            textBoxURL.Text = "";
        }
    }
}
