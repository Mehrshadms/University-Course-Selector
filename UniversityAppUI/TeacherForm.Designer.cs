namespace UniversityAppUI
{
    partial class TeacherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFname = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLname = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.CbDegree = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.CbGroup = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnAddTeacher = new MaterialSkin.Controls.MaterialButton();
            this.BtnUpdateTeacher = new MaterialSkin.Controls.MaterialButton();
            this.BtnRemoveTeacher = new MaterialSkin.Controls.MaterialButton();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListBox = new MaterialSkin.Controls.MaterialListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(682, 38);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(21, 29);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "نام";
            // 
            // txtFname
            // 
            this.txtFname.AnimateReadOnly = false;
            this.txtFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFname.Depth = 0;
            this.txtFname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFname.LeadingIcon = null;
            this.txtFname.Location = new System.Drawing.Point(441, 38);
            this.txtFname.MaxLength = 50;
            this.txtFname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFname.Multiline = false;
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(232, 36);
            this.txtFname.TabIndex = 0;
            this.txtFname.Text = "";
            this.txtFname.TrailingIcon = null;
            this.txtFname.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(679, 90);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 29);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "نام خانوادگی";
            // 
            // txtLname
            // 
            this.txtLname.AnimateReadOnly = false;
            this.txtLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLname.Depth = 0;
            this.txtLname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLname.LeadingIcon = null;
            this.txtLname.Location = new System.Drawing.Point(441, 89);
            this.txtLname.MaxLength = 50;
            this.txtLname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLname.Multiline = false;
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(232, 36);
            this.txtLname.TabIndex = 1;
            this.txtLname.Text = "";
            this.txtLname.TrailingIcon = null;
            this.txtLname.UseTallSize = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel4.Location = new System.Drawing.Point(679, 192);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(114, 29);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "مدرک تحصیلی";
            // 
            // CbDegree
            // 
            this.CbDegree.AutoResize = false;
            this.CbDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CbDegree.Depth = 0;
            this.CbDegree.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbDegree.DropDownHeight = 118;
            this.CbDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDegree.DropDownWidth = 121;
            this.CbDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbDegree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbDegree.FormattingEnabled = true;
            this.CbDegree.IntegralHeight = false;
            this.CbDegree.ItemHeight = 29;
            this.CbDegree.Location = new System.Drawing.Point(442, 186);
            this.CbDegree.MaxDropDownItems = 4;
            this.CbDegree.MouseState = MaterialSkin.MouseState.OUT;
            this.CbDegree.Name = "CbDegree";
            this.CbDegree.Size = new System.Drawing.Size(231, 35);
            this.CbDegree.StartIndex = 0;
            this.CbDegree.TabIndex = 2;
            this.CbDegree.UseTallSize = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel3.Location = new System.Drawing.Point(679, 137);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(109, 29);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "گروه آموزشی";
            // 
            // CbGroup
            // 
            this.CbGroup.AutoResize = false;
            this.CbGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CbGroup.Depth = 0;
            this.CbGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbGroup.DropDownHeight = 118;
            this.CbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGroup.DropDownWidth = 121;
            this.CbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbGroup.FormattingEnabled = true;
            this.CbGroup.IntegralHeight = false;
            this.CbGroup.ItemHeight = 29;
            this.CbGroup.Location = new System.Drawing.Point(441, 136);
            this.CbGroup.MaxDropDownItems = 4;
            this.CbGroup.MouseState = MaterialSkin.MouseState.OUT;
            this.CbGroup.Name = "CbGroup";
            this.CbGroup.Size = new System.Drawing.Size(232, 35);
            this.CbGroup.StartIndex = 0;
            this.CbGroup.TabIndex = 3;
            this.CbGroup.UseTallSize = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel6.Location = new System.Drawing.Point(107, 30);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(204, 29);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "دروس قابل ارائه این استاد";
            // 
            // BtnAddTeacher
            // 
            this.BtnAddTeacher.AutoSize = false;
            this.BtnAddTeacher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAddTeacher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAddTeacher.Depth = 0;
            this.BtnAddTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAddTeacher.HighEmphasis = true;
            this.BtnAddTeacher.Icon = null;
            this.BtnAddTeacher.Location = new System.Drawing.Point(630, 241);
            this.BtnAddTeacher.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAddTeacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddTeacher.Name = "BtnAddTeacher";
            this.BtnAddTeacher.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAddTeacher.Size = new System.Drawing.Size(158, 36);
            this.BtnAddTeacher.TabIndex = 7;
            this.BtnAddTeacher.Text = "اضافه کردن استاد جدید";
            this.BtnAddTeacher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAddTeacher.UseAccentColor = false;
            this.BtnAddTeacher.UseVisualStyleBackColor = false;
            this.BtnAddTeacher.Click += new System.EventHandler(this.BtnAddTeacher_Click);
            // 
            // BtnUpdateTeacher
            // 
            this.BtnUpdateTeacher.AutoSize = false;
            this.BtnUpdateTeacher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUpdateTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnUpdateTeacher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnUpdateTeacher.Depth = 0;
            this.BtnUpdateTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnUpdateTeacher.HighEmphasis = true;
            this.BtnUpdateTeacher.Icon = null;
            this.BtnUpdateTeacher.Location = new System.Drawing.Point(630, 289);
            this.BtnUpdateTeacher.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnUpdateTeacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdateTeacher.Name = "BtnUpdateTeacher";
            this.BtnUpdateTeacher.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnUpdateTeacher.Size = new System.Drawing.Size(158, 36);
            this.BtnUpdateTeacher.TabIndex = 8;
            this.BtnUpdateTeacher.Text = "بروزرسانی این استاد";
            this.BtnUpdateTeacher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnUpdateTeacher.UseAccentColor = false;
            this.BtnUpdateTeacher.UseVisualStyleBackColor = false;
            this.BtnUpdateTeacher.Click += new System.EventHandler(this.BtnUpdateTeacher_Click);
            // 
            // BtnRemoveTeacher
            // 
            this.BtnRemoveTeacher.AutoSize = false;
            this.BtnRemoveTeacher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRemoveTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnRemoveTeacher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnRemoveTeacher.Depth = 0;
            this.BtnRemoveTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnRemoveTeacher.HighEmphasis = true;
            this.BtnRemoveTeacher.Icon = null;
            this.BtnRemoveTeacher.Location = new System.Drawing.Point(441, 289);
            this.BtnRemoveTeacher.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRemoveTeacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRemoveTeacher.Name = "BtnRemoveTeacher";
            this.BtnRemoveTeacher.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnRemoveTeacher.Size = new System.Drawing.Size(158, 36);
            this.BtnRemoveTeacher.TabIndex = 9;
            this.BtnRemoveTeacher.Text = "حذف استاد انتخاب شده";
            this.BtnRemoveTeacher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnRemoveTeacher.UseAccentColor = true;
            this.BtnRemoveTeacher.UseVisualStyleBackColor = false;
            this.BtnRemoveTeacher.Click += new System.EventHandler(this.BtnRemoveTeacher_Click);
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AllowUserToResizeColumns = false;
            this.Dgv.AllowUserToResizeRows = false;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.BackgroundColor = System.Drawing.Color.Gray;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.coursename,
            this.major,
            this.hour,
            this.unit});
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dgv.GridColor = System.Drawing.SystemColors.Desktop;
            this.Dgv.Location = new System.Drawing.Point(3, 334);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(794, 279);
            this.Dgv.TabIndex = 5;
            this.Dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.DataPropertyName = "Teacher_Id";
            this.Id.FillWeight = 120F;
            this.Id.HeaderText = "آیدی";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 53;
            // 
            // coursename
            // 
            this.coursename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.coursename.DataPropertyName = "Teacher_FirstName";
            this.coursename.FillWeight = 74.63369F;
            this.coursename.HeaderText = "نام استاد";
            this.coursename.Name = "coursename";
            this.coursename.ReadOnly = true;
            this.coursename.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coursename.Width = 160;
            // 
            // major
            // 
            this.major.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.major.DataPropertyName = "Teacher_LastName";
            this.major.FillWeight = 15.83213F;
            this.major.HeaderText = "نام خانوادگی";
            this.major.Name = "major";
            this.major.ReadOnly = true;
            this.major.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.major.Width = 160;
            // 
            // hour
            // 
            this.hour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hour.DataPropertyName = "Degree_Name";
            this.hour.FillWeight = 1F;
            this.hour.HeaderText = "مدرک استاد";
            this.hour.Name = "hour";
            this.hour.ReadOnly = true;
            this.hour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hour.Width = 160;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "Group_Name";
            this.unit.FillWeight = 1F;
            this.unit.HeaderText = "گروه آموزشی";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ListBox.BorderColor = System.Drawing.Color.LightGray;
            this.ListBox.Depth = 0;
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListBox.Location = new System.Drawing.Point(7, 62);
            this.ListBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ListBox.Name = "ListBox";
            this.ListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListBox.SelectedIndex = -1;
            this.ListBox.SelectedItem = null;
            this.ListBox.ShowBorder = false;
            this.ListBox.ShowScrollBar = true;
            this.ListBox.Size = new System.Drawing.Size(404, 266);
            this.ListBox.TabIndex = 27;
            this.ListBox.UseAccentColor = true;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.BtnRemoveTeacher);
            this.Controls.Add(this.BtnUpdateTeacher);
            this.Controls.Add(this.BtnAddTeacher);
            this.Controls.Add(this.CbGroup);
            this.Controls.Add(this.CbDegree);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.materialLabel1);
            this.Name = "TeacherForm";
            this.Text = "صفحه اضافه،بروزرسانی و حذف استادان";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtFname;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtLname;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox CbDegree;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox CbGroup;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton BtnAddTeacher;
        private MaterialSkin.Controls.MaterialButton BtnUpdateTeacher;
        private MaterialSkin.Controls.MaterialButton BtnRemoveTeacher;
        private System.Windows.Forms.DataGridView Dgv;
        private MaterialSkin.Controls.MaterialListBox ListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursename;
        private System.Windows.Forms.DataGridViewTextBoxColumn major;
        private System.Windows.Forms.DataGridViewTextBoxColumn hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
    }
}