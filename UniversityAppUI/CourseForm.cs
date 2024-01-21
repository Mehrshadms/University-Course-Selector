using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UniversityAppData.Model;
using UniversityAppData.Viewmodels;

namespace UniversityAppUI
{
    public partial class CourseForm : UniversityAppUI.Template
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private const string NoPre = "ندارد";
        private List<Courses> CourseList = new List<Courses>();
        private List<CoursesViewModel> CourseViewList = new List<CoursesViewModel>();
        private Courses UpdateModel;
        private List<Majors> MajorList = new List<Majors>();

        private void UpdateData()
        {
            Dgv.AutoGenerateColumns = false;
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                CourseList = (List<Courses>)Db.CoursesRep.GetAllRecords();

                MajorList = Db.MajorsRep.GetAllRecords() as List<Majors>;
            }

            CourseViewList = CourseList.Select(S => new CoursesViewModel()
            {
                Id = S.Course_ID,
                CourseName = S.Course_Name,
                PracticalHours = S.Practical_Hours,
                PracticalUnits = S.Practical_Units,
                TheoryHours = S.Theory_Hours,
                TheoryUnits = S.Theory_Units,
                TotalHours = S.Total_Hours,
                TotalUnits = S.Total_Units,
                MajorId = S.FK_Major_ID,
                MajorsName = S.Majors.Major_Name,
                PrerequisiteId = S.FK_Prerequisite,
                PrerequisiteName = (S.Courses2 == null ? NoPre : S.Courses2.Course_Name)
            }
            ).ToList();
            Dgv.DataSource = CourseViewList.Select(Q => new
            {
                Q.Id,
                Q.CourseName,
                Q.PracticalHours,
                Q.TheoryHours,
                Q.TotalHours,
                Q.PracticalUnits,
                Q.TheoryUnits,
                Q.TotalUnits,
                Q.MajorsName,
                Q.MajorId,
                Q.PrerequisiteId,
                Q.PrerequisiteName
            }).ToList();
            CourseList.Add(new Courses()
            { Course_ID = -1, Course_Name = NoPre }
                );
            CbPrerequisite.DisplayMember = "Course_Name";
            CbPrerequisite.ValueMember = "Course_ID";
            CbMajor.DataSource = MajorList;
            CbMajor.DisplayMember = "Major_Name";
            CbMajor.ValueMember = "Major_ID";
            //CbMajor.DataSource = MajorList.Select(p => p.Major_Name).ToList();
            CbPrerequisite.DataSource = CourseList;
        }

        private void EmptyUpdateVariable()
        {
            txtCourse.Text = null;
        }

        private int CheckVariables()
        {
            int Flag = 0;
            if (string.IsNullOrEmpty(txtCourse.Text))
            {
                Flag = 1;
            }
            else if (string.IsNullOrEmpty(CbMajor.SelectedItem.ToString()))
            {
                Flag = 1;
            }
            return Flag;
        }

        private int? isPrerequisiteCourseEmpty()
        {
            int? FK_PrerequisiteTemp = null;
            if ((int)CbPrerequisite.SelectedValue != -1)
            {
                FK_PrerequisiteTemp = (int)CbPrerequisite.SelectedValue;
            }
            return FK_PrerequisiteTemp;
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            switch (CheckVariables())
            {
                case 0:

                    using (UniversityAppData.DbContext.UnitOfWork _Db = new UniversityAppData.DbContext.UnitOfWork())
                    {
                        Courses AddModel = new Courses()
                        {
                            Course_Name = txtCourse.Text,
                            Practical_Hours = ((int)NudPracticalUnit.Value * 32),
                            Theory_Hours = ((int)NudTheoryUnit.Value * 16),
                            Total_Hours = ((int)NudPracticalUnit.Value * 32) + ((int)NudTheoryUnit.Value * 16),
                            Practical_Units = (int)NudPracticalUnit.Value,
                            Theory_Units = (int)NudTheoryUnit.Value,
                            Total_Units = ((int)NudPracticalUnit.Value + (int)NudTheoryUnit.Value),
                            FK_Major_ID = (int)CbMajor.SelectedValue,
                            FK_Prerequisite = isPrerequisiteCourseEmpty()
                        };
                        if (_Db.CoursesRep.AddNewEntity(AddModel))
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

        private void BtnUpdateCourse_Click(object sender, EventArgs e)
        {
            switch (CheckVariables())
            {
                case 0:
                    string question = " آیا با آپدیت رکورد شماره  " + Dgv.SelectedRows[0].Cells[0].Value.ToString() + " موافق هستید؟ ";
                    if (MessageBox.Show(question, "آپدیت", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                    {
                        UpdateModel = new Courses()
                        {
                            Course_ID = int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString()),
                            Course_Name = txtCourse.Text,
                            Practical_Hours = ((int)NudPracticalUnit.Value * 32),
                            Theory_Hours = ((int)NudTheoryUnit.Value * 16),
                            Total_Hours = ((int)NudPracticalUnit.Value * 32) + ((int)NudTheoryUnit.Value * 16),
                            Practical_Units = (int)NudPracticalUnit.Value,
                            Theory_Units = (int)NudTheoryUnit.Value,
                            Total_Units = ((int)NudPracticalUnit.Value + (int)NudTheoryUnit.Value),
                            FK_Major_ID = (int)CbMajor.SelectedValue,
                            FK_Prerequisite = isPrerequisiteCourseEmpty()
                        };
                        using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                        {
                            if (Db.CoursesRep.UpdateThisModel(UpdateModel))
                            {
                                Db.Save();
                                EmptyUpdateVariable();
                                UpdateData();
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

        private void BtnRemoveCourse_Click(object sender, EventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                {
                    if (Db.CoursesRep.DeleteThisModelBy(int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString())))
                    {
                        Db.Save();
                        UpdateData();
                        EmptyUpdateVariable();
                    }
                }
            }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                txtCourse.Text = Dgv.SelectedRows[0].Cells[1].Value.ToString();
                CbPrerequisite.SelectedIndex = CbPrerequisite.FindString(Dgv.SelectedRows[0].Cells[5].Value.ToString());
                CbMajor.SelectedIndex = CbMajor.FindString(Dgv.SelectedRows[0].Cells[4].Value.ToString());
                CbPrerequisite.Refresh(); CbMajor.Refresh();
                using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                {
                    Courses temp = (Courses)Db.CoursesRep.GetRecordBy((int)Dgv.SelectedRows[0].Cells[0].Value);
                    LabelT.Text = $"{(decimal)temp.Theory_Hours}ساعت تئوری ";
                    LabelP.Text = $"{(decimal)temp.Practical_Hours}ساعت عملی ";

                    NudTheoryUnit.Value = (decimal)temp.Practical_Units;
                    NudPracticalUnit.Value = (decimal)temp.Theory_Units;
                }

                CbMajor.Refresh();
            }
        }

        private void NudTheoryUnit_ValueChanged(object sender, EventArgs e)
        {
            LabelT.Text = $"{NudTheoryUnit.Value * 16}ساعت تئوری ";
        }

        private void NudPracticalUnit_ValueChanged(object sender, EventArgs e)
        {
            LabelP.Text = $"{NudPracticalUnit.Value * 32}ساعت عملی ";
        }
    }
}