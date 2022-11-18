using System;
using System.Collections.Generic;

#nullable disable

namespace Angular.Repository.Models
{
    public partial class Compensation
    {
        public string Compensationeffectivedate { get; set; }
        public string Payschedule { get; set; }
        public string Paytype { get; set; }
        public string Payrate { get; set; }
        public string Overtime { get; set; }
        public string Overtimerate { get; set; }
        public string Changereason { get; set; }
        public string Comment { get; set; }
        public int Id { get; set; }
        public long? Employeeid { get; set; }
    }
}
