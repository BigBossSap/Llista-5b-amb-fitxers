using System;
using System.IO;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lletra;
            double contVocal = 0, contConsonants = 0;

            StreamReader fitxerR = new StreamReader(@"C:\Users\sergi\source\repos\llista 5.b fitxers\Ex03\text.txt");
            StreamWriter fitxerW = new StreamWriter(@"C:\Users\sergi\source\repos\llista 5.b fitxers\Ex03\resultat.txt", true);
            lletra = (char)fitxerR.Read();

            do
            {
                if (lletra == 'A' || lletra == 'E' || lletra == 'I' || lletra == 'O'
                    || lletra == 'U' || lletra == 'a' || lletra == 'e' || lletra == 'i' || lletra == 'o' || lletra == 'u')
                    contVocal++;

                else if (lletra != ' ' && lletra != '.')
                    contConsonants++;




                lletra = (char)fitxerR.Read();
            } while (!fitxerR.EndOfStream);

             

            double percentatjeVocals = contVocal * 100 / (contVocal + contConsonants);
            double percentatjeConsonants = contConsonants * 100 / (contVocal + contConsonants);
                  
            
            fitxerW.WriteLine($"La frase te {contVocal} vocals que es un {Math.Round(percentatjeVocals, 2)}% i {contConsonants} consonants que es un {Math.Round(percentatjeConsonants, 2)}%.");
            fitxerR.Close();    
            fitxerW.Close();
        }

    }
}
