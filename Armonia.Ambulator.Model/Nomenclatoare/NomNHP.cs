using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
   public class NomNHP:TemporalNomBaseDescription
    {
        public bool hasAmbulatoryBudget { get; set; }
        public bool hasHospitalBudget { get; set; }//hasHospitalBudget="0"

        public virtual NomCopaymentListDrug CopaymentDrug { get; set; }
    }
}
