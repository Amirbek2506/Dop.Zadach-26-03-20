using System;

namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        {/*
                        // Задача 1
            decimal Summ;
         Console.Write("Сумма покупка: ");
         Summ=Convert.ToDecimal(Console.ReadLine());
         if(Summ>500m && Summ<1000m)
         {
             Summ-=((Summ*3)/100);
             Console.WriteLine($" Скидка 3% ");
         }
         else if(Summ>1000m)
         {
             Summ-=((Summ*5)/100);
             Console.WriteLine($" Скидка 5% ");
         }
         Console.WriteLine($"Сумма оплата: {Summ}");
         Console.ReadKey();
                        // Задача 2
         double A1,A2,A3,A4,Min=0.0;
         Console.Write($"A1 = ");
         A1=Convert.ToDouble(Console.ReadLine());
         Console.Write($"A2 = ");
         A2=Convert.ToDouble(Console.ReadLine());
         Console.Write($"A3 = ");
         A3=Convert.ToDouble(Console.ReadLine());
         Console.Write($"A4 = ");
         A4=Convert.ToDouble(Console.ReadLine());

         bool a=!(A1<A2 && A2<A3 && A3<A4);

         if(a)                                   //Если они не по возрастанию
         {
             if(A1==A2 && A2==A3 && A3==A4)         //Если они равны
         {
             Console.WriteLine($"{A1} * {A2} * {A3} * {A4} = {A1 * A2 * A3 * A4}");
         }
         else{  if(A1<A2 && A1<A3 && A1<A4) Min=A1;
                if(A2<A1 && A2<A3 && A2<A4) Min=A2;
                if(A3<A1 && A3<A2 && A3<A4) Min=A3;
                if(A4<A1 && A4<A2 && A4<A3) Min=A4;
                Console.WriteLine($"Min({A1}, {A2}, {A3}, {A4}) = {Min}");}
         }
         else System.Console.WriteLine(" \t Числа расположены по возрастанию");
         Console.ReadKey();
                                 //Задача 3
         double a,b,c,K;
         Console.Write($"a = ");
         a=Convert.ToDouble(Console.ReadLine());
         Console.Write($"b = ");
         b=Convert.ToDouble(Console.ReadLine());
         Console.Write($"c = ");
         c=Convert.ToDouble(Console.ReadLine());

         if(b>a && a>c){ K=a; a=b; b=K; }
         else if(c>a && a>b){K=a; a=c; c=b; b=K;}
         else if(c>b && b>a){K=a; a=c; c=K;}
         else if(a>b && b<c){K=b; b=c; c=K;}
         else if(b>a && a<c){K=a; a=b; b=c; c=K;}
         Console.WriteLine($"{a}, {b}, {c};");
         Console.ReadKey();*/
        }
    }
}
