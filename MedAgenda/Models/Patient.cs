using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedAgenda.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public DateTime DOB { get; set; }
        public string ConsentForCare { get; set; }
        public string ConsentForText { get; set; }

    }
}
    