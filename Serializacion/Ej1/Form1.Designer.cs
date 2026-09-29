namespace Ej1
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbxFormato = new ComboBox();
            btnSerializar = new Button();
            btnDeserializar = new Button();
            listArchivoSerializado = new ListBox();
            listArchivoDeserializado = new ListBox();
            label4 = new Label();
            label5 = new Label();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 58);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(185, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(185, 84);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(154, 23);
            txtEdad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 87);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 124);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo de serialización:";
            // 
            // cbxFormato
            // 
            cbxFormato.FormattingEnabled = true;
            cbxFormato.Location = new Point(185, 121);
            cbxFormato.Name = "cbxFormato";
            cbxFormato.Size = new Size(154, 23);
            cbxFormato.TabIndex = 5;
            // 
            // btnSerializar
            // 
            btnSerializar.Location = new Point(51, 163);
            btnSerializar.Name = "btnSerializar";
            btnSerializar.Size = new Size(101, 31);
            btnSerializar.TabIndex = 6;
            btnSerializar.Text = "Serializar";
            btnSerializar.UseVisualStyleBackColor = true;
            btnSerializar.Click += btnSerializar_Click;
            // 
            // btnDeserializar
            // 
            btnDeserializar.Location = new Point(185, 163);
            btnDeserializar.Name = "btnDeserializar";
            btnDeserializar.Size = new Size(101, 31);
            btnDeserializar.TabIndex = 7;
            btnDeserializar.Text = "Deserializar";
            btnDeserializar.UseVisualStyleBackColor = true;
            btnDeserializar.Click += btnDeserializar_Click;
            // 
            // listArchivoSerializado
            // 
            listArchivoSerializado.FormattingEnabled = true;
            listArchivoSerializado.Location = new Point(397, 58);
            listArchivoSerializado.Name = "listArchivoSerializado";
            listArchivoSerializado.Size = new Size(287, 214);
            listArchivoSerializado.TabIndex = 8;
            // 
            // listArchivoDeserializado
            // 
            listArchivoDeserializado.FormattingEnabled = true;
            listArchivoDeserializado.Location = new Point(713, 58);
            listArchivoDeserializado.Name = "listArchivoDeserializado";
            listArchivoDeserializado.Size = new Size(287, 214);
            listArchivoDeserializado.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 30);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 10;
            label4.Text = "Archivo serializado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(713, 30);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 11;
            label5.Text = "Archivo deserializado";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 9);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 12;
            label6.Text = "SERIALIZACIÓN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 295);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listArchivoDeserializado);
            Controls.Add(listArchivoSerializado);
            Controls.Add(btnDeserializar);
            Controls.Add(btnSerializar);
            Controls.Add(cbxFormato);
            Controls.Add(label3);
            Controls.Add(txtEdad);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label label2;
        private Label label3;
        private ComboBox cbxFormato;
        private Button btnSerializar;
        private Button btnDeserializar;
        private ListBox listArchivoSerializado;
        private ListBox listArchivoDeserializado;
        private Label label4;
        private Label label5;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Label label6;
    }
}
