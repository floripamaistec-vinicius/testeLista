List<Compras> ListaDeCompras = new List<Compras>();

Compras item1 = new Compras("Pao", 8, 3.5);
ListaDeCompras.Add(item1);
Compras item2 = new Compras("Leite", 6, 3.5);
ListaDeCompras.Add(item2);
Compras item3 = new Compras("Nescau", 1, 3.5);
ListaDeCompras.Add(item3);
Compras item4 = new Compras("Doritos", 20, 3.5);
ListaDeCompras.Add(item4);
Compras item5 = new Compras("Suco", 7, 3.5);
ListaDeCompras.Add(item5);
Compras item6 = new Compras("Coca-Cola", 12, 3.5);
ListaDeCompras.Add(item6);
Compras item7 = new Compras("Queijo", 5, 3.5);
ListaDeCompras.Add(item7);

Console.WriteLine($"Quantidade de itens na lista de compras: {ListaDeCompras.Count()}");

Console.WriteLine($"Nome do produto: {ListaDeCompras[5].Produto}, Quantidade do Produto: {ListaDeCompras[5].Quantidade}");

for (int index = 0; index < ListaDeCompras.Count; index++)
{
    if (ListaDeCompras[index].Produto == "Coca-Cola") {
        Console.WriteLine();
        Console.WriteLine($"Encontrei a Coca-Cola no índice {index}");
        Console.WriteLine($"Essa {ListaDeCompras[index].Produto}");
        ListaDeCompras[index].Produto = "Fanta";
        Console.WriteLine($"Agora é {ListaDeCompras[index].Produto}");
        Console.WriteLine(ListaDeCompras[index].Produto);
        
    } else
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Índice na lista: {index}");
        Console.ReadLine();
        Console.WriteLine($"Index {index}, {ListaDeCompras[index].Produto}, {ListaDeCompras[index].Quantidade}");
    }
}
