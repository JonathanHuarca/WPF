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
using Semana06.ViewModel;

namespace Semana06.View
{
    /// <summary>
    /// Lógica de interacción para ListaProducto.xaml
    /// </summary>
    public partial class ListaProducto : Window

    {
        ListaProductoViewModel viewModel;
        public ListaProducto()
        {
            InitializeComponent();
            viewModel = new ListaProductoViewModel();
            this.DataContext = viewModel;
        }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}
