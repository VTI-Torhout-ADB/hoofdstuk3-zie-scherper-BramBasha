namespace Dertien_in_een_dozijn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int doosGrootte = 8;
            int aantalEieren = 124;
            int volleDozen = aantalEieren / doosGrootte; 
            int restEieren = aantalEieren % doosGrootte; 
            Console.WriteLine($"{aantalEieren} eieren passen in {volleDozen} dozen van doosgrootte: {doosGrootte}. Daarbij zal je nog {restEieren} eieren over hebben.");
        }
    }
}
