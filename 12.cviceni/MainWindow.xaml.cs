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

namespace _12.cviceni
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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			ServiceReference1.Service1Client sluzba = new ServiceReference1.Service1Client();

			Vysledek.Text = Convert.ToString(sluzba.Spocti(Convert.ToDecimal(Operand1.Text), Convert.ToDecimal(Operand2.Text), DropDown.Text));

			if (Convert.ToDecimal(Vysledek.Text) < 0)
			{
				Vysledek.Background = Brushes.Red;

			}

			if (Convert.ToDecimal(Operand1.Text) < 0)
			{
				Operand1.Background = Brushes.Red;

			}

			if (Convert.ToDecimal(Operand2.Text) < 0)
			{
				Operand2.Background = Brushes.Red;

			}

			if (Convert.ToDecimal(Vysledek.Text) > 100)
			{
				Vysledek.Background = Brushes.Blue;

			}

			if (Convert.ToDecimal(Vysledek.Text) == 420)
			{
				Vysledek.Background = Brushes.ForestGreen;

			}

		}


	}
}
