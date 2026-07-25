namespace UI
{
    partial class FrmUsuarios
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
            grillaUsuarios = new DataGridView();
            btnAgregar = new Button();
            btnDesbloquear = new Button();
            btnCambiarActivo = new Button();
            btnAplicar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // grillaUsuarios
            // 
            grillaUsuarios.AllowUserToAddRows = false;
            grillaUsuarios.AllowUserToDeleteRows = false;
            grillaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaUsuarios.Location = new Point(80, 57);
            grillaUsuarios.Name = "grillaUsuarios";
            grillaUsuarios.ReadOnly = true;
            grillaUsuarios.Size = new Size(422, 216);
            grillaUsuarios.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(521, 57);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(158, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnDesbloquear
            // 
            btnDesbloquear.Location = new Point(521, 86);
            btnDesbloquear.Name = "btnDesbloquear";
            btnDesbloquear.Size = new Size(158, 23);
            btnDesbloquear.TabIndex = 2;
            btnDesbloquear.Text = "Desbloquear";
            btnDesbloquear.UseVisualStyleBackColor = true;
            btnDesbloquear.Click += btnDesbloquear_Click;
            // 
            // btnCambiarActivo
            // 
            btnCambiarActivo.Location = new Point(521, 115);
            btnCambiarActivo.Name = "btnCambiarActivo";
            btnCambiarActivo.Size = new Size(158, 23);
            btnCambiarActivo.TabIndex = 3;
            btnCambiarActivo.Text = "Activar/Desactivar";
            btnCambiarActivo.UseVisualStyleBackColor = true;
            btnCambiarActivo.Click += btnCambiarActivo_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(521, 144);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(158, 23);
            btnAplicar.TabIndex = 4;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(521, 173);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(158, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(521, 250);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(158, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 305);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 7;
            label1.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(145, 302);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(152, 23);
            txtDni.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 331);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 23);
            txtNombre.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 334);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(145, 360);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(152, 23);
            txtApellido.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 363);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 11;
            label3.Text = "Apellido";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(145, 389);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(152, 23);
            txtCorreo.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 392);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 13;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 29);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 15;
            label5.Text = "USUARIOS";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 430);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtDni);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(btnAplicar);
            Controls.Add(btnCambiarActivo);
            Controls.Add(btnDesbloquear);
            Controls.Add(btnAgregar);
            Controls.Add(grillaUsuarios);
            Name = "FrmUsuarios";
            Text = "Gestión de Usuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)grillaUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaUsuarios;
        private Button btnAgregar;
        private Button btnDesbloquear;
        private Button btnCambiarActivo;
        private Button btnAplicar;
        private Button btnCancelar;
        private Button btnSalir;
        private Label label1;
        private TextBox txtDni;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtCorreo;
        private Label label4;
        private Label label5;
    }
}
