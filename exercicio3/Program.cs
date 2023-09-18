using System;

class program
{
    static void Main(string[] args)
    {
        //EXERCÍCIO 03
        //Some os números de 1 a 100 a imprima o valor.
     
        int soma = 0;

        for (int i = 1; i <= 100; i++)
        {
          soma=soma + i;
        }

        Console.WriteLine($"A soma dos números de 1 a 100 é igual a {soma}");
    }
}