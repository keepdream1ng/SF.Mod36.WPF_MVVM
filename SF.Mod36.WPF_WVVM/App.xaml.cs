using SF.Mod36.WPF_WVVM.DataAcces;
using SF.Mod36.WPF_WVVM.ViewModels;
using SF.Mod36.WPF_WVVM.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace SF.Mod36.WPF_MVVM;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
	protected override void OnStartup(StartupEventArgs e)
	{
		base.OnStartup(e);

		UnityContainer unityContainer = new();
		unityContainer.RegisterType<IEmployeeRepository, EmployeeRepository>();
		unityContainer.RegisterType<IEmployeesViewModel, EmployeesViewModel>();

		var startView = new EmployessView
		{
			DataContext = unityContainer.Resolve<IEmployeesViewModel>()
		};

		startView.Show();
	}
}
