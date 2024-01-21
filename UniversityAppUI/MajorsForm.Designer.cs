namespace UniversityAppUI
{
    partial class MajorsForm
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
            this.txtMajor = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CbLevel = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.CbGroup = new MaterialSkin.Controls.MaterialComboBox();
            this.BtnRemoveMajor = new MaterialSkin.Controls.MaterialButton();
            this.BtnUpdateMajor = new MaterialSkin.Controls.MaterialButton();
            this.BtnAddMajor = new MaterialSkin.Controls.MaterialButton();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMajor
            // 
            this.txtMajor.AnimateReadOnly = false;
            this.txtMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMajor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMajor.Depth = 0;
            this.txtMajor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMajor.LeadingIcon = null;
            this.txtMajor.Location = new System.Drawing.Point(349, 37);
            this.txtMajor.MaxLength = 50;
            this.txtMajor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMajor.Multiline = false;
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(239, 36);
            this.txtMajor.TabIndex = 7;
            this.txtMajor.Text = "";
            this.txtMajor.TrailingIcon = null;
            this.txtMajor.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(594, 44);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 29);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "نام رشته";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(274, 44);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(41, 29);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "مقطع";
            // 
            // CbLevel
            // 
            this.CbLevel.AutoResize = false;
            this.CbLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CbLevel.Depth = 0;
            this.CbLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbLevel.DropDownHeight = 118;
            this.CbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbLevel.DropDownWidth = 121;
            this.CbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbLevel.FormattingEnabled = true;
            this.CbLevel.IntegralHeight = false;
            this.CbLevel.ItemHeight = 29;
            this.CbLevel.Location = new System.Drawing.Point(66, 38);
            this.CbLevel.MaxDropDownItems = 4;
            this.CbLevel.MouseState = MaterialSkin.MouseState.OUT;
            this.CbLevel.Name = "CbLevel";
            this.CbLevel.Size = new System.Drawing.Size(202, 35);
            this.CbLevel.StartIndex = 0;
            this.CbLevel.TabIndex = 8;
            this.CbLevel.UseTallSize = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel3.Location = new System.Drawing.Point(554, 103);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(109, 29);
            this.materialLabel3.TabIndex = 6;
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
            this.CbGroup.Location = new System.Drawing.Point(349, 103);
            this.CbGroup.MaxDropDownItems = 4;
            this.CbGroup.MouseState = MaterialSkin.MouseState.OUT;
            this.CbGroup.Name = "CbGroup";
            this.CbGroup.Size = new System.Drawing.Size(199, 35);
            this.CbGroup.StartIndex = 0;
            this.CbGroup.TabIndex = 8;
            this.CbGroup.UseTallSize = false;
            // 
            // BtnRemoveMajor
            // 
            this.BtnRemoveMajor.AutoSize = false;
            this.BtnRemoveMajor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRemoveMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnRemoveMajor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnRemoveMajor.Depth = 0;
            this.BtnRemoveMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnRemoveMajor.HighEmphasis = true;
            this.BtnRemoveMajor.Icon = null;
            this.BtnRemoveMajor.Location = new System.Drawing.Point(62, 181);
            this.BtnRemoveMajor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRemoveMajor.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRemoveMajor.Name = "BtnRemoveMajor";
            this.BtnRemoveMajor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnRemoveMajor.Size = new System.Drawing.Size(158, 36);
            this.BtnRemoveMajor.TabIndex = 12;
            this.BtnRemoveMajor.Text = "حذف رشته انتخاب شده";
            this.BtnRemoveMajor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnRemoveMajor.UseAccentColor = true;
            this.BtnRemoveMajor.UseVisualStyleBackColor = false;
            this.BtnRemoveMajor.Click += new System.EventHandler(this.BtnRemoveMajor_Click);
            // 
            // BtnUpdateMajor
            // 
            this.BtnUpdateMajor.AutoSize = false;
            this.BtnUpdateMajor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUpdateMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnUpdateMajor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnUpdateMajor.Depth = 0;
            this.BtnUpdateMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnUpdateMajor.HighEmphasis = true;
            this.BtnUpdateMajor.Icon = null;
            this.BtnUpdateMajor.Location = new System.Drawing.Point(255, 181);
            this.BtnUpdateMajor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnUpdateMajor.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdateMajor.Name = "BtnUpdateMajor";
            this.BtnUpdateMajor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnUpdateMajor.Size = new System.Drawing.Size(158, 36);
            this.BtnUpdateMajor.TabIndex = 13;
            this.BtnUpdateMajor.Text = "بروزرسانی این رشته";
            this.BtnUpdateMajor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnUpdateMajor.UseAccentColor = false;
            this.BtnUpdateMajor.UseVisualStyleBackColor = false;
            this.BtnUpdateMajor.Click += new System.EventHandler(this.BtnUpdateMajor_Click);
            // 
            // BtnAddMajor
            // 
            this.BtnAddMajor.AutoSize = false;
            this.BtnAddMajor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAddMajor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAddMajor.Depth = 0;
            this.BtnAddMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAddMajor.HighEmphasis = true;
            this.BtnAddMajor.Icon = null;
            this.BtnAddMajor.Location = new System.Drawing.Point(448, 181);
            this.BtnAddMajor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAddMajor.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddMajor.Name = "BtnAddMajor";
            this.BtnAddMajor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAddMajor.Size = new System.Drawing.Size(158, 36);
            this.BtnAddMajor.TabIndex = 14;
            this.BtnAddMajor.Text = "اضافه کردن رشته جدید";
            this.BtnAddMajor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAddMajor.UseAccentColor = false;
            this.BtnAddMajor.UseVisualStyleBackColor = false;
            this.BtnAddMajor.Click += new System.EventHandler(this.BtnAddMajor_Click);
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
            this.term,
            this.Group,
            this.Level});
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dgv.GridColor = System.Drawing.SystemColors.Desktop;
            this.Dgv.Location = new System.Drawing.Point(3, 226);
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
            this.Dgv.Size = new System.Drawing.Size(663, 170);
            this.Dgv.TabIndex = 24;
            this.Dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Major_ID";
            this.Id.FillWeight = 62.94416F;
            this.Id.HeaderText = "آیدی";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // term
            // 
            this.term.DataPropertyName = "Major_Name";
            this.term.FillWeight = 125.5908F;
            this.term.HeaderText = "نام رشته";
            this.term.Name = "term";
            this.term.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group_Name";
            this.Group.FillWeight = 105.7325F;
            this.Group.HeaderText = "گروه آموزشی";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level_Name";
            this.Level.FillWeight = 105.7325F;
            this.Level.HeaderText = "مقطع";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // MajorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(669, 399);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.BtnRemoveMajor);
            this.Controls.Add(this.BtnUpdateMajor);
            this.Controls.Add(this.BtnAddMajor);
            this.Controls.Add(this.CbGroup);
            this.Controls.Add(this.CbLevel);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "MajorsForm";
            this.Load += new System.EventHandler(this.MajorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtMajor;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox CbLevel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox CbGroup;
        private MaterialSkin.Controls.MaterialButton BtnRemoveMajor;
        private MaterialSkin.Controls.MaterialButton BtnUpdateMajor;
        private MaterialSkin.Controls.MaterialButton BtnAddMajor;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn term;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
    }
}
