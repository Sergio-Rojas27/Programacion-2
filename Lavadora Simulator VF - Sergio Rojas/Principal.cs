namespace Lavadora_Simulator_V2___Sergio_Rojas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            Form Simulador = new Simulador();
            Simulador.Show();
        }
    }
}
