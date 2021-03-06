﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Movengo.Common
{
    public partial class Picture
    {
        public int Id { get; set; }
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public string AltAttribute { get; set; }
        public string TitleAttribute { get; set; }
        public bool IsNew { get; set; }
        public string VirtualPath { get; set; }
        public int? ProductId { get; set; }
    }
}
