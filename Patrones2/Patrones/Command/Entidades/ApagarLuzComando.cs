namespace Command.Entidades
{
    public class ApagarLuzComando : IComando
    {
        private Luz luz;
        public ApagarLuzComando(Luz luz)
        {
            this.luz = luz;
        }
        public void Ejecutar() => luz.Apagar();
        public void Deshacer() => luz.Encender();

    }
}
