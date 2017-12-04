using Newtonsoft.Json;
using PrivateSetterContractResolver.Tests.Models;
using System.Collections.Generic;
using Xunit;

namespace PrivateSetterContractResolver.Tests {
    public class Tests_IDictionary : Tests {
        [Fact]
        public void Serialization() {
            var model = new PublicIDictionary() {
                Dictionary = new Dictionary<string, string>() {
                    { "key1", "value1" },
                    { "key2", "value2" }
                }
            };

            string serialized = JsonConvert.SerializeObject(model, Settings);

            Assert.NotNull(serialized);
            Assert.Equal(@"{""dictionary"":{""key1"":""value1"",""key2"":""value2""}}", serialized);
        }

        [Fact]
        public void Deserialization() {
            const string serialized = @"{""dictionary"":{""key1"":""value1"",""key2"":""value2""}}";

            var model = JsonConvert.DeserializeObject<PublicIDictionary>(serialized, Settings);

            Assert.NotNull(model);
            Assert.NotNull(model.Dictionary);
            Assert.True(model.Dictionary.ContainsKey("key1"));
            Assert.True(model.Dictionary.ContainsKey("key2"));
            Assert.Equal("value1", model.Dictionary["key1"]);
            Assert.Equal("value2", model.Dictionary["key2"]);
        }
    }
}
