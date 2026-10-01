namespace Flyweight3.Entidades
{
    public class Tripulante
    {
        private string Nombre { get; set; }
        private int Id { get; set; }
        private string Rango { get; set; }
        private IEspecie Especie { get; set; }

        public Tripulante(string nombre, int id, string rango, IEspecie especie)
        {
            this.Nombre = nombre;
            this.Id = id;
            this.Rango = rango;
            this.Especie = especie;
        }
        public void MostrarInfo() => Especie.MostrarInfo(this.Nombre, this.Id, this.Rango);
    }
}
