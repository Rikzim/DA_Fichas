using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha3
{
    class Aluno: Pessoa
    {
        public Aluno(string nome, DateTime dtanascimento,int numeroAluno, string curso) : base(nome, dtanascimento)
        {
            this.numeroAluno = numeroAluno;
            this.curso = curso;

        }

        public int numeroAluno { get; set; }
        public string curso { get; set; }

        public override string ToString()
        {
            return nome + "(" + dtanascimento.ToString("dd/MM/yy") + "): " + pontuacao + "Pontos";

        }
    }
}
