using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UniversityAppData.Model;
using UniversityAppData.Utility;

namespace UniversityAppUI
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        public List<CoursesTime> CoursesToPdf = new List<CoursesTime>();
        private IReadOnlyList<DaysOfWeek> DayList = new List<DaysOfWeek>();
        public List<CoursesTime> ListCoursesTimes = new List<CoursesTime>();
        private List<Term> TermList = new List<Term>();

        private async void InitializeData()
        {
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                TermList = Db.TermRep.GetAllRecords() as List<Term>;
                CbTerm.DataSource = TermList;
                CbTerm.DisplayMember = "Term_Name";
                CbTerm.ValueMember = "Term_ID";
            }
            DayList = Days.GetDaysWeek();
            int termid = (int)CbTerm.SelectedValue;
            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                MaterialListBoxItem[] ListCourseTimeBoxItems;
                ListCoursesTimes = Db.CoursesTimeRep.GetAllRecords() as List<CoursesTime>;
                ListCourseTimeBoxItems = ListCoursesTimes.Select(CT => new MaterialListBoxItem()
                {
                    Text = $"{CT.Courses.Course_Name} با  {CT.Teacher.Teacher_FirstName} {CT.Teacher.Teacher_LastName}",
                    SecondaryText = $"روز {DayList.Where(D => D.Id == CT.CourseDay).Select(D => D.DayName).FirstOrDefault()}  از ساعت {CT.Start_Hour} تا ساعت {CT.End_Hour}",
                    Tag = CT.CourseTime_ID.ToString()
                }).ToArray();
                ListBox.AddItems(ListCourseTimeBoxItems);
            }
        }

        private async void UpdateData()
        {
            ListBox.Clear();
            ListBox.Refresh();
            MaterialListBoxItem[] ListCourseTimeBoxItems;

            using (UniversityAppData.DbContext.UnitOfWork Db = new UniversityAppData.DbContext.UnitOfWork())
            {
                ListCoursesTimes = Db.CoursesTimeRep.GetAllRecordsBy((int)CbTerm.SelectedValue) as List<CoursesTime>;
                ListCourseTimeBoxItems = ListCoursesTimes.Select(CT => new MaterialListBoxItem()
                {
                    Text = $"{CT.Courses.Course_Name} با  {CT.Teacher.Teacher_FirstName} {CT.Teacher.Teacher_LastName}",
                    SecondaryText = $"روز {DayList.Where(D => D.Id == CT.CourseDay).Select(D => D.DayName).FirstOrDefault()}  از ساعت {CT.Start_Hour} تا ساعت {CT.End_Hour}",
                    Tag = CT.CourseTime_ID.ToString()
                }).ToArray();
            }
            ListBox.AddItems(ListCourseTimeBoxItems);
        }

        public MainForm()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Grey900, Primary.Grey200, Accent.DeepPurple700, TextShade.WHITE);
        }

        private async void BtnTeacher_Click(object sender, System.EventArgs e)
        {
            TeacherForm TeacherFrm = new TeacherForm();
            TeacherFrm.ShowDialog();
        }

        private async void BtnCourses_Click(object sender, System.EventArgs e)
        {
            CourseForm CourseFrm = new CourseForm();
            CourseFrm.ShowDialog();
        }

        private async void BtnMajor_Click(object sender, System.EventArgs e)
        {
            MajorsForm MajorFrm = new MajorsForm();
            MajorFrm.ShowDialog();
        }

        private async void BtnLevel_Click(object sender, System.EventArgs e)
        {
            LevelForm LevelFrm = new LevelForm();
            LevelFrm.ShowDialog();
        }

        private async void BtnGroup_Click(object sender, System.EventArgs e)
        {
            GroupForm GroupFrm = new GroupForm();
            GroupFrm.ShowDialog();
        }

        private async void BtnDegree_Click(object sender, System.EventArgs e)
        {
            DegreeForm DegreeFrm = new DegreeForm();
            DegreeFrm.ShowDialog();
        }

        private async void BtnTerm_Click(object sender, System.EventArgs e)
        {
            TermForm TermFrm = new TermForm();
            TermFrm.ShowDialog();
        }

        private  async void BtnCourseTime_Click(object sender, System.EventArgs e)
        {
            CoursesTimeForm CourseTimeFrm = new CoursesTimeForm();
            CourseTimeFrm.ShowDialog();
        }

        private async void MainTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (MainTabControl.SelectedIndex == 1)
            {
                InitializeData();
                UpdateData();
            }
        }

        private async void CbTerm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void ListBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            DoIdentifyList();
        }

        //private void DoCourseSelect()
        //{
        //    foreach (MaterialSkin.Controls.MaterialExpansionPanel item in panel4.Controls)
        //    {
        //        if (item is MaterialExpansionPanel)
        //        {
        //            if (item.Collapse == false)
        //            {
        //                if (item.Controls[0] is MaterialListBoxItem)
        //                {
        //                    nameof(item.Controls[0].c)
        //                }
        //            }
        //        }
        //    }
        //}

        private async void DoIdentifyList()
        {
            int flag = 0;
            foreach (MaterialSkin.Controls.MaterialExpansionPanel item in panel4.Controls)
            {
                if (item is MaterialExpansionPanel)
                {
                    flag++;
                    if (item.Collapse == false)
                    {
                        DoCourseSelect(flag);
                        break;
                    }
                }
            }
        }

        private void DoCourseSelect(int Flag)
        {
            switch (Flag)
            {
                case 1:
                    MlbFour.AddItem(ListBox.SelectedItem);
                    CoursesToPdf.Add(ListCoursesTimes.Where(x => x.CourseTime_ID == int.Parse(ListBox.SelectedValue.ToString())).FirstOrDefault());
                    ListBox.RemoveItem(ListBox.SelectedItem);
                    break;

                case 2:
                    MlbThree.AddItem(ListBox.SelectedItem);
                    CoursesToPdf.Add(ListCoursesTimes.Where(x => x.CourseTime_ID == int.Parse(ListBox.SelectedValue.ToString())).FirstOrDefault());
                    ListBox.RemoveItem(ListBox.SelectedItem);
                    break;

                case 3:
                    MlbTwo.AddItem(ListBox.SelectedItem);
                    CoursesToPdf.Add(ListCoursesTimes.Where(x => x.CourseTime_ID == int.Parse(ListBox.SelectedValue.ToString())).FirstOrDefault());
                    ListBox.RemoveItem(ListBox.SelectedItem);
                    break;

                case 4:
                    MlbOne.AddItem(ListBox.SelectedItem);
                    CoursesToPdf.Add(ListCoursesTimes.Where(x => x.CourseTime_ID == int.Parse(ListBox.SelectedItem.Tag.ToString())).FirstOrDefault());
                    ListBox.RemoveItem(ListBox.SelectedItem);
                    break;

                default:
                    break;
            }
        }

        private async void OutputPdf_ClickAsync(object sender, EventArgs e)
        {
            PdfBuilder Pdf = new PdfBuilder();

            PrintResults(await Pdf.InitializeAsync(CoursesToPdf));
        }

        private async void PrintResults(DataTable Dt)
        {
            stiReport1.Load("Report.mrt");
            stiReport1.RegData("Dt", Dt);
            var s = stiReport1.GetComponentByName("ReportTitleText");
            //(stiReport1.GetComponentByName("ReportTitleText") as StiText).Text = "هفته اول";
            stiReport1.Render(false);
            stiReport1.ExportDocument(Stimulsoft.Report.StiExportFormat.Pdf, "CoursesList.pdf");
            System.Diagnostics.Process.Start("CoursesList.pdf");
        }
    }
}