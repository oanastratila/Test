using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
   public class NomPersonCategories : TemporalNomBaseDescription
    {
       public int RestrictedMinAge { get; set; }
       public bool SupportsOverlapping { get; set; }
       public bool DefinedByAge { get; set; }

       public int PersonStateId { get; set;}
       public virtual NomPersonStates PersonState { get; set; }

       public int Priority { get; set; }
       public int IsOptional { get; set; } // isOptional="0"(asa arata in xml)
       public int CanBeReported { get; set; }//canBeReported="0"
       
    }
}
