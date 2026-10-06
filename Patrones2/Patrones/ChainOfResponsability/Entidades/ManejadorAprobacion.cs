namespace ChainOfResponsability.Entidades
{
    public abstract class ManejadorAprobacion
    {
        protected ManejadorAprobacion? siguiente;
        public void EstablecerSiguiente(ManejadorAprobacion siguienteManejador)
        {
            siguiente = siguienteManejador;
        }
        public abstract void Manejar(string solicitante, decimal monto, string concepto);
    }
}
