using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
   public class NomStreet:NomenclatureBaseName
    {
       [ForeignKey("City")]
        public int CityId { get; set; } 
        public virtual  NomStreetType StreetType { get; set; }
       [ForeignKey("StreetType")]
        public int StreetTypeId { get; set; }
        public virtual NomCity City { get; set; }
    }
}
