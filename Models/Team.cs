using System;
using System.Collections.Generic;

namespace FIFAPI.Models
{
    public partial class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; } = null!;
        public string Country { get; set; } = null!;
    }
}
