﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.DTO
{
    public class CidadeDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
