using System;
using System.Collections.Generic;

namespace Renting_Company.Models
{
    public partial class Rental
    {
        public int CustmoerId { get; set; }
        public int EquipmentId { get; set; }
        public int RentalHours { get; set; }
        public bool IsCurrent { get; set; }
        public int Id { get; set; }
    }
}
