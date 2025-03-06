using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha3
{
    class Professor: Pessoa
    {
        public Professor (string nome, DateTime dtanascimento,string disciplina) : base(nome, dtanascimento)
        {
            this.disciplina = disciplina;

        }

        public string disciplina { get; set; }

        public override string ToString()
        {
            return nome + "(" + dtanascimento.ToString("dd/MM/yy") + "): " + pontuacao + "Pontos";
        }
    }
}
