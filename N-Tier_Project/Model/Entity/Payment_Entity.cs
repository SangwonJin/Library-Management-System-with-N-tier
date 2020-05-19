using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Payment_Entity
    {

        public int PaymentId { get; set; }
        [Required(ErrorMessage = "StudentId is Required")]
        [StringLength(8, ErrorMessage = "Student Id cannot exceed 8 digits")]
        public string StudentId { get; set; }
        [Required(ErrorMessage = "AmountOfPayment is required")]
        public decimal AmountOfPayment { get; set; }
        [Required(ErrorMessage = "Payment Date is required")]
        public DateTime Date { get; set; }
    }
}
