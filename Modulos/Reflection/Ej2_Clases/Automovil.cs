namespace Ej2_Clases
{
    public class Automovil
    {
        public string Marca { get; set; }
        public string Patente { get; set; }
        public int Velocidad { get; private set; }
        public void Acelerar(int pCantidad = 1) => Velocidad += pCantidad;
        public void Frenar(int pCantidad = 1)
        {
            Velocidad -= pCantidad;
            if (Velocidad < 0) Velocidad = 0;
        }
    }
}
