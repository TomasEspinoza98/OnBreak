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
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class AdminCliente : MetroWindow {
        public AdminCliente() {
            InitializeComponent();
        }


        private void AgregarCliente(object sender, RoutedEventArgs e)
        {
            AgregarPersona agregar = new AgregarPersona();
            agregar.Show();
            agregar.ResizeMode = System.Windows.ResizeMode.NoResize;
        }

        private void ListadoCliente(object sender, RoutedEventArgs e)
        {
            ListadoCliente listado = new ListadoCliente();
            listado.Show();
            listado.ResizeMode = System.Windows.ResizeMode.NoResize;
        }

        private void ActualizarCliente(object sender, RoutedEventArgs e)
        {
  

        }

            private void EliminarCliente(object sender, RoutedEventArgs e)
        {
            EliminarCliente eliminar = new EliminarCliente();
            eliminar.Show();
            eliminar.ResizeMode = System.Windows.ResizeMode.NoResize;
        }
    }
}
