using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entidades
{
    public class PdfCreator : ExportadorCreator
    {
        public override Exportador CrearExportador() => new PdfExportador();
    }
}
