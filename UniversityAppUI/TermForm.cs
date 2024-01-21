using System;
using System.Windows.Forms;
using UniversityAppData.Model;

namespace UniversityAppUI
{
    public partial class TermForm : UniversityAppUI.Template
    {
        public TermForm()
        {
            InitializeComponent();
        }

        private Term UpdateModel = new Term();

        private void BtnAddTerm_Click(object sender, EventArgs e)
        {
            int Flag = 0;
            if (string.IsNullOrEmpty(txtTerm.Text))
            {
                Flag = 1;
            }
            switch (Flag)
            {
                case 0:
                    using (UniversityAppData.DbContext.UnitOfWork _Db = new UniversityAppData.DbContext.UnitOfWork())
                    {
                        Term NewTerm = new Term()
                        {
                            Term_Name = int.Parse(txtTerm.Text)
                        };
                        if (_Db.TermRep.AddNewEntity(NewTerm))
                        {
                            _Db.Save();
                            UpdateData();
                            EmptyUpdateVariable();
                        }
                        else
                        {
                            //TODO
                        }
                    }
                    break;

                case 1:
                    MessageBox.Show("لطفا تمامی فیلد هارا پر نمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    break;

                default:
                    break;
            }
        }

        private void BtnUpdateTerm_Click(object sender, EventArgs e)
        {
            if (UpdateModel.Term_ID != -1)
            {
                string question = "آیا با آپدیت رکورد شماره  " + UpdateModel.Term_ID + " از " + UpdateModel.Term_Name + " به " + txtTerm.Text + " موافق هستید ";
                if (MessageBox.Show(question, "آپدیت", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    UpdateModel.Term_Name = int.Parse(txtTerm.Text);
                    using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                    {
                        if (Db.TermRep.UpdateThisModel(UpdateModel))
                        {
                            Db.Save();
                            txtTerm.Text = "";
                            EmptyUpdateVariable();
                            UpdateData();
                        }
                    }
                }
            }
        }

        private void BtnRemoveTerm_Click(object sender, EventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                {
                    if (Db.TermRep.DeleteThisModelBy(int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString())))
                    {
                        Db.Save();
                        UpdateData();
                        EmptyUpdateVariable();
                    }
                }
            }
        }

        private void UpdateData()
        {
            Dgv.AutoGenerateColumns = false;
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                Dgv.DataSource = Db.TermRep.GetAllRecords();
            }
        }

        private void TermForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void EmptyUpdateVariable()
        {
            UpdateModel.Term_ID = -1;
            UpdateModel.Term_Name = 0;
            txtTerm.Text = "";
        }

        private void DgvTerm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                UpdateModel.Term_ID = int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString());
                txtTerm.Text = Dgv.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}