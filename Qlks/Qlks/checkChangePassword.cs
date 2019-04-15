using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlks
{
    public class checkChangePassword
    {
        public static string check_changepassword(string oldpass, string newpass, string confpass)
        {

            if (oldpass == "") { return "Mật khẩu cũ sai"; }
            else if (newpass != confpass) { return  "Xác nhận lại mật khẩu"; }
            else if (newpass == confpass) { return "Nhập lại mật khẩu"; }
            return "Đổi mật khẩu thành công";



        }
    }
}