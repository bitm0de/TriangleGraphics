namespace PascalsTriangleDisplay
{
    sealed partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nudBase = new System.Windows.Forms.NumericUpDown();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbInnerShape = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.nudImgSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEnTransparency = new System.Windows.Forms.CheckBox();
            this.cpDefBaseColor = new PascalsTriangleDisplay.UI.ColorPicker();
            this.pascalsTriangle1 = new PascalsTriangleDisplay.UI.PascalsTriangle();
            this.cpTransColor = new PascalsTriangleDisplay.UI.ColorPicker();
            this.colorListView1 = new PascalsTriangleDisplay.UI.ColorListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nudBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpDefBaseColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pascalsTriangle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpTransColor)).BeginInit();
            this.SuspendLayout();
            // 
            // nudBase
            // 
            this.nudBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudBase.Location = new System.Drawing.Point(427, 28);
            this.nudBase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBase.Name = "nudBase";
            this.nudBase.Size = new System.Drawing.Size(60, 20);
            this.nudBase.TabIndex = 1;
            this.nudBase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBase.TextChanged += new System.EventHandler(this.nudBase_Changed);
            // 
            // nudSize
            // 
            this.nudSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSize.Location = new System.Drawing.Point(493, 28);
            this.nudSize.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(61, 20);
            this.nudSize.TabIndex = 2;
            this.nudSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSize.TextChanged += new System.EventHandler(this.nudSize_Changed);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(427, 386);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label3.Location = new System.Drawing.Point(191, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Developed by AceInfinity - (c) Tech.Reboot.Pro - 2013";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(547, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Transparency Color";
            // 
            // cbInnerShape
            // 
            this.cbInnerShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInnerShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInnerShape.FormattingEnabled = true;
            this.cbInnerShape.Items.AddRange(new object[] {
            "Circles",
            "Squares",
            "Triangles"});
            this.cbInnerShape.Location = new System.Drawing.Point(493, 55);
            this.cbInnerShape.Name = "cbInnerShape";
            this.cbInnerShape.Size = new System.Drawing.Size(169, 21);
            this.cbInnerShape.TabIndex = 10;
            this.cbInnerShape.SelectedIndexChanged += new System.EventHandler(this.cbInnerShape_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Inner Shape:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pascalsTriangle1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 368);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Image Size";
            // 
            // nudImgSize
            // 
            this.nudImgSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudImgSize.Location = new System.Drawing.Point(73, 389);
            this.nudImgSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudImgSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImgSize.Name = "nudImgSize";
            this.nudImgSize.Size = new System.Drawing.Size(78, 20);
            this.nudImgSize.TabIndex = 16;
            this.nudImgSize.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudImgSize.TextChanged += new System.EventHandler(this.nudImgSize_Changed);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "px";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label8.Location = new System.Drawing.Point(441, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "Note: Double click on a color to change the value.";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Default Base Color";
            // 
            // cbEnTransparency
            // 
            this.cbEnTransparency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEnTransparency.Location = new System.Drawing.Point(553, 87);
            this.cbEnTransparency.Name = "cbEnTransparency";
            this.cbEnTransparency.Size = new System.Drawing.Size(101, 37);
            this.cbEnTransparency.TabIndex = 18;
            this.cbEnTransparency.Text = "Enable Transparency";
            this.cbEnTransparency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbEnTransparency.UseVisualStyleBackColor = true;
            this.cbEnTransparency.CheckedChanged += new System.EventHandler(this.cbEnTransparency_CheckedChanged);
            // 
            // cpDefBaseColor
            // 
            this.cpDefBaseColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpDefBaseColor.DisplayColor = System.Drawing.Color.White;
            this.cpDefBaseColor.Location = new System.Drawing.Point(560, 28);
            this.cpDefBaseColor.Name = "cpDefBaseColor";
            this.cpDefBaseColor.Size = new System.Drawing.Size(102, 20);
            this.cpDefBaseColor.TabIndex = 17;
            this.cpDefBaseColor.TabStop = false;
            this.cpDefBaseColor.ColorChanged += new System.EventHandler<PascalsTriangleDisplay.UI.ColorPicker.ColorChangedEventArgs>(this.cpDefBaseColor_ColorChanged);
            // 
            // pascalsTriangle1
            // 
            this.pascalsTriangle1.BackColor = System.Drawing.Color.Transparent;
            this.pascalsTriangle1.Base = 5;
            this.pascalsTriangle1.BaseColors = ((System.Collections.Generic.Dictionary<int, System.Drawing.Color>)(resources.GetObject("pascalsTriangle1.BaseColors")));
            this.pascalsTriangle1.DefaultBaseColor = System.Drawing.Color.Empty;
            this.pascalsTriangle1.DefaultTransparencyColor = System.Drawing.Color.Empty;
            this.pascalsTriangle1.EnableTransparency = false;
            this.pascalsTriangle1.Image = ((System.Drawing.Image)(resources.GetObject("pascalsTriangle1.Image")));
            this.pascalsTriangle1.InnerShape = PascalsTriangleDisplay.UI.PascalsTriangle.ShapeType.Squares;
            this.pascalsTriangle1.LayoutSize = 0;
            this.pascalsTriangle1.Location = new System.Drawing.Point(0, 0);
            this.pascalsTriangle1.Name = "pascalsTriangle1";
            this.pascalsTriangle1.PngImage = ((System.Drawing.Bitmap)(resources.GetObject("pascalsTriangle1.PngImage")));
            this.pascalsTriangle1.ShapeSize = 2;
            this.pascalsTriangle1.Size = new System.Drawing.Size(272, 272);
            this.pascalsTriangle1.TabIndex = 0;
            this.pascalsTriangle1.TabStop = false;
            // 
            // cpTransColor
            // 
            this.cpTransColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpTransColor.DisplayColor = System.Drawing.Color.White;
            this.cpTransColor.Location = new System.Drawing.Point(434, 102);
            this.cpTransColor.Name = "cpTransColor";
            this.cpTransColor.Size = new System.Drawing.Size(102, 20);
            this.cpTransColor.TabIndex = 12;
            this.cpTransColor.TabStop = false;
            this.cpTransColor.ColorChanged += new System.EventHandler<PascalsTriangleDisplay.UI.ColorPicker.ColorChangedEventArgs>(this.cpTransColor_ColorChanged);
            // 
            // colorListView1
            // 
            this.colorListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.colorListView1.FullRowSelect = true;
            this.colorListView1.Location = new System.Drawing.Point(427, 143);
            this.colorListView1.Name = "colorListView1";
            this.colorListView1.OwnerDraw = true;
            this.colorListView1.Size = new System.Drawing.Size(235, 237);
            this.colorListView1.TabIndex = 6;
            this.colorListView1.UseCompatibleStateImageBehavior = false;
            this.colorListView1.View = System.Windows.Forms.View.Details;
            this.colorListView1.DoubleClick += new System.EventHandler(this.colorListView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fill Color";
            this.columnHeader2.Width = 191;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 436);
            this.Controls.Add(this.cbEnTransparency);
            this.Controls.Add(this.cpDefBaseColor);
            this.Controls.Add(this.nudImgSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cpTransColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbInnerShape);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorListView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.nudBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 275);
            this.Name = "Form1";
            this.Text = "Pascal\'s Triangle";
            ((System.ComponentModel.ISupportInitialize)(this.nudBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudImgSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpDefBaseColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pascalsTriangle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpTransColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.PascalsTriangle pascalsTriangle1;
        private System.Windows.Forms.NumericUpDown nudBase;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private UI.ColorListView colorListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbInnerShape;
        private System.Windows.Forms.Label label5;
        private UI.ColorPicker cpTransColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudImgSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private UI.ColorPicker cpDefBaseColor;
        private System.Windows.Forms.CheckBox cbEnTransparency;

    }
}

