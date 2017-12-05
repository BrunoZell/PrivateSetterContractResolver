using Newtonsoft.Json;
using PrivateSetterContractResolver.Tests.Models;
using Xunit;

namespace PrivateSetterContractResolver.Tests
{
    public class Tests_AllPublic : Tests
    {
        [Fact]
        public void Serialization()
        {
            var model = new AllPublic() {
                Number = 1,
                String = "Text"
            };

            string serialized = JsonConvert.SerializeObject(model, Settings);

            Assert.NotNull(serialized);
            Assert.Equal(@"{""number"":1,""string"":""Text""}", serialized);
        }

        [Fact]
        public void Deserialization()
        {
            const string serialized = @"{""number"":1,""string"":""Text""}";

            var model = JsonConvert.DeserializeObject<AllPublic>(serialized, Settings);

            Assert.NotNull(model);
            Assert.Equal(1, model.Number);
            Assert.Equal("Text", model.String);
        }
    }
}
