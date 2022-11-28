using System;
using System.IO;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
            bool imparell = true;
            StreamReader fitxerR = new StreamReader(@"D:\repos\llista 5b fitxers\Llista 5b amb fitxers\Ex10\llista.txt");
            StreamWriter fitxerW = new StreamWriter(@"D:\repos\llista 5b fitxers\Llista 5b amb fitxers\Ex10\resultat.txt", true);
            num = Convert.ToInt32(fitxerR.ReadLine());


            while (!(fitxerR.EndOfStream))
            {
                if (num % 2 != 0)
                    imparell = false;

                num = Convert.ToInt32(fitxerR.ReadLine());
            }

            if (imparell == false)
                fitxerW.WriteLine("No son tots parells.");
            else
                fitxerW.WriteLine("Son tots parells.");

            fitxerR.Close();
            fitxerW.Close();
        }
    }
}
