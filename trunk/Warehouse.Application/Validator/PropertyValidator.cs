namespace Warehouse.Application.Validator
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public class PropertyValidator : BaseValidator
    {
        public override IList<ValidationResult> Validate(object o)
        {
            var validationResult = new List<ValidationResult>();
            var context = new ValidationContext(o, null, null);

            foreach (var propertyInfo in o.GetType().GetProperties())
            {
                Validator.TryValidateProperty(propertyInfo.GetValue(o, null), context, validationResult);    
            }

            return validationResult;
        }
    }
}
