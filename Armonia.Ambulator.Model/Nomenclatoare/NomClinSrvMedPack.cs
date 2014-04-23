using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomClinSrvMedPack: IdEntity
    {
        public int MedSrvPackId { get; set; }
        public virtual NomMedSrvPack MedSrvPack { get; set; }


        public int ClinicServiceId { get; set; }
        public virtual NomClinicServices ClinicServices { get; set; }

        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int Point { get; set; }
        public int PointsSrg { get; set; }
        public int ValueLei { get; set; }

    }
}
