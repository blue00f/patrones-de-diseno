using BE;
using DAL;
using Servicios;
using System.Data;

namespace MAP
{
    public class MAP_Usuario : IABMC<BE_Usuario>
    {
        DAO_Usuario dao_usuario;
        public MAP_Usuario()
        {
            dao_usuario = new();
        }
        public void Agregar(BE_Usuario usuario)
        {
            List<ParametroBD> parametros = ObtenerParametros(usuario);
            dao_usuario.Agregar(parametros);
        }

        public void Borrar(BE_Usuario obj)
        {
            throw new NotImplementedException();
        }
        public void Modificar(BE_Usuario obj)
        {
            throw new NotImplementedException();
        }

        public List<BE_Usuario> Consultar()
        {
            List<BE_Usuario> lista = new();
            DataTable tabla = dao_usuario.Consultar();
            
            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(Mapear(fila));
            }
            return lista;
        }

        public BE_Usuario ConsultarPorId(BE_Usuario obj)
        {
            throw new NotImplementedException();
        }


        private List<ParametroBD> ObtenerParametros(BE_Usuario usuario)
        {
            return new List<ParametroBD>
            {
                new("@dni", SqlDbType.VarChar, usuario.Dni),
                new("@nombre", SqlDbType.VarChar, usuario.Nombre),
                new("@apellido", SqlDbType.VarChar, usuario.Apellido),
                new("@correo", SqlDbType.VarChar, usuario.Correo),
                new("@nombreUsuario", SqlDbType.VarChar, usuario.Usuario),
                new("@password", SqlDbType.VarChar, usuario.Password),
                new("@bloqueo", SqlDbType.Bit, usuario.Bloqueo),
                new("@activo", SqlDbType.Bit, usuario.Activo),
                new("@cantIntentos", SqlDbType.TinyInt, usuario.CantIntentos),
            };
        }

        private BE_Usuario Mapear(DataRow fila)
        {
            return new BE_Usuario(
                Convert.ToString(fila["dni"]),
                Convert.ToString(fila["nombre"]),
                Convert.ToString(fila["apellido"]),
                Convert.ToString(fila["correo"]),
                Convert.ToString(fila["nombreUsuario"]),
                Convert.ToString(fila["password"]),
                Convert.ToBoolean(fila["bloqueo"]),
                Convert.ToBoolean(fila["activo"]),
                Convert.ToInt16(fila["cantIntentos"])
            );
        }
    }
}
