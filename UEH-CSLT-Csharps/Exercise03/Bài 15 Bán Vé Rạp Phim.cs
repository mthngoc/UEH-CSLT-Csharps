using System;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_15_Ban_Ve_Rap_Phim
    {
        enum CustomerType {Child, Student, Adult, Senior}
        static void Bai15()
        {
            decimal giaGoc = 100000;
            CustomerType loaiKhach;
            while (true)
            {
                Console.Write("Loại khách hàng (Child / Student / Adult / Senior): ");
                string loaiKhachInput = Console.ReadLine();
                if (Enum.TryParse(loaiKhachInput, true, out loaiKhach))
                {
                    break;
                }
                Console.WriteLine("Loại khách hàng không hợp lệ! Vui lòng nhập lại.");
            }
            DayOfWeek ngayXem;
            while (true)
            {
                Console.Write("Ngày xem phim (Monday..Sunday): ");
                string ngayInput = Console.ReadLine();

                if (Enum.TryParse(ngayInput, true, out ngayXem))
                {
                    break;
                }
                Console.WriteLine("Ngày không hợp lệ! Vui lòng nhập lại.");
            }
            bool coTheSinhVien = false;
            if (loaiKhach == CustomerType.Student)
            {
                while (true)
                {
                    Console.Write("Có thẻ sinh viên hợp lệ hay không (True/False): ");
                    string theInput = Console.ReadLine();

                    if (bool.TryParse(theInput, out coTheSinhVien))
                    {
                        break;
                    }
                    Console.WriteLine("Vui lòng nhập True hoặc False.");
                }
            }
            bool laNgayT2DenT5 = ngayXem == DayOfWeek.Monday || ngayXem == DayOfWeek.Tuesday ||
                                  ngayXem == DayOfWeek.Wednesday || ngayXem == DayOfWeek.Thursday;
            bool laCuoiTuan = ngayXem == DayOfWeek.Friday || ngayXem == DayOfWeek.Saturday || ngayXem == DayOfWeek.Sunday;
            decimal giamGia = 0;
            string tenGiamGia = "Không áp dụng";
            switch (loaiKhach)
            {
                case CustomerType.Child:
                    giamGia = giaGoc * 0.5m;
                    tenGiamGia = "Trẻ em (50%)";
                    break;
                case CustomerType.Senior:
                    giamGia = giaGoc * 0.5m;
                    tenGiamGia = "Người cao tuổi (50%)";
                    break;
                case CustomerType.Student:
                    if (coTheSinhVien && laNgayT2DenT5)
                    {
                        giamGia = giaGoc * 0.3m;
                        tenGiamGia = "Sinh viên (30%)";
                    }
                    break;
                case CustomerType.Adult:
                    if (ngayXem == DayOfWeek.Wednesday)
                    {
                        giamGia = giaGoc * 0.2m;
                        tenGiamGia = "Khuyến mãi Thứ 4 Vui Vẻ (20%)";
                    }
                    break;
            }
            decimal phuThuCuoiTuan = 0;
            if (laCuoiTuan)
            {
                phuThuCuoiTuan = 20000;
            }
            decimal tongTien = giaGoc - giamGia + phuThuCuoiTuan;
            Console.WriteLine();
            Console.WriteLine($"Giá vé gốc: {giaGoc:N0} VNĐ");
            Console.WriteLine($"Giảm giá ({tenGiamGia}): -{giamGia:N0} VNĐ");
            Console.WriteLine($"Phụ thu cuối tuần: {phuThuCuoiTuan:N0} VNĐ");
            Console.WriteLine($"TỔNG TIỀN VÉ: {tongTien:N0} VNĐ");
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = System.Text.Encoding.UTF8;
        //    Bai15();
        //}
    }
}
