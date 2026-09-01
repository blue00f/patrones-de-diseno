using System.Data;
namespace DAL
{
    public class DAO_Producto
    {
        ComandoBD com;
        public DAO_Producto()
        {
            com = new();
        }
        public void Agregar(string codProducto, string nombre, int existencia, string descripcion, bool activo)
        {
            var parametros = new List<ParametroBD>
            {
                new("@codProducto", SqlDbType.VarChar, codProducto),
                new("@nombre", SqlDbType.VarChar, nombre),
                new("@existencia", SqlDbType.Int, existencia),
                new("@descripcion", SqlDbType.VarChar, descripcion),
                new("@activo", SqlDbType.Bit, activo),
            };
            com.Ejecutar("insert into Producto(Cod_Prod,Nombre,Existencia,Descripcion,Activo) values(@codProducto,@nombre,@existencia,@descripcion,@activo)", parametros);
        }
        public void Modificar(string codProducto, string nombre, int existencia, string descripcion)
        {
            var parametros = new List<ParametroBD>
            {
                new("@codProducto", SqlDbType.VarChar, codProducto),
                new("@nombre", SqlDbType.VarChar, nombre),
                new("@existencia", SqlDbType.Int, existencia),
                new("@descripcion", SqlDbType.VarChar, descripcion),
            };
            com.Ejecutar("update Producto set Nombre=@nombre,Existencia=@existencia,Descripcion=@descripcion where Cod_Prod=@codProducto", parametros);
        }
        public void CambiarEstadoActivo(string codProducto, bool activo)
        {
            var parametros = new List<ParametroBD>
            {
                new("@codProducto", SqlDbType.VarChar, codProducto),
                new("@activo", SqlDbType.Bit, activo)
            };
            com.Ejecutar("update Producto set Activo=@activo where Cod_Prod=@codProducto", parametros);
        }
        public DataTable Consultar() => com.Consultar("select * from Producto");
        public DataTable ConsultarPorId(string codProducto)
        {
            var parametros = new List<ParametroBD>
            {
                new("@codProducto", SqlDbType.VarChar, codProducto),
            };
            return com.Consultar("select * from Producto where Cod_Prod=@codProducto", parametros);
        }
    }
}
