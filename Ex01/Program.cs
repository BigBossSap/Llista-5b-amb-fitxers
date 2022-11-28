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


            int num, cont =0, primerNum;
            bool semafor = true;
            int aux=0;

            StreamReader fitxerR = new StreamReader(@"D:\repos\llista 5b fitxers\Llista 5b amb fitxers\Ex01\llista.txt");
            StreamWriter fitxerW = new StreamWriter(@"D:\repos\llista 5b fitxers\Llista 5b amb fitxers\Ex01\resultat.txt");
            primerNum = Convert.ToInt32(fitxerR.ReadLine());
            num = Convert.ToInt32(fitxerR.ReadLine());
            

            while (!(fitxerR.EndOfStream))
            {


                num = Convert.ToInt32(fitxerR.ReadLine());
                if (primerNum == num)
                {

                    semafor = false;
                    cont++;
                }
                                
            }

            if (semafor)
                fitxerW.WriteLine("No");
            else
                fitxerW.WriteLine($"Si, {primerNum} es repeteix {cont} veguades");

            fitxerR.Close();
            fitxerW.Close();

        }
    }
}
