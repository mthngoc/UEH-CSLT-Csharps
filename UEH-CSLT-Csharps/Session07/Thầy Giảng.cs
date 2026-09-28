//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace UEH_CSLT_Csharps.Session07
//{
//    internal class Thầy_Giảng
//    {
//        public static void Main(string[] args)
//        {
//            //int[] mang; //mang -> null 
//            //mang = new int[2]; // instantiation (memory allocation)

//            //initialization
//            //int[] mang2 = new int[2];

//            //vừa khởi nhớ vừa cấp phát vùng nhớ 
//            // *int[] mang3 = new
//            //int[] mang3 = new int[2] {1,2};
//            int N = 5;
//            Console.Write("Nhập số phần tử mảng N = ");//số bất kỳ
//            int[] mang = new int[N];
//            //nhapmang_com(mang);
//            nhapmang_random(mang);
//            Console.WriteLine(" Mảng sau khi nhập: ");
//            inmang(mang);
//            int m = Tim_Max_Mang(mang);
//            //in_SoNguyenTo(mang);
//        }
//        static void nhapmang_random(int[] a)
//        {
//            Random rnd = new Random();
//            for (int i = 0; i < a.Length; i++)
//            {
//                a[i] = rnd.Next(1, 100);
//            }
//        }
//        static void nhapmang_com(int[] a)
//        {
//            for (int i = 0; i < a.Length; i++)
//            {
//                Console.Write($"a[{i}] = ");
//                a[i] = int.Parse(Console.ReadLine());
//            }
//        }
//        static void inmang(int[] a)
//        {
//            foreach (int v in a)
//                Console.Write($" {v}, ");
//        }
//        //static ??? do_fooo(int[] a)
//        //{
//        //    for(int i = 0; i<a.Length; i++)
//        //    {
//        //        do on a[i]
//        //    }
//        //}
//        static int Tim_Max_Mang(int[] a)
//        {
//            int max = 0;
//            for (int i = 1; i < a.Length; i++)
//            {
//                if (a[i] > max) max = a[i];
//            }
//            return max;
//        }
//        //static void in_SoNguyenTo(int[] a)
//        //{
//        //    foreach (int v in a)
//        //        if (IsPrime(v))
//        //            Console.Write($"{v}, ");
//        //}
//        //private static void bool //chưa xong

//        public static void Main(string[] args)
//        {
//            int[,] mang;
//            mang = new int[3, 4];

//            int[,] mang2 = new int[3, 4];
//            int[,] mang3 = new int[3, 4]
//            {
//                { 1, 2, 3, 4},
//                { 5, 6, 7, 8},
//                { 9, 10, 11, 12}
//            };
//            int[,] mang4 =
//            {
//                { 1, 2, 3, 4},
//                { 5, 6, 7, 8},
//                { 9, 10, 11, 12}
//            };
//            int[,] mang;
//            mang = new int[3, 4];

//        }
//        static void nhap_mang(int[,] a)
//        {
//            for (int i = 0; i < a.GetLength(0); i++)
//            {
//                for (int j = 0; j < a.GetLength(1); j++)
//                {
//                    Console.Write($"{a[i, j]} = ");
//                    a[i, j] = int.Parse(Console.ReadLine());
//                }
//            }
//        }
//        static void in_mang(int[,] a)
//        {
//            for (int i = 0; i < a.GetLength(0); i++)
//            {
//                for (int j = 0; j < a.GetLength(1); j++)
//                {
//                    Console.Write($"{a[i, j]} = ");
//                }
//                Console.Write($"{a[i, j]}");
//            }
//        }
//    }
//}
