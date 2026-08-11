using Composite.Entidades;
using Microsoft.VisualBasic;

namespace Composite
{
    public partial class Form1 : Form
    {
        Categoria raiz;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            raiz = new Categoria("Catálogo");
            TreeNode nodoRaiz = new TreeNode(raiz.Nombre);
            nodoRaiz.Tag = raiz;

            treeView1.Nodes.Add(nodoRaiz);
            treeView1.ExpandAll();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode nodoSeleccionado = treeView1.SelectedNode;
                if (nodoSeleccionado == null) throw new Exception("No hay nodo seleccionado");

                Categoria catPadre = nodoSeleccionado.Tag as Categoria;
                if (catPadre == null) throw new Exception("Solo se puede agregar a una categoría");

                string nombre = Interaction.InputBox("nombre", "nombre del producto");
                if (nombre.Length == 0) throw new Exception("Nombre vacío");
                string strPrecio = Interaction.InputBox("precio", "precio del producto");
                if (!decimal.TryParse(strPrecio, out decimal precio)) throw new Exception("ingrese precio numérico");

                Producto p = new Producto(nombre, precio);
                TreeNode n = new TreeNode($"{p.Nombre} ${p.Precio:N2}");
                catPadre.Agregar(p);

                n.Tag = p;
                treeView1.Nodes.Add(n);
                treeView1.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode nodoSeleccionado = treeView1.SelectedNode;
                if (nodoSeleccionado == null) throw new Exception("No hay nodo seleccionado");

                Categoria catPadre = nodoSeleccionado.Tag as Categoria;
                if (catPadre == null) throw new Exception("Solo podés agregar dentro de una categoría");

                string nombre = Interaction.InputBox("nombre", "nombre de la categoría");
                if (nombre.Length == 0) throw new Exception("Nombre vacío");

                Categoria c = new Categoria(nombre);
                TreeNode n = new TreeNode(c.Nombre);
                catPadre.Agregar(c);

                n.Tag = c;
                treeView1.Nodes.Add(n);
                treeView1.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode nodoSeleccionado = treeView1.SelectedNode;
                if (nodoSeleccionado == null) throw new Exception("No hay nodo seleccionado");
                if (nodoSeleccionado.Parent == null) throw new Exception("No se puede borrar el catalogo raíz");

                Categoria catPadre = nodoSeleccionado.Parent.Tag as Categoria;
                IElemento elem = nodoSeleccionado.Tag as IElemento;
                catPadre.Borrar(elem);
                nodoSeleccionado.Remove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode nodoSeleccionado = treeView1.SelectedNode;
                if (nodoSeleccionado == null) throw new Exception("Seleccioná un nodo");
                IElemento elemento = nodoSeleccionado.Tag as IElemento;
                MessageBox.Show($"Total de {elemento.Nombre}: ${elemento.CalcularTotal():N2}", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
