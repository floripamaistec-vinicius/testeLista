public class Compras
{
    public string Produto { get; set; }
    public int Quantidade { get; set; }
    public double Preco { get; set; }
    public Compras() { 
    }
    public Compras(string produto, int quantidade, double preco) : this()
    {
        Produto = produto;
        Quantidade = quantidade;
        Preco = preco;
    }
}