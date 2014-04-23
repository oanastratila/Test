using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomCity : NomenclatureBaseName
    {
        public int CityTypeId { get; set; }
        public NomCityType CityType { get; set; }
        public int  DistricdId { get; set; }
        public NomDistrict District { get; set; }
    }

}
