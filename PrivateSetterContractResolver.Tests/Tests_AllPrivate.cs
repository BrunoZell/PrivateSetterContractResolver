using Newtonsoft.Json;
using PrivateSetterContractResolver.Tests.Models;
using Xunit;

namespace PrivateSetterContractResolver.Tests
{
    public class Tests_AllPrivate : Tests
    {
        [Fact]
        public void Serialization()
        {
            var model = new AllPrivate(1, "Text");

            string serialized = JsonConvert.SerializeObject(model, Settings);

            Assert.NotNull(serialized);
            Assert.Equal(@"{""number"":1,""string"":""Text""}", serialized);
        }

        [Fact]
        public void Deserialization()
        {
            const string serialized = @"{""number"":1,""string"":""Text""}";

            var model = JsonConvert.DeserializeObject<AllPrivate>(serialized, Settings);

            Assert.NotNull(model);
            Assert.Equal(1, model.GetPropertyValue<int>("Number"));
            Assert.Equal("Text", model.GetPropertyValue<string>("String"));
        }
    }
}
