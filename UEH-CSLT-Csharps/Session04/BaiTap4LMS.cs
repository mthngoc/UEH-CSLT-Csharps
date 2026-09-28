using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace UEH_CSLT_Csharps.Session04
{
    internal class BaiTap4LMS
    {
        static void Bai1()
        {
            Console.Write("Tuổi: ");
            int tuoi;
            while (!int.TryParse(Console.ReadLine(), out tuoi) || tuoi < 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Giờ chiếu: ");
            int gioChieu;
            while (!int.TryParse(Console.ReadLine(), out gioChieu) || gioChieu < 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            decimal giaTien = 0;
            if (tuoi > 60 || tuoi < 12)
            {
                giaTien = 50000m;
            }
            else if (tuoi >= 12 && tuoi <= 60 && gioChieu < 17)
            {
                giaTien = 80000m;
            }
            else if (tuoi >= 12 && tuoi <= 60 && gioChieu > 17)
            {
                giaTien = 110000;
            }
            Console.WriteLine($"Giá vé của bạn là: {giaTien:N0} VNĐ");
        }
        static void Bai2()
        {
            Console.WriteLine("ADMIN, MANAGER, EMPLOYEE, GUEST");
            Console.Write("Role = ");
            String role = Console.ReadLine();
            switch (role)
            {
                case "ADMIN":
                    {
                        Console.WriteLine("Toàn quyền quản trị hệ thống");
                    }
                    break;
                case "MANAGER":
                    {
                        Console.WriteLine("Quyền quản lý nhân sự và xem báo cáo");
                    }
                    break;
                case "EMPLOYEE":
                    {
                        Console.WriteLine("Quyền tạo và chỉnh sửa hồ sơ cá nhân");
                    }
                    break;
                case "GUEST":
                    {
                        Console.WriteLine("Chỉ có quyền xem thông tin công khai");
                    }
                    break;
            }
            Console.WriteLine("Mã vai trò không hợp lệ");
        }
        static void Bai3()
        {
            Console.Write("Nhập số dư tài khoản: ");
            decimal soDu = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nhập số tiền muốn rút: ");
            decimal soTienRut = Convert.ToDecimal(Console.ReadLine());
            decimal soDuConLai = soDu - soTienRut;
            if (soTienRut <= 0)
            {
                Console.WriteLine("Số tiền không hợp lệ");
            }
            else if (soTienRut % 50 != 0)
            {
                Console.WriteLine("Giao dịch thất bại! Số tiền rút phải là bội số của 50,000 VNĐ");
            }
            else if (soTienRut > soDu)
            {
                Console.WriteLine("Giao dịch thất bại! Số dư không khả dụng");
            }
            else if (soTienRut > 5000000)
            {
                Console.WriteLine("Giao dịch thất bại! Hạn mức rút tối đa 5,000,000 VNĐ");
            }
            else
            {
                Console.WriteLine($"Giao dịch thành công.Số dư còn lại: {soDuConLai:N0} VNĐ");
            }

        }
        static void Bai4()
        {
            Console.WriteLine("1. Gặp tổng đài viên tư vấn thẻ");
            Console.WriteLine("2. Tra cứu số dư tài khoản");
            Console.WriteLine("3. Báo khóa thẻ khẩn cấp");
            Console.WriteLine("4. Tra cứu tỷ giá ngoại tệ");
            Console.WriteLine("0. Quay lại menu chính");
            Console.Write("Phím bấm(0-4): ");
            int phimBam = Convert.ToInt32(Console.ReadLine());
            switch (phimBam)
            {
                case 0:
                    {
                        Console.WriteLine("Đã quay lại menu chính");
                    }
                    break;
                case 1:
                    {
                        Console.WriteLine("[Tổng Đài]: Quý khách muốn mở hạng thẻ nào ?");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Số dư tài khoản của bạn là: xx,xxx,xxx VNĐ");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("[Tổng Đài]: Yêu cầu khóa thẻ khẩn cấp đã được ghi nhận");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Bạn muốn tra cứu tỷ giá ngoại tệ nào ?");
                    }
                    break;
            }
        }
        static void Bai5()
        {
            Console.Write("Số km: ");
            double soKm = Convert.ToDouble(Console.ReadLine());
            decimal giaTien;
            decimal khuyenMai = 0m;
            if (soKm <= 1)
            {
                giaTien = 15000;
            }
            else if (soKm <= 10)
            {
                giaTien = 15000 + (decimal)(soKm - 1) * 12000;
            }
            else
            {
                giaTien = 15000 + 9 * 12000 + (decimal)(soKm - 10) * 10000;
            }
            if (soKm > 30)
            {
                khuyenMai = giaTien * 0.1m;
            }
            else
            {
                khuyenMai = 0;
            }
            decimal tongTien = giaTien - khuyenMai;
            Console.WriteLine($"Tổng tiền trước giảm: {giaTien:N0} VNĐ");
            Console.WriteLine($"Khuyến mãi (10%): {khuyenMai:N0} VNĐ");
            Console.WriteLine($"Thành tiền: {tongTien:N0} VNĐ");
        }
        static void Bai6()
        {
            Console.WriteLine("1. Pending");
            Console.WriteLine("2. Processing");
            Console.WriteLine("3. Shipped");
            Console.WriteLine("4. Delivered");
            Console.WriteLine("5. Cancelled");
            Console.Write("Phím bấm(1-5): ");
            int trangThai = Convert.ToInt32(Console.ReadLine());
            switch (trangThai)
            {
                case 1:
                    {
                        Console.WriteLine("[Trạng Thái] Chờ xác nhận thanh toán");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("[Trạng Thái] Đang đóng gói và bàn giao đơn vị vận chuyển");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("[Trạng Thái] Đơn hàng đang trên đường giao đến bạn");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("[Trạng Thái] Đơn hàng đã hoàn thành. Cảm ơn bạn!");
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("[Trạng Thái] Đơn hàng đã bị hủy. Xuất phiếu hoàn tiền");
                    }
                    break;
            }
        }
        static void Bai7()
        {
            double chieuCao;
            Console.Write("Nhập chiều cao của bạn(m): ");
            while (!double.TryParse(Console.ReadLine(), out chieuCao) || chieuCao <= 0)
            {
                Console.WriteLine("Dữ liệu không hợp lệ!");
                Console.Write("Vui lòng nhập lại: ");
            }
            double canNang;
            Console.Write("Nhập cân nặng của bạn(kg): ");
            while (!double.TryParse(Console.ReadLine(), out canNang) || canNang <= 0)
            {
                Console.WriteLine("Dữ liệu không hợp lệ!");
                Console.Write("Vui lòng nhập lại: ");
            }
            double chiSoBMI = canNang / Math.Pow(chieuCao, 2);
            Console.WriteLine($"Chỉ số BMI của bạn là:{chiSoBMI:F2}");
            if (chiSoBMI < 18.5)
            {
                Console.WriteLine("Gầy - Nên bổ sung dinh dưỡng");
            }
            else if (chiSoBMI < 25.0)
            {
                Console.WriteLine("Cân đối - Tiếp tục duy trì");
            }
            else if (chiSoBMI < 30.0)
            {
                Console.WriteLine("Thừa Cân - Nên tăng cường luyện tập");
            }
            else
            {
                Console.WriteLine("Béo Phì - Cần tư vấn của bác sĩ");
            }
        }
        static void Bai8()
        {
            Console.WriteLine("CAR, BIKE");
            Console.Write("Loại Xe = ");
            string loaiXe = Console.ReadLine();
            Console.WriteLine("1: Ban Ngày, 2: Ban Đêm");
            Console.Write("Thời gian = ");
            int thoiGian;
            decimal tienXe = 0;
            while (!int.TryParse(Console.ReadLine(), out thoiGian) || thoiGian != 1 && thoiGian != 2)
            {
                Console.WriteLine("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            switch (loaiXe)
            {
                case "CAR":
                    {
                        if (thoiGian == 1)
                        {
                            tienXe = 30000;
                        }
                        else if (thoiGian == 2)
                        {
                            tienXe = 60000;
                        }
                    }
                    break;
                case "BIKE":
                    {
                        if (thoiGian == 1)
                        {
                            tienXe = 5000;
                        }
                        else
                        {
                            tienXe = 10000;
                        }
                    }
                    break;
            }
            Console.WriteLine($"Phí gửi xe {loaiXe} ({thoiGian}): {tienXe:N0} VNĐ");
        }
        static void Bai9()
        {
            Console.Write("Nhập GPA (hệ 4.0): ");
            double gpa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nhập DRL (hệ 100): ");
            int drl = int.Parse(Console.ReadLine());
            if (gpa >= 3.6 && drl >= 90)
            {
                Console.WriteLine("Kết quả: Học bổng Xuất sắc (Mức 100%)");
            }
            else if (gpa >= 3.2 && drl >= 80)
            {
                string lyDo = "";
                if (gpa < 3.6 && drl < 90) lyDo = " (Do GPA < 3.6 và DRL < 90)";
                else if (gpa < 3.6) lyDo = " (Do GPA < 3.6)";
                else lyDo = " (Do DRL < 90)";
                Console.WriteLine($"Kết quả: Học bổng Khá/Giỏi (Mức 50%){lyDo}");
            }
            else
            {
                Console.WriteLine("Kết quả: Không đạt học bổng");
            }
        }
        static void Bai10()
        {
            Console.Write("Nhập số tiền VNĐ: ");
            double vnd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nhập mã ngoại tệ (USD/EUR/JPY): ");
            string maTien = Console.ReadLine().Trim().ToUpper();

            double tyGia;
            switch (maTien)
            {
                case "USD": tyGia = 25400; break;
                case "EUR": tyGia = 27200; break;
                case "JPY": tyGia = 165; break;
                default:
                    Console.WriteLine("Mã ngoại tệ không hợp lệ!");
                    return;
            }
            double ketQua = vnd / tyGia;
            Console.WriteLine($"Số tiền sau quy đổi: {ketQua.ToString("F2", CultureInfo.InvariantCulture)} {maTien}");
        }
        static void Bai11()
        {
            Console.Write("Số kWh: ");
            double soKWH;
            decimal soTienThanhToan;
            while (!double.TryParse(Console.ReadLine(), out soKWH) || soKWH < 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            if (soKWH <= 50)
            {
                soTienThanhToan = 1806 * (decimal)soKWH;
                Console.WriteLine($"Chi tiết: 1,806 * {soKWH}");
            }
            else if (soKWH <= 100)
            {
                soTienThanhToan = 1806 * 50 + 1866 * (decimal)(soKWH - 50);
                Console.WriteLine($"Chi tiết: (1,806 * 50) + (1,866 * ({soKWH - 50}))");
            }
            else
            {
                soTienThanhToan = 1806 * 50 + 1866 * 50 + 2167 * (decimal)(soKWH - 100);
                Console.WriteLine($"Chi tiết: (1,806 * 50) + (1,866 * 50) + (2,167 * {soKWH - 100})");
            }
            Console.WriteLine($"Tổng tiền điện phải thanh toán: {soTienThanhToan:N0} VNĐ");
        }
        static void Bai12()
        {
            Console.Write("Số ngày trễ: ");
            int ngayTre;
            while (!int.TryParse(Console.ReadLine(), out ngayTre) || ngayTre <= 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            decimal tienPhat;
            if (ngayTre <= 3)
            {
                tienPhat = (decimal)ngayTre * 5000;
            }
            else if (ngayTre <= 7)
            {
                tienPhat = (decimal)ngayTre * 10000;
            }
            else
            {
                tienPhat = (decimal)ngayTre * 20000;
            }
            Console.WriteLine($"Tiền phạt: {tienPhat:N0} VNĐ");
        }
        static void Bai13()
        {
            Console.Write("Nhập mức lương cơ bản: ");
            decimal luongCoBan;
            while (!decimal.TryParse(Console.ReadLine(), out luongCoBan) || luongCoBan < 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("KPI = ");
            double KPI;
            while (!double.TryParse(Console.ReadLine(), out KPI) || KPI < 0)
            {
                Console.Write("Dữ liệu không hợp lệ. Vui lòng nhập lại: ");
            }
            decimal tienThuongKPI;
            string danhGia;
            if (KPI < 80)
            {
                tienThuongKPI = 0;
                danhGia = "Cố gắng thêm nhé";
            }
            else if (KPI < 100)
            {
                tienThuongKPI = luongCoBan * 0.5m;
                danhGia = "Ổn! Phấn đấu thêm nhé";
            }
            else if (KPI <= 120)
            {
                tienThuongKPI = luongCoBan;
                danhGia = "Tốt lắm! Tiếp tục phát huy nhé";
            }
            else
            {
                tienThuongKPI = luongCoBan * 1.5m;
                danhGia = "Xuất Sắc! Tiếp tục phát huy nhé";
            }
            Console.WriteLine($"Đánh giá: {danhGia}. Tiền thưởng Tết: {tienThuongKPI:N0}");
        }
        static void Bai14()
        {
            Console.Write("Hóa đơn: ");
            decimal hoaDon;
            while (!decimal.TryParse(Console.ReadLine(), out hoaDon) || hoaDon < 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.WriteLine(" 1-WELCOME10, 2-SUPERDEAL, 3-FREESHIP");
            Console.Write("Chọn mã voucher (1-3): ");
            int maVoucher;
            while (!int.TryParse(Console.ReadLine(), out maVoucher) || maVoucher < 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            decimal giamGia = 0;
            switch (maVoucher)
            {
                case 1:
                    giamGia = hoaDon * 0.1m;
                    break;
                case 2:
                    giamGia = hoaDon * 0.2m;
                    if (giamGia > 100)
                    {
                        giamGia = 100000;
                    }
                    break;
                case 3:
                    giamGia = hoaDon - 30000;
                    break;
            }
            Console.WriteLine($"Được giảm: {giamGia:N0} VNĐ. Số tiền cần thanh toán: {hoaDon - giamGia:N0} VNĐ");
        }
        static void Bai15()
        {
            Console.Write("Tháng = ");
            int thang;
            while (!int.TryParse(Console.ReadLine(), out thang) || thang < 1 || thang > 12)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại");
            }
            Console.Write("Năm = ");
            int nam;
            while (!int.TryParse(Console.ReadLine(), out nam) || nam < 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            string loaiNam = null;
            int ngay = 0;
            switch (thang)
            {
                case 1:
                    ngay = 31;
                    break;
                case 2:
                    if (nam % 4 == 0 && nam % 100 != 0)
                    {
                        loaiNam = "(Năm nhuận)";
                        ngay = 29;
                    }
                    else
                    {
                        loaiNam = "(Không phải năm nhuận)";
                        ngay = 28;
                    }
                    break;
                case 3:
                    ngay = 31;
                    break;
                case 4:
                    ngay = 30;
                    break;
                case 5:
                    ngay = 31;
                    break;
                case 6:
                    ngay = 30;
                    break;
                case 7:
                    ngay = 31;
                    break;
                case 8:
                    ngay = 31;
                    break;
                case 9:
                    ngay = 30;
                    break;
                case 10:
                    ngay = 31;
                    break;
                case 11:
                    ngay = 30;
                    break;
                case 12:
                    ngay = 31;
                    break;

            }
            Console.WriteLine($"Tháng {thang} năm {nam} có {ngay} ngày {loaiNam}");
        }
        static void Bai16()
        {
            Console.WriteLine("1-NOI_THANH, 2-NGOAI_THANH");
            Console.Write("Khu vực: ");
            int khuVuc;
            while (!int.TryParse(Console.ReadLine(), out khuVuc) || khuVuc < 1 || khuVuc > 2)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Nhập trọng lượng: ");
            double trongLuong;
            while (!double.TryParse(Console.ReadLine(), out trongLuong) || trongLuong < 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            double phiVanChuyen = 0;
            switch (khuVuc)
            {
                case 1:
                    if (trongLuong <= 3)
                    {
                        phiVanChuyen = 20000;
                    }
                    else
                    {
                        phiVanChuyen = (3 * 20000) + (trongLuong - 3) * 5000;
                    }
                    break;
                case 2:
                    if (trongLuong <= 3)
                    {
                        phiVanChuyen = 35000;
                    }
                    else
                    {
                        phiVanChuyen = (3 * 35000) + (trongLuong - 3) * 10000;
                    }
                    break;
            }
            Console.WriteLine($"Phí vận chuyển: {phiVanChuyen:N0} VNĐ");

        }
        static void Bai17()
        {
            Console.Write("Nhập nhiệt độ (độ C): ");
            double nhietDo;
            while (!double.TryParse(Console.ReadLine(), out nhietDo))
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.WriteLine("1: Nắng, 2: Mưa");
            Console.Write("Thời tiết: ");
            int thoiTiet;
            string khuyenDung = null;
            while (!int.TryParse(Console.ReadLine(), out thoiTiet) || thoiTiet < 1 || thoiTiet > 2)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            if (nhietDo < 18)
            {
                khuyenDung = "Mặc áo khoác dày, giữ ấm";
            }
            else if (nhietDo < 28)
            {
                khuyenDung = "Mặc áo phông/ sơ mi thoải mái";
            }
            else
            {
                khuyenDung = "Mặc đồ thoáng mát, mang theo kem chống nắng";
            }
            string goiYThem = null;
            if (thoiTiet == 2)
            {
                goiYThem = "Đừng quên mang theo ô/ áo mưa nhé!";
            }
            else
            {
                //goiYThem = "";
            }
            Console.WriteLine($"Khuyên dùng: {khuyenDung}. {goiYThem}");
        }
        static void Bai18()
        {
            Console.Write("Mật khẩu: ");
            string matKhau = Console.ReadLine();
            string danhGia;
            if (matKhau.Length < 6)
            {
                danhGia = "Mật khẩu Yếu. (Cần tối thiểu 6 ký tự)";
            }
            else if (matKhau.Length < 11)
            {
                danhGia = "Mật khẩu Trung Bình. (Gợi ý: Nên kết hợp thêm ký tự đặc biệt)";
            }
            else
            {
                danhGia = "Mật khẩu Mạnh";
            }
            Console.WriteLine($"Đánh Giá: {danhGia}");

        }
        static void Bai19()
        {
            Console.Write("Nhập số a: ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Nhập số b: ");
            double b;
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Chọn phép tính: ");
            string phepTinh = Console.ReadLine();
            while (phepTinh != "+" && phepTinh != "-" && phepTinh != "*" && phepTinh != "/")
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            double toanTu = 0;
            string canhBao = null;
            switch (phepTinh)
            {
                case "+":
                    toanTu = a + b;
                    break;
                case "-":
                    toanTu = a - b;
                    break;
                case "*":
                    toanTu = a * b;
                    break;
                case "/":
                    toanTu = a / b;
                    if (b == 0)
                    {
                        canhBao = "(Lỗi: Không thể thực hiện phép chia cho 0!)";
                    }
                    break;
            }
            Console.WriteLine($"{a} {phepTinh} {b} = {toanTu}. {canhBao}");
        }
        static void Bai20()
        {
            Console.Write("Nhóm máu người nhận: ");
            string nhomMau = Console.ReadLine();
            while( nhomMau != "O" &&  nhomMau != "A" && nhomMau != "B" && nhomMau != "AB")
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            string nhomMauNhan = null;
            switch (nhomMau)
            {
                case "O":
                    nhomMauNhan = "chỉ nhận được từ nhóm máu O";
                    break;
                case "A":
                    nhomMauNhan = "nhận được từ nhóm A,O";
                    break;
                case "B":
                    nhomMauNhan = "nhận được từ nhóm B,O";
                    break;
                case "AB":
                    nhomMauNhan = "nhận được tất cả các nhóm A, B, O, AB";
                    break;
            }
            Console.WriteLine($"Người có nhóm máu {nhomMau} {nhomMauNhan}");
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = System.Text.Encoding.UTF8;
        //    //Bai1();
        //    //Bai2();
        //    //Bai3();
        //    //Bai4();
        //    //Bai5();
        //    //Bai6();
        //    //Bai7();
        //    //Bai8();
        //    //Bai9();
        //    //Bai10();
        //    //Bai11();
        //    //Bai12();
        //    //Bai13();
        //    //Bai14();
        //    //Bai15();
        //    //Bai16();
        //    //Bai17();
        //    //Bai18();
        //    //Bai19();
        //    //Bai20();
        //}
    }
}
