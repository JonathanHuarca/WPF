using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace Business
{
    public class BProducto
    {
        private DProducto DProducto = null;

        public List<Producto> Listar(int Idproducto)
        {
            List<Producto> productos = null;
            try
            {
                DProducto = new DProducto();
                productos = DProducto.Listar(new Producto { Idproducto = Idproducto});
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return productos;
        }

        public bool Insertar(Producto producto)
        {
            bool result = true;
            try
            {
                DProducto = new DProducto();
                DProducto.Insertar(producto);
            }
            catch (Exception ex)
            {
                //Escribir en el log
                result = false;
            }
            return result;
        }

        public bool Actualizar(Producto producto)
        {
            bool result = true;
            try
            {
                DProducto = new DProducto();
                DProducto.Actualizar(producto);
            }
            catch (Exception ex)
            {
                //Escribir en el log
                result = false;
            }
            return result;
        }

        public bool Eliminar(int Idproducto)
        {
            bool result = true;
            try
            {
                DProducto = new DProducto();
                DProducto.Eliminar(Idproducto);
            }
            catch (Exception ex)
            {
                //Escribir en el log
                result = false;
            }
            return result;
        }

    }
}
