using System;
using System.IO;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Fer un programa que demani una llista de números positius acabada en ‐1 i digui si
  el primer es repeteix.   */


            int num, comparador = int.MinValue;
            bool semafor = true;
            int aux=0;

            StreamReader fitxerR = new StreamReader(@"D:\repos\llista 5b fitxers\Llista 5b amb fitxers\Ex01\llista.txt");
            StreamWriter fitxerW = new StreamWriter(@"D:\repos\llista 5b fitxers\Llista 5b amb fitxers\Ex01\resultat.txt");
            num = Convert.ToInt32(fitxerR.ReadLine());


            while (!(fitxerR.EndOfStream))
            {



                if (comparador == num)

                    semafor = false;


                comparador = num;

                num = Convert.ToInt32(fitxerR.ReadLine());
            }

            if (semafor)
                fitxerW.WriteLine("No");
            else
                fitxerW.WriteLine("Si");

            fitxerR.Close();
            fitxerW.Close();

        }
    }
}
