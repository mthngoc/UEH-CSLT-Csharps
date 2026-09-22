using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_10_Quản_Lý_Tồn_Kho
    {
        enum StockStatus {OutOfStock, LowStock, InStock, Discontinued}
        static void Bai10()
        {
            string maSP = "KB-09";
            string tenSP = "Bàn phím Cơ Akko";
            int? quantity = null;
            int minThreshod = 10;
            DateTime? restockDate = null;
            int displayQty = quantity ?? 0;
            StockStatus status;
            if (quantity == null||quantity == 0)
            {
                status = StockStatus.OutOfStock;
            }
            else if (quantity <minThreshod)
            {
                status = StockStatus.LowStock;
            }
            else
            {
                status= StockStatus.InStock;
            }
            Console.WriteLine($"Sản phẩm: {tenSP} (Mã: {maSP})");
            Console.WriteLine($"Số lượng hiển thị: {displayQty} (Cảnh báo: Dữ liệu trống)");
            Console.WriteLine($"Trạng thái kho: {status} (Hết hàng)");
            string ngayNhap = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập hàng";
            Console.WriteLine($"Dự kiến nhập hàng: {ngayNhap}");
        }
        //static void Main( string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Bai10();
        //}
    }
}
