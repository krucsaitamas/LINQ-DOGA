using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Games
    {
        //Cim,Mufaj,KiadasDatum,AktivJatekosok,Ertekeles
        public string Cim { get; set; }
        public string Mufaj { get; set; }
        public DateTime KiadasDatum { get; set; }
        public int AktivJatekosok { get; set; }
        public float Ertekeles { get; set; }

        public override string ToString() =>
            $"\tCím: {Cim}\n" +
            $"\tMűfaj: {Mufaj}\n" +
            $"\tKiadás dátuma: {KiadasDatum}\n" +
            $"\tAktív játékosok száma: {AktivJatekosok}\n" +
            $"\tÉrtékelés: {Ertekeles}";
    }
}
