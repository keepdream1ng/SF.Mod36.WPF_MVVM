using SF.Mod36.WPF_WVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SF.Mod36.WPF_WVVM.DataAcces;

public class EmployeeRepository 
{
  private readonly List < Employee > _employees = new List < Employee > ();

  public EmployeeRepository() 
  {
    _employees.Add(
      new Employee() {
        Id = Guid.NewGuid(),
          FirstName = "Иван",
          LastName = "Иванович",
          Age = 28,
          CompanyName = "Инжиринг",
          JobTitle = "Инженер",
          CityName = "Владивосток"
      });

    _employees.Add(
      new Employee() 
      {
        Id = Guid.NewGuid(),
          FirstName = "Сергей",
          LastName = "Сергеевич",
          Age = 34,
          CompanyName = "Дальний рубеж",
          JobTitle = "Архитектор",
          CityName = "Уфа"
      });

    _employees.Add(
      new Employee() 
      {
        Id = Guid.NewGuid(),
          FirstName = "Константин",
          LastName = "Петрович",
          Age = 42,
          CompanyName = "Океан",
          JobTitle = "Программист",
          CityName = "Москва"
      });
  }

  public IEnumerable < Employee > GetAll() => _employees;

  public Employee GetById(Guid id) => _employees
    .FirstOrDefault(v => v.Id == id);

  public void Add(Employee employee) 
  {
    _employees.Add(employee);
  }

  public void Delete(Guid id) 
  {
    _employees.RemoveAll(v => v.Id == id);
  }
}
