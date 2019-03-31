using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Qlks
{
    public partial class capnhat : Form
    {
        public capnhat()
        {
            InitializeComponent();
        }

        public static int maphong;
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        SqlDataReader dr;

        private void form_load()
        {
            lb_mp.Text = "Phòng Số: " + maphong.ToString();
            dr = cl.hienchiphiphu(maphong);
            while (dr.Read())
            {

                txt_dc.Text = dr.GetInt32(0).ToString();
                txt_dv.Text = dr.GetString(1);
                txt_gia.Text = dr.GetInt32(2).ToString();
                lb_tt.Text = dr.GetInt32(3).ToString();

            }
        }
        private void capnhat_Load(object sender, EventArgs e)
        {
            form_load();
        }
        private void lu_click()
        {
            int giadv = 0, tiendatcoc = 0, d1 = 0, d2 = 0;

            string chuoi1 = txt_gia.Text;
            string[] ketqua1 = chuoi1.Split('+');
            d1 = ketqua1.Length - 1;
            if (d1 != 0)
            {
                for (int i = 0; i <= d1; i++)
                {
                    giadv += Convert.ToInt32(ketqua1[i]);
                }
                txt_gia.Text = giadv.ToString();
            }

            string chuoi2 = txt_dc.Text;
            string[] ketqua2 = chuoi2.Split('+');
            d2 = ketqua2.Length - 1;
            if (d2 != 0)
            {
                for (int i = 0; i <= d2; i++)
                {
                    tiendatcoc += Convert.ToInt32(ketqua2[i]);
                }
                txt_dc.Text = tiendatcoc.ToString();
            }

            dt = cl.capnhatchiphi(maphong, Convert.ToInt32(txt_dc.Text), txt_dv.Text, Convert.ToInt32(txt_gia.Text));
            if (dt.Rows[0]["errcode"].ToString() == "0")
            {

                //MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt = cl.Capnhattongtien(maphong, Convert.ToInt32(lb_tt.Text));
                form_load();

            }
        }
        private void bt_lu_Click(object sender, EventArgs e)
        {
            int giadv = 0, tiendatcoc = 0, d1 = 0, d2 = 0;
            
                string chuoi1 = txt_gia.Text;
                string[] ketqua1 = chuoi1.Split('+');
                d1 = ketqua1.Length - 1;
                if (d1 != 0)
                {
                    for (int i = 0; i <= d1; i++)
                    {
                        giadv += Convert.ToInt32(ketqua1[i]);
                    }
                    txt_gia.Text = giadv.ToString();
                }

                string chuoi2 = txt_dc.Text;
                string[] ketqua2 = chuoi2.Split('+');
                d2 = ketqua2.Length - 1;
                if (d2 != 0)
                {
                    for (int i = 0; i <= d2; i++)
                    {
                        tiendatcoc += Convert.ToInt32(ketqua2[i]);
                    }
                    txt_dc.Text = tiendatcoc.ToString();
                }

            dt = cl.capnhatchiphi(maphong, Convert.ToInt32(txt_dc.Text), txt_dv.Text, Convert.ToInt32(txt_gia.Text));
            if (dt.Rows[0]["errcode"].ToString() == "0")
            {
                
                MessageBox.Show(dt.Rows[0]["errmsg"].ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt = cl.Capnhattongtien(maphong, Convert.ToInt32(lb_tt.Text));
                form_load();
                
            }
            lu_click();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
