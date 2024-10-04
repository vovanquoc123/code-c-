using System;

namespace bien
{
    class mang2chieu
    {
        public static void Main()
        {  
         int a ,b ;
         Console.WriteLine(" so sánh 2 số chẳn và lẻ ");
         Console.Write ("nhap so a: ");
         a = Convert.ToInt32(Console.ReadLine ());
         b = a /2 ;
         if (a == 0)
         {
          Console.WriteLine("{0} là so chan ", a);

         }
         else 
         {
          Console.WriteLine("{0} là so le ", a);
         }
         Console.ReadKey();

    }
}
}