namespace PrivateSetterContractResolver.Tests.Models {
    public class AllSetterOnly {
        public AllSetterOnly() {

        }

        private int _number;
        public int Number {
            set {
                _number = value;
            }
        }

        private string _string;
        public string String {
            set {
                _string = value;
            }
        }
    }
}
