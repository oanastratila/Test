using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomDrug : TemporalNomBaseName
    {
        public string PresentationMode { get; set; }
        public short IsNarcotic { get; set; }
        public bool IsFractional { get; set; }
        public bool IsSpecial { get; set; }
        public bool IsBrand { get; set; }
        public bool HasBioEchiv { get; set; }
        public int QtyPerPackage { get; set; }
        public float PricePerPackage { get; set; }
        public float WholeSalePricePerPackage { get; set; }
        public string PrescriptionMode { get; set; }

        public NomActiveSubstance ActiveSubstance { get; set; }

        public int ConcentrationId { get; set; }
        public int PharmaceuticalFormId { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string Atc { get; set; }

        public virtual NomPharmaceuticalForm PharmaceuticalForm { get; set; }
        public virtual NomConcentration Concentration { get; set; }

        public virtual ICollection<NomCopaymentListDrug> Drug { get; set; }

    }
}


