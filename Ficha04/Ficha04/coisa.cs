using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ficha04
{
    class coisa
    {
        private static Random rnd = new Random();
        public string nome;
        public List<int> valores;
        public int TotalValores = 0;

        public coisa(string nome)
        {
            this.nome = nome;
            this.valores = new List<int>();
            this.TotalValores = 0;
        }

        public void InventarValor()
        {
            
            int valor = rnd.Next(1, 100);
            this.valores.Add(valor);
            this.TotalValores += valor;
        }

        public override string ToString()
        {
            return this.nome + " -> " + string.Join(", ", this.valores) + " = " + this.TotalValores;
        }




    }
}
