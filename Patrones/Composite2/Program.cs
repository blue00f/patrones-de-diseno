using Composite2;

class Program
{
    static void Main(string[] args)
    {
        Producto hamburguesa = new Producto("Hamburguesa", 5000);
        Producto papas = new Producto("Papas Fritas", 2000);
        Producto gaseosa = new Producto("Gaseosa", 1500);
        Producto helado = new Producto("Helado", 2500);

        Combo comboSimple = new Combo("Combo Simple");
        Combo comboPremium = new Combo("Combo Premium");

        comboSimple.Agregar(hamburguesa);
        comboSimple.Agregar(papas);
        comboSimple.Agregar(gaseosa);

        comboPremium.Agregar(comboSimple);
        comboPremium.Agregar(helado);

        comboPremium.Mostrar();

        Console.ReadKey();
    }
}