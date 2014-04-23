using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Armonia.Ambulator.Model.Nomenclatoare;

namespace Armonia.Ambulator.Model
{
    public class Consultatie
    {
        public DateTime Data { get; set; }
        public DateTime Ora { get; set; }
        public DateTime Sfarsit { get; set; }
        public Contract Contract { get; set; }
        public NomTipPacient TipPacient { get; set; }
        public NomMedSrvPack PachetMedical { get; set; }
        public NomInsuranceHouse CasaAsigurari { get; set; }
        public NomNivelUrgenta NivelUrgenta { get; set; }
        public NomModPrezentare ModPrezentare { get; set; }
        public NomPersonStates Categorie { get; set; }
        public NomStatusProgramare Status { get; set; }

        public int NumarRC { get; set; }
        public NomICD10 Diagnostic { get; set; }
        public DateTime DataConsultatie { get; set; }
        public NomTipDiagnostic TipDiagnostic { get; set; }

        public ICollection<DiagnosticSecundar> DiagnosticSecundar { get; set; }

        public NomSpecialities Specialitate { get; set; }

        public double Valoare { get; set; }
        public string Serie { get; set; }
        public string Numar { get; set; }

        public string Observatii { get; set; }
        public string Concluzii { get; set; }


        public Utilizator Utilizator { get; set; }

        public virtual Pacient Pacient { get; set; }
        public ICollection<CadruMedical> CadruMedical { get; set; }
    }
}
