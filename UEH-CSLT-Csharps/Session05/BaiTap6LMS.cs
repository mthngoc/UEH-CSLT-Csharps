using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Session05
{
    internal class BaiTap6LMS
    {
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    int bai01 = TinhTong(-6, 12);
        //    Console.WriteLine($"Tổng = {bai01}");

        //    bool bai02 = KiemTraChanLe(37);
        //    Console.WriteLine($"Đây có phải là số chẵn không: {bai02}");
            
        //    int bai03 = TimMax(12, 44, 68);
        //    Console.WriteLine($"Số lớn nhất là: {bai03}");
            
        //    long bai04 = TinhGiaiThua(5);
        //    Console.WriteLine($"{bai04}");

        //    Console.Write("Nhập một chuỗi ký tự: ");
        //    string input = Console.ReadLine();
        //    string bai05 = DaoNguocChuoi(input);
        //    Console.WriteLine($"{bai05}");

        //    bool bai06 = KiemTraSoNguyenTo(9);
        //    Console.WriteLine($"{bai06}");

        //    InFibonacci(5);

        //    Console.Write("Nhập một chuỗi ký tự: ");
        //    string chuoichu = Console.ReadLine();
        //    int bai08 = DemNguyenAnh(chuoichu);
        //    Console.WriteLine($"{bai08}");

        //    double bai09 = TinhLuyThua(2, 3);
        //    Console.WriteLine($"{bai09}");

        //    int[] mangSo = { 4, 5, 6, 7 };
        //    double bai10 = TinhTrungBinh(mangSo);
        //    Console.WriteLine($"Trung bình mảng: {bai10}");

        //    Console.Write("Nhập chuỗi kiểm tra đối xứng: ");
        //    string chuoiDoiXung = Console.ReadLine();
        //    bool bai11 = KiemTraDoiXung(chuoiDoiXung);
        //    Console.WriteLine($"Chuỗi đối xứng: {bai11}");

        //    double bai12 = CelsiusToFahrenheit(25);
        //    Console.WriteLine($"25 độ C = {bai12} độ F");

        //    int[] mang13 = { 10, 5, 8, 2, 9 };
        //    int bai13 = TimMin(mang13);
        //    Console.WriteLine($"Min của mảng: {bai13}");

        //    int bai14 = TongCacChuSo(1234);
        //    Console.WriteLine($"Tổng các chữ số 1234 là: {bai14}");

        //    int[] mang15 = { 3, 1, 4, 2 };
        //    Console.Write("Mảng sau sắp xếp: ");
        //    SapXepMang(mang15); 

        //    string bai16 = XoaTrungLap("programming");
        //    Console.WriteLine($"Chuỗi sau khi xóa trùng: {bai16}");

        //    int bai17 = UCLN(12, 18);
        //    Console.WriteLine($"UCLN(12, 18) = {bai17}");

        //    string bai18 = DecimalToBinary(10);
        //    Console.WriteLine($"10 sang Nhị phân: {bai18}");

        //    bool bai19_1 = KiemTraNamNhuan(2024);
        //    bool bai19_2 = KiemTraNamNhuan(2023);
        //    Console.WriteLine($"2024 là năm nhuận: {bai19_1}");
        //    Console.WriteLine($"2023 là năm nhuận: {bai19_2}");

        //    string cau = "Học lập trình C# rất thú vị";
        //    int bai20 = DemSoTu(cau);
        //    Console.WriteLine($"Số từ trong câu: {bai20}");
        //}
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static string DecimalToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
        static int DemSoTu(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return 0;

            string[] tu = sentence.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return tu.Length;
        }
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static int TongCacChuSo(int n)
        {
            int tong = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                tong += n % 10;
                n /= 10;        
            }
            return tong;
        }
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);

            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
        static string XoaTrungLap(string s)
        {
            string ketQua = "";
            foreach (char c in s)
            {
                if (!ketQua.Contains(c))
                {
                    ketQua += c;
                }
            }
            return ketQua;
        }
        static bool KiemTraDoiXung(string s)
        {
            char[] a = s.ToCharArray();
            Array.Reverse(a);
            string chuoiDao = new string(a);
            return s.Equals(chuoiDao, StringComparison.OrdinalIgnoreCase);
        }
        static double TinhTrungBinh(int[] tb)
        {
            int tong = 0;
            foreach (int x in tb)
            {
                tong += x;
            }
            return (double)tong / tb.Length;
        }
        static int DemNguyenAnh(string s)
        {
            int dem = 0;
            s = s.ToLower();
            foreach(char c in s)
            {
                if(c=='a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    dem++;
                }
            }
            return dem;
        }
        static double TinhLuyThua(double x, int y)
        {
            double ketqua = 1;
            for (int i = 1; i <= y; i++)
            {
                ketqua *= x;
            }
            return ketqua;
        }
        static void InFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a} ");
                int next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine();
        }
        static string DaoNguocChuoi(string input)
        {
            // .ToCharArray chuyển string -> char
            char[] chars = input.ToCharArray();
            // Array.Reverse dùng để đảo ngược mảng
            Array.Reverse(chars);
            return new string(chars);
        }
        static bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for(int i = 2; i < n-1; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        static bool KiemTraChanLe(int chanle)
        {
            return chanle % 2 == 0;
        }
        static int TimMax(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if(c > max)
            {
                max = c;
            }
            return max;
        }
        static long TinhGiaiThua(int n)
        {
            int ketqua = 1;
            for (int i = 1; i < n+1; i++)
            {
                ketqua *= i;
            }
            return ketqua;
        }
       
    }
}
