using System;
class program
{

    public class Solution
    {
        public static decimal CustoCompra(decimal quantidadeComprada)
        {
            decimal valorUnidade = 0;
            if (quantidadeComprada > 10)
            {
                valorUnidade = 1.25m;
            }
            else
            {
                valorUnidade = 1.45m;
            }

            decimal valorTotal = quantidadeComprada * valorUnidade;
            valorTotal = Math.Round(valorTotal, 2);
            return valorTotal;
        }
    }
}