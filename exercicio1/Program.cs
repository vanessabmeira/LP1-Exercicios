using System;

class program
{
    static void Main(string[] args)
    {

        {
            int tamanho = 10;
            int[] A = new int[tamanho];
            int[] B = new int[tamanho];
            int[] C = new int[tamanho];


            for (int i = 0; i < tamanho; i++)
            {
                A[i] = i + 1;
                B[i] = 10 - i;
            }


            for (int i = 0; i < tamanho; i++)
            {
                C[i] = A[i] + B[tamanho - 1 - i];
            }

            Console.WriteLine("Vetor C:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"C[{i}] = {C[i]}");
            }


        }
    }
