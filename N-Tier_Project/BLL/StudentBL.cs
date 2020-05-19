using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class StudentBL
    {
        Student s;
        public List<ValidationError> Errors = new List<ValidationError>();
        public Student GetStudent(string id)
        {
            StudentRepo repo = new StudentRepo();
            s = repo.RetrieveById(id);
           
            return s;
        }
        public bool Delete_Student(string studentid)
        {
            StudentRepo repo = new StudentRepo();
            Validation(studentid);
            if (Errors.Count == 0)
            {
                return repo.DeleteStudent(studentid);
            }
            return false;
         
        }

        public bool InsetStudent(Student s)
        {
            StudentRepo repo = new StudentRepo();
            if (Check_StudendId(s.StudentId) && IsValidEntity(s))
            {
                return repo.InsertStudent(s);
            }
            return false;
        }
        public bool UpdateStudent(Student s)
        {
            StudentRepo repo = new StudentRepo();
            if (IsValidEntity(s))
            {
                return repo.UpdateStudent(s);
            }
            return false;
            
      
        }
        private bool IsValidEntity(Student s)
        {
            ValidationContext context = new ValidationContext(s);
            List<ValidationResult> results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(s, context, results, true);

            foreach (ValidationResult r in results)
            {
                Errors.Add(new ValidationError(r.ErrorMessage));
            }

            return isValid;
        }
        public void Validation(string studentid)
        {
            Check_loan(studentid);
            Check_ReservedItem(studentid);
            //Check_Balance(studentid);
        }

        private bool Check_StudendId(string keyword)
        {
            if (int.TryParse(keyword, out int i))
            {
                string startdate = DateTime.Now.Year.ToString();
                if (keyword.Substring(0, 4) != startdate)
                {
                    Errors.Add(new ValidationError("ID should start with this year(hint: put this year, " + startdate + ")"));
                    return false;
                }
                Match m = Regex.Match(i.ToString(), $"{startdate}[0-9][0-9][0-9][0-9]");
                if (!m.Success)
                {
                    Errors.Add(new ValidationError("Invalid StudendId (hint: "+startdate+"1234)"));
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        private bool Check_loan(string studentid)
        {
            StudentRepo studentRepo = new StudentRepo();
            if (studentRepo.Check_loan(studentid))
            {
                Errors.Add(new ValidationError("This Student has loan records"));
                return false;
            }
            return true;

        }

        //Not used
        //private bool Check_Balance(string studentid)
        //{
        //    StudentRepo studentRepo = new StudentRepo();
        //    decimal balance = studentRepo.Check_Balance(studentid);
        //    if (balance > 0)
        //    {
        //        Errors.Add(new ValidationError("This Student has balance due "+ balance.ToString("c")));
        //        return false;
        //    }
        //    return true;

        //}
        private bool Check_ReservedItem(string studentid)
        {
            StudentRepo studentRepo = new StudentRepo();
            if (studentRepo.Check_ReservedItem(studentid))
            {
                Errors.Add(new ValidationError("This Student has reserved item"));
                return false;
            }
            return true;
        }
    }
}
