using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoduriNomenclatoare
{
    public class NomClinSrvMedPacks: IdEntity
    {
        public int MedSrvPackId { get; set; }
        public virtual NomMedSrvPacks MedSrvPack { get; set; }


        public int ClinicServiceId { get; set; }
        public virtual NomClinicServices ClinicServices { get; set; }

        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int Point { get; set; }
        public int PointsSrg { get; set; }
        public int ValueLei { get; set; }

    }
}
