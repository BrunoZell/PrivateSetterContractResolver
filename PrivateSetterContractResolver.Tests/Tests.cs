using Newtonsoft.Json;

namespace PrivateSetterContractResolver.Tests
{
    public abstract class Tests
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings() {
            ContractResolver = new Newtonsoft.Json.Serialization.PrivateSetterContractResolver()
        };
    }
}
