namespace Iterator.Entidades
{
    public interface IIterator
    {
        void Primero();
        void Siguiente();
        bool HaySiguiente();
        Empleado Actual();
    }
}
