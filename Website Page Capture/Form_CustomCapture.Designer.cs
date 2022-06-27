namespace webView2_Starter_Template
{
    partial class Form_CustomCapture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.textBoxPause = new System.Windows.Forms.TextBox();
            this.labelPause = new System.Windows.Forms.Label();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.labelStep = new System.Windows.Forms.Label();
            this.textBoxInterval2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInterval1 = new System.Windows.Forms.TextBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Links = new System.Windows.Forms.ColumnHeader();
            this.btnConfirm2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 246);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxStop);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnConfirm);
            this.tabPage1.Controls.Add(this.textBoxPause);
            this.tabPage1.Controls.Add(this.labelPause);
            this.tabPage1.Controls.Add(this.textBoxStep);
            this.tabPage1.Controls.Add(this.labelStep);
            this.tabPage1.Controls.Add(this.textBoxInterval2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxInterval1);
            this.tabPage1.Controls.Add(this.labelInterval);
            this.tabPage1.Controls.Add(this.textBoxLink);
            this.tabPage1.Controls.Add(this.labelLink);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Auto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxStop
            // 
            this.textBoxStop.Location = new System.Drawing.Point(427, 89);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(75, 23);
            this.textBoxStop.TabIndex = 12;
            this.textBoxStop.Text = "0";
            this.textBoxStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(370, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stop:";
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(281, 136);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // textBoxPause
            // 
            this.textBoxPause.Location = new System.Drawing.Point(90, 89);
            this.textBoxPause.Name = "textBoxPause";
            this.textBoxPause.Size = new System.Drawing.Size(188, 23);
            this.textBoxPause.TabIndex = 9;
            this.textBoxPause.Text = "5";
            this.textBoxPause.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPause.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPause_KeyPress);
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPause.Location = new System.Drawing.Point(8, 93);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(61, 19);
            this.labelPause.TabIndex = 8;
            this.labelPause.Text = "Pause:";
            this.labelPause.MouseHover += new System.EventHandler(this.labelPause_MouseHover);
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(425, 48);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(75, 23);
            this.textBoxStep.TabIndex = 7;
            this.textBoxStep.Text = "1";
            this.textBoxStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStep_KeyPress);
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStep.Location = new System.Drawing.Point(369, 52);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(50, 19);
            this.labelStep.TabIndex = 6;
            this.labelStep.Text = "Step:";
            this.labelStep.MouseHover += new System.EventHandler(this.labelStep_MouseHover);
            // 
            // textBoxInterval2
            // 
            this.textBoxInterval2.Location = new System.Drawing.Point(203, 48);
            this.textBoxInterval2.Name = "textBoxInterval2";
            this.textBoxInterval2.Size = new System.Drawing.Size(75, 23);
            this.textBoxInterval2.TabIndex = 5;
            this.textBoxInterval2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInterval2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInterval2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(171, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "to";
            // 
            // textBoxInterval1
            // 
            this.textBoxInterval1.Location = new System.Drawing.Point(90, 48);
            this.textBoxInterval1.Name = "textBoxInterval1";
            this.textBoxInterval1.Size = new System.Drawing.Size(75, 23);
            this.textBoxInterval1.TabIndex = 3;
            this.textBoxInterval1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInterval1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInterval1_KeyPress);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInterval.Location = new System.Drawing.Point(8, 52);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(81, 19);
            this.labelInterval.TabIndex = 2;
            this.labelInterval.Text = "Interval:";
            this.labelInterval.MouseHover += new System.EventHandler(this.labelInterval_MouseHover);
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(67, 10);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(510, 23);
            this.textBoxLink.TabIndex = 1;
            this.textBoxLink.Text = "https://";
            this.textBoxLink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLink_KeyDown);
            this.textBoxLink.MouseHover += new System.EventHandler(this.textBoxLink_MouseHover);
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLink.Location = new System.Drawing.Point(8, 12);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(53, 19);
            this.labelLink.TabIndex = 0;
            this.labelLink.Text = "Link:";
            this.labelLink.MouseHover += new System.EventHandler(this.labelLink_MouseHover);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.btnConfirm2);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.textBoxURL);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Links";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Links});
            this.listView1.Location = new System.Drawing.Point(0, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(586, 97);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnConfirm2
            // 
            this.btnConfirm2.Location = new System.Drawing.Point(245, 42);
            this.btnConfirm2.Name = "btnConfirm2";
            this.btnConfirm2.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm2.TabIndex = 3;
            this.btnConfirm2.Text = "Confirm";
            this.btnConfirm2.UseVisualStyleBackColor = true;
            this.btnConfirm2.Click += new System.EventHandler(this.btnConfirm2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(326, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(104, 13);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(460, 23);
            this.textBoxURL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Link:";
            // 
            // Form_CustomCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 195);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_CustomCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Capture";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBoxLink;
        private Label labelLink;
        private TextBox textBoxStep;
        private Label labelStep;
        private TextBox textBoxInterval2;
        private Label label3;
        private TextBox textBoxInterval1;
        private Label labelInterval;
        private TextBox textBoxPause;
        private Label labelPause;
        private Button btnConfirm;
        private ToolTip toolTip1;
        private TextBox textBoxURL;
        private Label label1;
        private TextBox textBoxStop;
        private Label label2;
        private Button btnAdd;
        private Button btnConfirm2;
        private ColumnHeader Links;
        public ListView listView1;
    }
}