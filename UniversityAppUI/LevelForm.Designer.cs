namespace UniversityAppUI
{
    partial class LevelForm
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
            this.txtLevel = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnRemoveLevel = new MaterialSkin.Controls.MaterialButton();
            this.BtnUpdateLevel = new MaterialSkin.Controls.MaterialButton();
            this.BtnAddLevel = new MaterialSkin.Controls.MaterialButton();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLevel
            // 
            this.txtLevel.AnimateReadOnly = false;
            this.txtLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLevel.Depth = 0;
            this.txtLevel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLevel.LeadingIcon = null;
            this.txtLevel.Location = new System.Drawing.Point(45, 42);
            this.txtLevel.MaxLength = 50;
            this.txtLevel.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLevel.Multiline = false;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(205, 36);
            this.txtLevel.TabIndex = 7;
            this.txtLevel.Text = "";
            this.txtLevel.TrailingIcon = null;
            this.txtLevel.UseTallSize = false;
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
            this.materialLabel1.Size = new System.Drawing.Size(137, 29);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "نام مقطع تحصیلی";
            // 
            // BtnRemoveLevel
            // 
            this.BtnRemoveLevel.AutoSize = false;
            this.BtnRemoveLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRemoveLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnRemoveLevel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnRemoveLevel.Depth = 0;
            this.BtnRemoveLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnRemoveLevel.HighEmphasis = true;
            this.BtnRemoveLevel.Icon = null;
            this.BtnRemoveLevel.Location = new System.Drawing.Point(7, 117);
            this.BtnRemoveLevel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRemoveLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRemoveLevel.Name = "BtnRemoveLevel";
            this.BtnRemoveLevel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnRemoveLevel.Size = new System.Drawing.Size(119, 36);
            this.BtnRemoveLevel.TabIndex = 12;
            this.BtnRemoveLevel.Text = "حذف این مقطع";
            this.BtnRemoveLevel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnRemoveLevel.UseAccentColor = true;
            this.BtnRemoveLevel.UseVisualStyleBackColor = false;
            this.BtnRemoveLevel.Click += new System.EventHandler(this.BtnRemoveLevel_Click);
            // 
            // BtnUpdateLevel
            // 
            this.BtnUpdateLevel.AutoSize = false;
            this.BtnUpdateLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUpdateLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnUpdateLevel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnUpdateLevel.Depth = 0;
            this.BtnUpdateLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnUpdateLevel.HighEmphasis = true;
            this.BtnUpdateLevel.Icon = null;
            this.BtnUpdateLevel.Location = new System.Drawing.Point(149, 117);
            this.BtnUpdateLevel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnUpdateLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdateLevel.Name = "BtnUpdateLevel";
            this.BtnUpdateLevel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnUpdateLevel.Size = new System.Drawing.Size(119, 36);
            this.BtnUpdateLevel.TabIndex = 13;
            this.BtnUpdateLevel.Text = "بروزرسانی این مقطع";
            this.BtnUpdateLevel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnUpdateLevel.UseAccentColor = false;
            this.BtnUpdateLevel.UseVisualStyleBackColor = false;
            this.BtnUpdateLevel.Click += new System.EventHandler(this.BtnUpdateLevel_Click);
            // 
            // BtnAddLevel
            // 
            this.BtnAddLevel.AutoSize = false;
            this.BtnAddLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAddLevel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAddLevel.Depth = 0;
            this.BtnAddLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAddLevel.HighEmphasis = true;
            this.BtnAddLevel.Icon = null;
            this.BtnAddLevel.Location = new System.Drawing.Point(291, 117);
            this.BtnAddLevel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAddLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddLevel.Name = "BtnAddLevel";
            this.BtnAddLevel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAddLevel.Size = new System.Drawing.Size(119, 36);
            this.BtnAddLevel.TabIndex = 14;
            this.BtnAddLevel.Text = "اضافه کردن این مقطع";
            this.BtnAddLevel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAddLevel.UseAccentColor = false;
            this.BtnAddLevel.UseVisualStyleBackColor = false;
            this.BtnAddLevel.Click += new System.EventHandler(this.BtnAddLevel_Click);
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
            this.Dgv.Size = new System.Drawing.Size(413, 150);
            this.Dgv.TabIndex = 25;
            this.Dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Level_ID";
            this.Id.FillWeight = 81.21828F;
            this.Id.HeaderText = "آیدی";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level_Name";
            this.Level.FillWeight = 118.7817F;
            this.Level.HeaderText = "نام مقطع تحصیلی";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // LevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(419, 315);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.BtnRemoveLevel);
            this.Controls.Add(this.BtnUpdateLevel);
            this.Controls.Add(this.BtnAddLevel);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.materialLabel1);
            this.Name = "LevelForm";
            this.Load += new System.EventHandler(this.LevelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtLevel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton BtnRemoveLevel;
        private MaterialSkin.Controls.MaterialButton BtnUpdateLevel;
        private MaterialSkin.Controls.MaterialButton BtnAddLevel;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
    }
}
