using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomClinicServices:TemporalNomBaseName
    {
        public int ServiceGroupId { get; set; }
        public virtual NomClinicServiceGroups ClinicServiceGroup { get; set; }

        public bool isExam { get; set; }
        public bool opRoom { get; set; }
        public bool isConnectedService { get; set; }
    }
}
