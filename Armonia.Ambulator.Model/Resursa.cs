using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model
{
   public class Resursa
    {
        //public ICollection<CadruMedical> Medici { get; set; }
        public ICollection<Consultatie> Consultatii { get; set; }
        public virtual Departamente Departament { get; set; }
        public virtual Enums.TipResursa TipResursa { get; set; }


    }
}
