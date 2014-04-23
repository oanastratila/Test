using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
   public class NomCityType:NomenclatureBaseName
    {
        public virtual ICollection<NomCity> City { get; set; }
    }
}
