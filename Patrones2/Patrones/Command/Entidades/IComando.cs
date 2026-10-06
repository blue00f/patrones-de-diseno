namespace Command.Entidades
{
    public interface IComando
    {
        void Ejecutar();
        void Deshacer();
    }
}
