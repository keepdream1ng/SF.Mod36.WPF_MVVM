using System.Windows;
using SF.Mod36.WPF_WVVM.Models;
using SF.Mod36.WPF_MVVM.ViewModels;
using SF.Mod36.WPF_WVVM.ViewModels;

namespace SF.Mod36.WPF_MVVM.Views
{
	/// <summary>
	/// Interaction logic for EmployeeInfoView.xaml
	/// </summary>
	public partial class EmployeeInfoView : Window
	{
		public EmployeeInfoView(IEmployeeInfoViewModel model)
		{
			InitializeComponent();
			DataContext = model;
		}
	}
}
