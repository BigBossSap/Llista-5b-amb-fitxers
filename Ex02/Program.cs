using System;
using System.IO;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           char lletra;
            int contVocal = 0;

            StreamReader fitxerR = new StreamReader(@"C:\Users\sergi\source\repos\llista 5.b fitxers\Ex02\text.txt");
            StreamWriter fitxerW = new StreamWriter(@"C:\Users\sergi\source\repos\llista 5.b fitxers\Ex02\resultat.txt", true);
            lletra = (char)fitxerR.Read();

            do

            {

                if (lletra == 'A' || lletra == 'E' || lletra == 'I' || lletra == 'O'
                    || lletra == 'U' || lletra == 'a' || lletra == 'e' || lletra == 'i' || lletra == 'o' || lletra == 'u')
                    contVocal++;

                lletra = lletra = (char)fitxerR.Read();
            } while (!fitxerR.EndOfStream);

            fitxerW.WriteLine(contVocal);

            fitxerR.Close();
            fitxerW.Close();
        }
    }
}
