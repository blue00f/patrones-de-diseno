using BE;
using BLL;

namespace UI
{
    public partial class FrmUsuarios : Form
    {
        BLL_Usuario bll_usuario;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            bll_usuario = new();
            Mostrar(grillaUsuarios, bll_usuario.Consultar());
        }
        private void Mostrar(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDni.Text;
                if (dni.Length != 8) throw new Exception("Formato DNI incorrecto");

                string nombre = txtNombre.Text;
                if (nombre.Length == 0) throw new Exception("Nombre vacio");

                string apellido = txtApellido.Text;
                if (apellido.Length == 0) throw new Exception("Apellido vacio");

                string correo = txtCorreo.Text;
                if (correo.Length == 0) throw new Exception("Correo vacio");

                BE_Usuario u = new(dni, nombre, apellido, correo);
                bll_usuario.Agregar(u);
                MessageBox.Show("Usuario creado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarActivo_Click(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
    }
}
