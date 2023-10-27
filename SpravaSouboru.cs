using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading.Channels;

namespace WorkWithFIle
{



    class SpravaSouboru {
        public static void Mainx(string[] args)
        {
            //string cesta = "C:\\kurs\\soubor.txt";
            string cesta = "C:\\Users\\Lenovo\\Dokumenty\\text.txt";
            FileInfo soubor = new FileInfo(cesta);
            //Console.WriteLine(File.exists(cesta) ? "Soubor existuje" : "Soubor nebyl smazan");
            if (File.Exists(cesta)) {
                //File.Delete(cesta);
                Console.WriteLine(File.Exists(cesta) ? "Soubor nebyl smazan" : "Soubor nebyl vytvoren");
            }
            try {
                File.Exists(cesta);
                Console.WriteLine("Soubor zije.");
                File.Create(cesta);
            }
            catch (IOException) { Console.WriteLine("Soubor nejze vytvorit");
            Console.WriteLine(File.Exists(cesta) ? "Soubor vytvoren" : "Soubor nebyl vytvoren");
            }
        }
    }
}

