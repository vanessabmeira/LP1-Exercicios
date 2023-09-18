using System;

    public class Solution
{
    public static bool ElementosRepetidos(params decimal[] numeros)
    {
        for (int i = 0; i < numeros.Length-1; i++)
        {
            for (int j = i+1; j< numeros.Length; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    return true;
                }
            }
        }

        return false;
    }


    public static int PrimeiroCaractereUnico(string palavra)
    {
        bool iguais=false;

        for (int i = 0; i < palavra.Length; i++)
        {
            iguais = false;
            for(int j =0 ;j< palavra.Length; j++)
            {
                if (i == j) { continue; }

                if (palavra[i]  == palavra[j])
                {
                    iguais=true;

                    break;
                }
            }
            if (iguais == false)
            {
                return i;
            }
           
        }
        return -1;
    }

}


