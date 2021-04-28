using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Business;

namespace Semana06.Model
{
    public class ProductoModel
    {
        public ObservableCollection<Producto> Categorias { get; set; }
        public bool Insertar(Producto categoria)
        {
            return (new BProducto()).Insertar(categoria);
        }
        public bool Actualizar(Categoria categoria)
        {
            return (new BCategoria()).Actualizar(categoria);
        }

        public ProductoModel()
        {
            var lista = (new BProducto().Listar(0));
            Categorias = new ObservableCollection<Producto>(lista);
            var categorias = from c in Categorias
                             select new { Nombre = c.nombreProducto + c.idProveedor+ c.idCategoria};
        }
    }
}
