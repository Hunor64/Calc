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

namespace Calculator
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
        private void Tetszoleges(object sender, RoutedEventArgs e)
        {
            String eredmeny = $"{txtAszam.Text} + {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) + Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye: " + eredmeny);
            Eredmenyek.Items.Add(eredmeny);
        }
        private void btnKivon_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny = $"{txtAszam.Text} - {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) - Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye: " + eredmeny);
            Eredmenyek.Items.Add(eredmeny);
        }
        private void btnSzoroz_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny = $"{txtAszam.Text} * {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) * Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye: " + eredmeny);
            Eredmenyek.Items.Add(eredmeny);
            //this.Background = new SolidColorBrush (Colors.DarkBlue);
        }
        private void btnoszt_Click(object sender, RoutedEventArgs e)
        {
            if (txtBszam.Text == "0")
            {
                MessageBox.Show("0-val nem osztunk!");
            }
            else
            {
                String eredmeny = $"{txtAszam.Text} / {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) / Convert.ToDouble(txtBszam.Text)}";
                MessageBox.Show("Az összeadás eredménye: " + eredmeny);
                Eredmenyek.Items.Add(eredmeny);
            }
        }
    }
}
