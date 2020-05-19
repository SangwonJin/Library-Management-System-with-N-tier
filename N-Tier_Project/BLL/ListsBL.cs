using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Model;
using Repository;

namespace BLL
{
    public class ListsBL
    {

        public List<ValidationError> Errors = new List<ValidationError>();
        public List<StudentLookUp> GetStudents(string keyword)
        {
            Check_StudendId(keyword);
            if (Errors.Count == 0)
            {
                ListsRepo repo = new ListsRepo();
                return repo.RetrieveStudentsList(keyword);
            }
            return null;
        }
        public List<LoanLookUp> GetLoans(string id)
        {
            ListsRepo repo = new ListsRepo();
            return repo.RetrieveLoanList(id);
        }
        private  bool Check_StudendId(string keyword)
        {
            ListsRepo repo = new ListsRepo();
            if(int.TryParse(keyword,out int i))
            {
                string startdate = repo.getStudendStartDate(i.ToString()).ToString("yyyy");
                Match m = Regex.Match(i.ToString(), $"{startdate}[0-9][0-9][0-9][0-9]");
                if (!m.Success)
                {
                    Errors.Add(new ValidationError("Invalid StudendId"));
                    return false;
                }
                return true;
            }
            return true;
        }
    }
}
