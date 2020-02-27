using System;
using System.Collections.Generic;

namespace SugarBItApplication2.Models
{
    public partial class Companys
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifedDate { get; set; }
    }
}
