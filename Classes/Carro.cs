using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Carro
    {
        public string Nome { get; set; }
        public string Motorizacao { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }

        public Carro() { }

        public Carro(string nome, string motorizacao, string categoria, string marca)
        {
            Nome = nome;
            Motorizacao = motorizacao;
            Categoria = categoria;
            Marca = marca;
        }
    }
}
