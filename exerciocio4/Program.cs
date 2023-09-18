using System;

class program
{
    static void Main(string[] args)
    {
        //EXERCÍCIO 04
        //Faça um algoritmo que leia números até o usuário digitar 0, após
        //finalizar, mostre quantos números lidos, a soma e quantos são pares.

        Console.WriteLine("Digite alguns numeros");
        int numero = 0, soma = 0, contador = 0, contadorPares = 0;

        numero = int.Parse(Console.ReadLine());


        while (numero!=0)
        {
            contador++; //toda vez que passar vai contabilizar +1 no contador

            soma = numero + soma;

            if (numero % 2 == 0) //para contar os pares usamos o % (resto) para saber se e par
            {
                contadorPares++;
            }
           
            numero = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($" a soma dos numeros e de {soma}");
        Console.WriteLine($" A quantidade de numeros lidos foi de {contador}");
        Console.WriteLine($" A quantidade de numeros pares lidos foi de {contadorPares}");

    }
}