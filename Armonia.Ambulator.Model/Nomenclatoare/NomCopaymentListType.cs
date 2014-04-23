using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomCopaymentListType : TemporalNomBaseDescription
    {
        public int CopaymentListTypesId { get; set; }
        public int Percent { get; set; }
        public int MaxValue { get; set; }
        public int DrugMaxNo { get; set; }

        public virtual NomCopaymentListTypePersState CopaymentListTypes { get; set; }

        public virtual ICollection<NomCopaymentListDrug> CopaymentListDrugs { get; set; }
    }

}
