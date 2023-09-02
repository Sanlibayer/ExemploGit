//1.Soma e Média: Escreva um programa que lê um vetor de 5 números inteiros e calcula a soma e a média dos elementos.
//2.Maior e Menor Valor: Crie um programa que encontra e exibe o maior e o menor valor em um vetor de números reais.
//3.Pares e Ímpares: Implemente um programa que divide um vetor de inteiros em dois vetores: um contendo os números pares e outro os números ímpares.
//4.Busca por Valor: Crie uma função que recebe um vetor e um valor para procurar. A função deve retornar verdadeiro se o valor estiver presente no vetor e falso caso contrário.
//5.Inversão de Vetor: Escreva um programa que inverte a ordem dos elementos em um vetor.
//6.Contagem de Elementos: Implemente uma função que conta quantas vezes um determinado valor aparece em um vetor.
//7.Mescla de Vetores: Desenvolva um programa que recebe dois vetores de inteiros ordenados e cria um terceiro vetor mesclando os elementos dos dois em ordem crescente.
namespace ListaArray;
class Program
{
    //1.Soma e Média: Escreva um programa que lê um vetor de 5 números inteiros e calcula a soma e a média dos elementos.
    static int IniciarMenu()
    {
        Console.WriteLine("DIGITE QUAL VETOR DESEJA ENTRAR");
        Console.WriteLine("1.Soma e Média: Escreva um programa que lê um vetor de 5 números inteiros e calcula a soma e a média dos elementos.");
        Console.WriteLine("2.Maior e Menor Valor: Crie um programa que encontra e exibe o maior e o menor valor em um vetor de números reais.");
        Console.WriteLine("3.Pares e Ímpares: Implemente um programa que divide um vetor de inteiros em dois vetores: um contendo os números pares e outro os números ímpares.");
        Console.WriteLine("4.Busca por Valor: Crie uma função que recebe um vetor e um valor para procurar. A função deve retornar verdadeiro se o valor estiver presente no vetor e falso caso contrário.");
        Console.WriteLine("5.Inversão de Vetor: Escreva um programa que inverte a ordem dos elementos em um vetor.");
        Console.WriteLine("6.Contagem de Elementos: Implemente uma função que conta quantas vezes um determinado valor aparece em um vetor.");
        Console.WriteLine("7.Mescla de Vetores: Desenvolva um programa que recebe dois vetores de inteiros ordenados e cria um terceiro vetor mesclando os elementos dos dois em ordem crescente.");
        return Convert.ToInt32(Console.ReadLine());
    }
    static string MediaElementos()
    {
        int[] media = new int[5];
        int soma = 0;
        int mediaTotal;
        Console.WriteLine("Digite os 5 números");
        for (int i = 0;i < media.Length;i++)
        {
            media[i] = Convert.ToInt32(Console.ReadLine());
            soma += media[i];
        }
        mediaTotal = soma / 5;
        string resultado = $"A soma é {soma} e a média é {mediaTotal}";
        return resultado;
    }
    //2.Maior e Menor Valor: Crie um programa que encontra e exibe o maior e o menor valor em um vetor de números reais.

    static double[] RetornarNumeros(double[] numeros)
    {
        Console.WriteLine("Digite os números");
        for (int d = 0;d < numeros.Length;d++)
        {
            Console.WriteLine("");
            numeros[d] = Convert.ToDouble(Console.ReadLine());
        }
        return numeros;
    }
    static double MaiorValor(double[] numero)
    {

        return numero.Max();
    }
    static double MenorValor(double[] numero)
    {
        return numero.Min();
    }
    //3.Pares e Ímpares: Implemente um programa que divide um vetor de inteiros em dois vetores: um contendo os números pares e outro os números ímpares.
    static int RetornarParesEImpares()
    {
        Console.WriteLine("Digite os números");
        List<int> numeros = new List<int>();
        for (int i =0;i < numeros.Length; i++)
        {
            Console.WriteLine($)
            if (numeros[i] % 
        }
            return 0;
    }
    static void Main(string[] args)
{
        switch (IniciarMenu())
        {
            case 1:
                Console.WriteLine(MediaElementos());
                break;
            case 2:
                Console.WriteLine("Digite a quantidade de  números");
                int qtdNumeros= Convert.ToInt32(Console.ReadLine());
                double[] numeros = new double[qtdNumeros];
                RetornarNumeros(numeros);
                Console.WriteLine($"O maior valor é {numeros.Max()} e o menor valor é {numeros.Min()}");

                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            default:
                Console.WriteLine("Escolha incorreta!");
                break;
        }
}



}