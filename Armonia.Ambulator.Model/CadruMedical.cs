using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model
{
    public class CadruMedical
    {
        public virtual ICollection<OrarMedic> Orar { get; set; }
        public virtual ICollection <Nomenclatoare.NomSpecialities> Specialities { get; set; }
        public virtual Enums.TipCadru TipCadru { get; set; }
        public virtual Consultatie Consultatie { get; set; }
    }
}
