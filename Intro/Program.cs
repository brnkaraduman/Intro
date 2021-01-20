using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1= "ders1-c#";
            //string kurs2 = "ders2-phyton";
            //string kurs3 = "ders3-java";
            String[] kurslar = new string[] { "ders1-c#","ders2-c#", "ders3-c#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("FOR Sonu");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("FOREACH Sonu");
        }
    }
}
