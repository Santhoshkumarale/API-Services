using System;
using System.Collections.Generic;

#nullable disable

namespace Angular.Repository.Models
{
    public partial class ImageDatum
    {
        public int Id { get; set; }
        public int? Imagedata { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
