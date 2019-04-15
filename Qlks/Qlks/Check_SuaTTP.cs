using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlks
{
    public class Check_SuaTTP
    {
          public static string kt_TTPhong(string maph, string giaphong)
          {
              if  (maph == "") { return ("1");}
              else
                  if (giaphong == "") { return ("2");}
                  else
                      return "0";
          }

    }
}
