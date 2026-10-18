namespace Ej2_Reflection
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
            btnDetectarClases = new Button();
            btnDetectarMetodos = new Button();
            btnDetectarParametros = new Button();
            btnCrearClase = new Button();
            btnInstanciar = new Button();
            SuspendLayout();
            // 
            // btnDetectarClases
            // 
            btnDetectarClases.Location = new Point(43, 34);
            btnDetectarClases.Name = "btnDetectarClases";
            btnDetectarClases.Size = new Size(136, 36);
            btnDetectarClases.TabIndex = 0;
            btnDetectarClases.Text = "Detectar clases";
            btnDetectarClases.UseVisualStyleBackColor = true;
            btnDetectarClases.Click += btnDetectarClases_Click;
            // 
            // btnDetectarMetodos
            // 
            btnDetectarMetodos.Location = new Point(185, 34);
            btnDetectarMetodos.Name = "btnDetectarMetodos";
            btnDetectarMetodos.Size = new Size(136, 36);
            btnDetectarMetodos.TabIndex = 1;
            btnDetectarMetodos.Text = "Detectar métodos";
            btnDetectarMetodos.UseVisualStyleBackColor = true;
            btnDetectarMetodos.Click += btnDetectarMetodos_Click;
            // 
            // btnDetectarParametros
            // 
            btnDetectarParametros.Location = new Point(327, 34);
            btnDetectarParametros.Name = "btnDetectarParametros";
            btnDetectarParametros.Size = new Size(136, 36);
            btnDetectarParametros.TabIndex = 2;
            btnDetectarParametros.Text = "Detectar parámetros";
            btnDetectarParametros.UseVisualStyleBackColor = true;
            btnDetectarParametros.Click += btnDetectarParametros_Click;
            // 
            // btnCrearClase
            // 
            btnCrearClase.Location = new Point(43, 76);
            btnCrearClase.Name = "btnCrearClase";
            btnCrearClase.Size = new Size(136, 36);
            btnCrearClase.TabIndex = 3;
            btnCrearClase.Text = "Crear clase";
            btnCrearClase.UseVisualStyleBackColor = true;
            btnCrearClase.Click += btnCrearClase_Click;
            // 
            // btnInstanciar
            // 
            btnInstanciar.Location = new Point(185, 76);
            btnInstanciar.Name = "btnInstanciar";
            btnInstanciar.Size = new Size(136, 36);
            btnInstanciar.TabIndex = 4;
            btnInstanciar.Text = "Intanciar e invocar";
            btnInstanciar.UseVisualStyleBackColor = true;
            btnInstanciar.Click += btnInstanciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 141);
            Controls.Add(btnInstanciar);
            Controls.Add(btnCrearClase);
            Controls.Add(btnDetectarParametros);
            Controls.Add(btnDetectarMetodos);
            Controls.Add(btnDetectarClases);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDetectarClases;
        private Button btnDetectarMetodos;
        private Button btnDetectarParametros;
        private Button btnCrearClase;
        private Button btnInstanciar;
    }
}
