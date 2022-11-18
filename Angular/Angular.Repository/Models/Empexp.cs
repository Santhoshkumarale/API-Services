using System;
using System.Collections.Generic;

#nullable disable

namespace Angular.Repository.Models
{
    public partial class Empexp
    {
        public Empexp()
        {
            ImgexpCreatedbyNavigations = new HashSet<Imgexp>();
            ImgexpEmployees = new HashSet<Imgexp>();
            InverseApprovedbyNavigation = new HashSet<Empexp>();
            InverseClientcodeNavigation = new HashSet<Empexp>();
            InverseCreatedbyNavigation = new HashSet<Empexp>();
            InverseEmployee = new HashSet<Empexp>();
            InverseUpdatedbyNavigation = new HashSet<Empexp>();
        }

        public long? Employeeid { get; set; }
        public string Entity { get; set; }
        public string Expensecode { get; set; }
        public string Expensedate { get; set; }
        public long? Clientcode { get; set; }
        public long? Amount { get; set; }
        public long? Approvedby { get; set; }
        public string Approvaldate { get; set; }
        public string Modeofpayment { get; set; }
        public string Paymentdate { get; set; }
        public string Creationdate { get; set; }
        public long? Createdby { get; set; }
        public long? Updatedby { get; set; }
        public long Id { get; set; }

        public virtual Empexp ApprovedbyNavigation { get; set; }
        public virtual Empexp ClientcodeNavigation { get; set; }
        public virtual Empexp CreatedbyNavigation { get; set; }
        public virtual Empexp Employee { get; set; }
        public virtual Empexp UpdatedbyNavigation { get; set; }
        public virtual ICollection<Imgexp> ImgexpCreatedbyNavigations { get; set; }
        public virtual ICollection<Imgexp> ImgexpEmployees { get; set; }
        public virtual ICollection<Empexp> InverseApprovedbyNavigation { get; set; }
        public virtual ICollection<Empexp> InverseClientcodeNavigation { get; set; }
        public virtual ICollection<Empexp> InverseCreatedbyNavigation { get; set; }
        public virtual ICollection<Empexp> InverseEmployee { get; set; }
        public virtual ICollection<Empexp> InverseUpdatedbyNavigation { get; set; }
    }
}
