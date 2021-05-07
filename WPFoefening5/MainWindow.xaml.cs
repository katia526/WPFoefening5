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

namespace WPFoefening5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Persoon> personen { get; set; } = new List<Persoon>();
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void Bewaar_Click(object sender, RoutedEventArgs e)
        {
            
            personen.Add(new Persoon() { Ind = Convert.ToInt32(txtIndex.Text), Name = txtNaam.Text, Voornaam = txtVoornaam.Text });
            txtIndex.Text = " ";
            txtVoornaam.Text = " ";
            txtNaam.Text = " ";
        }

        private void Bekijk_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(txtBekijk.Text);
           
            MessageBox.Show($"{personen[i-1].Name}");
        }
    }
    public class Persoon
    {
        public int Ind { get; set; }
        public string Name { get; set; }
        public string Voornaam { get; set; }
    }
}
