using ExemploConstrutor;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Pafúncio", 68);
        Pessoa p2 = new Pessoa("Zuleika");
        Pessoa p3 = new Pessoa();
        p3.Nome = "Josefina";

        p1.apresentarSe();
        p2.apresentarSe();
        p3.apresentarSe();
    }
}