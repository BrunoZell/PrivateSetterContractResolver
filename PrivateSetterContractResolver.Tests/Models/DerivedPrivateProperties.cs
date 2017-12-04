namespace PrivateSetterContractResolver.Tests.Models {
    class DerivedPrivateProperties : BasePrivateProperties
    {
        public DerivedPrivateProperties(string notDerived, string getterSetter, string getterOnly)
            : base(getterSetter, getterOnly) {
            NotDerived = notDerived;
        }

        private string NotDerived { get; set; }
    }

    class BasePrivateProperties {
        public BasePrivateProperties(string getterSetter, string getterOnly) {
            GetterSetter = getterSetter;
            GetterOnly = getterOnly;
        }

        private string GetterSetter { get; set; }
        private string GetterOnly { get; }
    }
}
