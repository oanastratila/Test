using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomClinSrvGrpSpecialties: IdEntity
    {
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

        public int ServiceGroupId { get; set; }
        public virtual NomClinicServiceGroups ClinicServiceGroup { get; set; }

        public int SpecialtyId { get; set; }
        public virtual NomSpecialities Speciality{ get; set; }
    }
}
