namespace Lavadora_Simulator_V2___Sergio_Rojas
{
    partial class Simulador
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulador));
            pictureBox1 = new PictureBox();
            BotonEncendido = new Button();
            CicloSeleccion = new ComboBox();
            BotonIniciar = new Button();
            LavadoraAnimacion = new PictureBox();
            ProgesoDeLavado = new ProgressBar();
            GatoBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            BotonApagado = new Button();
            LabelCiclo = new Label();
            labelEstado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LavadoraAnimacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GatoBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 493);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BotonEncendido
            // 
            BotonEncendido.BackColor = Color.Lime;
            BotonEncendido.BackgroundImage = (Image)resources.GetObject("BotonEncendido.BackgroundImage");
            BotonEncendido.BackgroundImageLayout = ImageLayout.Zoom;
            BotonEncendido.ForeColor = Color.Lime;
            BotonEncendido.Location = new Point(414, 138);
            BotonEncendido.Name = "BotonEncendido";
            BotonEncendido.Size = new Size(29, 28);
            BotonEncendido.TabIndex = 1;
            BotonEncendido.UseVisualStyleBackColor = false;
            BotonEncendido.Click += BotonEncendido_Click;
            // 
            // CicloSeleccion
            // 
            CicloSeleccion.Font = new Font("Segoe UI", 10F);
            CicloSeleccion.FormattingEnabled = true;
            CicloSeleccion.Items.AddRange(new object[] { "Lavado Rapido (15 segundos)", "Lavado Normal (30 segundos)", "Lavado Intensivo (60 segundos)", "Solo Enjuague (10 segundos)", "Solo Centrifugado (5 segundos)" });
            CicloSeleccion.Location = new Point(214, 138);
            CicloSeleccion.Name = "CicloSeleccion";
            CicloSeleccion.Size = new Size(192, 25);
            CicloSeleccion.TabIndex = 2;
            CicloSeleccion.Text = "Ciclo de Lavado";
            CicloSeleccion.SelectedIndexChanged += CicloSeleccion_SelectedIndexChanged;
            // 
            // BotonIniciar
            // 
            BotonIniciar.Font = new Font("Segoe UI", 16F);
            BotonIniciar.Location = new Point(296, 237);
            BotonIniciar.Name = "BotonIniciar";
            BotonIniciar.Size = new Size(104, 39);
            BotonIniciar.TabIndex = 3;
            BotonIniciar.Text = "Iniciar";
            BotonIniciar.UseVisualStyleBackColor = true;
            BotonIniciar.Click += BotonIniciar_Click;
            // 
            // LavadoraAnimacion
            // 
            LavadoraAnimacion.Image = (Image)resources.GetObject("LavadoraAnimacion.Image");
            LavadoraAnimacion.Location = new Point(203, 81);
            LavadoraAnimacion.Name = "LavadoraAnimacion";
            LavadoraAnimacion.Size = new Size(350, 313);
            LavadoraAnimacion.SizeMode = PictureBoxSizeMode.StretchImage;
            LavadoraAnimacion.TabIndex = 4;
            LavadoraAnimacion.TabStop = false;
            // 
            // ProgesoDeLavado
            // 
            ProgesoDeLavado.Enabled = false;
            ProgesoDeLavado.Location = new Point(230, 400);
            ProgesoDeLavado.Maximum = 60;
            ProgesoDeLavado.Name = "ProgesoDeLavado";
            ProgesoDeLavado.Size = new Size(281, 23);
            ProgesoDeLavado.TabIndex = 5;
            ProgesoDeLavado.Click += ProgesoDeLavado_Click;
            // 
            // GatoBox
            // 
            GatoBox.Image = (Image)resources.GetObject("GatoBox.Image");
            GatoBox.Location = new Point(559, 338);
            GatoBox.Name = "GatoBox";
            GatoBox.Size = new Size(167, 100);
            GatoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            GatoBox.TabIndex = 6;
            GatoBox.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 7;
            label1.Text = "Estado de la Lavadora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 32);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 8;
            label2.Text = "Lavadora Apagada";
            // 
            // BotonApagado
            // 
            BotonApagado.BackColor = Color.Red;
            BotonApagado.BackgroundImage = (Image)resources.GetObject("BotonApagado.BackgroundImage");
            BotonApagado.BackgroundImageLayout = ImageLayout.Zoom;
            BotonApagado.Location = new Point(445, 138);
            BotonApagado.Name = "BotonApagado";
            BotonApagado.Size = new Size(29, 28);
            BotonApagado.TabIndex = 9;
            BotonApagado.UseVisualStyleBackColor = false;
            BotonApagado.Click += BotonApagado_Click;
            // 
            // LabelCiclo
            // 
            LabelCiclo.AutoSize = true;
            LabelCiclo.Location = new Point(19, 50);
            LabelCiclo.Name = "LabelCiclo";
            LabelCiclo.Size = new Size(139, 15);
            LabelCiclo.TabIndex = 10;
            LabelCiclo.Text = "Ciclo de lavado: ninguno";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(19, 65);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(152, 15);
            labelEstado.TabIndex = 11;
            labelEstado.Text = "La lavadora esta: esperando";
            // 
            // Simulador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEstado);
            Controls.Add(LabelCiclo);
            Controls.Add(BotonApagado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BotonIniciar);
            Controls.Add(CicloSeleccion);
            Controls.Add(BotonEncendido);
            Controls.Add(pictureBox1);
            Controls.Add(LavadoraAnimacion);
            Controls.Add(ProgesoDeLavado);
            Controls.Add(GatoBox);
            Name = "Simulador";
            Text = "Simulador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LavadoraAnimacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)GatoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BotonEncendido;
        private ComboBox CicloSeleccion;
        private Button BotonIniciar;
        private PictureBox LavadoraAnimacion;
        private ProgressBar ProgesoDeLavado;
        private PictureBox GatoBox;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Button BotonApagado;
        private Label LabelCiclo;
        private Label labelEstado;
    }
}