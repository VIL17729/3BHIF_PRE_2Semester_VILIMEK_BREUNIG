using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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



		private void Start_Click(object sender, RoutedEventArgs e)
		{
			uc.Content = new UC.Start();
		}

		private void Patient_Click(object sender, RoutedEventArgs e)
		{
			uc.Content = new UC.Patienten();
		}
		private void Settings_Click(object sender, RoutedEventArgs e)
		{
			//uc.Content = new UC.Settings();
		}
		private void Help_Click(object sender, RoutedEventArgs e)
		{
			//uc.Content = new UC.Help();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if(!(System.Windows.Forms.MessageBox.Show("Sind sie sicher?", "Bestätigung", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes))
			{
				e.Cancel = true;
			}
		}
	}
}
