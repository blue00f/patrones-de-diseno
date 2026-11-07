using System.Text.Json;
using System.Xml.Serialization;
using Newtonsoft.Json;
namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxFormato.Items.AddRange("XML", "JSON");
            cbxFormato.SelectedIndex = 0;
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            try
            {
                listArchivoDeserializado.Items.Clear();
                Persona p = new Persona();
                p.Nombre = txtNombre.Text;
                p.Edad = Convert.ToInt16(txtEdad.Text);

                saveFileDialog.Filter = $"{cbxFormato.SelectedItem} Files|*.{cbxFormato.SelectedItem.ToString().ToLower()}";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string formato = cbxFormato.SelectedItem.ToString();
                    switch (formato)
                    {
                        case "XML":
                            SerializarXml(p, saveFileDialog.FileName);
                            MostrarArchivoSerializado(saveFileDialog.FileName);
                            break;
                        case "JSON":
                            SerializarJsonModerno(p, saveFileDialog.FileName);
                            MostrarArchivoSerializado(saveFileDialog.FileName);
                            break;
                    }
                    MessageBox.Show($"Persona serializada en formato {formato} con éxito", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL SERIALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = $"{cbxFormato.SelectedItem} Files|*.{cbxFormato.SelectedItem.ToString().ToLower()}";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string formato = cbxFormato.SelectedItem.ToString();
                    Persona p = null;
                    listArchivoSerializado.Items.Clear();
                    switch (formato)
                    {
                        case "XML":
                            p = DeserializarXml(openFileDialog.FileName);
                            break;
                        case "JSON":
                            p = DeserializarJsonModerno(openFileDialog.FileName);
                            break;
                    }
                    MostrarDatosDeserializados(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL DESERIALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SerializarXml(Persona persona, string path)
        {
            using(FileStream fs = new FileStream(path, FileMode.Create))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                serializador.Serialize(fs, persona);
            }
        }
        private void SerializarJson(Persona persona, string path)
        {
            string jsonString = JsonConvert.SerializeObject(persona, Formatting.Indented);
            File.WriteAllText(path, jsonString);
        }
        private void SerializarJsonModerno(Persona persona, string path)
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = System.Text.Json.JsonSerializer.Serialize(persona, opciones);
            File.WriteAllText(path, jsonString);
        }
        private Persona DeserializarXml(string path)
        {
            using(FileStream fs = new FileStream(path, FileMode.Open))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                return (Persona)serializador.Deserialize(fs);
            }
        }
        private Persona DeserializarJson(string path)
        {
            string jsonString = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Persona>(jsonString);
        }
        private Persona DeserializarJsonModerno(string path)
        {
            string jsonString = File.ReadAllText(path);
            return System.Text.Json.JsonSerializer.Deserialize<Persona>(jsonString);
        }
        private void MostrarArchivoSerializado(string path)
        {
            listArchivoSerializado.Items.Clear();
            string[] lineas = File.ReadAllLines(path);
            foreach (string linea in lineas)
            {
                listArchivoSerializado.Items.Add(linea);
            }
        }
        private void MostrarDatosDeserializados(Persona persona)
        {
            listArchivoDeserializado.Items.Clear();
            listArchivoDeserializado.Items.Add($"Nombre: {persona.Nombre}");
            listArchivoDeserializado.Items.Add($"Edad: {persona.Edad}");
        }
    }
}
