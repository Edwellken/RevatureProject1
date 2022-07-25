using System;
using System.Collections.Generic;

namespace FIFAPI.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; } = null!;
        public string? PlayerPosition { get; set; }
        public int? PlayerTeamId { get; set; }
    }
}
