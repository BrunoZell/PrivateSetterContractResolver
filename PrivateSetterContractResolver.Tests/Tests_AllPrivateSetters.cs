using Newtonsoft.Json;
using PrivateSetterContractResolver.Tests.Models;
using Xunit;

namespace PrivateSetterContractResolver.Tests {
    public class Tests_AllPrivateSetters : Tests {
        [Fact]
        public void Serialization() {
            var model = new AllPrivateSetters(1, "Text");

            string serialized = JsonConvert.SerializeObject(model, Settings);

            Assert.NotNull(serialized);
            Assert.Equal(@"{""number"":1,""string"":""Text""}", serialized);
        }

        [Fact]
        public void Deserialization() {
            const string serialized = @"{""number"":1,""string"":""Text""}";

            var model = JsonConvert.DeserializeObject<AllPrivateSetters>(serialized, Settings);

            Assert.NotNull(model);
            Assert.Equal(1, model.Number);
            Assert.Equal("Text", model.String);
        }
    }
}
