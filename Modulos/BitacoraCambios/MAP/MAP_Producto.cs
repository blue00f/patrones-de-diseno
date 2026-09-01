using BE;
using DAL;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MAP
{
    public class MAP_Producto
    {
        DAO_Producto dao_producto;
        public MAP_Producto()
        {
            dao_producto = new();
        }
        public void Agregar(BE_Producto producto)
        {
            dao_producto.Agregar(producto.CodProducto, producto.Nombre, producto.Existencia, producto.Descripcion, producto.Activo);
        }
        public void Modificar(BE_Producto producto)
        {
            dao_producto.Modificar(producto.CodProducto, producto.Nombre, producto.Existencia, producto.Descripcion);
        }
        public void Borrar(BE_Producto producto)
        {
            dao_producto.CambiarEstadoActivo(producto.CodProducto, false);
        }
        public List<BE_Producto> Consultar()
        {
            DataTable dt = dao_producto.Consultar();
            var lista = new List<BE_Producto>();
            foreach(DataRow dr in dt.Rows)
            {
                lista.Add(Mapear(dr));
            }
            return lista;
        }
        public BE_Producto? ConsultarPorId(BE_Producto producto)
        {
            DataTable dt = dao_producto.ConsultarPorId(producto.CodProducto);
            return dt.Rows.Count > 0 ? Mapear(dt.Rows[0]) : null;
        }
        private BE_Producto Mapear(DataRow fila)
        {
            return new BE_Producto(
                Convert.ToString(fila["Cod_Prod"]),
                Convert.ToString(fila["Nombre"]),
                Convert.ToInt32(fila["Existencia"]),
                Convert.ToString(fila["Descripcion"]),
                Convert.ToBoolean(fila["Activo"])
            );
        }
    }
}
