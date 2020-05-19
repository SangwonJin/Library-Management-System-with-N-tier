using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class PaymentBL
    {
        public List<ValidationError> Errors = new List<ValidationError>();
        public bool MakePayment(Payment_Entity p)
        {
            PaymentRepo repo = new PaymentRepo();
            if (IsValidEntity(p))
            {
                return repo.makePayment(p);
            }
            return false;
        }

        private bool IsValidEntity(Payment_Entity p)
        {
            ValidationContext context = new ValidationContext(p);
            List<ValidationResult> results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(p, context, results, true);

            foreach (ValidationResult r in results)
            {
                Errors.Add(new ValidationError(r.ErrorMessage));
            }

            return isValid;
        }
    }
 
}
