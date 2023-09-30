//1.Soma e Média: Escreva um programa que lê um vetor de 5 números inteiros e calcula a soma e a média dos elementos.
//2.Maior e Menor Valor: Crie um programa que encontra e exibe o maior e o menor valor em um vetor de números reais.
//3.Pares e Ímpares: Implemente um programa que divide um vetor de inteiros em dois vetores: um contendo os números
//pares e outro os números ímpares.
//4.Busca por Valor: Crie uma função que recebe um vetor e um valor para procurar. A função deve retornar verdadeiro
//se o valor estiver presente no vetor e falso caso contrário.
//5.Inversão de Vetor: Escreva um programa que inverte a ordem dos elementos em um vetor.
//6.Contagem de Elementos: Implemente uma função que conta quantas vezes um determinado valor aparece em um vetor.
//7.Mescla de Vetores: Desenvolva um programa que recebe dois vetores de inteiros ordenados e cria um terceiro vetor
//mesclando os elementos dos dois em ordem crescente.
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
        Console.WriteLine("7.Mescla de LISTAS: Desenvolva um programa que recebe dois vetores de inteiros ordenados e cria um terceiro vetor mesclando os elementos dos dois em ordem crescente.");
        Console.WriteLine("8.Mescla de VETORES: Desenvolva um programa que recebe dois vetores de inteiros ordenados e cria um terceiro vetor mesclando os elementos dos dois em ordem crescente.\"");
        return Convert.ToInt32(Console.ReadLine());
    }
    static string MediaElementos()
    {
        int[] media = new int[5];
        int soma = 0;
        int mediaTotal;
        Console.WriteLine("Digite os 5 números");
        for (int i = 0; i < media.Length; i++)
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
        for (int d = 0; d < numeros.Length; d++)
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
    static (List<int>, List<int>) RetornarParesEImpares(List<int> numeros)
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
    //4.Busca por Valor: Crie uma função que recebe um vetor e um valor para procurar.
    //A função deve retornar verdadeiro se o valor estiver presente no vetor e falso caso contrário.
    static List<int> ListarNumeros()
    {
        Console.WriteLine("Digite os valores, digite 0 para parar");
        List<int> listNumeros = new List<int>();
        while (true)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            {
                if (num == 0)
                {
                    break;
                }
                else
                {
                    listNumeros.Add(num);
                }
            }
        }
        return listNumeros;
    }
        
        static Boolean ProcurarVerdadeiro(List<int> numeros)
    {
        Console.WriteLine("Digite o número que procura");
        int procurar = Convert.ToInt32(Console.ReadLine());

        for (int i = 0;i < numeros.Count;i++)
        {
            if (numeros[i] == procurar)
            {
                return true;
            }
        }

        return false;
    }
    //5.Inversão de Vetor: Escreva um programa que inverte a ordem dos elementos em um vetor.

    static List<int> InverterList(List<int> numeros)
    {
        List<int> listInvertida = new List<int>();
        for (int i = numeros.Count-1;i >= 0; i--)
        {
            listInvertida.Add(numeros[i]);
            
        }
        return listInvertida;
    }
    //6.Contagem de Elementos: Implemente uma função que conta quantas vezes um determinado valor aparece em um vetor.
    static int ContadorElementos(List<int> numeros)
    {
        Console.WriteLine("Digite qual valor você procura");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int contador = 0;
        for (int i = 0; i < numeros.Count;i++)
        {
            if ((numeros[i] == num1))
            {
                contador++;
            }
        } return contador;
    }
    //7.Mescla de Vetores: Desenvolva um programa que recebe dois vetores de inteiros ordenados e cria um terceiro vetor
    //mesclando os elementos dos dois em ordem crescente.(USANDO LIST)
    static List<int> MesclarList(List<int> numeros,List<int> numeros2)
    {
        List<int> numerosJuntos = new List<int>();
        for (int i = 0;i < numeros.Count; i++)
        {
            numerosJuntos.Add(numeros[i]);

        }
        for (int i = 0; i < numeros2.Count; i++)
        {
            numerosJuntos.Add(numeros2[i]);
        }

        return numerosJuntos.OrderBy(x => x).ToList();
    }
    //8.Mescla de Vetores: Desenvolva um programa que recebe dois vetores de inteiros ordenados e cria um terceiro vetor
    //mesclando os elementos dos dois em ordem crescente.(USANDO VETORES)
    static int RetornarMesclados()
    {
        Console.WriteLine("Digite a quantidade do primeiro vetor");
        int nContagem1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite os números");
        int[] n1 = new int[nContagem1];
        for (int i = 0;i < n1.Length; i++)
        {
            n1[i] = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine("Digite a quantidade do segundo vetor");
        int nContagem2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite os números");
        int[] n2 = new int[nContagem2];
        for (int i = 0; i < n2.Length; i++)
        {
            n2[i] = Convert.ToInt32(Console.ReadLine());

        }
        int nContagem3 = nContagem1 + nContagem2;
        Console.WriteLine(nContagem3);

        int[] n3 = new int[nContagem3];

        for (int i = n1.Length-1;i >= 0; i--)
        {
            n3[i] = n1[i];
        }
        for (int i = n2.Length-1;i >= 0; i--)
        {
            nContagem3--;
            n3[nContagem3] = n2[i];
          
        }
        Array.Sort(n3);
        Console.WriteLine("Os números em ordem ficam:");
        for (int i = 0;i < n3.Length;i++)
        {
            Console.WriteLine(n3[i]);
        }

        return 0;
    }

    static void Main(string[] args)
        
    {
        try
        {

            switch (IniciarMenu())
            {
                case 1:
                    Console.WriteLine(MediaElementos());
                    break;
                case 2:
                    Console.WriteLine("Digite a quantidade de  números");
                    int qtdNumeros = Convert.ToInt32(Console.ReadLine());
                    double[] numeros = new double[qtdNumeros];
                    RetornarNumeros(numeros);
                    Console.WriteLine($"O maior valor é {numeros.Max()} e o menor valor é {numeros.Min()}");

                    break;
                case 3:

                    Console.WriteLine();
                    (List<int> pares, List<int> impares) = RetornarParesEImpares(ListarNumeros());
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
                    break;
                case 4:

                    Console.WriteLine($"O valor é {ProcurarVerdadeiro(ListarNumeros())}");

                    break;
                case 5:
                    List<int> numInvertidos = InverterList(ListarNumeros());
                    Console.WriteLine("Os números invertidos ficam");
                    foreach (int num in numInvertidos)
                    {
                        Console.WriteLine(num);
                    }

                    break;
                case 6:
                    Console.WriteLine($"Seu número aparece {ContadorElementos(ListarNumeros())} vezes");
                    break;
                case 7:
                    List<int> numJuntos = MesclarList(ListarNumeros(), ListarNumeros());
                    Console.WriteLine($"Os numeros mesclados ficam");
                    foreach (var item in numJuntos)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 8:
                    RetornarMesclados();
                    break;
                default:
                    Console.WriteLine("Escolha incorreta!");
                    break;
            }
        }catch (Exception ex)
        {
            Console.WriteLine("Erro Inesperado");
        }
    }

}



    