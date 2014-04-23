using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoduriNomenclatoare
{
    class NomLabSrvMedPacks: IdEntity
    {
        public int MedSrvPackId { get; set; }
        public virtual NomMedSrvPacks MedSrvPack { get; set; } 


        public int LaboratoriesServiceId { get; set; }
        public virtual NomLaboratoriesServices LaboratoriesService { get; set; }



    }
}
