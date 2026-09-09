namespace Bridge.Entidades
{
    public class ReporteResumido : Reporte
    {
        public ReporteResumido(IExportador exportador) : base(exportador) { }
        public override void Generar()
        {
            var contenido = new List<string>
            {
                "Total de turnos: 3",
                "Confirmados: 1 | Cancelados: 1 | Solicitados: 1",
                "Facturación estimada: $16.000"
            };
            exportador.Exportar("Reporte Resumido de Turnos", contenido);
        }
    }
}
