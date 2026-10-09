namespace Visitor.Entidades
{
    public class ImpresorDetalle : IVisitante
    {
        public void Visitar(Consulta consulta)
        {
            Console.WriteLine($"[Consulta] {consulta.Especialidad} - Honorarios: ${consulta.Honorarios:N2}");
        }
        public void Visitar(Estudio estudio)
        {
            string ayuno = estudio.RequiereAyuno ? " (requiere ayuno)" : "";
            Console.WriteLine($"[Estudio] {estudio.Nombre}{ayuno} - ${estudio.Precio:N2}");
        }
        public void Visitar(Medicamento medicamento)
        {
            Console.WriteLine($"[Medicamento] {medicamento.Nombre} x{medicamento.Cantidad} - ${medicamento.PrecioUnitario:N2} c/u");
        }
    }
}
