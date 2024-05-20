namespace currency_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] currencyCodes = { "USD", "RUB", "TRY" };
            decimal[] currencyRates = { 1.70M, 0.0187M, 0.0527M };
            bool systemProcess = true;

            int i = 0;



            while (systemProcess)
            {

                Console.WriteLine("Available commands:");
                Console.WriteLine("1. /show-recent-currency-rates");
                Console.WriteLine("2. /find-currency-rate-by-code");
                Console.WriteLine("3. /calculate-amount-by-currency");
                Console.WriteLine("4. /exit");
                Console.Write("Please enter a valid command: ");
                string command = Console.ReadLine();


                if (command == "1")
                {
                    Console.WriteLine("Current currency rates: ");
                    while (i < currencyCodes.Length)
                    {
                        Console.WriteLine($"{currencyCodes[i]} : {currencyRates[i]}");
                        i++;
                    }

                }

                else if (command == "2")
                {
                    Console.WriteLine("Please write a currency code (USD, RUB, TRY)");
                    string code_of_currency = Console.ReadLine().ToUpper();
                    bool found = false;

                    while (i < currencyCodes.Length)
                    {
                        if (currencyCodes[i] == code_of_currency)
                        {
                            Console.WriteLine($"{currencyCodes[i]} : {currencyRates[i]}");
                            found = true;
                            break;
                        }

                        i++;
                    }
                    if (!found)
                    {
                        Console.WriteLine("Invalid code written.");
                    }
        }        
    }
}
