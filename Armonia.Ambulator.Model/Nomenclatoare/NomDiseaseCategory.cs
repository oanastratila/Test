using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
   public  class NomDiseaseCategory:TemporalNomBaseDescription
    {
        public bool IsChronicDisease { get; set; }
        public bool IsAuctioned { get; set; }

        public virtual NomCopaymentListDrug DiseaseCode { get; set; }

    }
}
