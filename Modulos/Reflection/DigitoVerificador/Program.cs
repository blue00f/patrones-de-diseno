using DigitoVerificador.Entidades;

class Program
{
    static void Main(string[] args)
    {
        Proveedor p = new Proveedor("Los Sauces S.A.", "12345678");
        Cliente c = new Cliente("Luis", "Miguel", new DateTime(1981, 09, 22));

        var dvhProveedor = GestorDVH.GenerarDVH(p);
        var dvhCliente = GestorDVH.GenerarDVH(c);

        Saludador.Saludar(p);
        Saludador.Saludar(c);
    }
}