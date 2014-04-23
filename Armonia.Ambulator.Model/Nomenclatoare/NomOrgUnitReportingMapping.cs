using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class NomOrgUnitReportingMapping
    {
        public string orgUnitCode { get; set; }
        public string reportingCode { get; set; }
        public short appType{ get; set; }
    }
}

///clasa speciala, nu are name, code, description