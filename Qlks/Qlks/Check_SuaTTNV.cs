using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlks
{
    public class Check_SuaTTNV
    {
        public static string kt_SuaTTNV(string ten, string diachi, string sdt, string ngaysinh, string taikhoan, string matkhau)
        {
            if (ten == "") { return ("2"); }
            else
                if (taikhoan == "") { return ("3"); }
            else
                    if (taikhoan == "123") { return ("1"); }
                    else
                            return "0";
        }
    }
}
