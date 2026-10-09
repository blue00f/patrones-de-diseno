namespace Visitor.Entidades
{
    public interface IVisitante
    {
        void Visitar(Consulta consulta);
        void Visitar(Estudio estudio);
        void Visitar(Medicamento medicamento);
    }
}
