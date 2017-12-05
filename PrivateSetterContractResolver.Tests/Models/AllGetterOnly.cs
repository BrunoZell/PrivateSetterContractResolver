namespace PrivateSetterContractResolver.Tests.Models
{
    public class AllGetterOnly
    {
        public AllGetterOnly()
        {

        }

        public AllGetterOnly(int number, string @string)
        {
            Number = number;
            String = @string;
        }

        public int Number { get; }
        public string String { get; }
    }
}
