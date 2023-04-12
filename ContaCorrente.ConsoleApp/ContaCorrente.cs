using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    internal class ContaCorrente
    {
        public int Id { get; set; }
        public double Saldo { get; set; }
        public int Numero { get; set; }
        public int Limite { get; set; }
        public bool Especial { get; set; }
        public Movimentacao Movimetacoes { get; set;}

        public ContaCorrente()
        {
            
        }
        public ContaCorrente(int id, int saldo, int numero, int limite, bool especial)
        {
            this.Id = id;
            this.Saldo = saldo;
            this.Numero = numero;
            this.Limite = limite;
            this.Especial = especial;
            this.Movimetacoes = new Movimentacao();
        }
        public void PreencherExtratoMovimentacoes(int quantidade, string nomeOperacao)
        {
            string informacao = nomeOperacao + " " + quantidade;
        }
        public void SacarValor(int valor)
        {
            this.Saldo = this.Saldo - valor;
        }
        public void DepositarValor(int valor)
        {
            this.Saldo = this.Saldo + valor;
        }
        public void VisualizarSaldo()
        {
            Console.WriteLine(this.Saldo);
        }
        public void VisualizarExtrato()
        {
            foreach (var item in Movimetacoes)
            {
                Console.WriteLine(item);
            }
        }
        public void TransferirValor(int valor, ContaCorrente contaRemetente, ContaCorrente contaDestinataria)
        {
            bool sandoSuficiente = (contaRemetente.Saldo + contaRemetente.Limite) < valor;
            if (!sandoSuficiente)
            {
                contaRemetente.Saldo = contaRemetente.Saldo - Convert.ToDouble(valor);
                contaDestinataria.Saldo = contaDestinataria.Saldo + Convert.ToDouble(valor);
                Console.WriteLine("Deposito realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
            
        }
    }
}
