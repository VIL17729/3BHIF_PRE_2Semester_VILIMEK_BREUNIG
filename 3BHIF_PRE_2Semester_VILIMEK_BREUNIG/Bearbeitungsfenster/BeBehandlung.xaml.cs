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

namespace _3BHIF_PRE_2Semester_VILIMEK_BREUNIG.Bearbeitungsfenster
{
    /// <summary>
    /// Interaction logic for BeBehandlung.xaml
    /// </summary>
    public partial class BeBehandlung : Window
    {
        public BeBehandlung()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // dies ist leider notwenig um die DialogBox mit OK zu schliessen
            DialogResult = true;
        }
    }
}
