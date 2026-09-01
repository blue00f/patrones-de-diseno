using BE;
using DAL;
using System.Data;

namespace MAP
{
    public class MAP_Producto_C
    {
        DAO_Producto_C dao_producto_c;
        public MAP_Producto_C()
        {
            dao_producto_c = new();
        }
        public List<BE_Producto_C> Consultar()
        {
            DataTable dt = dao_producto_c.Consultar();
            var lista = new List<BE_Producto_C>();
            foreach (DataRow dr in dt.Rows)
            {
                lista.Add(Mapear(dr));
            }
            return lista;
        }
        public void Activar(BE_Producto_C producto)
        {
            dao_producto_c.Activar(producto.Id);
        }
        private BE_Producto_C Mapear(DataRow fila)
        {
            return new BE_Producto_C
            (
                Convert.ToInt32(fila["Id_C"]),
                Convert.ToString(fila["Cod_Prod"]),
                Convert.ToString(fila["Nombre"]),
                Convert.ToInt32(fila["Existencia"]),
                Convert.ToString(fila["Descripcion"]),
                Convert.ToBoolean(fila["EstadoProducto"]),
                Convert.ToDateTime(fila["FechaHora"]),
                Convert.ToBoolean(fila["Activo"])
            );
        }
    }
}
