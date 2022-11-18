using System;
using System.Collections.Generic;

#nullable disable

namespace Angular.Repository.Models
{
    public partial class Timesheet
    {
        public long? Employeeid { get; set; }
        public string Period { get; set; }
        public long? Clientid { get; set; }
        public long? Noofhours { get; set; }
        public long? Payrate { get; set; }
        public long? Revenuerate { get; set; }
        public string Creationdate { get; set; }
        public long? Operationalcost { get; set; }
        public long? Receivables { get; set; }
        public string Receivablespaid { get; set; }
        public long? Createdby { get; set; }
        public long? Updatedby { get; set; }
        public string Updateddate { get; set; }
        public int Id { get; set; }
    }
}
