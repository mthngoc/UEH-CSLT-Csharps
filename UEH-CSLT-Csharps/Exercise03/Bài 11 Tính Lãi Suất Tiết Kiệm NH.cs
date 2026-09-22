using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_11_Tính_Lãi_Suất_Tiết_Kiệm_NH
    {
        static void Bai11()
        {
            Console.Write("Nhập số tiền gửi ban đầu: ");
            decimal P;
            while(!decimal.TryParse(Console.ReadLine(), out P) || P <= 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Nhập lãi suất năm: ");
            double r;
            while(!double.TryParse(Console.ReadLine(), out r) || r <= 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Nhập kỳ hạn gửi (tháng): ");
            int n;
            while(!int.TryParse(Console.ReadLine(),out n) || n <= 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            decimal laiDon = P * (decimal)(r / 100) * (decimal)(n / 12.0);
            decimal laiKepA = (decimal)((double)P * Math.Pow((1 + (r / 100) / 12), n))-P;
            Console.WriteLine($"Tổng tiền lãi đơn: {laiDon:N0} VNĐ");
            Console.WriteLine($"Tổng tiền lãi kép: {laiKepA:N0} VNĐ");
            string laiToiUu;
            if(laiDon < laiKepA)
            {
                laiToiUu = "Lãi Kép";
            }
            else
            {
                laiToiUu = "Lãi Đơn";
            }
            Console.WriteLine($"Lợi nhuận chênh lệch: {laiKepA-laiDon:N0} VNĐ({laiToiUu} tối ưu hơn)");
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Bai11();
        //}
    }
}
