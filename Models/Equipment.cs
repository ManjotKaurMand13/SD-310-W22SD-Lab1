using System;
using System.Collections.Generic;

namespace Renting_Company.Models
{
    public partial class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
