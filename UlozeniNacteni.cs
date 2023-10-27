using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFIle
{
     class UlozeniNacteni
    {
        public static void Mainx(string[] args)
        {
            //string cesta = "C:\\kurs\\soubor.txt";
            string cesta = "C:\\Users\\Lenovo\\Dokumenty\\text.txt";
            FileInfo soubor = new FileInfo(cesta);
            //Console.WriteLine(File.exists(cesta) ? "Soubor existuje" : "Soubor nebyl smazan");
            if (File.Exists(cesta))
            {
                //File.Delete(cesta);
                Console.WriteLine(File.Exists(cesta) ? "Soubor nebyl smazan" : "Soubor nebyl vytvoren");
            }
            try
            { 
                File.Exists(cesta);
                Console.WriteLine("Soubor exituje.");
                string text = "";
                text = File.ReadAllText(cesta);
                Console.WriteLine(text);
                text += Console.ReadLine();
                File.WriteAllText(cesta, text);
                //File.Create(cesta);
                Console.WriteLine(text);
            }
            catch (IOException)
            {
                Console.WriteLine("Soubor nejze vytvorit");
                Console.WriteLine(File.Exists(cesta) ? "Soubor vytvoren" : "Soubor nebyl vytvoren");
            }
           
        }
    }
}
