namespace Composite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            btnAgregarProducto = new Button();
            btnBorrar = new Button();
            btnAgregarCategoria = new Button();
            btnCalcularTotal = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(33, 59);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(231, 286);
            treeView1.TabIndex = 0;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(284, 59);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(119, 23);
            btnAgregarProducto.TabIndex = 1;
            btnAgregarProducto.Text = "Agregar producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(284, 117);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(119, 23);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Location = new Point(284, 88);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(119, 23);
            btnAgregarCategoria.TabIndex = 3;
            btnAgregarCategoria.Text = "Agregar categoría";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // btnCalcularTotal
            // 
            btnCalcularTotal.Location = new Point(284, 146);
            btnCalcularTotal.Name = "btnCalcularTotal";
            btnCalcularTotal.Size = new Size(119, 23);
            btnCalcularTotal.TabIndex = 4;
            btnCalcularTotal.Text = "Ver total";
            btnCalcularTotal.UseVisualStyleBackColor = true;
            btnCalcularTotal.Click += btnCalcularTotal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 385);
            Controls.Add(btnCalcularTotal);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregarProducto);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private Button btnAgregarProducto;
        private Button btnBorrar;
        private Button btnAgregarCategoria;
        private Button btnCalcularTotal;
    }
}
