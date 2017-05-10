namespace MatthewJacome_CE06
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.numericUpDownMiles = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.textBoxMode = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMiles = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxLegs = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::MatthewJacome_CE06.Properties.Resources.document;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.newToolStripMenuItem.Text = "New          ";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 412);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxLegs);
            this.tabPage2.Controls.Add(this.textBoxHours);
            this.tabPage2.Controls.Add(this.textBoxMiles);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(458, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMode);
            this.groupBox1.Controls.Add(this.numericUpDownHours);
            this.groupBox1.Controls.Add(this.numericUpDownMiles);
            this.groupBox1.Controls.Add(this.comboBoxDirection);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mode";
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Items.AddRange(new object[] {
            "Nowhere",
            "East",
            "West",
            "North",
            "South"});
            this.comboBoxDirection.Location = new System.Drawing.Point(182, 54);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(121, 32);
            this.comboBoxDirection.TabIndex = 4;
            // 
            // numericUpDownMiles
            // 
            this.numericUpDownMiles.DecimalPlaces = 2;
            this.numericUpDownMiles.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownMiles.Location = new System.Drawing.Point(182, 100);
            this.numericUpDownMiles.Name = "numericUpDownMiles";
            this.numericUpDownMiles.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownMiles.TabIndex = 5;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.DecimalPlaces = 2;
            this.numericUpDownHours.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownHours.Location = new System.Drawing.Point(183, 144);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownHours.TabIndex = 6;
            // 
            // textBoxMode
            // 
            this.textBoxMode.Location = new System.Drawing.Point(182, 188);
            this.textBoxMode.Name = "textBoxMode";
            this.textBoxMode.Size = new System.Drawing.Size(120, 29);
            this.textBoxMode.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(26, 303);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(392, 52);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Miles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Legs";
            // 
            // textBoxMiles
            // 
            this.textBoxMiles.Location = new System.Drawing.Point(152, 25);
            this.textBoxMiles.Name = "textBoxMiles";
            this.textBoxMiles.ReadOnly = true;
            this.textBoxMiles.Size = new System.Drawing.Size(128, 29);
            this.textBoxMiles.TabIndex = 3;
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(152, 84);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.ReadOnly = true;
            this.textBoxHours.Size = new System.Drawing.Size(128, 29);
            this.textBoxHours.TabIndex = 4;
            // 
            // textBoxLegs
            // 
            this.textBoxLegs.Location = new System.Drawing.Point(152, 141);
            this.textBoxLegs.Name = "textBoxLegs";
            this.textBoxLegs.ReadOnly = true;
            this.textBoxLegs.Size = new System.Drawing.Size(128, 29);
            this.textBoxLegs.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(494, 38);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(498, 412);
            this.treeView1.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "upArrow.jpg");
            this.imageList1.Images.SetKeyName(1, "rightArrow.jpg");
            this.imageList1.Images.SetKeyName(2, "downArrow.jpg");
            this.imageList1.Images.SetKeyName(3, "leftArrow.jpg");
            this.imageList1.Images.SetKeyName(4, "document.png");
            this.imageList1.Images.SetKeyName(5, "plusSign.png");
            this.imageList1.Images.SetKeyName(6, "xIcon.png");
            this.imageList1.Images.SetKeyName(7, "gearIcon.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMode;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.NumericUpDown numericUpDownMiles;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLegs;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.TextBox textBoxMiles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

