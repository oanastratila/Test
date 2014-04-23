using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomCopaymentListTypePersState : IdEntity
    {
        public string PersonState { get; set; }
        public int Percent { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }


        public virtual ICollection<NomCopaymentListType> CopaymentType { get; set; }
    }

}
