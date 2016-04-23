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
            StreamReader objReader = new StreamReader("c:\\Users\\fwantzen\\Desktop\\20160303163832_A0154100303.ldt");
            String[] suchbegriff = { "3101", "3102", "84059", "3103" };
            ArrayList Patidnet = wortsuche(suchbegriff, objReader);

            // string sOutput in arrText
            foreach (String output in Patidnet)
                Console.WriteLine(output);
            objReader.Close();
            Console.ReadLine();
        }

        static public ArrayList wortsuche(String[] suchwort, StreamReader datei)
        {
            Console.WriteLine("wortsuche");
            Console.WriteLine(suchwort[0]);
            string sLine = "";
            ArrayList gefundenes_word = new ArrayList();
            while (sLine != null)
            {
                sLine = datei.ReadLine();
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
            return gefundenes_word;
        }

    }
}
