using System;
using System.Linq; // importa o namespace System.Linq

namespace _Marketplace
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();

            while (true)
            {
                Console.WriteLine("Digite o valor do item (ou 'sair' para encerrar):");
                string getPrice = Console.ReadLine();

                if (getPrice.ToLower() == "sair")
                {
                    break;
                }

                double price = double.Parse(getPrice);
                Item item = new Item { Price = price };
                cart.AddItem(item);
            }
         
            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("\n1 - À vista");
            Console.WriteLine("2 - Cartão de crédito\n");
            string paymentOption = Console.ReadLine();

            if (paymentOption == "1" )
            {
                cart.typePayment = typePayment.InCash;
            }
            else if (paymentOption == "2")
            {
                cart.typePayment = typePayment.CreditCard;
        
            }

            double total = cart.CalculateTotal();
            Console.WriteLine($"\nO valor total da compra é R${total:F2}");
        }
    }
}