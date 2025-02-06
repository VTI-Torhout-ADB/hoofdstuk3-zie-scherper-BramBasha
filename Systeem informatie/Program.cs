namespace Systeem_informatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int processorCount = 8; 
            double werkgeheugenMB = 9000; 
            double werkgeheugenGB = 11.00; 
            string machineName = "damsPowahPC"; 
            string userName = "admin"; 
            string is64BitOS = "True"; 
            
            Console.WriteLine($"Systeeminformatie voor {userName} op {machineName}:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"    Aantal processors: {processorCount}");
            Console.WriteLine($"    64-bit besturingssysteem: {is64BitOS}");
            Console.WriteLine($"    Huidige geheugengebruik: {werkgeheugenMB:F2} MB ({werkgeheugenGB:F2} GB)");
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
