using Newtonsoft.Json;
using PrivateSetterContractResolver.Tests.Models;
using System.Collections.Generic;
using Xunit;

namespace PrivateSetterContractResolver.Tests {
    public class Tests_IList : Tests {
        [Fact]
        public void Serialization() {
            var model = new PublicIList() {
                List = new List<string>() {
                    "value1",
                    "value2"
                }
            };

            string serialized = JsonConvert.SerializeObject(model, Settings);

            Assert.NotNull(serialized);
            Assert.Equal(@"{""list"":[""value1"",""value2""]}", serialized);
        }

        [Fact]
        public void Deserialization() {
            const string serialized = @"{""list"":[""value1"",""value2""]}";

            var model = JsonConvert.DeserializeObject<PublicIList>(serialized, Settings);

            Assert.NotNull(model);
            Assert.NotNull(model.List);
            Assert.True(model.List.Contains("value1"));
            Assert.True(model.List.Contains("value2"));
        }
    }
}
