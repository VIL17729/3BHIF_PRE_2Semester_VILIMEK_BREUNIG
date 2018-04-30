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

namespace _3BHIF_PRE_2Semester_VILIMEK_BREUNIG
{
	/// <summary>
	/// Interaction logic for NewEdit.xaml
	/// </summary>
	public partial class NewEdit : Window
	{
		public NewEdit()
		{
			InitializeComponent();
		}

		private void OkCancel(object sender, RoutedEventArgs e) //schreiben, sobald Datenbank vorhanden ist
		{
			if (((Button)sender).Content.Equals("Ok"))
			{
				try
				{

				}
				catch
				{
					Error.Visibility = Visibility.Visible;
				}
			}
			else
				this.Close();
		}
	}
}
