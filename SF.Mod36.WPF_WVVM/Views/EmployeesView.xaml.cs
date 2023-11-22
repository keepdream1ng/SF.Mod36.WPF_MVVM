using SF.Mod36.WPF_MVVM.ViewModels;
using SF.Mod36.WPF_WVVM.Models;
using SF.Mod36.WPF_WVVM.ViewModels;
using SF.Mod36.WPF_MVVM.Views;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SF.Mod36.WPF_WVVM.Views
{
	/// <summary>
	/// Interaction logic for EmployessView.xaml
	/// </summary>
	public partial class EmployessView : Window
	{
		private readonly IEmployeeInfoViewModel _infoModel;

		public EmployessView(IEmployeesViewModel model, IEmployeeInfoViewModel infoModel)
		{
			InitializeComponent();
			DataContext = model;
			_infoModel = infoModel;
		}

		private void ListView_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			var item = (sender as ListView).SelectedItem;
			if (item is null )
			{
				return;
			}

			_infoModel.Employee = item as Employee;
			var infoView = new EmployeeInfoView(_infoModel);
			infoView.Show();
        }
    }
}
