using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomChronicDisease:TemporalNomBaseDescription
    {
        public string Category { get; set; }
        public int OrderNo { get; set; }
        public virtual ICollection<NomDiseaseCategory> DiseaseCategory { get; set; }
    }
}
