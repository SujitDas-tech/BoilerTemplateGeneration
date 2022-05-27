using System;
using System.Collections.Generic;

namespace BoilerTemplateGeneration.Models
{
    public partial class TblBoilerLookUp
    {
        public string BoilerId { get; set; } = null!;
        public string? TechName { get; set; }
        public string? TechPath { get; set; }
    }
}
