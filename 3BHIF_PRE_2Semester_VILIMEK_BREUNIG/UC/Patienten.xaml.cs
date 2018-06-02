using _3BHIF_PRE_2Semester_VILIMEK_BREUNIG.Bearbeitungsfenster;
using _3BHIF_PRE_2Semester_VILIMEK_BREUNIG.modell;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var v = new Add();
            v.ShowDialog();
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e) //fertigschreiben, wenn Datenbank vorhanden
		{
			ComboBox c = (ComboBox)sender;
			if(c.Name == "cbox0")
			{
                if (c.SelectedIndex == 1)
                {
                    using (PatientendatenEntities db = new PatientendatenEntities())
                    {
                        var erg = from p in db.Patients
                                  orderby p.Nachname
                                  select p;
                        lb1.DataContext = erg.ToList();
                    }
                }

                if (c.SelectedIndex == 2)
                {
                    using (PatientendatenEntities db = new PatientendatenEntities())
                    {
                        var erg = from t in db.Termins
                                  orderby t.Nr
                                  select t;
                        lb1.DataContext = erg.ToList();
                    }
                }
            }
            else
            {
                if (c.SelectedIndex == 1)
                {
                    using (PatientendatenEntities db = new PatientendatenEntities())
                    {
                        var erg = from p in db.Patients
                                  orderby p.Nachname
                                  select p;
                        lb1.DataContext = erg.ToList();
                    }
                }

                if (c.SelectedIndex == 2)
                {
                    using (PatientendatenEntities db = new PatientendatenEntities())
                    {
                        var erg = from t in db.Termins
                                  orderby t.Nr
                                  select t;
                        lb1.DataContext = erg.ToList();
                    }
                }

                if (c.SelectedIndex == 3)
                {
                    using (PatientendatenEntities db = new PatientendatenEntities())
                    {
                        var erg = from b in db.Behandlungs
                                  orderby b.Name
                                  select b;
                        lb1.DataContext = erg.ToList();
                    }
                }

                if (c.SelectedIndex == 4)
                {
                    using (PatientendatenEntities db = new PatientendatenEntities())
                    {
                        var erg = from v in db.Verletzungs
                                  orderby v.Name
                                  select v;
                        lb1.DataContext = erg.ToList();
                    }
                }
            }
		}

		private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			ListBox l = (ListBox)sender;
            object s=l.SelectedItem;
            if (s == null)
                return;
            if(s is Patient)
            {
                var v = new BePatient();
                var vm = new vmPatient
                {
                    AktPatient = s as Patient,
                    IstinEditMode = true
                };
                v.DataContext = vm;
                v.ShowDialog();
                if (v.DialogResult.HasValue && v.DialogResult.Value)
                {           // speichern
                    using (PatientendatenEntities db = new PatientendatenEntities())
                    {           //füge die Instanz zum OR Mapper hinzu, erkläre sie als verändert
                        db.Entry(vm.AktPatient).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
            if (s is Termin)
            {
                var v = new BeTermin();
                var vm = new vmTermin
                {
                    AktTermin = s as Termin,
                    IstinEditMode = true
                };
                v.DataContext = vm;
                v.ShowDialog();
                if (v.DialogResult.HasValue && v.DialogResult.Value)
                {           // speichern
                    using (PatientendatenEntities db = new PatientendatenEntities())
                    {           //füge die Instanz zum OR Mapper hinzu, erkläre sie als verändert
                        db.Entry(vm.AktTermin).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
        }

        private void ListBox_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            ListBox l = (ListBox)sender;
            object s = l.SelectedItem;
            if (s == null)
                return;
            if (s is Patient)
            {
                var v = new BePatient();
                var vm = new vmPatient
                {
                    AktPatient = s as Patient,
                    IstinEditMode = true
                };
                v.DataContext = vm;
                v.ShowDialog();
                if (v.DialogResult.HasValue && v.DialogResult.Value)
                {           // speichern
                    using (PatientendatenEntities db = new PatientendatenEntities())
                    {           //füge die Instanz zum OR Mapper hinzu, erkläre sie als verändert
                        db.Entry(vm.AktPatient).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
            if (s is Termin)
            {
                var v = new BeTermin();
                var vm = new vmTermin
                {
                    AktTermin = s as Termin,
                    IstinEditMode = true
                };
                v.DataContext = vm;
                v.ShowDialog();
                if (v.DialogResult.HasValue && v.DialogResult.Value)
                {           // speichern
                    using (PatientendatenEntities db = new PatientendatenEntities())
                    {           //füge die Instanz zum OR Mapper hinzu, erkläre sie als verändert
                        db.Entry(vm.AktTermin).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
            if (s is Behandlung)
            {
                var v = new BeBehandlung();
                var vm = new vmBehandlung
                {
                    AktBehandlung = s as Behandlung,
                    IstinEditMode = true
                };
                v.DataContext = vm;
                v.ShowDialog();
                if (v.DialogResult.HasValue && v.DialogResult.Value)
                {           // speichern
                    using (PatientendatenEntities db = new PatientendatenEntities())
                    {           //füge die Instanz zum OR Mapper hinzu, erkläre sie als verändert
                        db.Entry(vm.AktBehandlung).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
            if (s is Verletzung)
            {
                var v = new BeVerletzung();
                var vm = new vmVerletzung
                {
                    AktVerletzung = s as Verletzung,
                    IstinEditMode = true
                };
                v.DataContext = vm;
                v.ShowDialog();
                if (v.DialogResult.HasValue && v.DialogResult.Value)
                {           // speichern
                    using (PatientendatenEntities db = new PatientendatenEntities())
                    {           //füge die Instanz zum OR Mapper hinzu, erkläre sie als verändert
                        db.Entry(vm.AktVerletzung).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
