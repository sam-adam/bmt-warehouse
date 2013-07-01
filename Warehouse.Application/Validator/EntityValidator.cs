namespace Warehouse.Application.Validator
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public class EntityValidator : BaseValidator
    {
        private readonly PropertyValidator _propertyValidator;

        public EntityValidator(PropertyValidator propertyValidator)
        {
            _propertyValidator = propertyValidator;
        }

        public override IList<ValidationResult> Validate(object o)
        {
            var validationResult = new List<ValidationResult>();
            var context = new ValidationContext(o, null, null);

            Validator.TryValidateObject(o, context, validationResult);

            return validationResult;
        }
    }
}
