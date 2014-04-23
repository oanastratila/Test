using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomATC : TemporalNomBaseDescription
    {
        public int DescriptionId { get; set; }
        public string ParentATC { get; set; }
    }
}
