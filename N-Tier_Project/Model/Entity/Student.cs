using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type;
namespace Model
{
    public class Student
    {
        private DateTime startDate;
        private DateTime endDate;

        public string StudentId { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(30, ErrorMessage = "The first name cannot exceed 30 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(20, ErrorMessage = "Last name cannot exceed 20 characters.")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        [StringLength(30, ErrorMessage = "Address cannot exceed 30 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is Required")]
        [StringLength(20, ErrorMessage = "City cannot exceed 20 characters.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Postal code is Required")]
        [StringLength(7, ErrorMessage = "Postal code cannot exceed 7 characters.")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Phone number is Required")]
        [Display(Name = "Cell Phone Number")]
        [StringLength(12,ErrorMessage = "Phone cannot exceed 12 characters.")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
          ErrorMessage = "Please enter a valid phone number")]
        public string Telephon { get; set; }

        [Required(ErrorMessage = "Program is Required")]
        public ProgramOption Program { get; set; }

        public DateTime StartDate 
        {
            get 
            {
                return startDate;
            } 
            
            set
            {
                if (value > endDate)
                {
                    throw new ArgumentException("StartDate cannot be more than end date");
                }
                startDate = value;
            }
        
        }
   
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                if (value < startDate)
                {
                    throw new ArgumentException("End cannot be less than start date");
                }
                endDate = value;
            }
        }


        [Required(ErrorMessage = "IsActive is requried")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Balance is requried")]
        public decimal BalanceDue { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
