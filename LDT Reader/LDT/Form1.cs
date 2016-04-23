using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace LDT
{
    public partial class Form1 : Form
    {
        public ArrayList Patdaten;
        static public String pfad;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pfad = openFileDialog1.FileName;
            //MessageBox.Show(pfad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                einlesen(pfad);
                // ersetzen(Datei, Patdaten[0].ToString(), "maxmuster");
                // ausgabe(Patdaten = wortsuche(suchbegriff, Datei));
            }

        }

        static public void ausgabe(ArrayList Patdaten)
        {
            // string sOutput in arrText
            foreach (String output in Patdaten)
                Console.WriteLine(output);
            Console.ReadLine();
        }

        public void einlesen(String pfad)
        {
            // suchbegriffe 3101 = Nachname 3102 = Vorname = 8405"9" = Fallnummer 3103 = Geburtsdatum 
            String[] suchbegriff = { "3101", "3102", "84059", "3103" };
            Patdaten = wortsuche(suchbegriff, pfad);
            ausgabe(Patdaten);
            this.TXT_Name.Text = Patdaten[0].ToString();
            this.TXT_Vorname.Text = Patdaten[1].ToString();
            this.TXT_Gebdat.Text = Patdaten[2].ToString();
            this.TXT_Fallnummer.Text = Patdaten[3].ToString();

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

        static public void ersetzen(String zuersetzen, String durch)
        {
            Console.WriteLine(" zuersetzen: " + zuersetzen + " durch: " + durch);
            StreamReader eingabe = File.OpenText(pfad);
            String inhalt = eingabe.ReadToEnd();
            eingabe.Close();
            inhalt = inhalt.Replace(zuersetzen, durch);
            StreamWriter ausgabe = File.CreateText(pfad);
            ausgabe.Write(inhalt);
            ausgabe.Close();
        }

        private void button_Speichern_Click(object sender, EventArgs e)
        {
            ArrayList aenderungen = new ArrayList();

            if(!this.TXT_Name.Text.Equals(Patdaten[0].ToString()))
            {
                ersetzen(Patdaten[0].ToString(), this.TXT_Name.Text);
                aenderungen.Add(Patdaten[0].ToString() + " in " + this.TXT_Name.Text);
            }

            if (!this.TXT_Vorname.Text.Equals(Patdaten[1].ToString()))
            {
                ersetzen(Patdaten[1].ToString(), this.TXT_Vorname.Text);
                aenderungen.Add(Patdaten[1].ToString() + " in " + this.TXT_Vorname.Text);
            }

            if (!this.TXT_Gebdat.Text.Equals(Patdaten[2].ToString()))
            {
                ersetzen(Patdaten[2].ToString(), this.TXT_Gebdat.Text);
                aenderungen.Add(Patdaten[2].ToString() + " in " + this.TXT_Gebdat.Text);
            }

            if (!this.TXT_Fallnummer.Text.Equals(Patdaten[3].ToString()))
            {
                ersetzen(Patdaten[3].ToString(), this.TXT_Fallnummer.Text);
                aenderungen.Add(Patdaten[3].ToString() + " in " + this.TXT_Fallnummer.Text);
            }


            String printString = null;
            foreach (object o in aenderungen)
            {
                // Add the fields you want to show here
                printString+= "\n" + o.ToString();
            }



            if(printString!=null)
            {
                MessageBox.Show(printString);
            }
            

        }
    }
}
