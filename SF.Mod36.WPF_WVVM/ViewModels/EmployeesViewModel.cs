using SF.Mod36.WPF_WVVM.DataAcces;
using SF.Mod36.WPF_WVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Mod36.WPF_WVVM.ViewModels;

public class EmployeesViewModel
{
	private readonly EmployeeRepository _repository;

	public EmployeesViewModel()
	{
		_repository = new EmployeeRepository();
	}

	public ObservableCollection<Employee> Employees
	{
		get
		{
			return new ObservableCollection<Employee>(this._repository.GetAll());
		}
	}
}
