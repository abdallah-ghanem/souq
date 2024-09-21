using System;
using System.Collections.Generic;

namespace souq.Models
{
    public partial class Card
    {
        public int Id { get; set; }
        public string? Userid { get; set; }
        public int? Product { get; set; }
        public int? Qty { get; set; }

        public virtual Product? ProductNavigation { get; set; }
    }
}
