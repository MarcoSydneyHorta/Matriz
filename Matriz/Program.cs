using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite 6 números inteiros separados por espaço: ");
            string[] vs1 = Console.ReadLine().Split(' ');
            int tam = vs1.Length;
            string vs2 = "";
            for (int i = 0; i < tam; i++)
                vs2 += vs1[i];

            int[,] mat = new int[3, 2];
            int n = 0;
            Console.WriteLine("Quantidade de números digitados: " + tam);
            Console.WriteLine("vs2: " + vs2);

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    mat[i, j] = int.Parse(vs1[n]);
                    n++;
                }

            }

            n = 0;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(" mat[" + i + "," + j + "]" + " = " + mat[i, j]);
                }

            }
        }
    }
}
