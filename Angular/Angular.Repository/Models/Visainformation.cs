using System;
using System.Collections.Generic;

#nullable disable

namespace Angular.Repository.Models
{
    public partial class Visainformation
    {
        public string Date { get; set; }
        public string Visastatus { get; set; }
        public string Issuingcountry { get; set; }
        public string Issueddate { get; set; }
        public string Expirationdate { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
        public long? Employeeid { get; set; }
        public string Changereason { get; set; }
        public string Comment { get; set; }
        public string Overtime { get; set; }
        public long? Overtimerate { get; set; }
        public long? Payrate { get; set; }
        public string Payschedule { get; set; }
        public string Paytype { get; set; }
        public string Issuedate { get; set; }
    }
}
