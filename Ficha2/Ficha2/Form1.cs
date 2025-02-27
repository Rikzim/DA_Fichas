using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            contadorTempo = new DateTime(0);
        }

        private DateTime contadorTempo;
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHora.Text = DateTime.Now.ToString();
            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 0, 0 , 10));
            toolStripStatusLabelContador.Text = contadorTempo.ToString("HH:mm:ss.fff");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = button1.Text == "Parar" ? "Ativar" : "Parar";

            if (button1.Text == "Ativar")
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contadorTempo = new DateTime(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " @ " + contadorTempo.ToString("HH:mm:ss.fff"));
        }
    }
}
