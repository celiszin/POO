using Exercicio07_ContaBancaria;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Testando Classe ContaGenerica ********");
        ContaGenerica c1 = new ContaGenerica();
        c1.Banco = 1;           //Banco do Brasil
        c1.Agencia = "0896-6";  //Agência de Barra Bonita
        c1.Conta = "17888-4";   //Número da Conta
        c1.depositar(500);
        c1.mostrarConta();
        c1.depositar(100);
        c1.mostrarConta();
        c1.depositar(-368);     //Tentando depositar valor negativo
        c1.mostrarConta();
        c1.sacar(400);
        c1.mostrarConta();
        c1.sacar(800);          //Tentando sacar mais $ do que tem no saldo
        c1.mostrarConta();

        Console.WriteLine("\n\n********** Testando Classe ContaCorrente ********\n\n");

        ContaCorrente c2 = new ContaCorrente();
        c2.Banco = 341;         //Banco Itau
        c2.Agencia = "0425";    //Agência da Barra
        c2.Conta = "34587-6";   //Número da Conta
        c2.Limite = 1000;
        c2.depositar(500);
        c2.mostrarConta();
        c2.sacar(1400);
        c2.mostrarConta();
        c2.sacar(500);          //Tentando sacar mais do que o limite permite
        c2.mostrarConta();
        c2.depositar(900);
        c2.mostrarConta();
        c2.depositar(100);
        c2.mostrarConta();
    }
}