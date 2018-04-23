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

namespace _3BHIF_PRE_2Semester_VILIMEK_BREUNIG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
			//lb0 daten laden
        }

		private void cbox0_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		/*private void cbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (cbox1.SelectedIndex == 0)
			{
				cbox1.Visibility = Visibility.Hidden;
                Grid.SetColumnSpan(cbox0, 1);
			}
			else
			{
				cbox1.Visibility = Visibility.Visible;

				switch(cbox1.SelectedIndex) //datacontext für listbox ändern
				{
					case 1:
						break;
					case 2:
						break;
					case 3:
						break;
					case 4:
						break;
				}
			}
		}*/
	}
}
