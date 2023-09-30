int[] vetor1 = { 1, 6, 5, 3, 5 };
int[] vetor2 = { 7, 8, 7, 9, 10 };
int[] vetorFinal = new int[vetor1.Length + vetor2.Length];
int contador = 0;
for (int i = 0; i < vetor1.Length; i++)
{
    vetorFinal[contador] = vetor1[i];
    contador++;
}
for (int i = 0; i < vetor2.Length; i++)
{
    vetorFinal[contador] = vetor2[i];
    contador++;
}
//Jeito mais facil 
//vetorFinal = Enumerable.Concat(vetor1, vetor2).ToArray();
Array.Sort(vetorFinal);
Console.WriteLine(string.Join(",", vetorFinal));
Console.ReadLine();