﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contso.Model
{
    public class People
    {
        public int id { get; set; }
        public string LastName { get; set; }
        public string Firstname { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string UnitOrApartmentNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string IsLocked { get; set; }
        public DateTime LastLockedDateTime { get; set; }
        public int FailedAttempts { get; set; }

        public ICollection<Roles> Roles { get; set; }
    }
}
