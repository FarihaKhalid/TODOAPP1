using System;
using System.Collections.Generic;

namespace SugarBItApplication2.Models
{
    public partial class Auctions
    {
        public int AuctionId { get; set; }
        public string AuctionName { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? MinRate { get; set; }
        public int? MinQuantity { get; set; }
        public DateTime? DeadLine { get; set; }
        public DateTime? PublishDate { get; set; }
        public bool? IsEmail { get; set; }
        public bool? IsSms { get; set; }
    }
}
