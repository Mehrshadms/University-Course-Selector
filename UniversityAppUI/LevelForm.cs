using System;
using System.Windows.Forms;
using UniversityAppData.Model;

namespace UniversityAppUI
{
    public partial class LevelForm : UniversityAppUI.Template
    {
        public LevelForm()
        {
            InitializeComponent();
        }

        private Levels UpdateModel = new Levels();

        private void UpdateData()
        {
            Dgv.AutoGenerateColumns = false;
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                Dgv.DataSource = Db.LevelsRep.GetAllRecords();
            }
        }

        private void EmptyUpdateVariable()
        {
            UpdateModel.Level_ID = -1;
            txtLevel.Text = null;
            UpdateModel.Level_Name = null;
        }

        private void BtnAddLevel_Click(object sender, System.EventArgs e)
        {
            int Flag = 0;
            if (string.IsNullOrEmpty(txtLevel.Text))
            {
                Flag = 1;
            }
            switch (Flag)
            {
                case 0:
                    using (UniversityAppData.DbContext.UnitOfWork _Db = new UniversityAppData.DbContext.UnitOfWork())
                    {
                        Levels AddModel = new Levels()
                        {
                            Level_Name = txtLevel.Text
                        };
                        if (_Db.LevelsRep.AddNewEntity(AddModel))
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

        private void BtnUpdateLevel_Click(object sender, System.EventArgs e)
        {
            if (UpdateModel.Level_ID != -1)
            {
                string question = "آیا با آپدیت رکورد شماره  " + UpdateModel.Level_ID + " از " + UpdateModel.Level_Name + " به " + txtLevel.Text + " موافق هستید ";
                if (MessageBox.Show(question, "آپدیت", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    UpdateModel.Level_Name = txtLevel.Text;
                    using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                    {
                        if (Db.LevelsRep.UpdateThisModel(UpdateModel))
                        {
                            Db.Save();
                            txtLevel.Text = "";
                            EmptyUpdateVariable();
                            UpdateData();
                        }
                    }
                }
            }
        }

        private void BtnRemoveLevel_Click(object sender, System.EventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                {
                    if (Db.LevelsRep.DeleteThisModelBy(int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString())))
                    {
                        Db.Save();
                        UpdateData();
                        EmptyUpdateVariable();
                    }
                }
            }
        }

        private void Dgv_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                UpdateModel.Level_ID = int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString());
                txtLevel.Text = Dgv.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void LevelForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}