using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setgio_Rojas_Segundo_Proyecto
{
    public partial class Agregar : Form
    {
        public Form1.Persona persona { get; set; } = new Form1.Persona();

        public Agregar()
        {
            InitializeComponent();
            // para que no se pueda escribir en los combobox
            comboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            textNombre.Text = persona.Nombre;
            textApellido.Text = persona.Apellido;
            textCedula.Text = persona.Cedula.ToString();
            comboSexo.Text = persona.Sexo;
            comboEstadoCivil.Text = persona.Estado_Civil;
        }

        private void ValidarSoloTexto(KeyPressEventArgs e)
        {
            // solo permite letras, espacios y teclas de control
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // si no es una letra, espacio o tecla de control, no lo deja escribir
                e.Handled = true;
            }
        }
        private void ValidarSoloNumeros(KeyPressEventArgs e)
        {
            // solo permite numeros y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // si no es un numero o tecla de control, no lo deja escribir
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // validacion de campos vacios
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("El Nombre no puede permanecer vacio");
                return;
            }
            if (string.IsNullOrWhiteSpace(textApellido.Text))
            {
                MessageBox.Show("El Apellido no puede permanecer vacio");
                return;
            }
            if (string.IsNullOrWhiteSpace(textCedula.Text))
            {
                MessageBox.Show("La cedula no puede permanecer vacia");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboSexo.Text))
            {
                MessageBox.Show("El Sexo no puede permanecer vacio");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboEstadoCivil.Text))
            {
                MessageBox.Show("El Estado Civil no puede permanecer vacio");
                return;
            }


            // si todo esta bien
            persona.Nombre = textNombre.Text;
            persona.Apellido = textApellido.Text;
            persona.Cedula = int.Parse(textCedula.Text);
            persona.Sexo = comboSexo.Text;
            persona.Estado_Civil = comboEstadoCivil.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloTexto(e);
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloTexto(e);
        }

        private void textCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(e);
        }
    }
}
