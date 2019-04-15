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
    public partial class tinhtien : Form
    {
        double tienphong, tongtien;
        public tinhtien()
        {
            InitializeComponent();
        }
        public static int maphong;
        public static string nv;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        CauLenh cl = new CauLenh();
       
        private void tinhtien_Load(object sender, EventArgs e)
        {
            int ngay1, thang1, ngay2, thang2, giaphong;
            dr = cl.loaiphong(maphong);
            while (dr.Read())
            {
                giaphong = dr.GetInt32(0);

                dr = cl.timphong(maphong);
                while (dr.Read())
                {
                    //lb_tt.Text = dr.GetString(1);
                    if (dr.GetString(1) == "Trống")
                    {


                    }
                    else
                    {


                        lb_ten.Text = dr.GetString(2);
                        lb_namsinh.Text = dr.GetInt32(3).ToString();
                        lb_socm.Text = dr.GetInt32(4).ToString();
                        lb_ngaydp.Text = dr.GetDateTime(6).ToString();
                        lb_ngaytp.Text = dr.GetDateTime(7).ToString();


                        string chuoi1 = lb_ngaydp.Text;
                        string chuoi2 = lb_ngaytp.Text;
                        string[] ketqua1 = chuoi1.Split('/');
                        thang1 = Convert.ToInt32(ketqua1[0]);
                        ngay1 = Convert.ToInt32(ketqua1[1]);
                        string[] ketqua2 = chuoi2.Split('/');
                        thang2 = Convert.ToInt32(ketqua2[0]);
                        ngay2 = Convert.ToInt32(ketqua2[1]);

                        tienphong = (thang2 - thang1) * (giaphong * 30) + (ngay2 - ngay1) * giaphong;
                        lb_tienphong.Text = Convert.ToString(tienphong);
                    }


                }
            }
            dr = cl.hientongtien(maphong);
            while (dr.Read())
            {
                lb_chiphi.Text = dr.GetInt32(0).ToString();

            }

            label1.Text = "Thông Tin Phòng: " + maphong.ToString();
            lb_tenp.Text = "Phòng Số: " + maphong.ToString();
            if (lb_tienphong.Text != "Trống")
            {
                tongtien = Convert.ToDouble(lb_tienphong.Text) - Convert.ToDouble(lb_chiphi.Text);
                lb_tongtien.Text = Convert.ToString(tongtien);
            }

        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_tinhtien_Click(object sender, EventArgs e)
        {
            string kt = Check_Tinhtien.kt_tongtien(lb_tongtien.Text);
            if (kt == "0")
            {
                if (lb_tongtien.Text == "0")
       
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
              
                    dt = cl.luuthongtinphong(maphong, lb_ten.Text, Convert.ToInt32(lb_namsinh.Text), Convert.ToInt32(lb_socm.Text), lb_ngaydp.Text, lb_ngaytp.Text, Convert.ToInt32(lb_tienphong.Text), Convert.ToInt32(lb_chiphi.Text), Convert.ToInt32(lb_tongtien.Text), nv);
                    MessageBox.Show("Đã Lưu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                /*lb_tongtien.Text = "0";
                lb_tienphong.Text = "0";
                lb_chiphi.Text = "0";*/

            }
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            
            dr.Close();
            dr = cl.laymakh(maphong, lb_ten.Text, Convert.ToInt32(lb_tongtien.Text));
            while(dr.Read())
            {
                //MessageBox.Show(dr.GetInt32(0).ToString());
                inhoadon.makh = dr.GetInt32(0);
                inhoadon i = new inhoadon();
                i.ShowDialog();

            }
        }
    }
}
