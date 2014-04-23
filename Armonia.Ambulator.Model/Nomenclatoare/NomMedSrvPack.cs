using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomMedSrvPack: TemporalNomBaseName
    {
   

       // public virtual ICollection<NomLabSrvMedPack> LabSrvMedPacks { get; set; }
        public virtual ICollection<NomClinSrvMedPack> ClinSrvMedPacks { get; set; }

        

    }
}
