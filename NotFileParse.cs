using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files;
class FileNotParse
{

    public static void Mainx()
    {   //třída TextFile.cs v projektu Soubory
        //co se bude zapisovat
        Console.WriteLine("Napiste neco:");
        string zprava = Console.ReadLine();
        //string[] poleStringu = new string[] { "pes", "kocka", "medved", "koza" };

        string cesta = "C:/kurs/zvirata.txt";  //Full Name souboru

        FileInfo file = new FileInfo(cesta);

        if (file.Directory.Exists)
        {
            //zapis pomoci metody WriteAllLines		
            //File.WriteAllLines(cesta, poleStringu);
            //zapis pomoci metody WriteAllText
            File.WriteAllText(cesta, zprava);

            //cteni pomoci ReadAllLines(cele az po konec else)
            //Console.WriteLine("Nasleduje precteni souboru pomoci metody ReadAllLines.");
            //string[] poleStringu2 = File.ReadAllLines(cesta);
            //for (int i = 0; i < poleStringu2.Length; i++) {
            //    Console.WriteLine(poleStringu2[i]);
            //}
            //Console.WriteLine("Precteno!");
        }
        else
            Console.WriteLine("cesta " + file.Directory + " neexistuje");

        //cteni pomoci ReadAllText
        Console.WriteLine("Nasleduje precteni souboru pomoci metody ReadAllText.");
        string coSePrecetlo = File.ReadAllText(cesta);
        Console.WriteLine(coSePrecetlo);
    }
}
