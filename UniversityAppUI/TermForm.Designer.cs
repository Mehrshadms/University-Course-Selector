namespace UniversityAppUI
{
    partial class TermForm
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
            this.BtnRemoveTerm = new MaterialSkin.Controls.MaterialButton();
            this.BtnUpdateTerm = new MaterialSkin.Controls.MaterialButton();
            this.BtnAddTerm = new MaterialSkin.Controls.MaterialButton();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTerm = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRemoveTerm
            // 
            this.BtnRemoveTerm.AutoSize = false;
            this.BtnRemoveTerm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRemoveTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnRemoveTerm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnRemoveTerm.Depth = 0;
            this.BtnRemoveTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnRemoveTerm.HighEmphasis = true;
            this.BtnRemoveTerm.Icon = null;
            this.BtnRemoveTerm.Location = new System.Drawing.Point(8, 117);
            this.BtnRemoveTerm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRemoveTerm.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRemoveTerm.Name = "BtnRemoveTerm";
            this.BtnRemoveTerm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnRemoveTerm.Size = new System.Drawing.Size(119, 36);
            this.BtnRemoveTerm.TabIndex = 24;
            this.BtnRemoveTerm.Text = "حذف این ترم";
            this.BtnRemoveTerm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnRemoveTerm.UseAccentColor = true;
            this.BtnRemoveTerm.UseVisualStyleBackColor = false;
            this.BtnRemoveTerm.Click += new System.EventHandler(this.BtnRemoveTerm_Click);
            // 
            // BtnUpdateTerm
            // 
            this.BtnUpdateTerm.AutoSize = false;
            this.BtnUpdateTerm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUpdateTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnUpdateTerm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnUpdateTerm.Depth = 0;
            this.BtnUpdateTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnUpdateTerm.HighEmphasis = true;
            this.BtnUpdateTerm.Icon = null;
            this.BtnUpdateTerm.Location = new System.Drawing.Point(150, 117);
            this.BtnUpdateTerm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnUpdateTerm.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdateTerm.Name = "BtnUpdateTerm";
            this.BtnUpdateTerm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnUpdateTerm.Size = new System.Drawing.Size(119, 36);
            this.BtnUpdateTerm.TabIndex = 25;
            this.BtnUpdateTerm.Text = "بروزرسانی این ترم";
            this.BtnUpdateTerm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnUpdateTerm.UseAccentColor = false;
            this.BtnUpdateTerm.UseVisualStyleBackColor = false;
            this.BtnUpdateTerm.Click += new System.EventHandler(this.BtnUpdateTerm_Click);
            // 
            // BtnAddTerm
            // 
            this.BtnAddTerm.AutoSize = false;
            this.BtnAddTerm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAddTerm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAddTerm.Depth = 0;
            this.BtnAddTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAddTerm.HighEmphasis = true;
            this.BtnAddTerm.Icon = null;
            this.BtnAddTerm.Location = new System.Drawing.Point(292, 117);
            this.BtnAddTerm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAddTerm.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddTerm.Name = "BtnAddTerm";
            this.BtnAddTerm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAddTerm.Size = new System.Drawing.Size(119, 36);
            this.BtnAddTerm.TabIndex = 26;
            this.BtnAddTerm.Text = "اضافه کردن این ترم";
            this.BtnAddTerm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAddTerm.UseAccentColor = false;
            this.BtnAddTerm.UseVisualStyleBackColor = false;
            this.BtnAddTerm.Click += new System.EventHandler(this.BtnAddTerm_Click);
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
            this.term});
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
            this.Dgv.TabIndex = 23;
            this.Dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvTerm_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Term_ID";
            this.Id.FillWeight = 81.21828F;
            this.Id.HeaderText = "آیدی";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // term
            // 
            this.term.DataPropertyName = "Term_Name";
            this.term.FillWeight = 118.7817F;
            this.term.HeaderText = "نام ترم";
            this.term.Name = "term";
            this.term.ReadOnly = true;
            // 
            // txtTerm
            // 
            this.txtTerm.AnimateReadOnly = false;
            this.txtTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTerm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTerm.Depth = 0;
            this.txtTerm.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTerm.LeadingIcon = null;
            this.txtTerm.Location = new System.Drawing.Point(88, 42);
            this.txtTerm.MaxLength = 12;
            this.txtTerm.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTerm.Multiline = false;
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(205, 36);
            this.txtTerm.TabIndex = 22;
            this.txtTerm.Text = "";
            this.txtTerm.TrailingIcon = null;
            this.txtTerm.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(299, 44);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 29);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "نام ترم";
            // 
            // TermForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(419, 315);
            this.Controls.Add(this.BtnRemoveTerm);
            this.Controls.Add(this.BtnUpdateTerm);
            this.Controls.Add(this.BtnAddTerm);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.materialLabel1);
            this.Name = "TermForm";
            this.Load += new System.EventHandler(this.TermForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton BtnRemoveTerm;
        private MaterialSkin.Controls.MaterialButton BtnUpdateTerm;
        private MaterialSkin.Controls.MaterialButton BtnAddTerm;
        private System.Windows.Forms.DataGridView Dgv;
        private MaterialSkin.Controls.MaterialTextBox txtTerm;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn term;
    }
}
