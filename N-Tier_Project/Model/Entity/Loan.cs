using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type;
namespace Model
{
    public class Loan
    {

        public int LoanId { get; set; }

        public string StudentId { get; set; }


        public int ResourceId { get; set; }

        public DateTime CheckOutDate { get; set; }
        public DateTime DueDate {

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
        public DateTime DateReturned { get; set; }
        public decimal OverDueCharge { get; set; }
        public decimal NonReturnCharge { get; set; }

        public LoanStatus LoanStatus { get; set; }
    }
}
