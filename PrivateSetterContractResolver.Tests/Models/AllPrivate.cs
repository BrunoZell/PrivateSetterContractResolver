namespace PrivateSetterContractResolver.Tests.Models {
    public class AllPrivate {
        public AllPrivate() {

        }

        public AllPrivate(int number, string @string) {
            Number = number;
            String = @string;
        }

        private int Number { get; set; }
        private string String { get; set; }
    }
}
