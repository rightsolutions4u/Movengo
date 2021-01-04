using MovengoCommon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovengoCommon
{
    public class Customer
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        [StringLength(10)]
        public string MobileCode { get; set; }
        [StringLength(30)]
        public string MobileNumber { get; set; }
        [StringLength(30)]
        public string EmailId { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }


    }
}
