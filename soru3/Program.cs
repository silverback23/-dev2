using System;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sesli = { 'a','e','ı','i','u','ü','o','ö'}; 
            int sayac = 0; 
            Console.WriteLine("Cümlenizi Giriniz: "); 
            String cumle = Console.ReadLine(); 

            for (int i = 0; i < cumle.Length; i++) 
            {
              for (int j = 0; j < sesli.Length; j++)
              {
                if (cumle[i]==sesli[j]) 
                {
                    sayac++; 
                }
               }
            }
            Console.WriteLine("sesli harf sayısı : {0}",sayac); 
            Console.ReadKey();
           
        }
    }
}
            