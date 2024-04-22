using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (var db = new BTEFNhanVienPhongBanCongtyEntities())
            {
                var select = from s in db.NhanViens 
                             where s.tuoi>=30 && s.tuoi<=40 && s.phongban.tenphongban=="marketing" 
                             select s;
                foreach (var data in select)
                {
                    Console.WriteLine("ID: {0}", data.idnhanvien);
                    Console.WriteLine("Tên: {0}", data.tennhanvien); 
                    Console.WriteLine("idphongban: {0}", data.idphongban);
                    Console.WriteLine("Tên phòng ban: {0}", data.phongban.tenphongban);
                    Console.WriteLine("Tuổi: {0}", data.tuoi);
                }
            }
            Console.ReadLine();
        }
    }
}
