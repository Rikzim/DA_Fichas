using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ficha3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dtanascimento = monthCalendar1.SelectionStart;
            DateTime hoje = DateTime.Now;
            if (dtanascimento > hoje)
            {
                MessageBox.Show("Data de nascimento inválida.");
            }
            else
            {
                Pessoa p = new Pessoa(textBox1.Text, dtanascimento);
                listBox1.Items.Add(p);
            }

            limparTextBoxes();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Pessoa p = (Pessoa)listBox1.SelectedItem;
                p.Pontuar(1);
                AtualizarRichTextBox(p);
                listBox1.Items[listBox1.SelectedIndex] = p;
            }
            else
            {
                MessageBox.Show("Selecione um item para pontuar.");
            }

            limparTextBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dtanascimento = monthCalendar1.SelectionStart;
            DateTime hoje = DateTime.Now;
            if (dtanascimento > hoje)
            {
                MessageBox.Show("Data de nascimento inválida.");
            }
            else
            {
                AlunoEspecial ae = new AlunoEspecial(textBox1.Text, dtanascimento, Convert.ToInt32(textBox3.Text), textBox2.Text, textBox5.Text);
                listBox1.Items.Add(ae);
            }

            limparTextBoxes();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Pessoa p = (Pessoa)listBox1.SelectedItem;
                AtualizarRichTextBox(p);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime dtanascimento = monthCalendar1.SelectionStart;
            DateTime hoje = DateTime.Now;
            if (dtanascimento > hoje)
            {
                MessageBox.Show("Data de nascimento inválida.");
            }
            else
            {
                Aluno a = new Aluno(textBox1.Text, dtanascimento, Convert.ToInt32(textBox3.Text), textBox2.Text);
                listBox1.Items.Add(a);
            }

            limparTextBoxes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime dtanascimento = monthCalendar1.SelectionStart;
            DateTime hoje = DateTime.Now;
            if (dtanascimento > hoje)
            {
                MessageBox.Show("Data de nascimento inválida.");
            }
            else
            {
                Professor prof = new Professor(textBox1.Text, dtanascimento, textBox4.Text);
                listBox1.Items.Add(prof);
            }

            limparTextBoxes();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {

                Pessoa p = (Pessoa)listBox1.SelectedItem;

                button7.Text = p.QuemSouEu();

                listBox1.Items[listBox1.SelectedIndex] = p;

            }
            else
            {
                MessageBox.Show("Selecione um item.");
            }
        }

        private void AtualizarRichTextBox(Pessoa p)
        {
            if (p is Aluno aluno)
            {
                richTextBox1.Text = p.nome
                    + "\n\t" + "NºAluno: " + aluno.numeroAluno
                    + "\n\t" + "Data de Nascimento: " + aluno.dtanascimento.ToString("dd/MM/yy")
                    + "\n\t" + "Curso: " + aluno.curso
                    + "\n\t" + "Pontuação: " + aluno.pontuacao;
            }
            else if (p is Professor prof)
            {
                richTextBox1.Text = p.nome
                    + "\n\t" + "Data de Nascimento: " + prof.dtanascimento.ToString("dd/MM/yy")
                    + "\n\t" + "Disciplina: " + prof.disciplina
                    + "\n\t" + "Pontuação: " + prof.pontuacao;
            }
            else if (p is AlunoEspecial ae)
            {
                richTextBox1.Text = p.nome
                    + "\n\t" + "NºAluno: " + ae
                    + "\n\t" + "Data de Nascimento: " + ae.dtanascimento.ToString("dd/MM/yy")
                    + "\n\t" + "Curso: " + ae.curso
                    + "\n\t" + "Dificuldade: " + ae.dificuldade
                    + "\n\t" + "Pontuação: " + ae.pontuacao;
            }
            else
            {
                richTextBox1.Text = p.nome
                    + "\n\t" + "Data de Nascimento: " + p.dtanascimento.ToString("dd/MM/yy")
                    + "\n\t" + "Pontuação: " + p.pontuacao;
            }
        }

        private void limparTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
