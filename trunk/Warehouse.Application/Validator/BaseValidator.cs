namespace Warehouse.Application.Validator
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public abstract class BaseValidator
    {
        public abstract IList<ValidationResult> Validate(object t);
    }
}
