using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReturnBL
    {
        public Student s;
        public Resource r;
        public Loan l;
        public List<ValidationError> Errors = new List<ValidationError>();
        public ReturnBL(Student st, Resource re)
        {
            this.s = st;
            this.r = re;

        }
        public bool ReturnTransaction(string studentId, int resourceId, DateTime returnDate, int loanStatus)
        {
            //OverDue(loanId,studentId,resourceId,returnDate);
            LoanRepo repo = new LoanRepo();


            return repo.Return(studentId, resourceId, returnDate, loanStatus);

        }
        private void OverDueIsZero ()
        {
            LoanRepo repo = new LoanRepo();
            if (repo.CalculateDate (l.StudentId,l.ResourceId) < 0)
            {
                l.OverDueCharge = 0;
                l.NonReturnCharge = 0; 
            }
        }
        private void OverDueIsGreaterThanZero()
        {
            LoanRepo repo = new LoanRepo();
            if (repo.CalculateDate(l.StudentId, l.ResourceId) > 0 && repo.CalculateDate(l.StudentId,l.ResourceId) < 5)
            {
                l.OverDueCharge += (l.DateReturned - l.DueDate).Days * 5m;
                l.NonReturnCharge = 0;

            }
        }
        private void OverDueIsGreaterThanFive()
        {
            LoanRepo repo = new LoanRepo();
            if (repo.CalculateDate(l.StudentId, l.ResourceId) > 0 && repo.CalculateDate(l.StudentId, l.ResourceId) < 5)
            {
                l.OverDueCharge += (l.DateReturned - l.DueDate).Days * 5m;
                l.NonReturnCharge += r.PurchasePrice;
            }
        }
    }
}
