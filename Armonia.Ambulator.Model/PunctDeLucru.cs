using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model
{
    public class PunctDeLucru
    {
        public ICollection<PunctDeLucru> Departamente { get; set; }

        //public ICollection<Contract> contract { get; set; }

        public virtual UnitateMedicala UnitateMedicala { get; set; }
    }
}
