using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_6_Chuẩn_Hóa_Họ_Tên
    {
        static void Bai6()
        {
            Console.Write("Nhập Họ Tên: ");
            string hoTen = Console.ReadLine();
            string[] tuList = hoTen.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tuList.Length; i++)
            {
                tuList[i] = tuList[i].Substring(0, 1).ToUpper() + tuList[i].Substring(1).ToLower();
            }
            string hoTenChuanHoa = string.Join(" ", tuList);
            Console.WriteLine($"Họ tên chuẩn hóa: {hoTenChuanHoa}");
            string ho = tuList[0];
            string ten = tuList[tuList.Length - 1];
            string tenDem = "";

            if (tuList.Length > 2)
            {
                tenDem = string.Join(" ", tuList, 1, tuList.Length - 2);
            }

            Console.WriteLine($"Họ: {ho} | Tên đệm: {tenDem} | Tên: {ten}");
            string tenKhongDau = BoDauTiengViet(ten);
            string hoKhongDau = BoDauTiengViet(ho);
            string tenDemKhongDau = BoDauTiengViet(tenDem).Replace(" ", "");
            string username = $"{tenKhongDau}.{hoKhongDau}{tenDemKhongDau}";
            Console.WriteLine($"Username tạo tự động: {username}");
            string email = username + "@company.edu.vn";
            Console.WriteLine($"Email cấp phát: {email}");

        }
        static string BoDauTiengViet(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            string[] dau = new string[]
            {"aàáạảãâầấậẩẫăằắặẳẵ", "eèéẹẻẽêềếệểễ", "iìíịỉĩ", "oòóọỏõôồốộổỗơờớợởỡ", "uùúụủũưừứựửữ", "yỳýỵỷỹ", "dđ"};
            string[] khongDau = new string[] { "a", "e", "i", "o", "u", "y", "d" };

            text = text.ToLower();
            for (int i = 0; i < dau.Length; i++)
            {
                for (int j = 0; j < dau[i].Length; j++)
                {
                    text = text.Replace(dau[i][j], khongDau[i][0]);
                }
            }
            return text;
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = System.Text.Encoding.UTF8;
        //    Bai6();
        //}
    }
}
