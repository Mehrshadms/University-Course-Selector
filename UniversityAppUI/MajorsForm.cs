using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityAppData.Model;

namespace UniversityAppUI
{
    public partial class MajorsForm : UniversityAppUI.Template
    {
        public MajorsForm()
        {
            InitializeComponent();
        }

        private Majors UpdateModel = new Majors();
        private List<Majors> MajorList = new List<Majors>();
        private List<Levels> LevelList = new List<Levels>();
        private List<Groups> GroupsList = new List<Groups>();

        async private Task UpdateData()
        {
            Dgv.AutoGenerateColumns = false;
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                MajorList = (List<Majors>)Db.MajorsRep.GetAllRecords();
                Dgv.DataSource = MajorList.Select(Q => new
                {
                    Q.Major_ID,
                    Q.Major_Name,
                    Q.Groups.Group_Name,
                    Q.Levels.Level_Name
                }).ToList();
                GroupsList = (List<Groups>)Db.GroupsRep.GetAllRecords();
                LevelList = Db.LevelsRep.GetAllRecords() as List<Levels>;
                CbGroup.DataSource = GroupsList;
                CbGroup.DisplayMember = "Group_Name";
                CbGroup.ValueMember = "Group_ID";
                CbLevel.DataSource = LevelList;
                CbLevel.DisplayMember = "Level_Name";
                CbLevel.ValueMember = "Level_Id";
            }
        }

        private void EmptyUpdateVariable()
        {
            UpdateModel.Major_ID = -1;
            UpdateModel.Major_Name = null;
            UpdateModel.Courses = null;
            UpdateModel.Levels = null;
            txtMajor.Text = null;
            CbGroup.SelectedIndex = -1;
            CbGroup.SelectedIndex = -1;
        }

        private int CheckVariables()
        {
            int Flag = 0;
            if (string.IsNullOrEmpty(txtMajor.Text))
            {
                Flag = 1;
            }
            else if (string.IsNullOrEmpty(CbGroup.SelectedItem.ToString()))
            {
                Flag = 1;
            }
            else if (string.IsNullOrEmpty(CbLevel.SelectedItem.ToString()))
            {
                Flag = 1;
            }
            return Flag;
        }

        private void BtnAddMajor_Click(object sender, EventArgs e)
        {
            switch (CheckVariables())
            {
                case 0:
                    using (UniversityAppData.DbContext.UnitOfWork _Db = new UniversityAppData.DbContext.UnitOfWork())
                    {
                        Majors AddModel = new Majors()
                        {
                            Major_Name = txtMajor.Text,
                            FK_Group_ID = GroupsList.Where(m => m.Group_Name == CbGroup.SelectedItem.ToString()).Select(n => n.Group_ID).Single(),
                            FK_Level_ID = LevelList.Where(m => m.Level_Name == CbLevel.SelectedItem.ToString()).Select(n => n.Level_ID).Single(),
                        };
                        if (_Db.MajorsRep.AddNewEntity(AddModel))
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

        private void BtnUpdateMajor_Click(object sender, EventArgs e)
        {
            switch (CheckVariables())
            {
                case 0:
                    if (UpdateModel.Major_ID != -1)
                    {
                        string question = " آیا با آپدیت رکورد شماره  " + UpdateModel.Major_ID + " موافق هستید؟ ";
                        if (MessageBox.Show(question, "آپدیت", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                        {
                            UpdateModel.Major_Name = txtMajor.Text;
                            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                            {
                                if (Db.MajorsRep.UpdateThisModel(UpdateModel))
                                {
                                    Db.Save();
                                    EmptyUpdateVariable();
                                    UpdateData();
                                }
                            }
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

        private void BtnRemoveMajor_Click(object sender, EventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                {
                    if (Db.MajorsRep.DeleteThisModelBy(int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString())))
                    {
                        Db.Save();
                        UpdateData();
                        EmptyUpdateVariable();
                    }
                }
            }
        }

        private void MajorsForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                UpdateModel.Major_ID = int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString());
                txtMajor.Text = Dgv.SelectedRows[0].Cells[1].Value.ToString();

                CbGroup.SelectedItem = Utility.WhichItemIsSelected(CbGroup, Dgv.SelectedRows[0].Cells[2].Value.ToString());
                CbLevel.SelectedItem = Utility.WhichItemIsSelected(CbLevel, Dgv.SelectedRows[0].Cells[3].Value.ToString());
                CbGroup.Refresh(); CbLevel.Refresh();
            }
        }
    }
}