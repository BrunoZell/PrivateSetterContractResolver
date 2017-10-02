using System.Reflection;

namespace Newtonsoft.Json.Serialization {
    /// <summary>
    /// Value provider for reflected fields
    /// </summary>
    class FieldValueProvider : IValueProvider {
        private readonly FieldInfo _fieldInfo;

        public FieldValueProvider(FieldInfo fieldInfo) {
            _fieldInfo = fieldInfo;
        }

        public object GetValue(object target) {
            return _fieldInfo.GetValue(target);
        }

        public void SetValue(object target, object value) {
            _fieldInfo.SetValue(target, value);
        }
    }
}
