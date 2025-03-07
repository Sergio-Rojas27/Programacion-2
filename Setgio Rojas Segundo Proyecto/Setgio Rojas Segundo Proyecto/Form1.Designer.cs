namespace Setgio_Rojas_Segundo_Proyecto
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
            botonAgregar = new Button();
            Titulo = new Label();
            botonEditar = new Button();
            botonEliminar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // botonAgregar
            // 
            botonAgregar.BackColor = Color.Yellow;
            botonAgregar.Font = new Font("Segoe UI", 15F);
            botonAgregar.Location = new Point(642, 92);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(106, 49);
            botonAgregar.TabIndex = 0;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = false;
            botonAgregar.Click += button1_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BorderStyle = BorderStyle.FixedSingle;
            Titulo.Font = new Font("Segoe UI Black", 19F);
            Titulo.Location = new Point(38, 22);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(336, 38);
            Titulo.TabIndex = 1;
            Titulo.Text = "Sistema de Registro Civil";
            // 
            // botonEditar
            // 
            botonEditar.BackColor = Color.DodgerBlue;
            botonEditar.Font = new Font("Segoe UI", 15F);
            botonEditar.Location = new Point(642, 166);
            botonEditar.Name = "botonEditar";
            botonEditar.Size = new Size(106, 49);
            botonEditar.TabIndex = 2;
            botonEditar.Text = "Editar";
            botonEditar.UseVisualStyleBackColor = false;
            botonEditar.Click += button2_Click;
            // 
            // botonEliminar
            // 
            botonEliminar.BackColor = Color.Red;
            botonEliminar.Font = new Font("Segoe UI", 15F);
            botonEliminar.Location = new Point(642, 236);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(106, 49);
            botonEliminar.TabIndex = 3;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = false;
            botonEliminar.Click += botonEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(580, 339);
            dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(762, 450);
            Controls.Add(dataGridView1);
            Controls.Add(botonEliminar);
            Controls.Add(botonEditar);
            Controls.Add(Titulo);
            Controls.Add(botonAgregar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonAgregar;
        private Label Titulo;
        private Button botonEditar;
        private Button botonEliminar;
        private DataGridView dataGridView1;
    }
}
