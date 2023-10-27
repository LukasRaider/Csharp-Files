using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files;
class FilesDelete
{
    public static void Mainx()
    {
        //Program vypíše obsah adresáře. 
        FileInfo[] listOfFiles;
        DirectoryInfo cesta = new DirectoryInfo("C:\\kurs\\pokusy\\");  //"C:/kurs/pokusy/"  @"C:\kurs\pokusy\"
        if (cesta.Exists)
        {
            Console.WriteLine($"Adresar existuje, obsahuje {cesta.GetFiles().Length} souboru.");
            listOfFiles = cesta.GetFiles();
            foreach (FileInfo file in listOfFiles)
            {
                Console.WriteLine($"{file.Name}\t{file.Length}\t{file.LastWriteTime}");//názvy a délky souborů ve složce
            }
        }
        else
        {
            Console.WriteLine("Slozka neexistuje");
        }
        //který soubor má smazat
        Console.WriteLine("Který soubor chcete smazat?");
        string toDelete = Console.ReadLine();
        //Poté se soubor smaže, což bude dokázáno novým výpisem adresáře, kde již daný soubor chybí

        //1. metoda Delete tridy File
        //Console.WriteLine(File.Exists(cesta.ToString() + toDelete) ? "Soubor existuje" : "Soubor neexistuje");   //pomoci File
        //if (File.Exists(cesta.ToString() + toDelete)) {
        //    File.Delete(cesta.ToString() + toDelete);
        //    Console.WriteLine(File.Exists(cesta.ToString() + toDelete) ? "Soubor nebyl smazán" : "Soubor smazán");
        //}

        //2. to same pomoci instancni metody tridy FileInfo
        FileInfo fi = new FileInfo(cesta.ToString() + toDelete);
        Console.WriteLine((fi.Exists) ? "Soubor existuje" : "Soubor neexistuje");
        if (fi.Exists)
        {
            fi.Delete();
            Console.WriteLine("Soubor smazan");
        }

        //spolecny vypis
        Console.WriteLine($"Adresar existuje, obsahuje {cesta.GetFiles().Length} souboru.");
        listOfFiles = cesta.GetFiles();
        foreach (FileInfo file in listOfFiles)
        {
            Console.WriteLine(file.Name + "\t" + file.Length);//názvy a délky souborů ve složce
        }

    }
}
