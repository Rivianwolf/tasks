using System;

namespace HR2.Model
{
    public class GetCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }
        public string GenderName { get; set; }
    }
}
