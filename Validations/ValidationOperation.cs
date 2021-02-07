using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStock.Validations
{
    static class ValidationOperation<T>
    {
        //The function in order to show validation messages
        public static bool ValidateOperation(T item)
        {
            ValidationContext context = new ValidationContext(item);
            List<ValidationResult> errors = new List<ValidationResult>();

            //Checking if there is any validation error
            if (!Validator.TryValidateObject(item, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    MessageBox.Show(result.ErrorMessage);
                    return false;
                }
            }
            return true;
        }
    }
}
