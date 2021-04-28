using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
using System.Data.SqlClient;
using System.Data;

namespace Data
{
    public class DProducto
    {
        public List<Producto> Listar(Producto producto)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            List<Producto> productos = null;

            try
            {
                comandText = "USP_GetProductos";
                parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@Idproducto", SqlDbType.Int);
                parameters[0].Value = producto.Idproducto;
                productos = new List<Producto>();

                using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.Connection, comandText,
                    CommandType.StoredProcedure, parameters))
                {

                    while (reader.Read())
                    {
                        productos.Add(new Producto
                        {
                            Idproducto = reader["idproducto"] != null ? Convert.ToInt32(reader["idproducto"]) : 0,
                            nombreProducto = reader["nombreProducto"] != null ? Convert.ToString(reader["nombreProducto"]) : string.Empty,
                            idProveedor = reader["idProveedor"] != null ? Convert.ToInt32(reader["idProveedor"]) : 0,
                            idCategoria = reader["idCategoria"] != null ? Convert.ToInt32(reader["idCategoria"]) : 0,
                            cantidadPorUnidad = reader["cantidadPorUnidad"] != null ? Convert.ToString(reader["cantidadPorUnidad"]) : string.Empty,
                            precioUnidad = reader["precioUnidad"] != null ? Convert.ToInt32(reader["precioUnidad"]) : 0,
                            unidadesEnExistencia = reader["unidadesEnExistencia"] != null ? Convert.ToInt32(reader["unidadesEnExistencia"]) : 0,
                            unidadesEnPedido = reader["unidadesEnPedido"] != null ? Convert.ToInt32(reader["unidadesEnPedido"]) : 0,
                            nivelNuevoPedido = reader["nivelNuevoPedido"] != null ? Convert.ToInt32(reader["nivelNuevoPedido"]) : 0,
                            suspendido = reader["suspendido"] != null ? Convert.ToInt32(reader["suspendido"]) : 0,
                            categoriaProducto = reader["categoriaProducto"] != null ? Convert.ToString(reader["categoriaProducto"]) : string.Empty,

                        });
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return productos;

        }

        public void Insertar(Producto producto)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            try
            {
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Actualizar(Producto producto)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            try
            {
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int Idproducto)
        {

            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            try
            {
           
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
