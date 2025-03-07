namespace Setgio_Rojas_Segundo_Proyecto
{
    partial class Agregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textCedula = new TextBox();
            comboSexo = new ComboBox();
            comboEstadoCivil = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            botonGuardar = new Button();
            botonCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(124, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 39);
            label1.TabIndex = 0;
            label1.Text = "Agregar/Editar Datos";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(177, 89);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(227, 23);
            textNombre.TabIndex = 1;
            textNombre.TextChanged += textBox1_TextChanged;
            textNombre.KeyPress += textNombre_KeyPress;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(177, 118);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(227, 23);
            textApellido.TabIndex = 2;
            textApellido.TextChanged += textApellido_TextChanged;
            textApellido.KeyPress += textApellido_KeyPress;
            // 
            // textCedula
            // 
            textCedula.Location = new Point(177, 149);
            textCedula.Name = "textCedula";
            textCedula.Size = new Size(227, 23);
            textCedula.TabIndex = 3;
            textCedula.TextChanged += textCedula_TextChanged;
            textCedula.KeyPress += textCedula_KeyPress;
            // 
            // comboSexo
            // 
            comboSexo.BackColor = SystemColors.InactiveBorder;
            comboSexo.FormattingEnabled = true;
            comboSexo.Items.AddRange(new object[] { "Hombre", "Mujer" });
            comboSexo.Location = new Point(177, 178);
            comboSexo.Name = "comboSexo";
            comboSexo.Size = new Size(211, 23);
            comboSexo.TabIndex = 4;
            comboSexo.SelectedIndexChanged += comboSexo_SelectedIndexChanged;
            // 
            // comboEstadoCivil
            // 
            comboEstadoCivil.BackColor = SystemColors.InactiveBorder;
            comboEstadoCivil.FormattingEnabled = true;
            comboEstadoCivil.Items.AddRange(new object[] { "Soltero", "Casado" });
            comboEstadoCivil.Location = new Point(177, 207);
            comboEstadoCivil.Name = "comboEstadoCivil";
            comboEstadoCivil.Size = new Size(211, 23);
            comboEstadoCivil.TabIndex = 5;
            comboEstadoCivil.SelectedIndexChanged += comboEstadoCivil_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(70, 89);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(70, 207);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 8;
            label4.Text = "Estado Civil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(70, 178);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 9;
            label5.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(70, 149);
            label6.Name = "label6";
            label6.Size = new Size(60, 23);
            label6.TabIndex = 10;
            label6.Text = "Cedula";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLight;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(70, 118);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 11;
            label7.Text = "Apelido";
            // 
            // botonGuardar
            // 
            botonGuardar.BackColor = Color.Lime;
            botonGuardar.Font = new Font("Segoe UI", 15F);
            botonGuardar.Location = new Point(131, 262);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(100, 47);
            botonGuardar.TabIndex = 12;
            botonGuardar.Text = "Guardar";
            botonGuardar.UseVisualStyleBackColor = false;
            botonGuardar.Click += button1_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.BackColor = Color.Red;
            botonCancelar.Font = new Font("Segoe UI", 15F);
            botonCancelar.Location = new Point(261, 262);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(98, 47);
            botonCancelar.TabIndex = 13;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = false;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(522, 334);
            Controls.Add(botonCancelar);
            Controls.Add(botonGuardar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(comboEstadoCivil);
            Controls.Add(comboSexo);
            Controls.Add(textCedula);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(label1);
            Name = "Agregar";
            Text = "Agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textCedula;
        private ComboBox comboSexo;
        private ComboBox comboEstadoCivil;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button botonGuardar;
        private Button botonCancelar;
    }
}