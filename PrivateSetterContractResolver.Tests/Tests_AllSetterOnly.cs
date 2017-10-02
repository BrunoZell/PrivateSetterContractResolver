using Newtonsoft.Json;
using PrivateSetterContractResolver.Tests.Models;
using Xunit;

namespace PrivateSetterContractResolver.Tests {
    public class Tests_AllSetterOnly : Tests {
        [Fact]
        public void Serialization_Default() {
            var model = new AllSetterOnly() {
                Number = 1,
                String = "Text"
            };

            string serialized = JsonConvert.SerializeObject(model, Settings);

            Assert.NotNull(serialized);
            Assert.Equal(@"{}", serialized);
        }

        [Fact]
        public void Deserialization() {
            const string serialized = @"{""number"":1,""string"":""Text""}";

            var model = JsonConvert.DeserializeObject<AllSetterOnly>(serialized, Settings);

            Assert.NotNull(model);
            Assert.Equal(1, model.GetFieldValue<int>("_number"));
            Assert.Equal("Text", model.GetFieldValue<string>("_string"));
        }
    }
}
