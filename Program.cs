using System;

namespace Array_Sınıfı_Metodları
{
    class Program
    {
        static void Main(string[] args)
        {
           //Sort
           int[] sayidizisi = {23,12,45,78,2,25,41,32} ;

           Console.WriteLine("****Sırasız Dizi****") ;

           foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi) ;
               
           Console.WriteLine("****Sıralı Dizi****") ;
           Array.Sort(sayidizisi) ;

           foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi) ;

            //Clear
            Console.WriteLine("****Clear Dizi****") ;

            Array.Clear(sayidizisi,2,2) ;  //dizide 2. indeksten itibaren (2. dahil değil) 2 eleman 0'lar
            foreach(var sayi in sayidizisi)
                 Console.WriteLine(sayi) ;

            //Reverse
            Console.WriteLine("****Reverse Dizi****") ; //diziyi tersten yazar
            Array.Reverse(sayidizisi) ;
            foreach(var sayi in sayidizisi)
                 Console.WriteLine(sayi) ;

            //IndexOf
            Console.WriteLine("****IndexOf Dizi****") ; //dizideki elemanın indeksini söyler
                 Console.WriteLine(Array.IndexOf(sayidizisi, 45)) ;

            //Resize
            Console.WriteLine("****Resize Dizi****") ; //
            Array.Resize<int>(ref sayidizisi, 10) ;
            sayidizisi[8] = 14 ;
            sayidizisi[9] = 28 ;

            foreach (var sayi in sayidizisi)
                 Console.WriteLine(sayi) ;

        }
    }
}
