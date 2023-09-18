using System;

class program
{
    static void Main(string[] args)
    {
        //        EXERCÍCIO 02
        //Crie um programa que peça 10 números inteiros e apresente a média, a soma e o menor.

        int num = 0, media = 0, soma = 0;
        int menor = 2147483646; // Maior numero aceito pot um inteiro

        Console.WriteLine("Digite 10 numeros inteiros para ser apresentado a media, soma e o menor numero");


        for (int i = 0; i < 10; i++)
        {
            try
            {// opcaoa para um possivel errado aodigitar o caractere.
                num = int.Parse(Console.ReadLine());

                if (num < menor)
                {
                    menor = num;
                }

                soma = num + soma;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                i--; // Se tiver um erro ele retorna uma posição
            }
        }

        media = soma / 10;

        Console.WriteLine($" A soma total dos numeros e {soma}");
        Console.WriteLine($" O menor numero digitado e {menor}");
        Console.WriteLine($" A media total dos numeros e {media}");
        Console.ReadLine();
    }
}