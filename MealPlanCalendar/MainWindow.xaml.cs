using MealPlanCalendar.Pages;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MealPlanCalendar
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			
			
		}

		private void MakeMealPlan_Click(object sender, RoutedEventArgs e)
		{
			WindowMakeMealPlan Go = new WindowMakeMealPlan();
			Go.ShowDialog();
		}

		private void ViewMealPlan_Click(object sender, RoutedEventArgs e)
		{
			WindowViewMealPlan Go = new WindowViewMealPlan();
			Go.ShowDialog();
		}

		private void ViewGroceryList_Click(object sender, RoutedEventArgs e)
		{
			WindowViewGroceries Go = new WindowViewGroceries();
			Go.ShowDialog();
		}

		private void AddDinnerItem_Click(object sender, RoutedEventArgs e)
		{
			WindowAddToDb Go = new WindowAddToDb();
			Go.ShowDialog();
		}
	}
}
