using System;
using System.Collections.Generic;

#nullable disable

namespace Angular.Repository.Models
{
    public partial class FileDatum
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
