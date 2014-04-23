using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomCountry : NomenclatureBaseName
    {
        public virtual ICollection<NomDistrict> District { get; set; }
        public virtual ICollection<NomCnasAgreement> CnasAgreement { get; set; }
    }
}
