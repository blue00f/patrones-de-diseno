namespace Iterator.Entidades
{
    public interface IColeccion
    {
        IIterator CrearIterador();
        IIterator CrearIteradorInverso();
    }
}
