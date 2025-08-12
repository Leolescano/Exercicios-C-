using Exercicio01;  

public class Program
{
    static void Main(string[] args)
    {
        var produto1 = Produto.Criar("Mouse Gamer", 150.00m);
        var produto2 = Produto.Criar("Teclado Mecânico", 350.00m);

        Console.WriteLine(produto1);
        Console.WriteLine(produto2);
    }
}