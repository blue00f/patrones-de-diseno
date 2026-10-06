namespace Command.Entidades
{
    public class EncenderLuzComando : IComando
    {
        private Luz luz;
        public EncenderLuzComando(Luz luz)
        {
            this.luz = luz;
        }
        public void Ejecutar() => luz.Encender();
        public void Deshacer() => luz.Apagar();

    }
}
