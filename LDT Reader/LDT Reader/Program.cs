using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;



namespace LDT_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            String Datei = "d:\\Datei";
            // suchbegriffe 3101 = Nachname 3102 = Vorname = 8405"9" = Fallnummer 3103 = Geburtsdatum 
            String[] suchbegriff = { "3101", "3102", "84059", "3103" };
            ArrayList Patdaten = wortsuche(suchbegriff, Datei);

           ausgabe(Patdaten);
           ersetzen(Datei, Patdaten[0].ToString(), "maxmuster");
           ausgabe(Patdaten = wortsuche(suchbegriff, Datei));
        }


       static public void ausgabe(ArrayList Patdaten)
        {
            // string sOutput in arrText
            foreach (String output in Patdaten)
                Console.WriteLine(output);
            Console.ReadLine();
        }

        static public ArrayList wortsuche(String[] suchwort, String Datei)
        {
            Console.WriteLine("Wortsuche gestartet");
            StreamReader objReader = new StreamReader(Datei);
            string sLine = "";
            ArrayList gefundenes_word = new ArrayList();
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                {
                    if (sLine.IndexOf(suchwort[0]) != -1)
                    {                
                        gefundenes_word.Add(sLine.Substring(7));
                    }
                    if (sLine != null)

                        if (sLine.IndexOf(suchwort[1]) != -1)
                        {
                            gefundenes_word.Add(sLine.Substring(7));
                        }
                    if (sLine != null)

                        if (sLine.IndexOf(suchwort[2]) != -1)
                        {
                            gefundenes_word.Add(sLine.Substring(8));
                        }
                    if (sLine != null)

                        if (sLine.IndexOf(suchwort[3]) != -1)
                        {
                            gefundenes_word.Add(sLine.Substring(7));
                        }
                }

            }
            objReader.Close();
            return gefundenes_word;
        }

        static public void ersetzen(String Datei, String zuersetzen, String durch )
        {
            Console.WriteLine(" zuersetzen: " + zuersetzen+ " durch: " + durch);
            StreamReader eingabe = File.OpenText(Datei);
            String inhalt = eingabe.ReadToEnd();
            eingabe.Close();
            inhalt = inhalt.Replace(zuersetzen, durch);
            StreamWriter ausgabe = File.CreateText("d:\\Datei");
            ausgabe.Write(inhalt);
            ausgabe.Close();
        }
    }
}
