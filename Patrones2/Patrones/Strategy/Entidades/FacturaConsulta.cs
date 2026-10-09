namespace Strategy.Entidades
{
    public class FacturaConsulta
    {
        private IEstrategiaCobertura estrategia;
        public string Paciente { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public FacturaConsulta(string paciente, string descripcion, decimal precio, IEstrategiaCobertura estrategia)
        {
            Paciente = paciente;
            Descripcion = descripcion;
            Precio = precio;
            this.estrategia = estrategia;
        }
        public void CambiarEstrategia(IEstrategiaCobertura nuevaEstrategia)
        {
            this.estrategia = nuevaEstrategia; 
        }
        public void Emitir()
        {
            decimal montoAPagar = estrategia.CalcularMontoAPagar(Precio);
            Console.WriteLine($"{Descripcion} | Paciente: {Paciente} | Precio: {Precio:N2} | Paga el paciente: ${montoAPagar:N2}");
        }
    }
}
