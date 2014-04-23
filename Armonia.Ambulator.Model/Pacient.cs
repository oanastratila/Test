using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model
{
    public class Pacient
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public string CNP { get; set; }
        public DateTime dataNasterii { get; set; }
        public char sex { get; set; }

    }
}
