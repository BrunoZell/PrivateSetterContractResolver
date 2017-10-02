using Newtonsoft.Json;
using PrivateSetterContractResolver.Tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrivateSetterContractResolver.Tests
{
    public class Tests_DerivedPrivateProperties : Tests
    {
        [Fact]
        public void Serialization() {
            var model = new DerivedPrivateProperties("NotDerived", "GetterSetter", "GetterOnly");

            string serialized = JsonConvert.SerializeObject(model, Settings);

            Assert.NotNull(serialized);
            Assert.Equal(@"{""notDerived"":""NotDerived"",""getterSetter"":""GetterSetter"",""getterOnly"":""GetterOnly""}", serialized);
        }

        [Fact]
        public void Deserialization() {
            const string serialized = @"{""notDerived"":""NotDerived"",""getterSetter"":""GetterSetter"",""getterOnly"":""GetterOnly""}";

            var model = JsonConvert.DeserializeObject<DerivedPrivateProperties>(serialized, Settings);

            Assert.NotNull(model);
            Assert.Equal("NotDerived", model.GetPropertyValue<string>("NotDerived"));
            Assert.Equal("GetterSetter", model.GetPropertyValue<string>("GetterSetter"));
            Assert.Equal("GetterOnly", model.GetPropertyValue<string>("GetterOnly"));
        }
    }
}
