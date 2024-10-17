using System.Globalization;

namespace Programa_Bar {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Sexo: ");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Quantidade de cervejas: ");
            int beer = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de refrigerantes: ");
            int softDrink = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de espetinhos: ");
            int berbecue = int.Parse(Console.ReadLine());
            Bill bill = new Bill(gender, beer, berbecue, softDrink);
            Console.WriteLine();
            Console.WriteLine("RELATÓRIO:");
            Console.WriteLine("Consumo = R$ " + bill.feeding().ToString("F2", CultureInfo.InvariantCulture));
            if (bill.cover() == 4.00) {
                Console.WriteLine("Couvert = R$ " + bill.cover().ToString("F2", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("Isento de Couvert");
            }
            Console.WriteLine("Ingresso = R$ " + bill.ticket().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Valor a pagar = R$ " + bill.total().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
