using System;
using System.Collections.Generic;

#nullable disable

namespace Angular.Repository.Models
{
    public partial class Jobinformation
    {
        public string Jobeffectivedate { get; set; }
        public string Location { get; set; }
        public string Clientname { get; set; }
        public string Jobtitle { get; set; }
        public string Reportsto { get; set; }
        public int Id { get; set; }
        public long? Employeeid { get; set; }
    }
}
