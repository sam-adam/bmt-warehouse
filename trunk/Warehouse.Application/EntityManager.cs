namespace Warehouse.Application
{
    using System.Collections.Generic;
    using Warehouse.Application.Common;
    using Warehouse.Application.Validator;

    public class EntityManager : ObjectManager
    {
        private readonly EntityValidator _entityValidator;

        public EntityManager(EntityValidator entityValidator)
        {
            _entityValidator = entityValidator;
        }

        public IList<string> Validate(object o)
        {
            var validationErrorMessage = new List<string>();

            var validationResult = _entityValidator.Validate(o);

            foreach (var result in validationResult)
            {
                validationErrorMessage.Add(result.ErrorMessage);    
            }

            return validationErrorMessage;
        }
    }
}
