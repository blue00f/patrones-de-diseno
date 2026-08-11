using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class PanelWeb : ISuscriptor
    {
        public string Dominio { get; set; }
        public PanelWeb(string dominio)
        {
            Dominio = dominio;
        }
        public void Actualizar(decimal temperatura)
        {
            Console.WriteLine($"Mostrando temperatura {temperatura} en la página {this.Dominio}");
        }
    }
}
