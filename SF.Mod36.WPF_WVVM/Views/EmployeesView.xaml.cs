﻿using SF.Mod36.WPF_WVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SF.Mod36.WPF_WVVM.Views
{
	/// <summary>
	/// Interaction logic for EmployessView.xaml
	/// </summary>
	public partial class EmployessView : Window
	{
		public EmployessView()
		{
			InitializeComponent();
		}

		private void ListView_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			var item = (sender as ListView).SelectedItem;
			if (item is null )
			{
				return;
			}

			var empl = item as Employee;
			MessageBox.Show($"Selected employee {empl.FirstName} {empl.LastName} {empl.JobTitle}");
        }
    }
}
