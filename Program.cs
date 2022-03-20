using System;
namespace od3
{
    class Program
    {
        static  void Main(string[] args)
        {
            ///Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı 
            //kelimeleri sondan başa doğru console'a yazdırın.


            Console.Write("Lütfen pozitif bir sayı giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            string[] dizi = new string[diziUzunlugu];

            Console.WriteLine("Lütfen girdiğiniz sayı kadar kelime giriniz.");

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}.kelimeyi giriniz: ",i+1);
                dizi[i] = Console.ReadLine();
            }

            int son = dizi.Length-1;

            for (int i = son; i >= 0; --i)
            {
                Console.WriteLine(dizi[i]);
            }

            




        }
    }
}
