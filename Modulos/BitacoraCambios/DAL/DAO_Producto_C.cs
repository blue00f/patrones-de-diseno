using System.Data;

namespace DAL
{
    public class DAO_Producto_C
    {
        ComandoBD com;
        public DAO_Producto_C()
        {
            com = new();
        }
        public DataTable Consultar()
        {
            return com.Consultar("select Id_C,Cod_Prod,Nombre,Existencia,Descripcion,FechaHora,EstadoProducto,Activo from Producto_C");
        }
        public void Activar(int idC)
        {
            var parametros = new List<ParametroBD>
            {
                new("@idC", SqlDbType.Int, idC)
            };
            com.Ejecutar("update Producto_C set Activo=1 where Id_C=@idC", parametros);
        }
    }
}
