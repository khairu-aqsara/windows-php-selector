namespace PHP_Selector
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPhpVersion = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnChoose = new Button();
            txtDirectory = new TextBox();
            groupBox2 = new GroupBox();
            btnSelect = new Button();
            cmbPhpVersion = new ComboBox();
            folderBrowser = new FolderBrowserDialog();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblPhpVersion
            // 
            lblPhpVersion.AutoSize = true;
            lblPhpVersion.FlatStyle = FlatStyle.Flat;
            lblPhpVersion.Font = new Font("Segoe UI", 9F);
            lblPhpVersion.Location = new Point(19, 31);
            lblPhpVersion.Name = "lblPhpVersion";
            lblPhpVersion.Size = new Size(96, 15);
            lblPhpVersion.TabIndex = 0;
            lblPhpVersion.Text = "Available Version";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Path";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChoose);
            groupBox1.Controls.Add(txtDirectory);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 95);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "PHP Collection Directory";
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(374, 51);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(77, 23);
            btnChoose.TabIndex = 3;
            btnChoose.Text = "Choose";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // txtDirectory
            // 
            txtDirectory.Location = new Point(21, 52);
            txtDirectory.Name = "txtDirectory";
            txtDirectory.Size = new Size(347, 23);
            txtDirectory.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSelect);
            groupBox2.Controls.Add(cmbPhpVersion);
            groupBox2.Controls.Add(lblPhpVersion);
            groupBox2.Location = new Point(12, 113);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "PHP";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(242, 48);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 3;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // cmbPhpVersion
            // 
            cmbPhpVersion.FormattingEnabled = true;
            cmbPhpVersion.Location = new Point(19, 49);
            cmbPhpVersion.Name = "cmbPhpVersion";
            cmbPhpVersion.Size = new Size(217, 23);
            cmbPhpVersion.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 216);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(110, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "PHP Selector (1.0.0)";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 216);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 6;
            label2.Text = "By Khairu Aqsara";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 240);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "PHP Selector";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhpVersion;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnChoose;
        private TextBox txtDirectory;
        private Button btnSelect;
        private ComboBox cmbPhpVersion;
        private FolderBrowserDialog folderBrowser;
        private LinkLabel linkLabel1;
        private Label label2;
    }

}
