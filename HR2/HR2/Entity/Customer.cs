using HR2.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Customer
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int GenderId { get; set; }

   
    public Gender Gender { get; set; }

    public List<PhoneNumbers> PhoneNumbers { get; set; }

}

