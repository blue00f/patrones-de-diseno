using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entidades
{
    public class CsvExportador : Exportador
    {
        public override void ExportarReporte() => MessageBox.Show("Exportando a CSV...");
    }
}
