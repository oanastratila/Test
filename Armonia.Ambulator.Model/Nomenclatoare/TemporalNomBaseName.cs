﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armonia.Ambulator.Model.Nomenclatoare
{
    public class TemporalNomBaseName : NomenclatureBaseName
    {
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

    }
}