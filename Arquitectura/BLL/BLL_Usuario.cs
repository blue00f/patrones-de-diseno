using BE;
using MAP;
using Servicios;

namespace BLL
{
    public class BLL_Usuario : IABMC<BE_Usuario>
    {
        MAP_Usuario map_usuario;
        public BLL_Usuario()
        {
            map_usuario = new();
        }

        public void Agregar(BE_Usuario obj)
        {
            obj.Password = SER_Cripto.Encriptar(obj.Password);
            map_usuario.Agregar(obj);
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
            return map_usuario.Consultar();
        }

        public BE_Usuario ConsultarPorId(BE_Usuario obj)
        {
            throw new NotImplementedException();
        }

    }
}
