using System;
using System.Collections.Generic;
using System.Text;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            List<Sinhvien> ListSV = new List<Sinhvien>();

            ListSV.Add(new Sinhvien("1", "chu tuan kiet", 8.8));
            ListSV.Add(new Sinhvien("2", "chu tuan anh", 8.8));
            ListSV.Add(new Sinhvien("3", "le van vo", 6.7));
            ListSV.Add(new Sinhvien("4", "le nhat vo", 6.7));
            ListSV.Add(new Sinhvien("5", "pham hai tu", 9));

            SelectTypeSort(ref ListSV);
        }

        public static void XuatDS(List<Sinhvien> ListSV)
        {
            foreach (var e in ListSV)
            {
                e.Xuat();
            }
        }
        public static void NhapDS(ref List<Sinhvien> ListSV)
        {
            Console.WriteLine("Nhập số lượng sinh viên :");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập sinh viên thứ {i + 1}");
                ListSV.Add(new Sinhvien());
                ListSV[ListSV.Count - 1].Nhap();
            }
        }
        public static void SelectTypeSort(ref List<Sinhvien> ListSV)
        {
            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("Lựa chọn kiểu sắp xếp : ");
                Console.WriteLine("1. Nhập dữ liệu sinh viên.");
                Console.WriteLine("2. Mặc định (Sắp xếp theo điểm tb, nếu bằng -> sắp xếp theo họ tên)");
                Console.WriteLine("3. Sắp xếp theo họ tên.");
                Console.WriteLine("4. Sắp xếp theo điểm trung bình.");
                Console.WriteLine("5. Hiển thị danh sách.");
                Console.WriteLine("0. Thoát chương trình.");

                int c;
                bool check = int.TryParse(Console.ReadLine(), out c);
                while (!check)
                {
                    check = int.TryParse(Console.ReadLine(), out c);
                }
                string key;
                switch (c)
                {
                    case 1:
                        {
                            NhapDS(ref ListSV);
                            XuatDS(ListSV);
                            break;
                        }
                    case 2:
                        {
                            ListSV.Sort();
                            XuatDS(ListSV);

                            break;
                        }
                    case 3:
                        {
                            ListSV.Sort(new SortByName());
                            XuatDS(ListSV);

                            break;
                        }
                    case 4:
                        {
                            ListSV.Sort(new SortByDiemTB());
                            XuatDS(ListSV);
                            break;
                        }
                    case 5:
                        {
                            XuatDS(ListSV);
                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                    default:
                        Console.WriteLine("Không có lựa chọn đó!! Hãy chọn lại");
                        break;
                }
              


                Console.WriteLine("Bạn có muốn tiếp tục ? (Y/N)");
                key = Console.ReadLine().ToUpper();

                if (key == "N")
                {
                    run = false;
                }
                else if (key == "Y")
                {
                    Console.Out.Flush();
                }

            }
        }


    }
}
