using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            Console.Write("Dizinin eleman sayısını giriniz: ");
            int len = int.Parse(Console.ReadLine());
            int[] numList = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write($"{i+1}. sayıyı giriniz: ");
                numList[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (var num in numList)
            {
                sum += num;
            }

            Console.WriteLine("Ortalama: " + sum / len);
        }
    }
}
