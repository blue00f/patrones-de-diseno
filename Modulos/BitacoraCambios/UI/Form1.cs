using BE;
using BLL;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI
{
    public partial class Form1 : Form
    {
        BLL_Producto bll_producto;
        BLL_Producto_C bll_producto_c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bll_producto = new();
            bll_producto_c = new();
            foreach (var control in Controls)
            {
                if (control is DataGridView grilla)
                {
                    grilla.MultiSelect = false;
                    grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            dtpFechaInicio.MaxDate = DateTime.Today;
            dtpFechaFin.MaxDate = DateTime.Today;
            Mostrar(grillaProductos, bll_producto.ConsultarGrilla());
            Mostrar(grillaProductosCopia, bll_producto_c.ConsultarActivos());

            grillaProductosCopia.Columns[0].Visible = false;
        }
        private void Mostrar(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string codProducto = Interaction.InputBox("Código de producto:", "Datos de Producto");
                if (codProducto.Length == 0) throw new Exception("Código vacío");
                string nombre = Interaction.InputBox("Nombre:", "Datos de Producto");
                if (nombre.Length == 0) throw new Exception("Nombre vacío");
                string strExistencia = Interaction.InputBox("Número de existencia:", "Datos de Producto");
                if (!int.TryParse(strExistencia, out int existencia)) throw new Exception("Existencia no numérica");
                string descripcion = Interaction.InputBox("Descripción:", "Datos de Producto");
                if (descripcion.Length == 0) throw new Exception("Descripción vacía");

                BE_Producto producto = new BE_Producto(codProducto, nombre, existencia, descripcion);
                bll_producto.Agregar(producto);
                Mostrar(grillaProductos, bll_producto.ConsultarGrilla());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var prodAux = new BE_Producto(grillaProductos.SelectedRows[0].Cells[0].Value.ToString());
                bll_producto.Borrar(prodAux);
                Mostrar(grillaProductos, bll_producto.ConsultarGrilla());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Producto prodViejo = bll_producto.ConsultarPorId(new BE_Producto(grillaProductos.SelectedRows[0].Cells[0].Value.ToString()));
                string nombre = Interaction.InputBox("Nombre:", "Modificación del Producto", prodViejo.Nombre);
                if (nombre.Length == 0) throw new Exception("Nombre vacío");
                string strExistencia = Interaction.InputBox("Número de existencia:", "Modificación del Producto", prodViejo.Existencia.ToString());
                if (!int.TryParse(strExistencia, out int existencia)) throw new Exception("Existencia no numérica");
                string descripcion = Interaction.InputBox("Descripción:", "Modificación del Producto", prodViejo.Descripcion);
                if (descripcion.Length == 0) throw new Exception("Descripción vacía");

                bool huboCambios = nombre != prodViejo.Nombre || existencia != prodViejo.Existencia || descripcion != prodViejo.Descripcion;
                if (!huboCambios) throw new Exception("No se detectaron cambios");

                BE_Producto producto = new BE_Producto(prodViejo.CodProducto, nombre, existencia, descripcion);
                bll_producto.Modificar(producto);
                Mostrar(grillaProductos, bll_producto.ConsultarGrilla());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                string codProd = txtCodProd.Text;
                string nombre = txtNombre.Text;
                DateTime fechaInicio = dtpFechaInicio.Value.Date;
                DateTime fechaFin = dtpFechaFin.Value.Date.AddDays(1).AddTicks(-1);
                if (fechaInicio > fechaFin) throw new Exception("La fecha de inicio no puede ser mayor a la fecha de fin");
                Mostrar(grillaProductosCopia, bll_producto_c.ConsultarFiltrado(nombre.ToUpper(), codProd.ToUpper(), fechaInicio, fechaFin));
                if (grillaProductosCopia.Rows.Count > 0) grillaProductosCopia.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaProductosCopia.Rows.Count == 0) throw new Exception("No hay filas en la grilla!");
                BE_Producto_C producto = new BE_Producto_C(int.Parse(grillaProductosCopia.SelectedRows[0].Cells[0].Value.ToString()));
                bll_producto_c.Activar(producto);

                Mostrar(grillaProductos, bll_producto.ConsultarGrilla());
                btnAplicar_Click(null, null);
                if (grillaProductosCopia.Rows.Count > 0) grillaProductosCopia.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCodProd.Clear();
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Value = DateTime.Today;
            Mostrar(grillaProductosCopia, bll_producto_c.ConsultarActivos());
        }
    }
}
