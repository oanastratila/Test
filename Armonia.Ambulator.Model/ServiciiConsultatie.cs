using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Armonia.Ambulator.Model.Nomenclatoare;

namespace Armonia.Ambulator.Model
{
    public class ServiciiConsultatie
    {
        public NomClinicServices Serviciu { get; set; }
        public NomTipServiciu TipServiciu { get; set; }
        public int Cantitate { get; set; }
        public string CnpConex { get; set; }
        public NomSpecialities Specialitate { get; set; }

    }
}
