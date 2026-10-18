namespace DigitoVerificador.Entidades
{
    public class Proveedor : Entity
    {
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public Proveedor(string razonSocial, string cuit)
        {
            RazonSocial = razonSocial;
            Cuit = cuit;
        }
    }
}
