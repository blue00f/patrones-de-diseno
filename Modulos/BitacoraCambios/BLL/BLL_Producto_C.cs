using BE;
using MAP;

namespace BLL
{
    public class BLL_Producto_C
    {
        MAP_Producto_C map_producto_c;
        public BLL_Producto_C()
        {
            map_producto_c = new();
        }
        public List<BE_Producto_C> Consultar() => map_producto_c.Consultar();
        public List<object> ConsultarActivos()
        {
            var consulta = from p in Consultar() where p.EstadoProducto == true
                           select new
                           {
                               p.Id,
                               p.CodProducto,
                               p.Nombre,
                               p.Existencia,
                               p.Descripcion,
                               Fecha = p.FechaHora.ToShortDateString(),
                               Hora = p.FechaHora.ToString("HH:mm"),
                               p.Activo
                           };
            return consulta.ToList<object>();
        }
        public List<object> ConsultarFiltrado(string nombre, string codProducto, DateTime? fechaInicio, DateTime? fechaFin)
        {
            var consulta = from p in Consultar()
                           where
                           p.EstadoProducto == true
                           &&
                           (string.IsNullOrWhiteSpace(nombre) || p.Nombre.Contains(nombre))
                           &&
                           (string.IsNullOrWhiteSpace(codProducto) || p.CodProducto.Contains(codProducto))
                           &&
                           (!fechaInicio.HasValue || p.FechaHora >= fechaInicio.Value)
                           &&
                           (!fechaFin.HasValue || p.FechaHora <= fechaFin.Value)
                           select new
                           {
                               p.Id,
                               p.CodProducto,
                               p.Nombre,
                               p.Existencia,
                               p.Descripcion,
                               Fecha = p.FechaHora.ToShortDateString(),
                               Hora = p.FechaHora.ToString("HH:mm"),
                               p.Activo
                           };
            return consulta.ToList<object>();
        }
        public void Activar(BE_Producto_C producto) => map_producto_c.Activar(producto);
    }
}
