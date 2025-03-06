using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha3
{
    class Pessoa
    {
        public Pessoa(string nome, DateTime dtanascimento)
        {
            this.nome = nome;
            this.dtanascimento = dtanascimento;
            this.pontuacao = 0;
            this.tipoPessoa = this.GetType().Name;
        }
        public string nome { get; set; }
        public DateTime dtanascimento { get; set; }
        public int pontuacao { get; set; }
        public string tipoPessoa { get; private set; }

        public int Idade()
        {
            DateTime hoje = DateTime.Now;

            int idade = hoje.Year - dtanascimento.Year;

            if (hoje.Month < dtanascimento.Month || (hoje.Month == dtanascimento.Month && hoje.Day < dtanascimento.Day))
            {
                idade--;
            }

            return idade;
        }

        public void Pontuar(int pontuacao)
        {
            this.pontuacao += pontuacao;
        }

        public override string ToString()
        {
            return nome + "(" + dtanascimento.ToString("dd/MM/yy") + "): " + pontuacao + "Pontos";
        }

        public string QuemSouEu()
        {
            return tipoPessoa;
        }
    }
}
