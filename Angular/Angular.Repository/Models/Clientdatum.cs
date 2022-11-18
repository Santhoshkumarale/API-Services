using System;
using System.Collections.Generic;

#nullable disable

namespace Angular.Repository.Models
{
    public partial class Clientdatum
    {
        public long Clientcode { get; set; }
        public string Clientname { get; set; }
        public long? Taxfederal { get; set; }
        public string Clientlocation { get; set; }
        public string Agreementstartdate { get; set; }
        public string Serviceagreementonboarded { get; set; }
        public string Agreementenddate { get; set; }
        public int Id { get; set; }
    }
}
