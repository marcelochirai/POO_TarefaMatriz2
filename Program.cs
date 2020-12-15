using System;

//Programa para ler dois número inteiro M e N, 
//e depois ler uma matriz de M linhas por N colunas contendo números inteiros, podendo haver repetições.
namespace POO_TarefaMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para linha e coluna (Ex.: 3 4 - 3 linhas 4 colunas): ");
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]); //Recebe o valor de m - linha
            int n = int.Parse(line[0]); //Recebe o valor de n - coluna

            int[,] mat = new int[m, n];

            Console.WriteLine("Digite os números, separados por espaço (Ex: 1 2 3): ");
            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //Ler um número inteiro X que pertence à matriz
            Console.WriteLine("Escolha um dos números digitados acima: ");
            int x = int.Parse(Console.ReadLine());  //Recebe o valor de referência.

            for (int i = 0; i < m; i++) //Exibe os valores ao redor da referência.
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine($"Posição " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine($"Esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Acima: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine($"Direita: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Abaixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
