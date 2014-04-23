using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomClinicServiceGroups: TemporalNomBaseDescription
    {
        public virtual ICollection<NomClinSrvGrpSpecialties> ClinSrvGrpSpecialty { get; set; }

        

    }
}
