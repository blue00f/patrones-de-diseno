namespace Bridge.Entidades
{
    public class ReporteDetallado : Reporte
    {
        public ReporteDetallado(IExportador exportador) : base(exportador) { }
        public override void Generar()
        {
            var contenido = new List<string>
            {
                "Turno #1 | Paul McCartney  | Dr. Fernández | Confirmado | $8.000",
                "Turno #2 | Michael Jackson | Dra. Gómez | Cancelado | $0",
                "Turno #3 | Gustavo Cerati  | Dr. Fernández | Solicitado | $8.000"
            };
            exportador.Exportar("Reporte Detallado de Turnos", contenido);
        }
    }
}
