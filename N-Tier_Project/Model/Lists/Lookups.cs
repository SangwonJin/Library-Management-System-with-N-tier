using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type;

namespace Model
{
    public class StudentLookUp
    {
        public string StudentId { get; set; }
        public string FullName {

            get
            {
                return FirstName + " " +LastName;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class LoanLookUp
    {
        public string StudendId { get; set; }
        public int ResourceId { get; set; }
        public string ResourceTitle { get; set; }
        public ResourceType ResoruceType { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public DateTime DueDate
        {
            get
            {
                DateTime duedate = CheckOutDate;
                switch (CheckOutDate.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                    case DayOfWeek.Monday:
                    case DayOfWeek.Tuesday:
                    case DayOfWeek.Wednesday:
                        duedate = CheckOutDate.AddDays(2);
                        break;
                    case DayOfWeek.Thursday:
                    case DayOfWeek.Friday:
                        duedate = CheckOutDate.AddDays(4);
                        break;
                    case DayOfWeek.Saturday:
                        duedate = CheckOutDate.AddDays(3);
                        break;
                }
                return duedate.Date.AddHours(8).AddMinutes(30);
            }
        }
        public LoanStatus LoanStatus { get; set; }
        public string ImageOfItem { get; set; }

    }
}
