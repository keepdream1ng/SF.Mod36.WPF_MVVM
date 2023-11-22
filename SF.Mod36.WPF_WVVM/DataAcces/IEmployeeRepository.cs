using SF.Mod36.WPF_WVVM.Models;
using System;
using System.Collections.Generic;

namespace SF.Mod36.WPF_WVVM.DataAcces
{
	public interface IEmployeeRepository
	{
		void Add(Employee employee);
		void Delete(Guid id);
		IEnumerable<Employee> GetAll();
		Employee GetById(Guid id);
	}
}