using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSetterContractResolver.Tests.Models {
    public class AllGetterOnly {
        public AllGetterOnly() {

        }

        public AllGetterOnly(int number, string @string) {
            Number = number;
            String = @string;
        }

        public int Number { get; }
        public string String { get; }
    }
}
