namespace UniversityAppUI
{
    partial class DegreeForm
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
            this.BtnRemoveDegree = new MaterialSkin.Controls.MaterialButton();
            this.BtnUpdateDegree = new MaterialSkin.Controls.MaterialButton();
            this.BtnAddDegree = new MaterialSkin.Controls.MaterialButton();
            this.txtDegree = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRemoveDegree
            // 
            this.BtnRemoveDegree.AutoSize = false;
            this.BtnRemoveDegree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRemoveDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnRemoveDegree.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnRemoveDegree.Depth = 0;
            this.BtnRemoveDegree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnRemoveDegree.HighEmphasis = true;
            this.BtnRemoveDegree.Icon = null;
            this.BtnRemoveDegree.Location = new System.Drawing.Point(8, 117);
            this.BtnRemoveDegree.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRemoveDegree.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRemoveDegree.Name = "BtnRemoveDegree";
            this.BtnRemoveDegree.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnRemoveDegree.Size = new System.Drawing.Size(119, 36);
            this.BtnRemoveDegree.TabIndex = 30;
            this.BtnRemoveDegree.Text = "حذف این مدرک";
            this.BtnRemoveDegree.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnRemoveDegree.UseAccentColor = true;
            this.BtnRemoveDegree.UseVisualStyleBackColor = false;
            this.BtnRemoveDegree.Click += new System.EventHandler(this.BtnRemoveDegree_Click);
            // 
            // BtnUpdateDegree
            // 
            this.BtnUpdateDegree.AutoSize = false;
            this.BtnUpdateDegree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUpdateDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnUpdateDegree.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnUpdateDegree.Depth = 0;
            this.BtnUpdateDegree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnUpdateDegree.HighEmphasis = true;
            this.BtnUpdateDegree.Icon = null;
            this.BtnUpdateDegree.Location = new System.Drawing.Point(150, 117);
            this.BtnUpdateDegree.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnUpdateDegree.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdateDegree.Name = "BtnUpdateDegree";
            this.BtnUpdateDegree.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnUpdateDegree.Size = new System.Drawing.Size(119, 36);
            this.BtnUpdateDegree.TabIndex = 31;
            this.BtnUpdateDegree.Text = "بروزرسانی این مدرک";
            this.BtnUpdateDegree.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnUpdateDegree.UseAccentColor = false;
            this.BtnUpdateDegree.UseVisualStyleBackColor = false;
            this.BtnUpdateDegree.Click += new System.EventHandler(this.BtnUpdateDegree_Click);
            // 
            // BtnAddDegree
            // 
            this.BtnAddDegree.AutoSize = false;
            this.BtnAddDegree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAddDegree.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAddDegree.Depth = 0;
            this.BtnAddDegree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAddDegree.HighEmphasis = true;
            this.BtnAddDegree.Icon = null;
            this.BtnAddDegree.Location = new System.Drawing.Point(292, 117);
            this.BtnAddDegree.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAddDegree.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddDegree.Name = "BtnAddDegree";
            this.BtnAddDegree.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAddDegree.Size = new System.Drawing.Size(119, 36);
            this.BtnAddDegree.TabIndex = 32;
            this.BtnAddDegree.Text = "اضافه کردن این مدرک";
            this.BtnAddDegree.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAddDegree.UseAccentColor = false;
            this.BtnAddDegree.UseVisualStyleBackColor = false;
            this.BtnAddDegree.Click += new System.EventHandler(this.BtnAddDegree_Click);
            // 
            // txtDegree
            // 
            this.txtDegree.AnimateReadOnly = false;
            this.txtDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtDegree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDegree.Depth = 0;
            this.txtDegree.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDegree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDegree.LeadingIcon = null;
            this.txtDegree.Location = new System.Drawing.Point(46, 42);
            this.txtDegree.MaxLength = 50;
            this.txtDegree.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDegree.Multiline = false;
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(205, 36);
            this.txtDegree.TabIndex = 28;
            this.txtDegree.Text = "";
            this.txtDegree.TrailingIcon = null;
            this.txtDegree.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(260, 44);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(140, 29);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "نام مدرک تحصیلی";
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
            this.Dgv.TabIndex = 33;
            this.Dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Degree_ID";
            this.Id.FillWeight = 81.21828F;
            this.Id.HeaderText = "آیدی";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Degree_Name";
            this.Level.FillWeight = 118.7817F;
            this.Level.HeaderText = "نام مدرک تحصیلی";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // DegreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(419, 315);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.BtnRemoveDegree);
            this.Controls.Add(this.BtnUpdateDegree);
            this.Controls.Add(this.BtnAddDegree);
            this.Controls.Add(this.txtDegree);
            this.Controls.Add(this.materialLabel1);
            this.Name = "DegreeForm";
            this.Load += new System.EventHandler(this.DegreeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton BtnRemoveDegree;
        private MaterialSkin.Controls.MaterialButton BtnUpdateDegree;
        private MaterialSkin.Controls.MaterialButton BtnAddDegree;
        private MaterialSkin.Controls.MaterialTextBox txtDegree;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
    }
}
