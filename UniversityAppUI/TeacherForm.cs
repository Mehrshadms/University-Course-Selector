using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityAppData.Model;

namespace UniversityAppUI
{
    public partial class TeacherForm : UniversityAppUI.Template
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        public List<CoursesTime> CoursesToPdf = new List<CoursesTime>();
        private IReadOnlyList<DaysOfWeek> DayList = new List<DaysOfWeek>();
        public List<CoursesTime> ListCoursesTimes = new List<CoursesTime>();
        private List<Term> TermList = new List<Term>();

        private List<int> SelectedCourses = new List<int>(6);
        private Teacher UpdateModel;
        private List<Teacher_Degree> DegreeList = new List<Teacher_Degree>();
        private List<Groups> GroupList = new List<Groups>();
        private List<Teacher> TeachersList = new List<Teacher>();

        async private Task UpdateData()
        {
            Dgv.AutoGenerateColumns = false;
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                TeachersList = (List<Teacher>)Db.TeacherRep.GetAllRecords();

                Dgv.DataSource = TeachersList.Select(model => new
                {
                    model.Teacher_Id,
                    model.Teacher_FirstName,
                    model.Teacher_LastName,
                    model.FK_Teacher_Degree_ID,
                    model.FK_Teacher_Group_ID,
                    model.Teacher_Degree.Degree_Name,
                    model.Groups.Group_Name,
                }).ToList();
            }
        }

        private void EmptyUpdateVariable()
        {
            ListBox.Clear();
            SelectedCourses.Clear();
            ListBox.Refresh();
        }

        private int CheckVariables()
        {
            int Flag = 0;
            if (string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text))
            {
                Flag = 1;
            }
            else if (string.IsNullOrEmpty(CbDegree.SelectedItem.ToString()) || string.IsNullOrEmpty(CbGroup.SelectedItem.ToString()))
            {
                Flag = 1;
            }
            return Flag;
        }

        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            switch (CheckVariables())
            {
                case 0:
                    using (UniversityAppData.DbContext.UnitOfWork _Db = new UniversityAppData.DbContext.UnitOfWork())
                    {
                        Teacher AddModel = new Teacher()
                        {
                            Teacher_FirstName = txtFname.Text,
                            Teacher_LastName = txtLname.Text,
                            FK_Teacher_Degree_ID = DegreeList.Where(m => m.Degree_Name == CbDegree.SelectedItem.ToString()).Select(n => n.Degree_ID).Single(),
                            FK_Teacher_Group_ID = GroupList.Where(m => m.Group_Name == CbGroup.SelectedItem.ToString()).Select(n => n.Group_ID).Single(),
                        };
                        if (_Db.TeacherRep.AddNewEntity(AddModel))
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

        private void BtnUpdateTeacher_Click(object sender, EventArgs e)
        {
            switch (CheckVariables())
            {
                case 0:
                    string question = " آیا با آپدیت رکورد شماره  " + Dgv.SelectedRows[0].Cells[0].Value.ToString() + " موافق هستید؟ ";
                    if (MessageBox.Show(question, "آپدیت", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                    {
                        UpdateModel = new Teacher()
                        {
                            Teacher_Id = int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString()),
                            Teacher_FirstName = txtFname.Text,
                            Teacher_LastName = txtLname.Text,
                            FK_Teacher_Degree_ID = DegreeList.Where(m => m.Degree_Name == CbDegree.SelectedItem.ToString()).Select(n => n.Degree_ID).Single(),
                            FK_Teacher_Group_ID = GroupList.Where(m => m.Group_Name == CbGroup.SelectedItem.ToString()).Select(n => n.Group_ID).Single()
                        };

                        using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                        {
                            if (Db.TeacherRep.UpdateThisModel(UpdateModel))
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

        private void BtnRemoveTeacher_Click(object sender, EventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                {
                    if (Db.TeacherRep.DeleteThisModelBy(int.Parse(Dgv.SelectedRows[0].Cells[0].Value.ToString())))
                    {
                        Db.Save();
                        UpdateData();
                        EmptyUpdateVariable();
                    }
                }
            }
        }

        private async void TeacherForm_Load(object sender, EventArgs e)
        {
            UpdateData();
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                GroupList = Db.GroupsRep.GetAllRecords() as List<Groups>;
                DegreeList = Db.TeacherDegreeRep.GetAllRecords() as List<Teacher_Degree>;
                CbGroup.DataSource = GroupList.Select(p => p.Group_Name).ToList();
                CbDegree.DataSource = DegreeList.Select(p => p.Degree_Name).ToList();
            }
        }

        private void Dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Dgv.SelectedRows.Count == 1)
            {
                ListBox.Clear();
                Teacher temp = new Teacher();
                using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
                {
                    temp = (Teacher)Db.TeacherRep.GetRecordBy((int)Dgv.SelectedRows[0].Cells[0].Value);
                    txtFname.Text = temp.Teacher_FirstName;
                    txtLname.Text = temp.Teacher_LastName;
                    CbDegree.SelectedIndex = Utility.WhichItemIsSelected(CbDegree, temp.Teacher_Degree.Degree_Name);
                    CbGroup.SelectedIndex = Utility.WhichItemIsSelected(CbGroup, temp.Groups.Group_Name);

                    MaterialListBoxItem[] ListCourseTimeBoxItems;
                    ListCoursesTimes = Db.CoursesTimeRep.GetAllRecords() as List<CoursesTime>;
                    ListCoursesTimes = ListCoursesTimes.Where(x => x.FK_Teacher_ID == (int)Dgv.SelectedRows[0].Cells[0].Value).ToList();
                    ListCourseTimeBoxItems = ListCoursesTimes.Select(CT => new MaterialListBoxItem()
                    {
                        Text = $"{CT.Courses.Course_Name} با  {CT.Teacher.Teacher_FirstName} {CT.Teacher.Teacher_LastName}",
                        SecondaryText = $"روز {DayList.Where(D => D.Id == CT.CourseDay).Select(D => D.DayName).FirstOrDefault()}  از ساعت {CT.Start_Hour} تا ساعت {CT.End_Hour}",
                        Tag = CT.CourseTime_ID.ToString()
                    }).ToArray();
                    ListBox.AddItems(ListCourseTimeBoxItems);
                }
                CbDegree.Refresh(); CbGroup.Refresh();
            }
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            string question = " آیا با حدف تمام درس ها  " + " موافق هستید؟ ";
            if (MessageBox.Show(question, "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                ListBox.Clear();
                SelectedCourses.Clear();
            }
        }
    }
}