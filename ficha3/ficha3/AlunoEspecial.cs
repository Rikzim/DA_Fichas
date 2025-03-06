using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha3
{
    class AlunoEspecial: Aluno
    {
        public AlunoEspecial(string nome, DateTime dtanascimento, int numeroAluno, string curso, string dificuldade) : base(nome, dtanascimento, numeroAluno, curso)
        {
            this.dificuldade = dificuldade;
        }
        public string dificuldade { get; set; }

        public override string ToString()
        {
            return nome + "(" + dtanascimento.ToString("dd/MM/yy") + "): " + pontuacao + "Pontos";
        }
    }
}
