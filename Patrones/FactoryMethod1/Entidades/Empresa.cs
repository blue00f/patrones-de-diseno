namespace FactoryMethod.Entidades
{
    public class Empresa
    {
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public string Direccion { get; set; }
        public Empresa(string razonSocial, string cuit, string direccion)
        {
            RazonSocial = razonSocial;
            Cuit = cuit;
            Direccion = direccion;
        }
    }
}
