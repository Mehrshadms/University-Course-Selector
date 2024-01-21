using System.Collections.Generic;
using UniversityAppData.Model;

namespace UniversityAppData.Utility
{
    static public class Days
    {
        public static IReadOnlyList<DaysOfWeek> GetDaysWeek()
        {
            return new List<DaysOfWeek>
            {
                new DaysOfWeek
                {
                    Id= 0,
                    DayName="شنبه"
                },
                new DaysOfWeek
                {
                    Id= 1,
                    DayName="یکشنبه"
                },
                new DaysOfWeek
                {
                    Id= 2,
                    DayName="دوشنبه"
                },
                new DaysOfWeek
                {
                    Id= 3,
                    DayName="سه شنبه"
                },
                new DaysOfWeek
                {
                    Id= 4,
                    DayName="چهار شنبه"
                },
                new DaysOfWeek
                {
                    Id= 5,
                    DayName="پنج شنبه"
                }
            };
        }
    }
}