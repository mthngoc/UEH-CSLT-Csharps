using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise01
{
    internal class Ex1to10
    {
        static void Ex01()
        {
            Console.Write("Nhập số a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int tong = 0;
            tong = a + b;
            Console.WriteLine($"Tổng hai số là: {a} + {b} = {tong}");
            //Console.WriteLine($"Tổng hai số là: {a} + {b} = {a + b}");
        }
        static void Ex02()
        {
            Console.Write("Nhập số a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int traoDoi = a;
            a = b;
            b = traoDoi;
            Console.WriteLine($"Sau khi hoán đổi: a = {a}, b = {b}");

        }
        static void Ex03()
        {
            Console.Write("Nhập số thực a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số thực b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Tích hai số thực là: {a} x {b} = {a * b}");

        }
        static void Ex04()
        {
            Console.Write("Nhập số feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine($"Đổi feet sang meter: {feet} feet = {meter} meter ");
        }
        static void Ex05()
        {
            Console.Write("Nhập độ C: ");
            double doC = Convert.ToDouble(Console.ReadLine());
            double doF = (doC * 1.8) + 32;
            Console.WriteLine($"Đổi độ C sang độ F: {doC} độ C = {doF} độ F");
        }
        static void Ex06()
        {
            Console.WriteLine($"Kích thước của int: {sizeof(int)} bytes");
            Console.WriteLine($"Kích thước của long: {sizeof(long)} bytes");
            Console.WriteLine($"Kích thước của float: {sizeof(float)} bytes");
            Console.WriteLine($"Kích thước của double: {sizeof(double)} bytes");
            Console.WriteLine($"Kích thước của char: {sizeof(char)} bytes");
            Console.WriteLine($"Kích thước của bool: {sizeof(bool)} bytes");
        }
        static void Ex07() //In giá trị ASCII của kí tự
        {
            Console.Write("Nhập một kí tự: ");
            char kiTu = Convert.ToChar(Console.ReadLine());
            int asciiValue = (int)kiTu;
            Console.WriteLine($"ASCII VALUE của {kiTu} là: {asciiValue} ");
        }
        static void Ex08() //Tính bán kính hình tròn
        {
            Console.Write("Nhập bán kính hình tròn: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Diện tích của hình tròn là: {S}");
        }
        static void Ex09() //Đổi số ngày sang năm, tuần
        {
            Console.Write("Nhập số ngày: ");
            int day = Convert.ToInt32(Console.ReadLine());
            int nam = day / 365;
            int ngayDu = day % 365;
            int tuan = ngayDu / 7;
            int ngayLe = ngayDu % 7;
            Console.WriteLine($"{day} ngày = {nam} năm, {tuan} tuần, lẻ {ngayLe} ngày");
        }
        static void Ex10() //Tính lãi đơn
        {
            Console.Write("Nhập P(tiền gốc): ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập R(lãi suất năm): ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập T(thời gian tính bằng năm): ");
            double T = Convert.ToDouble(Console.ReadLine());
            double laiSuatDon = (P * R * T) / 100;
            Console.WriteLine($"Lãi suất đơn là: {laiSuatDon}");
        }

        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = System.Text.Encoding.UTF8;
        //    Ex01();
        //    Ex02();
        //    Ex04();
        //    Ex05();
        //    Ex06();
        //    Ex07();
        //    Ex08();
        //    Ex09();
        //    Ex10();
        //}
    }
}
