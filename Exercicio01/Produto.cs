namespace Exercicio01;

public class Produto
{
    private static int contadorId = 0; 

    public int Id { get; private set; }
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }

    
    private Produto(string nome, decimal preco)
    {
        Id = ++contadorId;
        Nome = nome;
        Preco = preco;
    }

    public static Produto Criar(string nome, decimal preco)
    {
        return new Produto(nome, preco);
    }

    public override string ToString()
    {
        return $"Produto: {Id} - Nome: {Nome} - Preço: R${Preco:N2}";
    }
}