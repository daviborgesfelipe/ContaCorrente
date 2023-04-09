using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    internal class ContaCorrente
    {
        public int Id { get; set; }
        public int Saldo { get; set; }
        public int Numero { get; set; }
        public int Limite { get; set; }
        public bool Especial { get; set; }
        public List<Movimentacao> Movimetacoes { get; set;}

        public ContaCorrente()
        {
            
        }
        public void SacarValor()
        {
        }
        public void DepositarValor()
        {
        }
        public void VisualizarSaldo()
        {
        }
        public void VisualizarExtrato()
        {
        }
        public void TransferirValor()
        {
        }
    }
}
