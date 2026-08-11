namespace Iterator.Entidades
{
    public interface IIterador
    {
        void Primero();
        void Siguiente();
        bool HaySiguiente();
        Celular Actual();
    }
}
