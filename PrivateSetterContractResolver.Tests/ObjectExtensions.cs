using System.Linq;
using System.Reflection;

namespace PrivateSetterContractResolver.Tests {
    internal static class ObjectExtensions {
        public static T GetPropertyValue<T>(this object obj, string name) {
            var property = obj.GetType().GetAllPropertiesRecursive().FirstOrDefault(p => p.Name == name);
            if (property.CanRead) {
                return (T)property.GetValue(obj);
            }

            var backingField = obj.GetType().GetField($"<{property.Name}>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance);
            return (T)backingField.GetValue(obj);
        }

        public static T GetFieldValue<T>(this object obj, string name) {
            var field = obj.GetType().GetField(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            return (T)field.GetValue(obj);
        }
    }
}
