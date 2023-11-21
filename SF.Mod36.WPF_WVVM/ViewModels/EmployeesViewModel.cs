using SF.Mod36.WPF_WVVM.DataAcces;
using SF.Mod36.WPF_WVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SF.Mod36.WPF_WVVM.ViewModels;

public class EmployeesViewModel : INotifyPropertyChanged
{
	private readonly EmployeeRepository _repository;

	public event PropertyChangedEventHandler? PropertyChanged;

	private string _filter;
	public string Filter {
		get { return _filter; }
		set
		{
			if (_filter != value)
			{
				_filter = value;
				FillListView();
			}
		}
	}
	public ObservableCollection<Employee> Employees { get; set; }

	public EmployeesViewModel()
	{
		_repository = new EmployeeRepository();
		FillListView();
	}

	private void OnPropertyChanged([CallerMemberName]string propertyName = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	private void FillListView()
	{
		if (!String.IsNullOrEmpty(Filter))
		{
			Employees = new ObservableCollection<Employee>(
			  _repository.GetAll()
				.Where(v => 
						(v.FirstName + v.LastName)
						.ToLower()
						.Contains(Filter.ToLower())
				)
			  );
		}
		else
		{
			Employees = new ObservableCollection<Employee>(_repository.GetAll());
		}
		OnPropertyChanged(nameof(Employees));
	}
}
