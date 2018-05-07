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

namespace _3BHIF_PRE_2Semester_VILIMEK_BREUNIG.UC
{
	/// <summary>
	/// Interaction logic for Patienten.xaml
	/// </summary>
	public partial class Patienten : UserControl
	{
		public Patienten()
		{
			InitializeComponent();
		}

		private void SelectionChanged(object sender, SelectionChangedEventArgs e) //fertigschreiben, wenn Datenbank vorhanden
		{
			ComboBox c = (ComboBox)sender;
			if(c.Name.Equals("cbox0"))
			{
				switch(cbox0.SelectedIndex)
				{
					case 0:
						lb0.ItemsSource = null;
						break;
					case 1:
						lb0.ItemsSource = Patientendaten
						break;
				}
			} else
			{
			}
		}

		private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			ListBox l = (ListBox)sender;
			
		}
	}
}
