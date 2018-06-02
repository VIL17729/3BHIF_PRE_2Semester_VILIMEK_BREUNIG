using _3BHIF_PRE_2Semester_VILIMEK_BREUNIG.modell;
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
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Patient_Click(object sender, RoutedEventArgs e)
        {
            var v = new BePatient();          // der View
            var vm = new vmPatient();           // das ViewModel
            vm.AktPatient= new Patient();     
            vm.IstinEditMode = false;

            v.DataContext = vm;                 // V hat das VM im DataContext
            v.ShowDialog();                     // V anzeigen und warten auf schliessen
            if (v.DialogResult.HasValue && v.DialogResult.Value)
            {           // speichern
                using (PatientendatenEntities db = new PatientendatenEntities())
                {           //füge die Instanz zum OR Mapper hinzu, erkläre sie als verändert
                    db.Patients.Add(vm.AktPatient);
                    db.SaveChanges();
                }
                this.Close();
            }
        }

        private void Termin_Click(object sender, RoutedEventArgs e)
        {
            var v = new BeTermin();
            v.ShowDialog();
            if (v.DialogResult.HasValue && v.DialogResult.Value)
            {           // speichern
                using (PatientendatenEntities db = new PatientendatenEntities())
                {           //füge die Instanz zum OR Mapper hinzu, erkläre sie als verändert
                    db.SaveChanges();
                }
            }
            this.Close();
        }

        private void Verletzung_Click(object sender, RoutedEventArgs e)
        {
            var v = new BeVerletzung();
            v.ShowDialog();
            if (v.DialogResult.HasValue && v.DialogResult.Value)
            {           // speichern
                using (PatientendatenEntities db = new PatientendatenEntities())
                {           //füge die Instanz zum OR Mapper hinzu, erkläre sie als verändert
                    db.SaveChanges();
                }
            }
            this.Close();
        }

        private void Behandlung_Click(object sender, RoutedEventArgs e)
        {
            var v = new BeBehandlung();
            v.ShowDialog();
            if (v.DialogResult.HasValue && v.DialogResult.Value)
            {           // speichern
                using (PatientendatenEntities db = new PatientendatenEntities())
                {           //füge die Instanz zum OR Mapper hinzu, erkläre sie als verändert
                    db.SaveChanges();
                }
            }
            this.Close();
        }
    }
}
