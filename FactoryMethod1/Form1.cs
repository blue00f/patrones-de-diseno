using FactoryMethod.Entidades;

namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[]
            {
                "PDF",
                "Excel",
                "CSV"
            });
            comboBox1.SelectedIndex = 0;
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportadorCreator creator;
            if (comboBox1.Text == "PDF")
            {
                creator = new PdfCreator();
            }
            else if (comboBox1.Text == "Excel")
            {
                creator = new ExcelCreator();
            }
            else
            {
                creator = new CsvCreator();
            }
            Exportador exportador = creator.CrearExportador();
            exportador.ExportarReporte();
        }

    }
}
