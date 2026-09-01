using BE;
using MAP;

namespace BLL
{
    public class BLL_Producto
    {
        MAP_Producto map_producto;
        public BLL_Producto()
        {
            map_producto = new();
        }
        public void Agregar(BE_Producto producto) => map_producto.Agregar(producto);
        public void Modificar(BE_Producto producto) => map_producto.Modificar(producto);
        public void Borrar(BE_Producto producto) => map_producto.Borrar(producto);
        public List<BE_Producto> Consultar() => map_producto.Consultar();
        public List<object> ConsultarGrilla()
        {
            var consulta = from producto in Consultar() where producto.Activo == true
                           select new
                           {
                               Codigo = producto.CodProducto,
                               Nombre = producto.Nombre,
                               Existencia = producto.Existencia,
                               Descripcion = producto.Descripcion,
                           };
            return consulta.ToList<object>();
        }
        public BE_Producto? ConsultarPorId(BE_Producto producto) => map_producto.ConsultarPorId(producto);
    }
}
