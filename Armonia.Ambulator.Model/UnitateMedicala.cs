using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model
{
    public class UnitateMedicala
    {
        public ICollection<PunctDeLucru> PunctLucru { get; set; }

        public ICollection<Contract> Contracte { get; set; }
    }
}
