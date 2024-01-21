using System;
using System.Windows.Forms;
using UniversityAppData.Model;

namespace UniversityAppUI
{
    public partial class DegreeForm : UniversityAppUI.Template
    {
        public DegreeForm()
        {
            InitializeComponent();
        }

        private Teacher_Degree UpdateModel = new Teacher_Degree();

        private void UpdateData()
        {
            Dgv.AutoGenerateColumns = false;
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                Dgv.DataSource = Db.TeacherDegreeRep.GetAllRecords();
            }
        }

        private void EmptyUpdateVariable()
        {
            UpdateModel.Degree_ID = -1;
            UpdateModel.Degree_Name = null;
        }

        private void BtnAddDegree_Click(object sender, EventArgs e)
        {
            int Flag = 0;
            if (string.IsNullOrEmpty(txtDegree.Text))
            {
                Flag = 1;
            }
            switch (Flag)
            {
                case 0:
                    using (UniversityAppData.DbContext.UnitOfWork _Db = new UniversityAppData.DbContext.UnitOfWork())
                    {
                        Teacher_Degree AddModel = new Teacher_Degree()
                        {
                            Degree_Name = txtDegree.Text
                        };
                        if (_Db.TeacherDegreeRep.AddNewEntity(AddModel))
                        {
                            _Db.Save();
                            UpdateData();
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

        private void BtnUpdateDegree_Click(object sender, EventArgs e)
        {
            if (UpdateModel.Degree_ID != -1)
            {
                string question = "آیا با آپدیت رکورد شماره  " + UpdateModel.Degree_ID + " از " + UpdateModel.Degree_Name + " به " + txtDegree.Text + " موافق هستید ";
                if (MessageBox.Show(question, "آپدیت", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    UpdateModel.Degree_Name = txtDegree.Text;
                    using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                    {
                        if (Db.TeacherDegreeRep.UpdateThisModel(UpdateModel))
                        {
                            Db.Save();
                            txtDegree.Text = "";
                            EmptyUpdateVariable();
                            UpdateData();
                        }
                    }
                }
            }
        }

        private void BtnRemoveDegree_Click(object sender, EventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                {
                    if (Db.TeacherDegreeRep.DeleteThisModelBy(int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString())))
                    {
                        Db.Save();
                        UpdateData();
                        EmptyUpdateVariable();
                    }
                }
            }
        }

        private void DegreeForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                UpdateModel.Degree_ID = int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString());
                txtDegree.Text = Dgv.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}