using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSetterContractResolver.Tests.Models {
    public class AllSetterOnly {
        public AllSetterOnly() {

        }

        private int _number;
        public int Number {
            set {
                _number = value;
            }
        }

        private string _string;
        public string String {
            set {
                _string = value;
            }
        }
    }
}
