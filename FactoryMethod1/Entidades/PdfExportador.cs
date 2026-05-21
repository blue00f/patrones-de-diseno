using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entidades
{
    public class PdfExportador : Exportador
    {
        public override void ExportarReporte() => MessageBox.Show("Exportando a PDF...");
    }
}
