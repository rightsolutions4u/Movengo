﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Movengo.Common
{
    public partial class CustomerAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int DisplayOrder { get; set; }
    }
}
