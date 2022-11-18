using System;
using System.Collections.Generic;

#nullable disable

namespace Angular.Repository.Models
{
    public partial class Payrollexpense
    {
        public long? Employeeid { get; set; }
        public string Payperiodstartdate { get; set; }
        public string Payperiodenddate { get; set; }
        public string Paymentdate { get; set; }
        public long? Noofhours { get; set; }
        public long? Payrate { get; set; }
        public long? Grosspay { get; set; }
        public long? Payrollexpense1 { get; set; }
        public long? Insurancebycompany { get; set; }
        public long? Totalpayroll { get; set; }
        public string Creatioddate { get; set; }
        public long? Createdby { get; set; }
        public long? Updatedby { get; set; }
        public string Updateddate { get; set; }
        public int Id { get; set; }
    }
}
