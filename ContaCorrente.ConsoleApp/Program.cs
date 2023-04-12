namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc_01 = new ContaCorrente(1, 1800, 9876, 600, true);
            ContaCorrente cc_02 = new ContaCorrente(2, 1700, 6789, 450, true);
            Console.WriteLine(cc_01.Saldo);

            cc_01.SacarValor(200);
            cc_01.DepositarValor(300);
            cc_01.DepositarValor(500);
            cc_01.SacarValor(200);
            Console.WriteLine(cc_01.Saldo);
            Console.WriteLine(cc_02.Saldo);

            cc_02.TransferirValor(90, cc_02, cc_01);
            Console.WriteLine($"saldoDestinatario: {cc_01.Saldo}");
            Console.WriteLine($"saldoRemetente: {cc_02.Saldo}");

            Console.WriteLine(cc_01.Saldo);

            Console.WriteLine(cc_02.Saldo);

            cc_02.SacarValor(2);
            cc_02.DepositarValor(5);
            cc_02.DepositarValor(3);
            cc_02.SacarValor(2);
            cc_02.TransferirValor(150, cc_01, cc_02);
            Console.WriteLine($"saldoDestinatario: {cc_02.Saldo}");
            Console.WriteLine($"saldoRemetente: {cc_01.Saldo}");
            Console.WriteLine(cc_02.Saldo);

            Console.ReadLine();
        }
    }
}