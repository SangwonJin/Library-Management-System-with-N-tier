using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Model
{
    public class StudentIDAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var startdate = Convert.ToDateTime(validationContext.ObjectInstance.GetType().GetProperty("StartDate"));
            Match m = Regex.Match(value.ToString(), $"{startdate.Year}[0-9][0-9][0-9][0-9]");
            if (m.Success)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Please enter a valid Student ID.");
        }
    }
    internal class StatusAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Byte.TryParse(value.ToString(), out byte result))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Please enter a valid Status.");
        }
    }
    internal class ResourceAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Match m = Regex.Match(value.ToString(), "[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]");
            if (m.Success)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Please enter a valid Resource ID.");
        }
    }
}

