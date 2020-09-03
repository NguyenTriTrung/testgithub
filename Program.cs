using System;
namespace Nhap_Xuat
{
    class Nhap_Xuat
    {
        static void Main(string[] args)
        {
           Console.WriteLine("gia tri:" + Console.ReadLine()); // đọc dữ liệu từ bàn phím cho đến khi gặp ký tự xuống dòng thì dừng. Sau đó in giá trị đã nhập ra màn hình.
            Console.WriteLine("gia tri: "+ Console.ReadLine());
            Console.ReadKey(true);// lệnh này dùng với mục đích dừng màn hình để xem kết quả., true thì không in ra kí tự nhập
        }

    }
}