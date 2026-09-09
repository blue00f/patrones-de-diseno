namespace Bridge.Entidades
{
    public abstract class Reporte
    {
        protected IExportador exportador;
        public Reporte(IExportador exportador)
        {
            this.exportador = exportador;
        }
        public void CambiarExportador(IExportador nuevoExportador)
        {
            this.exportador = nuevoExportador;
        }
        public abstract void Generar();
    }
}
