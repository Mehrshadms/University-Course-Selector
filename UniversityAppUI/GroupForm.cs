using System;
using System.Windows.Forms;
using UniversityAppData.Model;

namespace UniversityAppUI
{
    public partial class GroupForm : UniversityAppUI.Template
    {
        public GroupForm()
        {
            InitializeComponent();
        }

        private Groups UpdateModel = new Groups();

        private void UpdateData()
        {
            Dgv.AutoGenerateColumns = false;
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                Dgv.DataSource = Db.GroupsRep.GetAllRecords();
            }
        }

        private void EmptyUpdateVariable()
        {
            txtGroup.Text = null;
            UpdateModel.Group_ID = -1;
            UpdateModel.Group_Name = null;
        }

        private void BtnAddGroup_Click(object sender, EventArgs e)
        {
            int Flag = 0;
            if (string.IsNullOrEmpty(txtGroup.Text))
            {
                Flag = 1;
            }
            switch (Flag)
            {
                case 0:
                    using (UniversityAppData.DbContext.UnitOfWork _Db = new UniversityAppData.DbContext.UnitOfWork())
                    {
                        Groups AddModel = new Groups()
                        {
                            Group_Name = txtGroup.Text
                        };
                        if (_Db.GroupsRep.AddNewEntity(AddModel))
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

        private void BtnUpdateGroup_Click(object sender, EventArgs e)
        {
            if (UpdateModel.Group_ID != -1)
            {
                string question = "آیا با آپدیت رکورد شماره  " + UpdateModel.Group_ID + " از " + UpdateModel.Group_Name + " به " + txtGroup.Text + " موافق هستید ";
                if (MessageBox.Show(question, "آپدیت", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    UpdateModel.Group_Name = txtGroup.Text;
                    using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                    {
                        if (Db.GroupsRep.UpdateThisModel(UpdateModel))
                        {
                            Db.Save();
                            txtGroup.Text = "";
                            EmptyUpdateVariable();
                            UpdateData();
                        }
                    }
                }
            }
        }

        private void BtnRemoveGroup_Click(object sender, EventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                {
                    if (Db.GroupsRep.DeleteThisModelBy(int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString())))
                    {
                        Db.Save();
                        UpdateData();
                        EmptyUpdateVariable();
                    }
                }
            }
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                UpdateModel.Group_ID = int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString());
                txtGroup.Text = Dgv.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}