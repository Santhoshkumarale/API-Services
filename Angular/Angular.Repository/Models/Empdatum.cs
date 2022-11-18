using System;
using System.Collections.Generic;

#nullable disable

namespace Angular.Repository.Models
{
    public partial class Empdatum
    {
        public Empdatum()
        {
            InverseSupervisorNavigation = new HashSet<Empdatum>();
        }

        public long Employeeid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname { get; set; }
        public string Empstatus { get; set; }
        public string Emailaddress { get; set; }
        public string Jobtitle { get; set; }
        public string Internalstaff { get; set; }
        public long? Supervisor { get; set; }
        public string Visastatus { get; set; }
        public string Gender { get; set; }
        public string Entity { get; set; }
        public string Dateofbirth { get; set; }
        public string Clientname { get; set; }
        public string Clientcode { get; set; }
        public string Startdate { get; set; }
        public string Createdby { get; set; }
        public string Updatedby { get; set; }
        public string Immigrationstatus { get; set; }
        public string Highestdegree { get; set; }
        public string University { get; set; }
        public int Id { get; set; }
        public long? Contactnumber { get; set; }
        public string Addressline1 { get; set; }
        public string Addressline2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long? Zipcode { get; set; }
        public string Country { get; set; }
        public string Ssn { get; set; }
        public long? Taxfilenumber { get; set; }
        public long? Emergencynumber { get; set; }
        public string Effectivedate { get; set; }
        public string Location { get; set; }
        public string Reportsto { get; set; }
        public string Payschedule { get; set; }
        public string Paytype { get; set; }
        public string Payrate { get; set; }
        public string Overtime { get; set; }
        public string Overtimerate { get; set; }
        public string Changereason { get; set; }
        public string Comment { get; set; }
        public string Specialization { get; set; }
        public string Gpa { get; set; }
        public string Degreestartdate { get; set; }
        public string Degreeenddate { get; set; }
        public string Date { get; set; }
        public string Issuingcountry { get; set; }
        public string Issueddate { get; set; }
        public string Expirationdate { get; set; }
        public string Status { get; set; }
        public string Employementstatus { get; set; }
        public string Jobeffectivedate { get; set; }
        public string Compensationeffectivedate { get; set; }

        public virtual Empdatum SupervisorNavigation { get; set; }
        public virtual ICollection<Empdatum> InverseSupervisorNavigation { get; set; }
    }
}
