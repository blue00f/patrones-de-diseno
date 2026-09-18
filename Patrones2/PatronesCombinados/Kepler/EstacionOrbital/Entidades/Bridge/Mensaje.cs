namespace EstacionOrbital.Entidades.Bridge
{
    public abstract class Mensaje
    {
        protected ICifrado cifrado;
        protected string contenido;
        protected abstract string Tipo { get; }
        protected abstract string Prioridad { get; }
        public Mensaje(ICifrado cifrado, string contenido)
        {
            this.cifrado = cifrado;
            this.contenido = contenido;
        }
        public void Enviar()
        {
            string contenidoCifrado = cifrado.Cifrar(contenido);
            Console.WriteLine($"[{Tipo}] (prioridad {Prioridad})");
            Console.WriteLine($"  Método de cifrado: {cifrado.Nombre}");
            Console.WriteLine($"  Contenido original: {contenido}");
            Console.WriteLine($"  Contenido enviado:  {contenidoCifrado}");
        }
    }
}
