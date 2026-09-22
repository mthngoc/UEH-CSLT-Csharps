//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Text;

//namespace UEH_CSLT_Csharps.Session04
//{
//    internal class BaiTap4LMS
//    {
//        static void Bai1()
//        {
//            Console.Write("Tuổi: ");
//            int tuoi;
//            while (!int.TryParse(Console.ReadLine(), out tuoi) || tuoi < 0)
//            {
//                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
//            }
//            Console.Write("Giờ chiếu: ");
//            int gioChieu;
//            while (!int.TryParse(Console.ReadLine(), out gioChieu) || gioChieu < 0)
//            {
//                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
//            }
//            decimal giaTien = 0;
//            if (tuoi > 60 || tuoi < 12)
//            {
//                giaTien = 50000m;
//            }
//            else if (tuoi >= 12 && tuoi <= 60 && gioChieu < 17)
//            {
//                giaTien = 80000m;
//            }
//            else if (tuoi >= 12 && tuoi <= 60 && gioChieu > 17)
//            {
//                giaTien = 110000;
//            }
//            Console.WriteLine($"Giá vé của bạn là: {giaTien:N0} VNĐ");
//        }
//        static void Bai2()
//        {
//            Console.WriteLine("ADMIN, MANAGER, EMPLOYEE, GUEST");
//            Console.Write("Role = ");
//            String role = Console.ReadLine();
//            switch (role)
//            {
//                case "ADMIN":
//                    {
//                        Console.WriteLine("Toàn quyền quản trị hệ thống");
//                    }
//                    break;
//                case "MANAGER":
//                    {
//                        Console.WriteLine("Quyền quản lý nhân sự và xem báo cáo");
//                    }
//                    break;
//                case "EMPLOYEE":
//                    {
//                        Console.WriteLine("Quyền tạo và chỉnh sửa hồ sơ cá nhân");
//                    }
//                    break;
//                case "GUEST":
//                    {
//                        Console.WriteLine("Chỉ có quyền xem thông tin công khai");
//                    }
//                    break;
//            }
//            Console.WriteLine("Mã vai trò không hợp lệ");
//        }
//        static void Bai3()
//        {
//            Console.Write("Nhập số dư tài khoản: ");
//            decimal soDu = Convert.ToDecimal(Console.ReadLine());
//            Console.Write("Nhập số tiền muốn rút: ");
//            decimal soTienRut = Convert.ToDecimal(Console.ReadLine());
//            decimal soDuConLai = soDu - soTienRut;
//            if (soTienRut <= 0)
//            {
//                Console.WriteLine("Số tiền không hợp lệ");
//            }
//            else if (soTienRut % 50 != 0)
//            {
//                Console.WriteLine("Giao dịch thất bại! Số tiền rút phải là bội số của 50,000 VNĐ");
//            }
//            else if (soTienRut > soDu)
//            {
//                Console.WriteLine("Giao dịch thất bại! Số dư không khả dụng");
//            }
//            else if (soTienRut > 5000000)
//            {
//                Console.WriteLine("Giao dịch thất bại! Hạn mức rút tối đa 5,000,000 VNĐ");
//            }
//            else
//            {
//                Console.WriteLine($"Giao dịch thành công.Số dư còn lại: {soDuConLai:N0} VNĐ");
//            }

//        }
//        static void Bai4()
//        {
//            Console.WriteLine("1. Gặp tổng đài viên tư vấn thẻ");
//            Console.WriteLine("2. Tra cứu số dư tài khoản");
//            Console.WriteLine("3. Báo khóa thẻ khẩn cấp");
//            Console.WriteLine("4. Tra cứu tỷ giá ngoại tệ");
//            Console.WriteLine("0. Quay lại menu chính");
//            Console.Write("Phím bấm(0-4): ");
//            int phimBam = Convert.ToInt32(Console.ReadLine());
//            switch (phimBam)
//            {
//                case 0:
//                    {
//                        Console.WriteLine("Đã quay lại menu chính");
//                    }
//                    break;
//                case 1:
//                    {
//                        Console.WriteLine("[Tổng Đài]: Quý khách muốn mở hạng thẻ nào ?");
//                    }
//                    break;
//                case 2:
//                    {
//                        Console.WriteLine("Số dư tài khoản của bạn là: xx,xxx,xxx VNĐ");
//                    }
//                    break;
//                case 3:
//                    {
//                        Console.WriteLine("[Tổng Đài]: Yêu cầu khóa thẻ khẩn cấp đã được ghi nhận");
//                    }
//                    break;
//                case 4:
//                    {
//                        Console.WriteLine("Bạn muốn tra cứu tỷ giá ngoại tệ nào ?");
//                    }
//                    break;
//            }
//        }
//        static void Bai5()
//        {
//            Console.Write("Số km: ");
//            double soKm = Convert.ToDouble(Console.ReadLine());
//            decimal giaTien;
//            decimal khuyenMai = 0m;
//            if (soKm <= 1)
//            {
//                giaTien = 15000;
//            }
//            else if (soKm <= 10)
//            {
//                giaTien = 15000 + (decimal)(soKm - 1) * 12000;
//            }
//            else
//            {
//                giaTien = 15000 + 9 * 12000 + (decimal)(soKm - 10) * 10000;
//            }
//            if (soKm > 30)
//            {
//                khuyenMai = giaTien * 0.1m;
//            }
//            else
//            {
//                khuyenMai = 0;
//            }
//            decimal tongTien = giaTien - khuyenMai;
//            Console.WriteLine($"Tổng tiền trước giảm: {giaTien:N0} VNĐ");
//            Console.WriteLine($"Khuyến mãi (10%): {khuyenMai:N0} VNĐ");
//            Console.WriteLine($"Thành tiền: {tongTien:N0} VNĐ");
//        }
//        static void Bai6()
//        {
//            Console.WriteLine("1. Pending");
//            Console.WriteLine("2. Processing");
//            Console.WriteLine("3. Shipped");
//            Console.WriteLine("4. Delivered");
//            Console.WriteLine("5. Cancelled");
//            Console.Write("Phím bấm(1-5): ");
//            int trangThai = Convert.ToInt32(Console.ReadLine());
//            switch (trangThai)
//            {
//                case 1:
//                    {
//                        Console.WriteLine("[Trạng Thái] Chờ xác nhận thanh toán");
//                    }
//                    break;
//                case 2:
//                    {
//                        Console.WriteLine("[Trạng Thái] Đang đóng gói và bàn giao đơn vị vận chuyển");
//                    }
//                    break;
//                case 3:
//                    {
//                        Console.WriteLine("[Trạng Thái] Đơn hàng đang trên đường giao đến bạn");
//                    }
//                    break;
//                case 4:
//                    {
//                        Console.WriteLine("[Trạng Thái] Đơn hàng đã hoàn thành. Cảm ơn bạn!");
//                    }
//                    break;
//                case 5:
//                    {
//                        Console.WriteLine("[Trạng Thái] Đơn hàng đã bị hủy. Xuất phiếu hoàn tiền");
//                    }
//                    break;
//            }
//        }
//        static void Bai7()
//        {
//            double chieuCao;
//            Console.Write("Nhập chiều cao của bạn(m): ");
//            while (!double.TryParse(Console.ReadLine(), out chieuCao) || chieuCao <= 0)
//            {
//                Console.WriteLine("Dữ liệu không hợp lệ!");
//                Console.Write("Vui lòng nhập lại: ");
//            }
//            double canNang;
//            Console.Write("Nhập cân nặng của bạn(kg): ");
//            while (!double.TryParse(Console.ReadLine(), out canNang) || canNang <= 0)
//            {
//                Console.WriteLine("Dữ liệu không hợp lệ!");
//                Console.Write("Vui lòng nhập lại: ");
//            }
//            double chiSoBMI = canNang / Math.Pow(chieuCao, 2);
//            Console.WriteLine($"Chỉ số BMI của bạn là:{chiSoBMI:F2}");
//            if (chiSoBMI < 18.5)
//            {
//                Console.WriteLine("Gầy - Nên bổ sung dinh dưỡng");
//            }
//            else if (chiSoBMI < 25.0)
//            {
//                Console.WriteLine("Cân đối - Tiếp tục duy trì");
//            }
//            else if (chiSoBMI < 30.0)
//            {
//                Console.WriteLine("Thừa Cân - Nên tăng cường luyện tập");
//            }
//            else
//            {
//                Console.WriteLine("Béo Phì - Cần tư vấn của bác sĩ");
//            }
//        }
//        static void Bai8()
//        {
//            Console.WriteLine("CAR, BIKE");
//            Console.Write("Loại Xe = ");
//            string loaiXe = Console.ReadLine();
//            Console.WriteLine("1: Ban Ngày, 2: Ban Đêm");
//            Console.Write("Thời gian = ");
//            int thoiGian;
//            decimal tienXe = 0;
//            while (!int.TryParse(Console.ReadLine(), out thoiGian) || thoiGian != 1 && thoiGian != 2)
//            {
//                Console.WriteLine("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
//            }
//            switch (loaiXe)
//            {
//                case "CAR":
//                    {
//                        if (thoiGian == 1)
//                        {
//                            tienXe = 30000;
//                        }
//                        else if (thoiGian == 2)
//                        {
//                            tienXe = 60000;
//                        }
//                    }
//                    break;
//                case "BIKE":
//                    {
//                        if (thoiGian == 1)
//                        {
//                            tienXe = 5000;
//                        }
//                        else
//                        {
//                            tienXe = 10000;
//                        }
//                    }
//                    break;
//            }
//            Console.WriteLine($"Phí gửi xe {loaiXe} ({thoiGian}): {tienXe:N0} VNĐ");
//        }
//        static void Bai9()
//        {
//            Console.Write("Nhập GPA (hệ 4.0): ");
//            double gpa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.Write("Nhập DRL (hệ 100): ");
//            int drl = int.Parse(Console.ReadLine());
//            if (gpa >= 3.6 && drl >= 90)
//            {
//                Console.WriteLine("Kết quả: Học bổng Xuất sắc (Mức 100%)");
//            }
//            else if (gpa >= 3.2 && drl >= 80)
//            {
//                string lyDo = "";
//                if (gpa < 3.6 && drl < 90) lyDo = " (Do GPA < 3.6 và DRL < 90)";
//                else if (gpa < 3.6) lyDo = " (Do GPA < 3.6)";
//                else lyDo = " (Do DRL < 90)";
//                Console.WriteLine($"Kết quả: Học bổng Khá/Giỏi (Mức 50%){lyDo}");
//            }
//            else
//            {
//                Console.WriteLine("Kết quả: Không đạt học bổng");
//            }
//        }
//        static void Bai10()
//        {
//            Console.Write("Nhập số tiền VNĐ: ");
//            double vnd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.Write("Nhập mã ngoại tệ (USD/EUR/JPY): ");
//            string maTien = Console.ReadLine().Trim().ToUpper();

//            double tyGia;
//            switch (maTien)
//            {
//                case "USD": tyGia = 25400; break;
//                case "EUR": tyGia = 27200; break;
//                case "JPY": tyGia = 165; break;
//                default:
//                    Console.WriteLine("Mã ngoại tệ không hợp lệ!");
//                    return;
//            }
//            double ketQua = vnd / tyGia;
//            Console.WriteLine($"Số tiền sau quy đổi: {ketQua.ToString("F2", CultureInfo.InvariantCulture)} {maTien}");
//        }

//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Bai1();
//            Bai2();
//            Bai3();
//            Bai4();
//            Bai5();
//            Bai6();
//            Bai7();
//            Bai8();
//            Bai9();
//            Bai10();
//        }
//    }
//}
