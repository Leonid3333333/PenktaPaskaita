using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPaskaita
{
    public class Matrica

    {
       public int[,] dvimatis = {
            {7, 8 , 7 },
            {8, 10, 155},
            {0, 55, 0} };

        public int[,] Sugeneruotas()
        {
            int[,] Sugeneruotas = new int[,];

            for (int i = 0; i < dvimatis.GetLength(0); i++)
            {
                for(int j = 0; j < dvimatis.GetLength(1); j++)
                {
                    Console.WriteLine();
                }
            }
            return dvimatis;
        }

        public static int[,] Transponuoti(int[,] dvimatis)
        {

            int length1 = dvimatis.GetLength(0);
            int length2 = dvimatis.GetLength(1);

            int[,] transponuotas = new int[length2, length1];

            for (int i = 0; i < transponuotas.GetLength(0); i++)
            {
                for (int j = 0; j < transponuotas.GetLength(1); j++)
                {
                    transponuotas[i, j] = dvimatis[j, i];
                }
            }
            return transponuotas;

        }
        public int[,] Sumuoti(int[,] dvimatis1, int[,] dvimatis2)
        {
            int length1 = dvimatis1.GetLength(0);
            int length2 = dvimatis1.GetLength(1);
            int[,] sum = new int[length1, length2];

            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    sum[i, j] = dvimatis1[i, j] + dvimatis2[i, j];
                }
            }
            return sum;
        }

    }
}
