using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomPharmaceuticalForm:IdEntity
    {
        public virtual ICollection<NomDrug> Drugs { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string Code { get; set; }

    }
}
