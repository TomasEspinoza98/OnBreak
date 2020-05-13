using MahApps.Metro.Controls;
using OnBreak.vistas;
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

namespace OnBreak {
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void administracionCliente(object sender, RoutedEventArgs e) {
            AdminCliente admCliente = new AdminCliente();
            admCliente.Show();
        }

        private void listadoCliente(object sender, RoutedEventArgs e) {
            
        }


        private void administracionContrato(object sender, RoutedEventArgs e) {

        }

        private void listadoContratos(object sender, RoutedEventArgs e) {

        }
    }
}
