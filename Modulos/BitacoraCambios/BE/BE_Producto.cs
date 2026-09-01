namespace BE
{
    public class BE_Producto
    {
        public string CodProducto { get; set; }
        public string Nombre { get; set; }
        public int Existencia { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public BE_Producto(string codProducto, string nombre, int existencia, string descripcion)
        {
            CodProducto = codProducto;
            Nombre = nombre;
            Existencia = existencia;
            Descripcion = descripcion;
            Activo = true;
        }
        public BE_Producto(string codProducto, string nombre, int existencia, string descripcion, bool activo)
        {
            CodProducto = codProducto;
            Nombre = nombre;
            Existencia = existencia;
            Descripcion = descripcion;
            Activo = activo;
        }
        public BE_Producto(string codProducto)
        {
            CodProducto = codProducto;
        }
    }
}
