﻿using System;
using System.Collections.Generic;

namespace souq.Models
{
    public partial class Rewiew
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }
        public string? Subject { get; set; }
    }
}
