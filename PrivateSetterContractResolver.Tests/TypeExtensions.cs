using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PrivateSetterContractResolver.Tests
{
    static class TypeExtensions
    {
        public static IEnumerable<PropertyInfo> GetAllPropertiesRecursive(this Type type)
        {
            if (type == null) {
                return Enumerable.Empty<PropertyInfo>();
            }

            var flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly;
            return type.GetProperties(flags).Concat(GetAllPropertiesRecursive(type.BaseType));
        }
    }
}
