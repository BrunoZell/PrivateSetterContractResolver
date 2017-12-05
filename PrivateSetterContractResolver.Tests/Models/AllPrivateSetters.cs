namespace PrivateSetterContractResolver.Tests.Models
{
    public class AllPrivateSetters
    {
        public AllPrivateSetters()
        {

        }

        public AllPrivateSetters(int number, string @string)
        {
            Number = number;
            String = @string;
        }

        public int Number { get; private set; }
        public string String { get; private set; }
    }
}
