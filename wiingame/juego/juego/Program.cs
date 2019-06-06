using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego
{
    class Program
    {
        static void Main(string[] args)
        {
            juego a = new juego();


            if (a.winagame())
                Console.WriteLine("gano :) ");
            else
                Console.WriteLine("perdio :(... ");
            Console.ReadLine();
        }
    }
    class juego
    {
        public Char[,] matriz = new Char[3, 3]; /*{
            { 'x', 'o', 'x' },
            { 'o', 'o', 'o' },
            { 'x', 'o', 'x' }
        };  */

        public bool marcar(int i, int j, Char simbolo)
        {
            matriz[i, j] = simbolo;

            return true;
        }
        public bool winagame()
        {
            bool gano = false;
            int c = 0;
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (matriz[i, c] == matriz[i, c + 1] && matriz[i, c] == matriz[i, c + 2])
                {
                    gano = true;
                    break;
                }

            }

            i = 0;

            for (c = 0; c < 3; c++)
            {
                if (matriz[i, c] == matriz[i + 1, c] && matriz[i, c] == matriz[i + 2, c])
                {
                    gano = true;
                    break;
                }
            }
            if (matriz[0,0] == matriz[1,1] && matriz[0,0] == matriz[2,2] || matriz[0, 2] == matriz[1, 1] && matriz[0,2] == matriz[2,0])
            {
                gano = true;
                
            }
            return gano;

        }


    }
}
