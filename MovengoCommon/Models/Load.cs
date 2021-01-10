using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace MovengoCommon.Models
{
    public class Load
    {
        public int Id { get; set; }
        
        public Customer Customer { get; set; }
       
        //public IEnumerable<Cart> Cart { get; set; }

    }
}
