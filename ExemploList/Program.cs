using System.Data;
class Program
{
    static (List<int>, List<int>) RetornaDois(List<int> numeros)
    {
        List<int> pares = new List<int>();
        List<int> impares = new List<int>();
        foreach (int i in numeros)
        {
            if (i % 2 == 0)
            {
                pares.Add(i);
            }
            else
            {
                impares.Add(i);
            }
        }
        return (pares, impares);
    }

    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        while (true)
        {
            Console.WriteLine("Digite um numero ou zero para parar");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                break;
            }
            else
            {
                numeros.Add(num);
            }
        }
        Console.WriteLine();
        (List<int> pares, List<int> impares) = RetornaDois(numeros);
        Console.WriteLine("Pares");
        foreach (int num in pares)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("Impares");
        foreach (int num in impares)
        {
            Console.WriteLine(num);
        }

    }
}