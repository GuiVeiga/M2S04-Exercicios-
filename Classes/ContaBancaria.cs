using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ContaBancaria
    {
        public ContaBancaria(int contaNumero, int contaDigito, string nomeTitular, string agencia, string endereco, decimal saldo)
        {
            ContaNumero = contaNumero;
            ContaDigito = contaDigito;
            NomeTitular = nomeTitular;
            Agencia = agencia;
            Endereco = endereco;
            Saldo = saldo;
        }

        private int ContaNumero { get; set; }
        private int ContaDigito { get; set; }
        private string NomeTitular { get; set; }
        private string Agencia { get; set; }
        private string Endereco { get; set; }
        private decimal Saldo { get; set; }

        public int GetContaNumero()
        {
            return ContaNumero;
        }

        public int GetContaDigito()
        {
            return ContaDigito;
        }

        public string GetNomeTitular()
        {
            return NomeTitular;
        }

        public string GetAgencia()
        {
            return Agencia;
        }

        public string GetEndereco()
        {
            return Endereco;
        }

        public decimal GetSaldo()
        {
            return Saldo;
        }
    }
}
