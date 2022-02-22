using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Sinhvien : IComparable<Sinhvien>
    {
        private string Masinhvien;
        private string Hoten;
        private double DiemTB;

        public string Masinhvien1 { get => Masinhvien; set => Masinhvien = value; }
        public string Hoten1 { get => Hoten; set => Hoten = value; }
        public double DiemTB1 { get => DiemTB; set => DiemTB = value; }

        public Sinhvien() 
        {
            Masinhvien = Hoten = "";
            DiemTB = 0.0;
        }
        public Sinhvien (string ma, string ten, double diem)
        {
            Masinhvien = ma;
            Hoten = ten;
            DiemTB = diem;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập mã sinh viên :"); Masinhvien = Console.ReadLine();
            Console.WriteLine("Nhập họ tên sinh viên :"); Hoten = Console.ReadLine();
            Console.WriteLine($"Nhập điểm trung bình của {Hoten} :");

            do
            {
                DiemTB = double.Parse(Console.ReadLine());
                if (DiemTB < 0 || DiemTB > 10)
                {
                    Console.WriteLine("Điểm nhập phải ở thang 10!!Hãy nhập lại");
                }
            } while (DiemTB < 0 || DiemTB > 10);

        }
        public void Xuat()
        {
            Console.Write($"Mã sinh viên: {Masinhvien}"); 
            Console.Write($", Họ tên sinh viên :{Hoten}");
            Console.WriteLine($", Điểm trung bình của {Hoten} :{DiemTB}"); 
        }
        public int CompareTo(Sinhvien obj)
        {
            if(this.DiemTB == obj.DiemTB)
            {
                return this.Hoten.CompareTo(obj.Hoten);
            }
            else
            {
                return this.DiemTB.CompareTo(obj.DiemTB);
            }
        }



    }
}
