namespace Memento.Entidades
{
    public class Historial
    {
        Stack<Memento> historial;
        public Historial()
        {
            historial = new Stack<Memento>();
        }
        public void Guardar(Memento memento) => historial.Push(memento);
        public Memento Deshacer() => historial.Pop();
    }
}
