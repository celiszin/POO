using POO_Exec_01;

public class Program
{
    private static void Main(string[] args)
    {
        Livro livro1 = new Livro();
        livro1.titulo = "A volta dos que não foram";
        livro1.autor = "Ann Arfa";
        livro1.editora = "Cia sem Letras";
        livro1.anoLancamento = 2015;

        Console.WriteLine($"Livro: {livro1.titulo}\nLançamento {livro1.anoLancamento}");

        Livro livro2 = new Livro();
        livro2.titulo = "Um Livro";
        livro2.autor = "Anônimo";
        livro2.editora = "Da Esquina";
        livro2.anoLancamento = 1978;

        Console.WriteLine($"Livro: {livro2.titulo}\nLançamento {livro2.anoLancamento}");

        Livro livro3 = new Livro();
        livro3.titulo = "Livro 3";
        livro3.autor = "Autor 3";
        livro3.editora = "Editora 3";
        livro3.anoLancamento = 1978;

        Console.WriteLine($"Livro: {livro2.titulo}\nLançamento {livro2.anoLancamento}");

        Console.WriteLine("\n\n\n==================================\n\n\n");

        Pet p1 = new Pet();
        p1.nome = "Rex";
        p1.idade = 3;
        p1.tipo = "Doguinho Caramelo";
        p1.alimentarSe();

        Pet p2 = new Pet();
        p2.nome = "Arranhão";
        p2.idade = 4;
        p2.tipo = "Gato Amarelo";
        p2.alimentarSe();
        p2.emiteSom();

        Cachorro cachorro = new Cachorro();
        cachorro.nome = "Tibúrcio";
        cachorro.idade = 5;
        cachorro.tipo = "VL Legítimo com pedigree";
        cachorro.emiteSom();

        Gato gato = new Gato();
        gato.nome = "Spock";
        gato.idade = 6;
        gato.tipo = "Gato Vulcano";
        gato.emiteSom();

        Tutor tutor = new Tutor();
        tutor.nome = "Etelvaldo";
        //tutor.creditos = 5000;
        tutor.setCreditos(-5000);
        Console.WriteLine(tutor.getCreditos());

        tutor.setCreditos(2658);
        Console.WriteLine(tutor.getCreditos());
    }
}