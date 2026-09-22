using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_7_Chi_Phí_Nhiên_Liệu
    {
        static void Bai7()
        {
            Console.Write("Nhập khoảng cách chuyến đi (km): ");
            double soKm;
            while (!double.TryParse(Console.ReadLine(), out soKm) || soKm < 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Nhập mức tiêu thụ trung bình của xe(lít/100km): ");
            double tieuThu;
            while (!double.TryParse(Console.ReadLine(), out tieuThu) || tieuThu < 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Nhập giá xăng hiện tại: ");
            decimal giaXang;
            while (!decimal.TryParse(Console.ReadLine(), out giaXang) || giaXang < 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Nhập số lượng người tham gia chuyến đi: ");
            int soNguoi;
            while (!int.TryParse(Console.ReadLine(), out soNguoi) || soNguoi <= 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            double tongLitXang = (soKm / 100) * tieuThu;
            Console.WriteLine($"Tổng nhiên liệu tiêu thụ là: {tongLitXang:F2} Lít");
            decimal tongChiPhiXang = (decimal)tongLitXang * giaXang;
            Console.WriteLine($"Tổng chi phí xăng dầu: {tongChiPhiXang:N0} VNĐ");
            decimal chiPhiMoiNguoi = Math.Ceiling(tongChiPhiXang / soNguoi /1000m)*1000m;
            Console.Write($"Chi phí mỗi người là: {chiPhiMoiNguoi:N0} VNĐ");
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Bai7();
        //}
    }
}
