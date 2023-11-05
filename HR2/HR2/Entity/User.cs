using HR2.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    //public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public string PasswordHash { get; set; }
    public bool IsActive { get; set; }
}

