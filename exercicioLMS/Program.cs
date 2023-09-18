using System;

    class program {
    public class Solution
    {
        public static decimal CalculoSalario(params decimal[] input)
        {
            decimal tempoServico = input[0], valorInflacao = input[1],salarioFuncionario = input[2];
            decimal percentualTservico = 0;
            if(tempoServico <= 5)
            {
                percentualTservico = 1;
            } else if (tempoServico <= 10)
            {
                percentualTservico = 1.5m;
            }else
            {
                percentualTservico = 2;
            }


            decimal percentualReajuste = percentualTservico + valorInflacao;
            decimal salarioReajustado = salarioFuncionario * (percentualReajuste / 100 + 1);
            salarioReajustado =Math.Round(salarioReajustado,2);
            return salarioReajustado;
        }

        static void Main(string[] args)
        {



        }
    }
}