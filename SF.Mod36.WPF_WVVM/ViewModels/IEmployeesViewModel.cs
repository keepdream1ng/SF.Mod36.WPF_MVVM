using SF.Mod36.WPF_WVVM.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SF.Mod36.WPF_WVVM.ViewModels
{
	public interface IEmployeesViewModel
	{
		ObservableCollection<Employee> Employees { get; set; }
		string Filter { get; set; }

		event PropertyChangedEventHandler? PropertyChanged;
	}
}