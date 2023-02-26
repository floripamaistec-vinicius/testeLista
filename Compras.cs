public class Compras
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public double Preco { get; set; }
    public Compras() { 
    }
    public Compras(string nome, int quantidade, double preco) : this()
    {
        Nome = nome;
        Quantidade = quantidade;
        Preco = preco;
    }
}