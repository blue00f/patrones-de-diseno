namespace UI
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
            grillaProductos = new DataGridView();
            label1 = new Label();
            btnAgregarProducto = new Button();
            btnBorrarProducto = new Button();
            btnModificarProducto = new Button();
            btnActivar = new Button();
            btnLimpiar = new Button();
            btnAplicar = new Button();
            label2 = new Label();
            grillaProductosCopia = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtCodProd = new TextBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)grillaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaProductosCopia).BeginInit();
            SuspendLayout();
            // 
            // grillaProductos
            // 
            grillaProductos.AllowUserToAddRows = false;
            grillaProductos.AllowUserToDeleteRows = false;
            grillaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaProductos.Location = new Point(27, 47);
            grillaProductos.Name = "grillaProductos";
            grillaProductos.ReadOnly = true;
            grillaProductos.Size = new Size(607, 217);
            grillaProductos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 1;
            label1.Text = "Productos";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(27, 270);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(112, 35);
            btnAgregarProducto.TabIndex = 2;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.Location = new Point(155, 270);
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.Size = new Size(112, 35);
            btnBorrarProducto.TabIndex = 3;
            btnBorrarProducto.Text = "Borrar";
            btnBorrarProducto.UseVisualStyleBackColor = true;
            btnBorrarProducto.Click += btnBorrarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(284, 270);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(112, 35);
            btnModificarProducto.TabIndex = 4;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnActivar
            // 
            btnActivar.Location = new Point(932, 332);
            btnActivar.Name = "btnActivar";
            btnActivar.Size = new Size(230, 38);
            btnActivar.TabIndex = 9;
            btnActivar.Text = "Activar";
            btnActivar.UseVisualStyleBackColor = true;
            btnActivar.Click += btnActivar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1050, 298);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 28);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(932, 298);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(112, 28);
            btnAplicar.TabIndex = 7;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(680, 19);
            label2.Name = "label2";
            label2.Size = new Size(348, 25);
            label2.TabIndex = 6;
            label2.Text = "Bitácora de cambios - Producto Copia";
            // 
            // grillaProductosCopia
            // 
            grillaProductosCopia.AllowUserToAddRows = false;
            grillaProductosCopia.AllowUserToDeleteRows = false;
            grillaProductosCopia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaProductosCopia.Location = new Point(680, 47);
            grillaProductosCopia.Name = "grillaProductosCopia";
            grillaProductosCopia.ReadOnly = true;
            grillaProductosCopia.Size = new Size(607, 217);
            grillaProductosCopia.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(682, 336);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 10;
            label3.Text = "Código Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(682, 371);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(682, 404);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "Fecha Fin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(682, 301);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 13;
            label6.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(786, 298);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(112, 23);
            txtNombre.TabIndex = 14;
            // 
            // txtCodProd
            // 
            txtCodProd.Location = new Point(786, 333);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.Size = new Size(112, 23);
            txtCodProd.TabIndex = 15;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(786, 365);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(112, 23);
            dtpFechaInicio.TabIndex = 16;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(786, 398);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(112, 23);
            dtpFechaFin.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 438);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(txtCodProd);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnActivar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAplicar);
            Controls.Add(label2);
            Controls.Add(grillaProductosCopia);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnBorrarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(label1);
            Controls.Add(grillaProductos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaProductosCopia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaProductos;
        private Label label1;
        private Button btnAgregarProducto;
        private Button btnBorrarProducto;
        private Button btnModificarProducto;
        private Button btnActivar;
        private Button btnLimpiar;
        private Button btnAplicar;
        private Label label2;
        private DataGridView grillaProductosCopia;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtCodProd;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
    }
}
