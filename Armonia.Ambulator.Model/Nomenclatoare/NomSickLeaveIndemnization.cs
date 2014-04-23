using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
   public class NomSickLeaveIndemnization:TemporalNomBaseDescription
    {
        public virtual NomSickLeaveIndemnizationsGroup IndemnizationGroup { get; set; }

        public int Percent { get; set; }
        public bool isTaxable { get; set; }
        public bool mustHaveStage { get; set; }
    
    }
}
