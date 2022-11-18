using System;
using System.Collections.Generic;

#nullable disable

namespace Angular.Repository.Models
{
    public partial class Education
    {
        public string University { get; set; }
        public string Highestdegree { get; set; }
        public string Specialization { get; set; }
        public string Gpa { get; set; }
        public string Degreestartdate { get; set; }
        public string Degreeenddate { get; set; }
        public int Id { get; set; }
        public long? Employeeid { get; set; }
    }
}
