namespace NVT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string choise;
            List<students> students = new List<students>();
            {
                new students { maSV = "241230879", hoTen = "Nguyen Van Tu", email = "nguyentu05092006@gmail.com" }
            };
            do
            {
                menu();
                Console.WriteLine("ban chon chuc nang gi: ");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        //them sinh vien
                        ThemMoiSinhVien(students);
                        break;
                    case "2":
                        //hien thi
                        HienThiThongTinSinhVien(students);
                        break;
                    case "14":
                        Console.WriteLine("Ban da chon thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Ban da chon sai chuc nang, vui long chon lai");
                        break;
                }
            } while (choise != "14");

        }

        static void menu()
        {
            Console.WriteLine("=============CHUC NANG=============");
            Console.WriteLine("1.\tThem sinh vien.\r");
            Console.WriteLine("2.\tHien thi danh sach.\r");
            Console.WriteLine("3.\tTim sinh vien theo ma.\r");
            Console.WriteLine("4.\tTim gan dung theo ho ten.\r");
            Console.WriteLine("5.\tCap nhat sinh vien.\r");
            Console.WriteLine("6.\txoa sinh vien.\r");
            Console.WriteLine("7.\tsap xep theo ho ten.\r");
            Console.WriteLine("8.\tsap xep theo diem trung binh.\r");
            Console.WriteLine("9.\thien thi sinh vien co diem tu 8 tro len.\r");
            Console.WriteLine("10.\thien thi sinh vien co dim cao nhat.\r");
            Console.WriteLine("11.\ttinh diem trung binh toan bo sinh vien.\r");
            Console.WriteLine("12.\tthong ke sinh vien theo nganh.\r");
            Console.WriteLine("13.\tthong ke sinh vien theo trang thai.\r");
            Console.WriteLine("14.\tThoat");

        }
        static void HienThiThongTinSinhVien(List<students> students)
        {
            Console.WriteLine("Danh sach sinh vien: ");
            foreach (var student in students)
            {
                Console.WriteLine("maSV: " + student.maSV);
                Console.WriteLine("hoTen: " + student.hoTen);
                Console.WriteLine("ngaySinh: " + student.ngaySinh);
                Console.WriteLine("gioiTinh: " + student.gioiTinh);
                Console.WriteLine("email: " + student.email);
                Console.WriteLine("-----------------------------");
            }

        }
        static void ThemMoiSinhVien(List<students> students)
        {
            Console.WriteLine("Nhap thong tin sinh vien: ");
            students newStudent = new students();
            Console.Write("Nhap ma sinh vien: ");
            students.maSV = Console.ReadLine();
            Console.Write("ho ten: ");
            students.hoTen = Console.ReadLine();
            Console.Write("ngay sinh: ");
            students.ngaySinh = DateTime.Parse(Console.ReadLine());
           
           
            
            
            
            students.Add(newStudent);
        }
    }
}
