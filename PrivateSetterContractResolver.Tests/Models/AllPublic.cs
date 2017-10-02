using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSetterContractResolver.Tests.Models {
    public class AllPublic {
        public AllPublic() {

        }

        public int Number { get; set; }
        public string String { get; set; }
    }
}
