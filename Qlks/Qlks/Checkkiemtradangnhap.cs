using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Qlks
{
    public class Checkkiemtradangnhap
    {

        public static string ktdangnhap(string id, string pass)
        {
            if ((id == "") && (pass == "")) { return ("1"); }
            else
                if ((id == "")) { return ("2"); }
                else
                    if (pass == "") { return ("3"); }

                    else return "0";
        }

    }
}