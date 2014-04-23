using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
   public class NomSickLeaveIndemnizationsGroup:TemporalNomBaseDescription
    {
        public virtual ICollection<NomSickLeaveIndemnization> SickLeaveIndemnizations { get; set; }
    }
}
