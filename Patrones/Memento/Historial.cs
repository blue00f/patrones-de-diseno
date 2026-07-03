namespace Memento
{
    public class Historial
    {
        private Stack<MementoCelular> historial = new Stack<MementoCelular>();
        public void Guardar(MementoCelular memento) => historial.Push(memento);
        public MementoCelular Deshacer() => historial.Pop();
    }
}
