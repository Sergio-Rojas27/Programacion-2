namespace Setgio_Rojas_Segundo_Proyecto
{
    public partial class Form1 : Form
    {
        private List<Persona> inventario = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = inventario;
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Cedula { get; set; }
            public string Sexo { get; set; }
            public string Estado_Civil { get; set; }
        }
        Persona persona = new Persona();




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una persona");
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                Persona personaSeleccionada = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
                Agregar formEditar = new Agregar();
                formEditar.persona = personaSeleccionada;

                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    ActualizarDataGridView();
                }

                else
                {
                    MessageBox.Show("Seleccione una persona");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar formAgregar = new Agregar();
            if (formAgregar.ShowDialog() == DialogResult.OK)
            {
                inventario.Add(formAgregar.persona);
                ActualizarDataGridView();
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Persona personaSeleccionada = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
                inventario.Remove(personaSeleccionada);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Seleccione una persona");
            }
        }
    }
}
