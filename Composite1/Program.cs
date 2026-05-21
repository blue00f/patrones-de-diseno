using Composite;

public class Program
{
    public static void Main(string[] args)
    {
        Archivo doc = new Archivo("capaFisica.pdf", 100);
        Archivo img = new Archivo("modeloOsi.jpg", 120);
        Archivo bkpBd = new Archivo("bkp_negocio.sql", 400);
        Archivo queriesBd = new Archivo("pa_negocio.sql", 200);

        Carpeta raiz = new Carpeta("root");
        Carpeta baseDeDatos = new Carpeta("baseDeDatos");
        Carpeta redes = new Carpeta("redes");

        raiz.Agregar(baseDeDatos);
        raiz.Agregar(redes);

        baseDeDatos.Agregar(bkpBd);
        baseDeDatos.Agregar(queriesBd);
        redes.Agregar(doc);
        redes.Agregar(img);

        raiz.Mostrar();
    }
}