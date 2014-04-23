using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomDistrict:NomenclatureBaseName
    {
        public virtual ICollection<NomCity> Cities { get; set; }
        public int CountriesId { get; set; }
        public virtual NomCountry Countries { get; set; }
    }
}
