namespace UniversityAppUI
{
    partial class CoursesTimeForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.ListBox = new MaterialSkin.Controls.MaterialListBox();
            this.BtnDelThis = new MaterialSkin.Controls.MaterialButton();
            this.BtnAddtoList = new MaterialSkin.Controls.MaterialButton();
            this.NudHourstart = new System.Windows.Forms.NumericUpDown();
            this.CbTerm = new MaterialSkin.Controls.MaterialComboBox();
            this.CbDay = new MaterialSkin.Controls.MaterialComboBox();
            this.CbTeacher = new MaterialSkin.Controls.MaterialComboBox();
            this.CbCourse = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.LblHourEnd = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudHourstart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.ListBox);
            this.panel4.Controls.Add(this.BtnDelThis);
            this.panel4.Controls.Add(this.BtnAddtoList);
            this.panel4.Controls.Add(this.NudHourstart);
            this.panel4.Controls.Add(this.CbTerm);
            this.panel4.Controls.Add(this.CbDay);
            this.panel4.Controls.Add(this.CbTeacher);
            this.panel4.Controls.Add(this.CbCourse);
            this.panel4.Controls.Add(this.materialLabel14);
            this.panel4.Controls.Add(this.materialLabel13);
            this.panel4.Controls.Add(this.LblHourEnd);
            this.panel4.Controls.Add(this.materialLabel9);
            this.panel4.Controls.Add(this.materialLabel12);
            this.panel4.Controls.Add(this.materialLabel10);
            this.panel4.Controls.Add(this.materialLabel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(3, 24);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(794, 423);
            this.panel4.TabIndex = 3;
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ListBox.BorderColor = System.Drawing.Color.LightGray;
            this.ListBox.Depth = 0;
            this.ListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListBox.Location = new System.Drawing.Point(0, 202);
            this.ListBox.Margin = new System.Windows.Forms.Padding(5);
            this.ListBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ListBox.Name = "ListBox";
            this.ListBox.SelectedIndex = -1;
            this.ListBox.SelectedItem = null;
            this.ListBox.ShowBorder = false;
            this.ListBox.ShowScrollBar = true;
            this.ListBox.Size = new System.Drawing.Size(794, 221);
            this.ListBox.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.ListBox.TabIndex = 16;
            this.ListBox.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.ListBox_SelectedIndexChanged);
            this.ListBox.MouseLeave += new System.EventHandler(this.ListBox_MouseLeave);
            // 
            // BtnDelThis
            // 
            this.BtnDelThis.AutoSize = false;
            this.BtnDelThis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDelThis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDelThis.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnDelThis.Depth = 0;
            this.BtnDelThis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnDelThis.HighEmphasis = true;
            this.BtnDelThis.Icon = null;
            this.BtnDelThis.Location = new System.Drawing.Point(65, 148);
            this.BtnDelThis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnDelThis.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelThis.Name = "BtnDelThis";
            this.BtnDelThis.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnDelThis.Size = new System.Drawing.Size(235, 43);
            this.BtnDelThis.TabIndex = 14;
            this.BtnDelThis.Text = "حذف این واحد";
            this.BtnDelThis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnDelThis.UseAccentColor = true;
            this.BtnDelThis.UseVisualStyleBackColor = false;
            this.BtnDelThis.Click += new System.EventHandler(this.BtnDelThis_Click);
            // 
            // BtnAddtoList
            // 
            this.BtnAddtoList.AutoSize = false;
            this.BtnAddtoList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddtoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAddtoList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAddtoList.Depth = 0;
            this.BtnAddtoList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAddtoList.HighEmphasis = true;
            this.BtnAddtoList.Icon = null;
            this.BtnAddtoList.Location = new System.Drawing.Point(484, 148);
            this.BtnAddtoList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAddtoList.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddtoList.Name = "BtnAddtoList";
            this.BtnAddtoList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAddtoList.Size = new System.Drawing.Size(235, 43);
            this.BtnAddtoList.TabIndex = 14;
            this.BtnAddtoList.Text = "افزودن واحد";
            this.BtnAddtoList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAddtoList.UseAccentColor = false;
            this.BtnAddtoList.UseVisualStyleBackColor = false;
            this.BtnAddtoList.Click += new System.EventHandler(this.BtnAddtoList_Click);
            // 
            // NudHourstart
            // 
            this.NudHourstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NudHourstart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudHourstart.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NudHourstart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NudHourstart.Location = new System.Drawing.Point(175, 76);
            this.NudHourstart.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.NudHourstart.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NudHourstart.Name = "NudHourstart";
            this.NudHourstart.Size = new System.Drawing.Size(53, 24);
            this.NudHourstart.TabIndex = 13;
            this.NudHourstart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudHourstart.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NudHourstart.ValueChanged += new System.EventHandler(this.NudHourstart_ValueChanged);
            // 
            // CbTerm
            // 
            this.CbTerm.AutoResize = false;
            this.CbTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CbTerm.Depth = 0;
            this.CbTerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbTerm.DropDownHeight = 118;
            this.CbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTerm.DropDownWidth = 121;
            this.CbTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbTerm.FormattingEnabled = true;
            this.CbTerm.IntegralHeight = false;
            this.CbTerm.ItemHeight = 29;
            this.CbTerm.Location = new System.Drawing.Point(573, 76);
            this.CbTerm.MaxDropDownItems = 4;
            this.CbTerm.MouseState = MaterialSkin.MouseState.OUT;
            this.CbTerm.Name = "CbTerm";
            this.CbTerm.Size = new System.Drawing.Size(153, 35);
            this.CbTerm.StartIndex = 0;
            this.CbTerm.TabIndex = 12;
            this.CbTerm.UseTallSize = false;
            // 
            // CbDay
            // 
            this.CbDay.AutoResize = false;
            this.CbDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CbDay.Depth = 0;
            this.CbDay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbDay.DropDownHeight = 118;
            this.CbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDay.DropDownWidth = 121;
            this.CbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbDay.FormattingEnabled = true;
            this.CbDay.IntegralHeight = false;
            this.CbDay.ItemHeight = 29;
            this.CbDay.Location = new System.Drawing.Point(333, 75);
            this.CbDay.MaxDropDownItems = 4;
            this.CbDay.MouseState = MaterialSkin.MouseState.OUT;
            this.CbDay.Name = "CbDay";
            this.CbDay.Size = new System.Drawing.Size(145, 35);
            this.CbDay.StartIndex = 0;
            this.CbDay.TabIndex = 12;
            this.CbDay.UseTallSize = false;
            // 
            // CbTeacher
            // 
            this.CbTeacher.AutoResize = false;
            this.CbTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CbTeacher.Depth = 0;
            this.CbTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbTeacher.DropDownHeight = 118;
            this.CbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTeacher.DropDownWidth = 121;
            this.CbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbTeacher.FormattingEnabled = true;
            this.CbTeacher.IntegralHeight = false;
            this.CbTeacher.ItemHeight = 29;
            this.CbTeacher.Location = new System.Drawing.Point(88, 20);
            this.CbTeacher.MaxDropDownItems = 4;
            this.CbTeacher.MouseState = MaterialSkin.MouseState.OUT;
            this.CbTeacher.Name = "CbTeacher";
            this.CbTeacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CbTeacher.Size = new System.Drawing.Size(242, 35);
            this.CbTeacher.StartIndex = 0;
            this.CbTeacher.TabIndex = 12;
            this.CbTeacher.UseTallSize = false;
            this.CbTeacher.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CbTeacher_Format);
            // 
            // CbCourse
            // 
            this.CbCourse.AutoResize = false;
            this.CbCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CbCourse.Depth = 0;
            this.CbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbCourse.DropDownHeight = 118;
            this.CbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCourse.DropDownWidth = 121;
            this.CbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbCourse.FormattingEnabled = true;
            this.CbCourse.IntegralHeight = false;
            this.CbCourse.ItemHeight = 29;
            this.CbCourse.Location = new System.Drawing.Point(453, 20);
            this.CbCourse.MaxDropDownItems = 4;
            this.CbCourse.MouseState = MaterialSkin.MouseState.OUT;
            this.CbCourse.Name = "CbCourse";
            this.CbCourse.Size = new System.Drawing.Size(273, 35);
            this.CbCourse.StartIndex = 0;
            this.CbCourse.TabIndex = 12;
            this.CbCourse.UseTallSize = false;
            this.CbCourse.SelectionChangeCommitted += new System.EventHandler(this.CbCourse_SelectionChangeCommitted);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel14.Location = new System.Drawing.Point(96, 75);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(68, 29);
            this.materialLabel14.TabIndex = 9;
            this.materialLabel14.Text = "تا ساعت";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel13.Location = new System.Drawing.Point(234, 75);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(73, 29);
            this.materialLabel13.TabIndex = 9;
            this.materialLabel13.Text = "از ساعت";
            // 
            // LblHourEnd
            // 
            this.LblHourEnd.AutoSize = true;
            this.LblHourEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LblHourEnd.Depth = 0;
            this.LblHourEnd.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblHourEnd.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.LblHourEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LblHourEnd.Location = new System.Drawing.Point(60, 75);
            this.LblHourEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblHourEnd.Name = "LblHourEnd";
            this.LblHourEnd.Size = new System.Drawing.Size(30, 29);
            this.LblHourEnd.TabIndex = 9;
            this.LblHourEnd.Text = "عدد";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel9.Location = new System.Drawing.Point(484, 75);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(35, 29);
            this.materialLabel9.TabIndex = 9;
            this.materialLabel9.Text = "روز";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel12.Location = new System.Drawing.Point(732, 76);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(53, 29);
            this.materialLabel12.TabIndex = 9;
            this.materialLabel12.Text = "در ترم";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel10.Location = new System.Drawing.Point(336, 20);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(57, 29);
            this.materialLabel10.TabIndex = 9;
            this.materialLabel10.Text = "با استاد";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel8.Location = new System.Drawing.Point(732, 20);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(41, 29);
            this.materialLabel8.TabIndex = 9;
            this.materialLabel8.Text = "درس";
            // 
            // CoursesTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Name = "CoursesTimeForm";
            this.Text = "CoursesTime";
            this.Load += new System.EventHandler(this.CoursesTimeForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudHourstart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialButton BtnAddtoList;
        private System.Windows.Forms.NumericUpDown NudHourstart;
        private MaterialSkin.Controls.MaterialComboBox CbTerm;
        private MaterialSkin.Controls.MaterialComboBox CbDay;
        private MaterialSkin.Controls.MaterialComboBox CbTeacher;
        private MaterialSkin.Controls.MaterialComboBox CbCourse;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel LblHourEnd;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialListBox ListBox;
        private MaterialSkin.Controls.MaterialButton BtnDelThis;
    }
}