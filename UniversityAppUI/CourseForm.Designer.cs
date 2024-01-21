namespace UniversityAppUI
{
    partial class CourseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCourse = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.NudTheoryUnit = new System.Windows.Forms.NumericUpDown();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.NudPracticalUnit = new System.Windows.Forms.NumericUpDown();
            this.LabelT = new MaterialSkin.Controls.MaterialLabel();
            this.LabelP = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.CbMajor = new MaterialSkin.Controls.MaterialComboBox();
            this.BtnRemoveCourse = new MaterialSkin.Controls.MaterialButton();
            this.BtnUpdateCourse = new MaterialSkin.Controls.MaterialButton();
            this.BtnAddCourse = new MaterialSkin.Controls.MaterialButton();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrerequisiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.CbPrerequisite = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudTheoryUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPracticalUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCourse
            // 
            this.txtCourse.AnimateReadOnly = false;
            this.txtCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourse.Depth = 0;
            this.txtCourse.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCourse.LeadingIcon = null;
            this.txtCourse.Location = new System.Drawing.Point(550, 33);
            this.txtCourse.MaxLength = 70;
            this.txtCourse.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCourse.Multiline = false;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(164, 36);
            this.txtCourse.TabIndex = 5;
            this.txtCourse.Text = "";
            this.txtCourse.TrailingIcon = null;
            this.txtCourse.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(727, 36);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 29);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "نام واحد";
            // 
            // NudTheoryUnit
            // 
            this.NudTheoryUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NudTheoryUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudTheoryUnit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NudTheoryUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NudTheoryUnit.Location = new System.Drawing.Point(294, 43);
            this.NudTheoryUnit.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NudTheoryUnit.Name = "NudTheoryUnit";
            this.NudTheoryUnit.Size = new System.Drawing.Size(53, 24);
            this.NudTheoryUnit.TabIndex = 6;
            this.NudTheoryUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudTheoryUnit.ValueChanged += new System.EventHandler(this.NudTheoryUnit_ValueChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(353, 43);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(134, 29);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "تعداد واحد تئوری";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel3.Location = new System.Drawing.Point(96, 40);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(126, 29);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "تعداد واحد عملی";
            // 
            // NudPracticalUnit
            // 
            this.NudPracticalUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NudPracticalUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudPracticalUnit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NudPracticalUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NudPracticalUnit.Location = new System.Drawing.Point(37, 40);
            this.NudPracticalUnit.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NudPracticalUnit.Name = "NudPracticalUnit";
            this.NudPracticalUnit.Size = new System.Drawing.Size(53, 24);
            this.NudPracticalUnit.TabIndex = 6;
            this.NudPracticalUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudPracticalUnit.ValueChanged += new System.EventHandler(this.NudPracticalUnit_ValueChanged);
            // 
            // LabelT
            // 
            this.LabelT.AutoSize = true;
            this.LabelT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LabelT.Depth = 0;
            this.LabelT.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelT.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.LabelT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LabelT.Location = new System.Drawing.Point(20, 116);
            this.LabelT.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelT.Name = "LabelT";
            this.LabelT.Size = new System.Drawing.Size(118, 29);
            this.LabelT.TabIndex = 4;
            this.LabelT.Text = "0ساعت تئوری";
            // 
            // LabelP
            // 
            this.LabelP.AutoSize = true;
            this.LabelP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LabelP.Depth = 0;
            this.LabelP.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelP.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.LabelP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LabelP.Location = new System.Drawing.Point(27, 82);
            this.LabelP.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelP.Name = "LabelP";
            this.LabelP.Size = new System.Drawing.Size(110, 29);
            this.LabelP.TabIndex = 4;
            this.LabelP.Tag = "";
            this.LabelP.Text = "0ساعت عملی";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel6.Location = new System.Drawing.Point(727, 107);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(41, 29);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "رشته";
            // 
            // CbMajor
            // 
            this.CbMajor.AutoResize = false;
            this.CbMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CbMajor.Depth = 0;
            this.CbMajor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbMajor.DropDownHeight = 118;
            this.CbMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMajor.DropDownWidth = 121;
            this.CbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbMajor.FormattingEnabled = true;
            this.CbMajor.IntegralHeight = false;
            this.CbMajor.ItemHeight = 29;
            this.CbMajor.Location = new System.Drawing.Point(550, 104);
            this.CbMajor.MaxDropDownItems = 4;
            this.CbMajor.MouseState = MaterialSkin.MouseState.OUT;
            this.CbMajor.Name = "CbMajor";
            this.CbMajor.Size = new System.Drawing.Size(164, 35);
            this.CbMajor.StartIndex = 0;
            this.CbMajor.TabIndex = 7;
            this.CbMajor.UseTallSize = false;
            // 
            // BtnRemoveCourse
            // 
            this.BtnRemoveCourse.AutoSize = false;
            this.BtnRemoveCourse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRemoveCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnRemoveCourse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnRemoveCourse.Depth = 0;
            this.BtnRemoveCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnRemoveCourse.HighEmphasis = true;
            this.BtnRemoveCourse.Icon = null;
            this.BtnRemoveCourse.Location = new System.Drawing.Point(128, 167);
            this.BtnRemoveCourse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRemoveCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRemoveCourse.Name = "BtnRemoveCourse";
            this.BtnRemoveCourse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnRemoveCourse.Size = new System.Drawing.Size(158, 36);
            this.BtnRemoveCourse.TabIndex = 9;
            this.BtnRemoveCourse.Text = "حذف واحد انتخاب شده";
            this.BtnRemoveCourse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnRemoveCourse.UseAccentColor = true;
            this.BtnRemoveCourse.UseVisualStyleBackColor = false;
            this.BtnRemoveCourse.Click += new System.EventHandler(this.BtnRemoveCourse_Click);
            // 
            // BtnUpdateCourse
            // 
            this.BtnUpdateCourse.AutoSize = false;
            this.BtnUpdateCourse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUpdateCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnUpdateCourse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnUpdateCourse.Depth = 0;
            this.BtnUpdateCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnUpdateCourse.HighEmphasis = true;
            this.BtnUpdateCourse.Icon = null;
            this.BtnUpdateCourse.Location = new System.Drawing.Point(321, 167);
            this.BtnUpdateCourse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnUpdateCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdateCourse.Name = "BtnUpdateCourse";
            this.BtnUpdateCourse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnUpdateCourse.Size = new System.Drawing.Size(158, 36);
            this.BtnUpdateCourse.TabIndex = 10;
            this.BtnUpdateCourse.Text = "بروزرسانی این واحد";
            this.BtnUpdateCourse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnUpdateCourse.UseAccentColor = false;
            this.BtnUpdateCourse.UseVisualStyleBackColor = false;
            this.BtnUpdateCourse.Click += new System.EventHandler(this.BtnUpdateCourse_Click);
            // 
            // BtnAddCourse
            // 
            this.BtnAddCourse.AutoSize = false;
            this.BtnAddCourse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAddCourse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAddCourse.Depth = 0;
            this.BtnAddCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAddCourse.HighEmphasis = true;
            this.BtnAddCourse.Icon = null;
            this.BtnAddCourse.Location = new System.Drawing.Point(514, 167);
            this.BtnAddCourse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAddCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddCourse.Name = "BtnAddCourse";
            this.BtnAddCourse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAddCourse.Size = new System.Drawing.Size(158, 36);
            this.BtnAddCourse.TabIndex = 11;
            this.BtnAddCourse.Text = "اضافه کردن واحد جدید";
            this.BtnAddCourse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAddCourse.UseAccentColor = false;
            this.BtnAddCourse.UseVisualStyleBackColor = false;
            this.BtnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
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
            this.hour,
            this.unit,
            this.major,
            this.PrerequisiteName});
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dgv.GridColor = System.Drawing.SystemColors.Desktop;
            this.Dgv.Location = new System.Drawing.Point(3, 212);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(794, 235);
            this.Dgv.TabIndex = 25;
            this.Dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.DataPropertyName = "Id";
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
            this.coursename.DataPropertyName = "CourseName";
            this.coursename.FillWeight = 74.63369F;
            this.coursename.HeaderText = "نام درس";
            this.coursename.Name = "coursename";
            this.coursename.ReadOnly = true;
            this.coursename.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coursename.Width = 220;
            // 
            // hour
            // 
            this.hour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hour.DataPropertyName = "TotalHours";
            this.hour.FillWeight = 1F;
            this.hour.HeaderText = "مجموع ساعات";
            this.hour.Name = "hour";
            this.hour.ReadOnly = true;
            this.hour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hour.Width = 70;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unit.DataPropertyName = "TotalUnits";
            this.unit.FillWeight = 1F;
            this.unit.HeaderText = "مجموع واحد ها";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.unit.Width = 106;
            // 
            // major
            // 
            this.major.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.major.DataPropertyName = "MajorsName";
            this.major.HeaderText = "رشته";
            this.major.Name = "major";
            this.major.ReadOnly = true;
            this.major.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PrerequisiteName
            // 
            this.PrerequisiteName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrerequisiteName.DataPropertyName = "PrerequisiteName";
            this.PrerequisiteName.HeaderText = "پیش نیاز";
            this.PrerequisiteName.Name = "PrerequisiteName";
            this.PrerequisiteName.ReadOnly = true;
            this.PrerequisiteName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrerequisiteName.Width = 200;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel7.Location = new System.Drawing.Point(471, 107);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(69, 29);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "پیش نیاز";
            // 
            // CbPrerequisite
            // 
            this.CbPrerequisite.AutoResize = false;
            this.CbPrerequisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CbPrerequisite.Depth = 0;
            this.CbPrerequisite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbPrerequisite.DropDownHeight = 118;
            this.CbPrerequisite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPrerequisite.DropDownWidth = 121;
            this.CbPrerequisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbPrerequisite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbPrerequisite.FormattingEnabled = true;
            this.CbPrerequisite.IntegralHeight = false;
            this.CbPrerequisite.ItemHeight = 29;
            this.CbPrerequisite.Location = new System.Drawing.Point(294, 104);
            this.CbPrerequisite.MaxDropDownItems = 4;
            this.CbPrerequisite.MouseState = MaterialSkin.MouseState.OUT;
            this.CbPrerequisite.Name = "CbPrerequisite";
            this.CbPrerequisite.Size = new System.Drawing.Size(164, 35);
            this.CbPrerequisite.StartIndex = 0;
            this.CbPrerequisite.TabIndex = 7;
            this.CbPrerequisite.UseTallSize = false;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.BtnRemoveCourse);
            this.Controls.Add(this.BtnUpdateCourse);
            this.Controls.Add(this.BtnAddCourse);
            this.Controls.Add(this.CbPrerequisite);
            this.Controls.Add(this.CbMajor);
            this.Controls.Add(this.NudPracticalUnit);
            this.Controls.Add(this.NudTheoryUnit);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.LabelP);
            this.Controls.Add(this.LabelT);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudTheoryUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPracticalUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtCourse;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.NumericUpDown NudTheoryUnit;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.NumericUpDown NudPracticalUnit;
        private MaterialSkin.Controls.MaterialLabel LabelT;
        private MaterialSkin.Controls.MaterialLabel LabelP;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox CbMajor;
        private MaterialSkin.Controls.MaterialButton BtnRemoveCourse;
        private MaterialSkin.Controls.MaterialButton BtnUpdateCourse;
        private MaterialSkin.Controls.MaterialButton BtnAddCourse;
        private System.Windows.Forms.DataGridView Dgv;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox CbPrerequisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursename;
        private System.Windows.Forms.DataGridViewTextBoxColumn hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn major;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrerequisiteName;
    }
}