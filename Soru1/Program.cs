using System;
using System.Collections;

namespace Sorular2
{
    class Program
    {
        static void Main(string[] args)
        {
             ArrayList Asalsayilar=new ArrayList();
             ArrayList AsalOlmayansayilar=new ArrayList();

             int kontrol=0;
             int deger1=0;
             int deger2=0;
             int toplam1=0;
             int toplam2=0;
      
             Console.WriteLine("Sayılarınızı giriniz");
             
             for (int j = 0; j < 7; j++)
             {
                 int sayi=Convert.ToInt32(Console.ReadLine());
                 
                 if(sayi<0)
                  Console.WriteLine("Lütfen Pozitif bir değer giriniz");
                  else                 
                  {
                    for (int i = 2; i < sayi; i++)
                   {
                      if(sayi%i==0)
                    {
                       kontrol=1;                   
                    }
                    else
                        kontrol=0;

                     if(kontrol>=1)
                      break;
                   }
                        if(kontrol!=0)
                       {
                           AsalOlmayansayilar.Add(sayi);
                       }
                          else
                          {
                           Asalsayilar.Add(sayi);
                        }
                        if(j==6)
                        {
                            Console.WriteLine("Asalsayılar");
                            foreach (var item1 in Asalsayilar)
                            {                            
                                Console.WriteLine(item1);
                                deger1++;
                                toplam1=(int)item1+toplam1;
                            }
                            Console.WriteLine("{0} tane asal sayı girilmiştir. Ortalaması ={1}'dir",deger1,toplam1/deger1);
                            
                            
                            Console.WriteLine("Asalolmayan Sayılar");
                            foreach (var item2 in AsalOlmayansayilar)
                            {
                                Console.WriteLine(item2);
                                deger2++;
                                toplam2=(int)item2+toplam2;
                                
                            }
                            Console.WriteLine("{0} tane asal sayı girilmiştir. Ortalaması ={1}'dir",deger2,toplam2/deger2);
                            
                            
                    }
                      
                  }
                 
                 

                
               
            }
            
             
       
        }
    }
}
