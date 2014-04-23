using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomCim10s:NomenclatureBaseName
    {
        public int EntityLevel { get; set; }
        public string ParentCode { get; set; }

        public int ParentId { get; set; }
        public virtual NomCim10s Parent { get; set; }
    }
}
