using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomSpecialities:TemporalNomBaseName
    {

        public virtual ICollection<NomClinSrvGrpSpecialties> ClinSrvGroups { get; set; }
    }
}
