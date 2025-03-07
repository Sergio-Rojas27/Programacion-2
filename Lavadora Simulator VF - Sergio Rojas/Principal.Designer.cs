namespace Lavadora_Simulator_V2___Sergio_Rojas
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            label1 = new Label();
            BotonInicio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSalmon;
            label1.Font = new Font("Sitka Banner", 26.2499962F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 40);
            label1.Name = "label1";
            label1.Size = new Size(284, 50);
            label1.TabIndex = 0;
            label1.Text = "Lavadora Simulator";
            // 
            // BotonInicio
            // 
            BotonInicio.BackColor = Color.Salmon;
            BotonInicio.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonInicio.Location = new Point(530, 141);
            BotonInicio.Name = "BotonInicio";
            BotonInicio.Size = new Size(182, 107);
            BotonInicio.TabIndex = 1;
            BotonInicio.Text = "Iniciar Simulador";
            BotonInicio.UseVisualStyleBackColor = false;
            BotonInicio.Click += BotonInicio_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonInicio);
            Controls.Add(label1);
            Name = "Principal";
            Text = "Lavadora Simulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BotonInicio;
    }
}
