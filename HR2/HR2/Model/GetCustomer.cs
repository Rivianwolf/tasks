using HR2.Entity;
using System;
using System.Collections.Generic;

namespace HR2.Model
{
    public class GetCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }
        public string GenderName { get; set; }

        public List<PhoneNumberModel> PhoneNumbers { get; set; }
        

    }

    public class PhoneNumberModel
    { 
        public string PhoneNumber { get; set; }
        public bool IsDefault { get; set; }
    }
}
