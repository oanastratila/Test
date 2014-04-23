using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    class NomLaboratoriesService:TemporalNomBaseName
    {
        public bool highLevel { get; set; }
        public bool recByPC { get; set; }
        public bool formula { get; set; }
        public bool inClinic { get; set; }
        public short serviceType { get; set; }

    }
}
