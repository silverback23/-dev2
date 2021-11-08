using System;
using System.Collections;

namespace Sorular2
{
    class Program
    {
        static void Main(string[] args)
    {
      ArrayList sayilar=new ArrayList();
      

      Console.WriteLine("Sayılarınızı giriniz");
      
      for (int i = 0; i < 21; i++)
      {
          int sayi=Convert.ToInt32(Console.ReadLine());
          sayilar.Add(sayi);
           if(i==20)
           {
               sayilar.Sort();
               Console.WriteLine("sayilar");
               foreach (var item in sayilar)
               {
                   Console.WriteLine(item);
               }    
               Console.WriteLine("En büyük 3 sayı sıralaması={0}-{1}-{2} ",sayilar[20],sayilar[19],sayilar[18]);
               Console.WriteLine("Toplamları= {0} Ortalaması ise = {1}",(int)sayilar[20]+(int)sayilar[19]+(int)sayilar[18],((int)sayilar[6]+(int)sayilar[5]+(int)sayilar[4])/3);

               Console.WriteLine("En küçük 3 sayı sıralaması={0}-{1}-{2} ",sayilar[0],sayilar[1],sayilar[2]);
               Console.WriteLine("Toplamları= {0} Ortalaması ise = {1}",(int)sayilar[0]+(int)sayilar[1]+(int)sayilar[2],((int)sayilar[0]+(int)sayilar[1]+(int)sayilar[2])/3);

           }

       
       
      }
    }
    
 }
} 
