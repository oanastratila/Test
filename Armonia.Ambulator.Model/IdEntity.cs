using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model
{
    public class IdEntity
    {
          [Key]
          public int id  { get; set; }
    }
}
