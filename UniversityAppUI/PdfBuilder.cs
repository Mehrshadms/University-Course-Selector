using FastMember;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityAppData.Model;
using UniversityAppData.Utility;
using UniversityAppData.Viewmodels;

namespace UniversityAppUI
{
    public class PdfBuilder
    {
        private IReadOnlyList<DaysOfWeek> DayList = new List<DaysOfWeek>();

        public async Task<DataTable> InitializeAsync(List<CoursesTime> CtInput)
        {
            DayList = Days.GetDaysWeek();
            IEnumerable<CoursesTimeViewModel> Vm = CtInput.Select(x => new CoursesTimeViewModel()
            {
                CourseName = x.Courses.Course_Name,
                Day = DayList.Where(D => D.Id == x.CourseDay).Select(D => D.DayName).FirstOrDefault(),
                Id = x.CourseTime_ID,
                TeacherFullName = $"{x.Teacher.Teacher_FirstName}  {x.Teacher.Teacher_LastName}",
                StartHour = x.Start_Hour.ToString(),
                EndHour = x.End_Hour.ToString()
            });
            DataTable Dt = new DataTable();
            using (ObjectReader reader = ObjectReader.Create(Vm))
            {
                Dt.Load(reader);
            }
            return await Task.Run(() =>
             {
                 return Dt;
             });
        }

        //public void DoHtmlToPdf(DataTable Dt)
        //{
        //    string Html = ConvertDataTableToHTML(Dt);
        //    var Renderer = new IronPdf.ChromePdfRenderer();
        //    var pdf = Renderer.RenderHtmlAsPdf(Html);
        //    pdf.SaveAs("test.pdf");
        //}

        public string ConvertDataTableToHTML(DataTable dt)
        {
            StringBuilder html = new StringBuilder();
            string HtmlStr = "";
            //html.Append(" <html lang='en'><head> <link rel='stylesheet' href='/ lib / bootstrap/ dist / css / bootstrap.min.css'/></head>");
            html.Append(" <html lang='en'><head> <link rel='stylesheet' href='/lib/bootstrap/dist/css/bootstrap.min.css'/></head>");
            HtmlStr += "<html lang='en'><head> <link rel=\"stylesheet\" href=\"/lib/bootstrap/dist/css/bootstrap.min.css\"/></head>";

            html.Append("<table class='table table-striped table-dark'> <thead>");
            HtmlStr += "<table class=\"table table-striped table-dark\"> <thead>";
            //add header row
            html.Append("<tr>");
            HtmlStr += "<tr>";

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                html.Append($"<th scope='col'>  {dt.Columns[i].ColumnName}  </th>");
                HtmlStr += $"<th scope=\"col\">  {dt.Columns[i].ColumnName}  </th>";
            }
            html.Append("<tr>");
            HtmlStr += "<tr>";
            html.Append("<tbody>");
            HtmlStr += "<tbody>";
            //add rows
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                html.Append("<tr>");
                HtmlStr += "<tr>";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    html.Append($"<td>{dt.Rows[i][j]}</td>");
                    HtmlStr += $"<td>{dt.Rows[i][j]}</td>";
                }

                html.Append("</tr>");
                HtmlStr += "</tr>";
            }
            HtmlStr += "</tbody>";
            HtmlStr += "</table>";
            html.Append("</tbody>");
            html.Append("</table>");
            File.AppendAllText("test.html", HtmlStr);
            return HtmlStr;
        }
    }
}