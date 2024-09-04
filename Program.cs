using System;

namespace SUMDUONGCHEO
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int n;
            int sum=0;
            int[,] arr1= new int[10,10];

            Console.WriteLine("Nhap size ma tran: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Nhap cac phan tu cua ma tran:\n");
            for(a=0;a<n;a++)
            {
                for(b=0;b<n;b++)
                {
                    Console.Write("Phan tu[{0}],[{1}]: ", a, b);
                    arr1[a, b] = int.Parse(Console.ReadLine());
                    if(a==b) sum = sum + arr1[a,b];
                }
            }
            Console.Write("In ma tran:\n");
            for(a=0;a<n;a++)
            {
                for(b=0;b<n;b++)
                {
                    Console.Write("{0} ", arr1[a, b]);
                Console.Write("\n");
                }
            }
            Console.Write("Tong cac phan tu tren duong cheo chinh la: {0}\n", sum);
            Console.ReadKey();
        }
    }
}