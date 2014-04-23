using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomActiveSubstance : IdEntity
    {
        public virtual ICollection<NomCopaymentListDrug> HgDci { get; set; }

        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

        //[ForeignKey("Atc")]
        //public int CodeId { get; set; }
        public virtual NomATC Atc { get; set; }

        public virtual ICollection<NomDrug> Drugs { get; set; }
    }
}
