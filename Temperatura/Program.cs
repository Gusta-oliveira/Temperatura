internal class Program
{
    private static void Main(string[] args)
    {
        double celsius, fah;

        Console.WriteLine("Informe a temperatura em ºC: ");
        celsius = float.Parse(Console.ReadLine());
        fah = ((celsius * 9)/5) + 32;
        Console.WriteLine("A temperatura {0}ºC convertidaem {1}ºF", celsius, fah);
    }
}