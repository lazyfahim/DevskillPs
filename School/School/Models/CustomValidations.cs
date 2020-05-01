using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace School.Models
{
    public class CustomValidations
    {
        
    }

    public class NonZeroIntiger : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var val = value.ToString();
            if (val.StartsWith('0'))
                return new ValidationResult("Number should not contain leading zero");
            else if (! Regex.Match(input: val, @"^[0-9]*$").Success)
                return new ValidationResult("Only numbers are allowed");
            else return ValidationResult.Success;
            
        }
    }

    public class NonZeroDouble : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var val = value.ToString();
            if (val.StartsWith('0'))
                return new ValidationResult("Number should not contain leading zero");
            else if (! Regex.Match(input: val, @"^[0-9,.]*$").Success)
                return new ValidationResult("Only numbers are allowed");
            else return ValidationResult.Success;
            
        }
    }
}