using System;
using System.IO;
namespace QTMCsharp {
    class TestCsharp {
        static FileStream fs; 
        static StreamWriter sw;
        khai báo delegate 
        public delegate void printString(string s);
       phương thức thứ nhất để in trên console 
        public static void WriteToScreen(string str) { 
            Console.WriteLine("Chuỗi la: {0}", str); 
        }phương thức thứ hai để ghi dữ liệu vào file 
        public static void WriteToFile(string s) { 
            fs = new FileStream("c:\\message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs); sw.WriteLine(s); sw.Flush(); sw.Close();
            fs.Close(); 
        }

