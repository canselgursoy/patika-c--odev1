using System;
namespace odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Lütfen bir cümle yazınız:");
            string cümle = Console.ReadLine();

            

            string [] dizi = cümle.Split(' ');
            Console.WriteLine("Kelime sayısı:"+ dizi.Length);
            Console.Write("Harf sayısı:"+cümle.Length);

            
            


            

            



        }
    }
}