using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_8_Kiểm_Tra_Mã_OTP
    {
        static void Bai8()
        {
            string otpGoc = "839201";
            DateTime creationTime = DateTime.Now;
            Console.Write("Mã OTP nhận được: ");
            string inputOTP = Console.ReadLine();
            Console.Write("Thời gian trôi qua: ");
            int phut = 2;
            int giay = 15;
            TimeSpan timeTroiQua = new TimeSpan(0,0,phut, giay);
            DateTime timeXacThuc = creationTime.Add(timeTroiQua);
            TimeSpan timeChenhLech = timeXacThuc - creationTime;
            if (inputOTP.Length != 6 ||!long.TryParse(inputOTP, out _))
            {
                Console.WriteLine("Trang thái xác thực: Lỗi - Định dạng không hợp lệ ");
            }
            else if(timeTroiQua.TotalSeconds >300)
            {
                Console.WriteLine("Trạng thái xác thực: Lỗi - Hết hạn OTP");
            }
            else if (inputOTP != otpGoc)
            {
                Console.WriteLine("Trạng thái xác thực: Lỗi - Mã OTP không hợp lệ");
            }
            else
            {
                Console.WriteLine("Trạng thái xác thực: Thành Công - Giao dịch đã được phê duyệt");
            }
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Bai8();
        //}
    }
}
