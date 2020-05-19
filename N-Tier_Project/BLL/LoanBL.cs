using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;
using Type;

namespace BLL
{
    public class LoanBL
    {
        public Student s;
        public Resource r;
        public List<ValidationError> Errors = new List<ValidationError>();
        public LoanBL(Student st, Resource re)
        {
            if (st == null)
            {
                Errors.Add(new ValidationError("Search Student"));
            }
            else
            {
                this.s = st;
            }
            if(re == null)
            {
                Errors.Add(new ValidationError("Search Resoruce"));
            }
            else
            {
                this.r = re;
            }
        }
        public bool ResourceTransaction(DateTime checkoutDate, DateTime dueDate)
        {
            LoanRepo repo = new LoanRepo();

            Validation();
            if (Errors.Count == 0)
            {
                return repo.Transaction(s.StudentId, r.ResourceId, checkoutDate, dueDate);
            }

            return false;
        }

        public void Validation()
        {
            if (r != null && s != null)
            {
                Check_ResourceStatus();
                Check_Reservation();
                Check_Active();
                Check_balance(s.BalanceDue);
                Check_SameType(s.StudentId, (int)r.ResourceType);
            }
        }

        private bool Check_ResourceStatus()
        {
            if (r.ResourceStatus != 0)
            {
                Errors.Add(new ValidationError("Please Check this resource status"));
                return false;
            }
            return true;
        }
        private bool Check_SameType(string studendId, int resourceType)
        {
            LoanRepo repo = new LoanRepo();
            if (repo.Check_SameType(studendId, resourceType) > 0)
            {
                Errors.Add(new ValidationError("This Student has already borrowed same type item in the loan "));
                return false;
            }
        
            return true;
        }
        private bool Check_balance(decimal balance)
        {
            if ( balance != 0)
            {
                Errors.Add(new ValidationError("This Student has overdue balance"));
                return false;
            }
            return true;
        }
        private bool Check_Active()
        {
            if (s.IsActive == false)
            {
                Errors.Add(new ValidationError("This Student cannot borrow items becuase it is inactive"));
                return false;
            }
            return true;
        }
        private bool Check_Reservation()
        {
            if (r.IsReserved == true && (int)r.ResourceStatus==0)
            {
                LoanRepo repo = new LoanRepo();
                if (s==null||!repo.Check_Reservation(s.StudentId, r.ResourceId))
                {
                    Errors.Add(new ValidationError("This is not the student who has reserved this item"));
                    return false;
                }
            }
            return true;
        }
    }
}
