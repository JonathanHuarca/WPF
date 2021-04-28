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
    /// Lógica de interacción para ListaCategoria.xaml
    /// </summary>
    public partial class ListaCategoria : Window
    {
        ListaCategoriaViewModel viewModel;

        public ListaCategoria()
        {
            InitializeComponent();
            viewModel = new ListaCategoriaViewModel();
            this.DataContext = viewModel;
        }


        private void AddProduct(object sender, RoutedEventArgs e)
        {
            ManCategoriaViewModel viewModels;

            viewModels = new ManCategoriaViewModel();
            this.DataContext = viewModels;

        }

        private void UpdateProduct(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateProductForEdit(object s, RoutedEventArgs e)
        {
            
        }
        private void DeleteProduct(object s, RoutedEventArgs e)
        {
        
            

        }

        private void dgvCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
