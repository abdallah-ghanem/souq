using System;
using System.Collections.Generic;

namespace souq.Models
{
    public partial class CatId
    {
        public CatId()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Photo { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
