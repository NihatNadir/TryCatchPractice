using System;
namespace TryCatchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bir sayı giriniz..."); 

                try
                {
                    int number = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan sayı alıyoruz.
                    Console.WriteLine($"Sayının karesi = {number*number}"); // Alınan değer int değer ise ekrana sayının karesi yazdırılır döngüden çıkış yapılır.
                    break; // Doğru sonuç geldiğinde çıkış yapılır.
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz."); // Kullanıcı hatalı değer girerse catch yakalar ve ekrana hatalı olduğu yazdırılır.
                }
                
            }
        }


    }

    

}