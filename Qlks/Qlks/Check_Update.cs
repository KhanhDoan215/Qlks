using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Qlks
{
    public class Check_Update
    {
        public static string kt_suaphong(string tenkh, string namsinh, string socm,string songdatphong)
        {
            if (tenkh == "") { return ("2"); }
            else
                if ((namsinh == "")) { return ("3"); }
                else
                    if ((socm == "")) { return ("4"); }
                    else
                        if ((songdatphong == "")) { return ("5"); }
                        else return "1";






        }

    }
}
