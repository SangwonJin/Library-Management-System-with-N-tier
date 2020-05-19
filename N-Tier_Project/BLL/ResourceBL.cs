using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;
using System.Text.RegularExpressions;

namespace BLL
{
   public  class ResourceBL
    {
    
        public List<ValidationError> Errors = new List<ValidationError>();
        public Resource GetResource(int id)
        {
            Check_ResoruceId(id);
            if (Errors.Count == 0)
            {
                ResourceRepo repo = new ResourceRepo();
                return repo.RetrieveById(id);
            }
            return null;
 
        }
        public bool InsertResource(Resource r)
        {
            ResourceRepo repo = new ResourceRepo();
            return repo.InsertResource(r);
        }

        public Resource GetResourceOnLoan(int id)
        {
            ResourceRepo repo = new ResourceRepo();
            return repo.RetrieveByIdForResourceOnLoan(id);
        }

  
        private bool Check_ResoruceId(int id)
        {
          
            Match m = Regex.Match(id.ToString(), "[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]");
            if (!m.Success)
            {
                Errors.Add(new ValidationError("Invalid ResourceId"));
                return false;
            }
            return true;
        }
        public bool changeReservation(int id, string studentId, int reserved)
        {

            ResourceRepo repo = new ResourceRepo();
            if (reserved == 0) studentId = null;
            return repo.changeReservation(id, reserved, studentId);
        }
    }
}
