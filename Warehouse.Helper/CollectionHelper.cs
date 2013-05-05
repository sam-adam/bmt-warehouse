namespace Warehouse.Helper
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public static class CollectionHelper
    {
        public static bool IsEmpty<T>(IEnumerable<T> list)
        {
            if (list == null)
            {
                throw new ArgumentException("list");
            }

            var genericCollection = list as ICollection<T>;
            if (genericCollection != null)
            {
                return genericCollection.Count == 0;
            }

            var nonGenericCollection = list as ICollection;
            if (nonGenericCollection != null)
            {
                return nonGenericCollection.Count == 0;
            }

            return !list.Any();
        }
    }
}
