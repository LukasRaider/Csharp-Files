using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
//Zadejte počet dnů a hodin. Program vypočte, kolik je to hodin (výsledek může být reálné číslo)
//Nejprve parsování z textového souboru do proměnných. Vytvořte třídu A1FileStr.
//A to tak, že upravíte A1 pro čtení z textového souboru (předem vytvoříte pomocí notepadu) a výsledek uložte do textového souboru.
//Použijte třídy metody vracející a ukládající řetězec. Které to jsou?
namespace PredelaniCvzVB
{
    class A1FileStr
    {
        
        public static void Mainx(string[] args)
        {
            int dny;
            int hodiny;
            String  TextReader = "";
            
            
            String cesta = "C:\\Users\\Lenovo\\Dokumenty\\Novy.txt";
            Console.WriteLine("Jestli chces prepsat stavajici soubor napis 1");
            
                TextReader = File.ReadAllText(cesta);
            
            
            Console.Write("Zadejte pocet dnu: ");
            dny = int.Parse(Console.ReadLine());
            TextReader += (dny.ToString() + " dnu\n");
            Console.Write("Zadejte pocet hodin: ");
            hodiny = int.Parse(Console.ReadLine());
            TextReader += (hodiny.ToString() + " hodin\n");
            Console.WriteLine("\n{0} dnu a {1} hodiny je {2} hodin\n", dny, hodiny, (dny * 24) + hodiny);
            Console.WriteLine("\n" + dny + " dnu a " + hodiny + "hodiny je " + (dny * 24) + hodiny + " hodin\n"); //druhá možnost

            if (File.Exists(cesta))
            {
                try
                {
                    Console.WriteLine("Soubor existuje");
                    File.WriteAllText(cesta, TextReader);
                    Console.WriteLine(File.ReadAllText(cesta) + "Kontrola zapisu");
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            else {
                File.Create(cesta).Close();
                File.WriteAllText(cesta, TextReader);
                Console.WriteLine(File.ReadAllText(cesta)+ "Kontrola zapisu");
            }
        }
    }
}
