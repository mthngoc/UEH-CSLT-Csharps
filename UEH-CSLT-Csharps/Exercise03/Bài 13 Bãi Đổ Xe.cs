using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_13_Bãi_Đổ_Xe
    {
        enum vehicleType { motorBike, car, truck }
        static void Bai13()
        {
            Console.Write("Loại xe (Motorbike / Car / Truck): ");
            string loaiXeInput = Console.ReadLine();
            vehicleType loaiXe = (vehicleType)Enum.Parse(typeof(vehicleType), loaiXeInput, true);

            Console.Write("Giờ vào (yyyy-MM-dd HH:mm): ");
            string gioVaoInput = Console.ReadLine();
            DateTime gioVao = DateTime.ParseExact(gioVaoInput, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Giờ ra (yyyy-MM-dd HH:mm): ");
            string gioRaInput = Console.ReadLine();
            DateTime gioRa = DateTime.ParseExact(gioRaInput, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            TimeSpan khoangThoiGian = gioRa - gioVao;
            double tongGioThucTe = khoangThoiGian.TotalHours;
            int soGioTinhPhi = (int)Math.Ceiling(tongGioThucTe);
            decimal giaHaiGioDau = 0;
            decimal giaMoiGioThem = 0;
            if (loaiXe == vehicleType.motorBike)
            {
                giaHaiGioDau = 5000;
                giaMoiGioThem = 2000;
            }
            else if (loaiXe == vehicleType.car)
            {
                giaHaiGioDau = 20000;
                giaMoiGioThem = 10000;
            }
            else if (loaiXe == vehicleType.truck)
            {
                giaHaiGioDau = 50000;
                giaMoiGioThem = 25000;
            }
            decimal phiHaiGioDau = giaHaiGioDau;
            int soGioThem = 0;
            decimal phiGioThem = 0;

            if (soGioTinhPhi > 2)
            {
                soGioThem = soGioTinhPhi - 2;
                phiGioThem = soGioThem * giaMoiGioThem;
            }
            decimal phuPhiQuaDem = 0;
            if (gioVao.Date != gioRa.Date)
            {
                phuPhiQuaDem = 30000;
            }

            decimal tongTien = phiHaiGioDau + phiGioThem + phuPhiQuaDem;

            Console.WriteLine();
            Console.WriteLine($"Tổng thời gian đỗ: {tongGioThucTe:F2} giờ -> Tính phí: {soGioTinhPhi} giờ");
            Console.WriteLine($"Phí 2 giờ đầu: {phiHaiGioDau:N0} VNĐ");
            if (soGioThem > 0)
            {
                Console.WriteLine($"Phí {soGioThem} giờ tiếp theo: {phiGioThem:N0} VNĐ ({giaMoiGioThem:N0} x {soGioThem})");
            }
            if (phuPhiQuaDem > 0)
            {
                Console.WriteLine($"Phụ phí qua đêm: {phuPhiQuaDem:N0} VNĐ");
            }
            Console.WriteLine($"Tổng phí đỗ xe: {tongTien:N0} VNĐ");
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = System.Text.Encoding.UTF8;
        //    Bai13();
        //}
    }
}
