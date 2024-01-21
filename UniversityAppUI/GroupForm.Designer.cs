namespace UniversityAppUI
{
    partial class GroupForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnRemoveGroup = new MaterialSkin.Controls.MaterialButton();
            this.BtnUpdateGroup = new MaterialSkin.Controls.MaterialButton();
            this.BtnAddGroup = new MaterialSkin.Controls.MaterialButton();
            this.txtGroup = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRemoveGroup
            // 
            this.BtnRemoveGroup.AutoSize = false;
            this.BtnRemoveGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRemoveGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnRemoveGroup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnRemoveGroup.Depth = 0;
            this.BtnRemoveGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnRemoveGroup.HighEmphasis = true;
            this.BtnRemoveGroup.Icon = null;
            this.BtnRemoveGroup.Location = new System.Drawing.Point(8, 117);
            this.BtnRemoveGroup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRemoveGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRemoveGroup.Name = "BtnRemoveGroup";
            this.BtnRemoveGroup.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnRemoveGroup.Size = new System.Drawing.Size(119, 36);
            this.BtnRemoveGroup.TabIndex = 18;
            this.BtnRemoveGroup.Text = "حذف این گروه";
            this.BtnRemoveGroup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnRemoveGroup.UseAccentColor = true;
            this.BtnRemoveGroup.UseVisualStyleBackColor = false;
            this.BtnRemoveGroup.Click += new System.EventHandler(this.BtnRemoveGroup_Click);
            // 
            // BtnUpdateGroup
            // 
            this.BtnUpdateGroup.AutoSize = false;
            this.BtnUpdateGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUpdateGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnUpdateGroup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnUpdateGroup.Depth = 0;
            this.BtnUpdateGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnUpdateGroup.HighEmphasis = true;
            this.BtnUpdateGroup.Icon = null;
            this.BtnUpdateGroup.Location = new System.Drawing.Point(150, 117);
            this.BtnUpdateGroup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnUpdateGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdateGroup.Name = "BtnUpdateGroup";
            this.BtnUpdateGroup.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnUpdateGroup.Size = new System.Drawing.Size(119, 36);
            this.BtnUpdateGroup.TabIndex = 19;
            this.BtnUpdateGroup.Text = "بروزرسانی این گروه";
            this.BtnUpdateGroup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnUpdateGroup.UseAccentColor = false;
            this.BtnUpdateGroup.UseVisualStyleBackColor = false;
            this.BtnUpdateGroup.Click += new System.EventHandler(this.BtnUpdateGroup_Click);
            // 
            // BtnAddGroup
            // 
            this.BtnAddGroup.AutoSize = false;
            this.BtnAddGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAddGroup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAddGroup.Depth = 0;
            this.BtnAddGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAddGroup.HighEmphasis = true;
            this.BtnAddGroup.Icon = null;
            this.BtnAddGroup.Location = new System.Drawing.Point(292, 117);
            this.BtnAddGroup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAddGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddGroup.Name = "BtnAddGroup";
            this.BtnAddGroup.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAddGroup.Size = new System.Drawing.Size(119, 36);
            this.BtnAddGroup.TabIndex = 20;
            this.BtnAddGroup.Text = "اضافه کردن این گروه";
            this.BtnAddGroup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAddGroup.UseAccentColor = false;
            this.BtnAddGroup.UseVisualStyleBackColor = false;
            this.BtnAddGroup.Click += new System.EventHandler(this.BtnAddGroup_Click);
            // 
            // txtGroup
            // 
            this.txtGroup.AnimateReadOnly = false;
            this.txtGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGroup.Depth = 0;
            this.txtGroup.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtGroup.LeadingIcon = null;
            this.txtGroup.Location = new System.Drawing.Point(45, 42);
            this.txtGroup.MaxLength = 50;
            this.txtGroup.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGroup.Multiline = false;
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(205, 36);
            this.txtGroup.TabIndex = 16;
            this.txtGroup.Text = "";
            this.txtGroup.TrailingIcon = null;
            this.txtGroup.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(256, 43);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(135, 29);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "نام گروه آموزشی";
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
            this.Level});
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dgv.GridColor = System.Drawing.SystemColors.Desktop;
            this.Dgv.Location = new System.Drawing.Point(3, 162);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Dgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(413, 150);
            this.Dgv.TabIndex = 26;
            this.Dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Group_ID";
            this.Id.FillWeight = 81.21828F;
            this.Id.HeaderText = "آیدی";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Group_Name";
            this.Level.FillWeight = 118.7817F;
            this.Level.HeaderText = "نام گروه آموزشی";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(419, 315);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.BtnRemoveGroup);
            this.Controls.Add(this.BtnUpdateGroup);
            this.Controls.Add(this.BtnAddGroup);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.materialLabel1);
            this.Name = "GroupForm";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton BtnRemoveGroup;
        private MaterialSkin.Controls.MaterialButton BtnUpdateGroup;
        private MaterialSkin.Controls.MaterialButton BtnAddGroup;
        private MaterialSkin.Controls.MaterialTextBox txtGroup;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
    }
}
