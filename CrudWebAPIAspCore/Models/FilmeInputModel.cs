﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWebAPIAspCore.Models
{
    public class FilmeInputModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }
        public string Resumo { get; set; }
    }
}
