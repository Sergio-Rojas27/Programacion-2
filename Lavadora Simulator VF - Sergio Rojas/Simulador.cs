using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.VisualBasic.ApplicationServices;

namespace Lavadora_Simulator_V2___Sergio_Rojas
{
    public partial class Simulador : Form
    {
        Lavadora lavadora = new Lavadora();
        private int tiempo;

        public void EncenderTotal()
        {
            lavadora.Encender();
            label2.Text = "Lavadora Encendida";
        }


        /*  El metodo mas que ayudar, complica el codigo porque depues de asignar los datos a las
         *  variables de la clase Lavadora, se tendrian que igualar a las variables de la clase 
         *  Simulador en el metodo BotonIniciar_Click, lo cual no es necesario.
         
           public void ActualizarCiclo()
        {
            int indiceSeleccionado = CicloSeleccion.SelectedIndex;
            switch (indiceSeleccionado)
            {
                case 0:
                    lavadora.cicloDeLavado = "Ciclo de Lavado: Rapido";
                    lavadora.tiempoDelCiclo = 15;
                    break;
                case 1:
                    lavadora.cicloDeLavado = "Ciclo de Lavado: Normal";
                    lavadora.tiempoDelCiclo = 30;
                    break;
                case 2:
                    lavadora.cicloDeLavado = "Ciclo de Lavado: Intensivo";
                    lavadora.tiempoDelCiclo = 60;
                    break;
                case 3:
                    lavadora.cicloDeLavado = "Ciclo de Lavado: Solo Enjuague";
                    lavadora.tiempoDelCiclo = 10;
                    break;
                case 4:
                    lavadora.cicloDeLavado = "Ciclo de Lavado: Solo Centrifugado";
                    lavadora.tiempoDelCiclo = 5;
                    break;
                default:
                    MessageBox.Show("Seleccione un ciclo de lavado");
                    break;
            }

        }
        */

        private SoundPlayer efectoSonoro;

        public void ReproducirSonido()
        {
            string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;
            string rutaAudio = Path.Combine(rutaDeAplicacion, "ArchivosAdicionales" , "LavadoraWakaWakaWab.wav");
            efectoSonoro = new SoundPlayer(rutaAudio);
        }

        public Simulador()
        {
            InitializeComponent();
            CicloSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            timer1.Enabled = false;
            tiempo = 0;
            LavadoraAnimacion.Visible = false;
            GatoBox.Visible = false;
            ReproducirSonido();
            //efectoSonoro = new SoundPlayer(@"C:/Users/Sergio/source/repos/Lavadora Simulator V2 - Sergio Rojas/ArchivosAdicionales/LavadoraWakaWakaWab.wav");
        }
        private void efectoSonoro_PlayCompleted(object sender , AsyncCompletedEventArgs e)
        {
            efectoSonoro.Play();
        }

        private void CicloSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonEncendido_Click(object sender, EventArgs e)
        {
           EncenderTotal();
        }

        private void BotonApagado_Click(object sender, EventArgs e)
        {
            lavadora.Apagar();
            label2.Text = "Lavadora Apagada";
            
        }

        private void ProgesoDeLavado_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgesoDeLavado.Value = tiempo;
            if (ProgesoDeLavado.Value < ProgesoDeLavado.Maximum)
                tiempo++;
            if (ProgesoDeLavado.Value == ProgesoDeLavado.Maximum)
            {
                timer1.Enabled = false;
                MessageBox.Show("Lavado Terminado");
                tiempo = 0;
                ProgesoDeLavado.Value = 0;
                LabelCiclo.Text = "Ciclo de lavado: ninguno";
                labelEstado.Text = "La lavadora esta: esperando";
                LavadoraAnimacion.Visible = false;
                GatoBox.Visible = false;
                efectoSonoro.Stop();
                pictureBox1.Visible = true;
                BotonIniciar.Visible = true;
                BotonApagado.Visible = true;
                BotonEncendido.Visible = true;
                CicloSeleccion.Visible = true;
            }
        }

        private void BotonIniciar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = CicloSeleccion.SelectedIndex;
            switch (indiceSeleccionado)
            {
         // Los numeros son tan grandes porque esta en milisegundos,asi es mas suave la transicion
                case 0:
                    ProgesoDeLavado.Maximum = 150;
                    LabelCiclo.Text = "Ciclo de lavado: Rapido"; 
                    labelEstado.Text = "La lavadora esta: Lavando → Enjuagando → Centrifugando";                
                    break;
                case 1:
                    ProgesoDeLavado.Maximum = 300;
                    LabelCiclo.Text = "Ciclo de lavado: Normal";
                    labelEstado.Text = "La lavadora esta: Lavando → Enjuagando → Centrifugando";
                    break;
                case 2:
                    ProgesoDeLavado.Maximum = 600;
                    LabelCiclo.Text = "Ciclo de lavado: Intensivo";
                    labelEstado.Text = "La lavadora esta: Lavando → Enjuagando → Centrifugando";
                    break;
                case 3:
                    ProgesoDeLavado.Maximum = 100;
                    LabelCiclo.Text = "Ciclo de lavado: Solo Enjuague";
                    labelEstado.Text = "La lavadora esta: Enjuagando";
                    break;
                case 4:
                    ProgesoDeLavado.Maximum = 50;
                    LabelCiclo.Text = "Ciclo de lavado: Solo Centrifugado";
                    labelEstado.Text = "La lavadora esta: Centrifugando";
                    break;
                default:
                    MessageBox.Show("Seleccione un ciclo de lavado");
                break;

            }
            if (indiceSeleccionado >= 0 && indiceSeleccionado <= 4)
            {
                EncenderTotal();
                pictureBox1.Visible = false;
                BotonIniciar.Visible = false;
                BotonApagado.Visible = false;
                BotonEncendido.Visible = false;
                CicloSeleccion.Visible = false;
                timer1.Enabled = true;
                LavadoraAnimacion.Visible = true;
                GatoBox.Visible = true;
                efectoSonoro.PlayLooping();
            }
         
        }

    }
}
