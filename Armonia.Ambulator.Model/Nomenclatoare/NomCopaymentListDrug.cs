using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
   public class NomCopaymentListDrug:IdEntity
    {
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public virtual NomCopaymentListType CopaymentListType { get; set; }

        public virtual ICollection<NomDrug> Drugs { get; set; }

        public int DiseaseCategoryId { get; set; }
        public virtual ICollection<NomDiseaseCategory> DiseaseCategories { get; set; }

        public virtual ICollection<NomNHP> NhpCode { get; set; }

        public float MaxPrice { get; set; }
        public float MaxPriceUt { get; set; }
        public float CopaymentValue { get; set; }
        public float CopaymentValue90 { get; set; }
        public float WholeSalePrice { get; set; }
        public float ReferencePrice { get; set; }
        public bool SpecialLaw { get; set; }
        public string NeedApproval { get; set; }
        public string OverValue { get; set; }
        public string NeedSpecialty { get; set; }
        public string ClassIfInsulin { get; set; }
        public string HgDci { get; set; }
       public virtual ICollection<NomATC> HgAtc { get; set; }
         }
}
