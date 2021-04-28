using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Entity;

namespace Semana06.ViewModel
{
   public  class ListaProductoViewModel : ViewModelBase
    {
        ObservableCollection<Producto> _Productos;
        public ObservableCollection<Producto> Productos
        {
            get { return _Productos; }
            set
            {
                if (_Productos != value)
                {
                    _Productos = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand NuevoCommand { set; get; }
        public ICommand ConsultarCommand { set; get; }
        public ListaProductoViewModel()
        {
            Productos = new Model.ProductoModel().Categorias;

            NuevoCommand = new RelayCommand<Window>(
                param => Abrir()

                );

            ConsultarCommand = new RelayCommand2(
                o => { Productos = (new Model.ProductoModel()).Categorias; }
                );

            void Abrir()
            {
                View.ManCategoria window = new View.ManCategoria();
                window.ShowDialog();


            }
        }

    }
}
