using System;
using System.IO;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"C:\github\183\02b_edition_fichier\A distribuer\text.txt"))
                {
                    string line;

                    Console.Write("Contenu : \n");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.Write(line);
                    }
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erreur de la lecture du fichier");
            }
            Console.ReadKey();
        }
    }
}
