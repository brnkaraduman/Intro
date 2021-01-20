using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Berna";
            kurs1.IzlenmeOranı = 47;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Birnur";
            kurs2.IzlenmeOranı = 53;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Eğitmen = "Zeynep";
            kurs3.IzlenmeOranı = 64;

            Kurs[] kurslar = new Kurs[]
                {
              kurs1,kurs2,kurs3
                };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " :" + kurs.Eğitmen);
            }
            // Console.WriteLine(kurs1.KursAdi + " :" + kurs1.Eğitmen);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
