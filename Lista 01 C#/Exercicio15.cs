public class Exercicio15
{
    public static void Executar()
    {
        //Leia: nome do produto, preco unitario, quantidade
        //Calcule: subtotal, desconto (10% se subtotal > 200) e total final
        //Exiba organizado. 
        //Utilize operador ternario ? :
        Console.WriteLine("====CAIXA REGISTRADORA====");
        Console.WriteLine("Digite o nome do produto que quer comprar: ");
        string nomeProduto = Console.ReadLine();
        Console.WriteLine("Digite o preco do produto: ");
        double precoProduto = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a quantidade que quer comprar: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());
        double subtotal = CalcularSubtotal(precoProduto, quantidade);
        double desconto = CalcularDesconto(subtotal);
        Console.WriteLine($"Produto: {nomeProduto} | Quantidade: {quantidade} | Valor: R${precoProduto}| Subtotal: R${subtotal:F2} | Desconto: {desconto:P0} | Total: R${CalcularTotal(subtotal, desconto):F2}");
    }

    public static double CalcularSubtotal(double valor, int quantidade)
    {
        double subtotal = valor * quantidade;
        return subtotal;
    }

    public static double CalcularDesconto(double subtotal) 
    {
        return subtotal > 200 ? 0.10 : 0.0;
    }

    public static double CalcularTotal(double subtotal, double porcentagemDesconto)
    {
        double desconto = subtotal * porcentagemDesconto;
        double total = subtotal - desconto;
        return total;
    }
}