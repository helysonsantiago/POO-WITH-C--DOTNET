public enum typePayment
{
    InCash,
    CreditCard
}
 
public class Cart
{
    private List<Item> itens = new List<Item>(); //expressão lambda
    public typePayment typePayment { get; set; } = typePayment.InCash; 
    public int Installments { get; set; } = 1;

    public void AddItem(Item item)
    {
        itens.Add(item);
    }

    public double CalculateTotal()
    {
        double total = itens.Sum(item => item.Price);

        if (typePayment == typePayment.InCash)
        {
            if (total <= 100)
            {
                total *= 0.8; // 20% de desconto
                Console.WriteLine("\nVocê obteve 20% de desconto");
            }
            else if (total > 100 && total <= 500)
            {
                total *= 0.95; // 5% de desconto
                Console.WriteLine("\nVocê obteve 5% de desconto");
            }
        }
        else if (typePayment == typePayment.CreditCard)
        {
            if (total > 300 && Installments >= 1 && Installments <= 3)
            {
                Console.WriteLine("\n\nDigite o número de parcelas (1 a 3):");
                string qtdInstallments = Console.ReadLine();
                Installments = int.Parse(qtdInstallments);
            }
        }

        return total;
    }
}