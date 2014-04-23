using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Armonia.Ambulator.Model.Nomenclatoare;

namespace Armonia.Ambulator.Model
{
    public class DiagnosticSecundar
    {
        public NomICD10 Diagnostic { get; set; }
        public NomTipDiagnostic TipDiagnostic { get; set; }
    }
}
