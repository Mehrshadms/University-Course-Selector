using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UniversityAppData.Model;
using UniversityAppData.Utility;

namespace UniversityAppUI
{
    public partial class CoursesTimeForm : UniversityAppUI.Template
    {
        private int RemoveId;
        private List<CoursesTime> ListCoursesTimes = new List<CoursesTime>();
        private List<Teacher> TeacherList = new List<Teacher>();
        private List<Term> TermList = new List<Term>();
        private List<Courses> CoursesList = new List<Courses>();
        private IReadOnlyList<DaysOfWeek> DayList = new List<DaysOfWeek>();

        public CoursesTimeForm()
        {
            InitializeComponent();
        }

        private async void InitializeData()
        {
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                TeacherList = Db.TeacherRep.GetAllRecords() as List<Teacher>;
                CoursesList = Db.CoursesRep.GetAllRecords() as List<Courses>;
                TermList = Db.TermRep.GetAllRecords() as List<Term>;
            }

            DayList = Days.GetDaysWeek();

            CbDay.DataSource = DayList;
            CbTeacher.DataSource = TeacherList;
            CbCourse.DataSource = CoursesList;
            CbTerm.DataSource = TermList;
            CbDay.DisplayMember = "DayName";
            CbDay.ValueMember = "Id";
            CbTeacher.DisplayMember = "Teacher_FirstName";
            CbTeacher.ValueMember = "Teacher_id";
            CbCourse.DisplayMember = "Course_Name";
            CbCourse.ValueMember = "Course_ID";
            CbTerm.DisplayMember = "Term_Name";
            CbTerm.ValueMember = "Term_ID";
        }

        private async void UpdateData()
        {
            ListBox.Clear();
            MaterialListBoxItem[] ListCourseTimeBoxItems;
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                ListCoursesTimes = Db.CoursesTimeRep.GetAllRecords() as List<CoursesTime>;
                ListCourseTimeBoxItems = ListCoursesTimes.Select(CT => new MaterialListBoxItem()
                {
                    Text = $"{CT.Courses.Course_Name} با  {CT.Teacher.Teacher_FirstName} {CT.Teacher.Teacher_LastName}",
                    SecondaryText = $"روز {DayList.Where(D => D.Id == CT.CourseDay).Select(D => D.DayName).FirstOrDefault()}  از ساعت {CT.Start_Hour} تا ساعت {CT.End_Hour}",
                    Tag = CT.CourseTime_ID.ToString()
                }).ToArray();
            }

            //MaterialListBoxItem[] ListCourseTimeBoxItems = ListCoursesTimes.Select(CT => new MaterialListBoxItem()
            //{
            //    Text = $"{CT.Courses.Course_Name} با  {CT.Teacher.Teacher_FirstName} {CT.Teacher.Teacher_LastName}",
            //    SecondaryText = $"روز {DayList.Where(D => D.Id == CT.CourseDay).Select(D => D.DayName).First()}  از ساعت {CT.Start_Hour} تا ساعت {CT.End_Hour}",
            //}).ToArray();
            ListBox.AddItems(ListCourseTimeBoxItems);
        }

        private void EmptyVariable()
        {
            CbCourse.SelectedIndex = -1;
            CbDay.SelectedIndex = -1;
            CbTerm.SelectedIndex = -1;
            CbTeacher.SelectedIndex = -1;
            NudHourstart.ResetText();
        }

        private int CheckVariables()
        {
            int Flag = 0;
            if (string.IsNullOrEmpty(CbTerm.SelectedItem.ToString()))
            {
                Flag = 1;
            }
            else if (string.IsNullOrEmpty(CbTeacher.SelectedItem.ToString()))
            {
                Flag = 1;
            }
            else if (string.IsNullOrEmpty(CbCourse.SelectedItem.ToString()))
            {
                Flag = 1;
            }
            else if (string.IsNullOrEmpty(CbDay.SelectedItem.ToString()))
            {
                Flag = 1;
            }
            return Flag;
        }

        private void InsertNew(CoursesTime model)
        {
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                Db.CoursesTimeRep.AddNewEntity(model);
                Db.Save();
            }
            UpdateData();
        }

        private void BtnAddtoList_Click(object sender, System.EventArgs e)
        {
            switch (CheckVariables())
            {
                case 0:
                    CoursesTime AddModel = new CoursesTime()
                    {
                        CourseDay = (int)CbDay.SelectedValue,
                        FK_Teacher_ID = (int)CbTeacher.SelectedValue,
                        FK_Term_ID = (int)CbTerm.SelectedValue,
                        FK_Major_ID = (int)CoursesList.Where(n => n.Course_ID == (int)CbCourse.SelectedValue).Single().FK_Major_ID,
                        FK_Course_ID = (int)CbCourse.SelectedValue,
                        Start_Hour = (int)NudHourstart.Value,
                        End_Hour = (int)NudHourstart.Value + ((int)CoursesList.Where(n => n.Course_ID == (int)CbCourse.SelectedValue).Single().Total_Hours / 16),
                    };
                    
                    if (ListCoursesTimes
                        .Where(L => L.FK_Teacher_ID == AddModel.FK_Teacher_ID
                        && L.CourseDay == AddModel.CourseDay
                        && L.FK_Term_ID == AddModel.FK_Term_ID).Any())
                    {
                        if (ListCoursesTimes.Any(L => (Math.Max(L.Start_Hour, AddModel.Start_Hour) < Math.Min(L.End_Hour, AddModel.End_Hour))))
                        {
                            MessageBox.Show($"این واحد در ساعت {AddModel.Start_Hour} تا {AddModel.End_Hour} با واحد دیگری تداخل دارد", "تداخل زمانی واحد", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            InsertNew(AddModel);
                        }
                    }
                    else
                    {
                        InsertNew(AddModel);
                    }

                    break;

                case 1:
                    MessageBox.Show("لطفا تمامی فیلد هارا پر نمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    break;

                default:
                    break;
            }
        }

        private void BtnAddAll_Click(object sender, System.EventArgs e)
        {
            switch (CheckVariables())
            {
                case 0:
                    using (UniversityAppData.DbContext.UnitOfWork _Db = new UniversityAppData.DbContext.UnitOfWork())
                    {
                    }
                    break;

                case 1:
                    MessageBox.Show("لطفا تمامی فیلد هارا پر نمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    break;

                default:
                    break;
            }
        }

        private void BtnRemoveAllList_Click(object sender, System.EventArgs e)
        {
            string question = " آیا با پاک کردن همه  " + " موافق هستید؟ ";
            if (MessageBox.Show(question, "پاک کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                ListBox.Clear();
            }
        }

        private void materialButton1_Click(object sender, System.EventArgs e)
        {
            if (TeacherList != null)
            {
                List<Teacher> tmpteachers = new List<Teacher>();
                CbTeacher.DataSource = tmpteachers;
                CbTeacher.DisplayMember = "Teacher_LastName";
                CbTeacher.ValueMember = "Teacher_Id";
            }
        }

        private async void CoursesTimeForm_Load(object sender, EventArgs e)
        {
            InitializeData();
            if (CoursesList.Count != 0)
            {
                CbCourse.SelectedIndex = 0;
                LblHourEnd.Text = ((int)NudHourstart.Value + CoursesList.Where(c => c.Course_ID == (int)CbCourse.SelectedValue).Select(c => c.Total_Hours / 16).First()).ToString();
            }

            UpdateData();
        }

        private void CbTeacher_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((Teacher)e.ListItem).Teacher_LastName;
            string firstname = ((Teacher)e.ListItem).Teacher_FirstName;
            e.Value = firstname + "  " + lastname;
        }

        private void NudHourstart_ValueChanged(object sender, EventArgs e)
        {
            LblHourEnd.Text = ((int)NudHourstart.Value + CoursesList.Where(c => c.Course_ID == (int)CbCourse.SelectedValue).Select(c => c.Total_Hours / 16).First()).ToString();
        }

        private void CbCourse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LblHourEnd.Text = ((int)NudHourstart.Value + CoursesList.Where(c => c.Course_ID == (int)CbCourse.SelectedValue).Select(c => c.Total_Hours / 16).First()).ToString();
        }

        private void BtnDelThis_Click(object sender, EventArgs e)
        {
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                if (RemoveId != null)
                {
                    CoursesTime Ct = Db.CoursesTimeRep.GetRecordBy(RemoveId);
                    Db.CoursesTimeRep.DeleteThisModelBy(Ct);
                    Db.Save();
                    UpdateData();
                }
            }
        }

        private void ListBox_MouseLeave(object sender, EventArgs e)
        {
        }

        private void ListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            RemoveId = int.Parse(ListBox.SelectedItem.Tag.ToString());
        }
    }
}