using MahApps.Metro.Controls;
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

namespace OnBreak.vistas {
    public partial class ListadoClientesPrincipal : MetroWindow {
        public ListadoClientesPrincipal() {
            InitializeComponent();
        }

        private void btnAtras(object sender, RoutedEventArgs e) {
            MainWindow ventanaPrincipal = new MainWindow();
            ventanaPrincipal.Show();
            Close();
        }
    }
}
