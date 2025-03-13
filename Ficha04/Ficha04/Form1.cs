using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha04
{
    public partial class Form1: Form
    {
        private static Random rnd = new Random();
        List<coisa> lista = new List<coisa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarNomes_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduza um nome para adicionar à lista.");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void baralhar_Click(object sender, EventArgs e)
        {
            // Adicionar novos itens à lista se houver novos itens no listBox1
            if (listBox1.Items.Count > lista.Count)
            {
                for (int i = lista.Count; i < listBox1.Items.Count; i++)
                {
                    coisa c = new coisa(listBox1.Items[i].ToString());
                    c.InventarValor();
                    lista.Add(c);
                }
            }
            else
            {
                // Realizar ações aleatórias na lista de objetos "coisa"
                int numAcoes = (int)numericUpDown1.Value;
                for (int i = 0; i < numAcoes; i++)
                {
                    foreach (var coisaobj in lista)
                    {
                        if (coisaobj.valores.Count > 1)
                        {
                            int index1 = rnd.Next(coisaobj.valores.Count);
                            int index2 = rnd.Next(coisaobj.valores.Count);

                            // Trocar os valores entre dois índices aleatórios
                            int temp = coisaobj.valores[index1];
                            coisaobj.valores[index1] = coisaobj.valores[index2];
                            coisaobj.valores[index2] = temp;
                        }
                    }

                    for (int j = 0; j < lista.Count; j++)
                    {
                        int index1 = rnd.Next(lista.Count);
                        int index2 = rnd.Next(lista.Count);
                        coisa temp = lista[index1];

                        lista[index1] = lista[index2];
                        lista[index2] = temp;
                    }
                }

            }
            // Atualizar o DataSource do listBox2
            listBox2.DataSource = null;
            listBox2.DataSource = lista;
            listBox2.DisplayMember = "nome"; // Exibir o nome dos objetos "coisa"
        }

        private void darValores_Click(object sender, EventArgs e)
        {
            if (lista != null)
            {
                foreach (coisa c in lista)
                {
                    c.InventarValor();
                }
                listBox2.DataSource = null;
                listBox2.DataSource = lista;
            }
        }
    }
}
