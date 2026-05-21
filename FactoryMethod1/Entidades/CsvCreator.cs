using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entidades
{
    public class CsvCreator : ExportadorCreator
    {
        public override Exportador CrearExportador() => new CsvExportador();
    }
}
