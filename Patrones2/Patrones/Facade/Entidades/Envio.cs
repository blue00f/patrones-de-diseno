namespace Facade.Entidades
{
    public class Envio
    {
        public string GenerarEtiquetaEnvio(string direccion)
        {
            string codigoSeguimiento = "ENV-" + new Random().Next(1000, 9999);
            Console.WriteLine($"\t[Envío] Etiqueta generada para '{direccion}' -> Código: {codigoSeguimiento}");
            return codigoSeguimiento;
        }
    }
}
