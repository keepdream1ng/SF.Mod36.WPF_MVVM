using System;

namespace SF.Mod36.WPF_WVVM.Models;

public class Employee
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string CompanyName { get; set; }
    public string JobTitle { get; set; }
    public string CityName { get; set; }
}
