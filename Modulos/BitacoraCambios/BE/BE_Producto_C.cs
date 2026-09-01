namespace BE
{
    public class BE_Producto_C
    {
        public int Id { get; set; }
        public string CodProducto { get; set; }
        public string Nombre { get; set; }
        public int Existencia { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoProducto { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Activo { get; set; }
        public BE_Producto_C(int id, string codProducto, string nombre, int existencia, string descripcion, bool estadoProducto, DateTime fechaHora, bool activo)
        {
            Id = id;
            CodProducto = codProducto;
            Nombre = nombre;
            Existencia = existencia;
            Descripcion = descripcion;
            EstadoProducto = estadoProducto;
            FechaHora = fechaHora;
            Activo = activo;
        }
        public BE_Producto_C(int id)
        {
            Id = id;
        }
    }
}
