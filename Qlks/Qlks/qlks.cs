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
    public partial class qlks : Form
    {
        public qlks()
        {
            InitializeComponent();
        }
        public static string nguoi_dn;
        public string hinh1 = @"Hinh\hinh1.png";
        public string hinh2 = @"Hinh\hinh2.png";
        public string h1 = @"Hinh\h1.jpg";
        public string h2 = @"Hinh\h2.jpg";
        public string h3 = @"Hinh\h3.jpg";
        public string h4 = @"Hinh\h4.png";
        public string h5 = @"Hinh\h5.jpg";
        public string h6 = @"Hinh\h6.jpg";
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        private string tinhtrang(int ma)
        {
            dt.Clear();
            dt = cl.ttphong(ma);
            string tt = dt.Rows[0]["TinhTrang"].ToString();
            string hinh = null;
            if (tt == "Không")
            {
                hinh = hinh2;
            }
            if (tt == "Trống")
            {
                hinh = hinh1;
            }
            return hinh;
        }

        private bool txp(int ma)
        {
            dr = cl.txphong(ma);
            while (dr.Read())
            {
                string tt = dr.GetString(1);

                if (tt == "Hiện")
                    return true;
            }
            return false;
        }
        public void frm_load()
        {

            //lbl_ten.Text = "Chào " + nguoi_dn;
            if (nguoi_dn != "admin")
            {
                sửaPhòngToolStripMenuItem.Enabled = false;
                nhânViênToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
            }

            string k1 = tinhtrang(101);
            if (!string.IsNullOrEmpty(k1))
            {
                bt_101.Image = Image.FromFile(k1);
                bt_101.Visible = txp(101);
                lb_101.Visible = txp(101);
            }
            string k2 = tinhtrang(102);
            if (!string.IsNullOrEmpty(k2))
            {
                bt_102.Image = Image.FromFile(k2);
                bt_102.Visible = txp(102);
                lb_102.Visible = txp(102);
            }
            string k3 = tinhtrang(103);
            if (!string.IsNullOrEmpty(k3))
            {
                bt_103.Image = Image.FromFile(k3);
                bt_103.Visible = txp(103);
                lb_103.Visible = txp(103);
            }
            string k4 = tinhtrang(104);
            if (!string.IsNullOrEmpty(k4))
            {
                bt_104.Image = Image.FromFile(k4);
                bt_104.Visible = txp(104);
                lb_104.Visible = txp(104);
            }
            string k5 = tinhtrang(105);
            if (!string.IsNullOrEmpty(k4))
            {
                bt_105.Image = Image.FromFile(k5);
                bt_105.Visible = txp(105);
                lb_105.Visible = txp(105);
            }
            string k6 = tinhtrang(106);
            if (!string.IsNullOrEmpty(k4))
            {
                bt_106.Image = Image.FromFile(k6);
                bt_106.Visible = txp(105);
                lb_106.Visible = txp(105);
            }
            string k7 = tinhtrang(107);
            if (!string.IsNullOrEmpty(k7))
            {
                bt_107.Image = Image.FromFile(k7);
                bt_107.Visible = txp(107);
                lb_107.Visible = txp(107);
                string k8 = tinhtrang(108);
                if (!string.IsNullOrEmpty(k8))
                {
                    bt_108.Image = Image.FromFile(k8);
                    bt_108.Visible = txp(108);
                    lb_108.Visible = txp(108);
                }
                string k9 = tinhtrang(109);
                if (!string.IsNullOrEmpty(k9))
                {
                    bt_109.Image = Image.FromFile(k9);
                    bt_109.Visible = txp(107);
                    lb_109.Visible = txp(107);
                }
                string k10 = tinhtrang(110);
                if (!string.IsNullOrEmpty(k10))
                {
                    bt_110.Image = Image.FromFile(k10);
                    bt_110.Visible = txp(110);
                    lb_110.Visible = txp(110);
                }
                string k20 = tinhtrang(201);
                if (!string.IsNullOrEmpty(k20))
                {
                    bt_201.Image = Image.FromFile(k10);
                    bt_201.Visible = txp(201);
                    lb_201.Visible = txp(201);
                }
                string k21 = tinhtrang(202);
                if (!string.IsNullOrEmpty(k21))
                {
                    bt_202.Image = Image.FromFile(k21);
                    bt_202.Visible = txp(202);
                    lb_202.Visible = txp(202);
                }
                string k22 = tinhtrang(203);
                if (!string.IsNullOrEmpty(k22))
                {
                    bt_203.Image = Image.FromFile(k22);
                    bt_203.Visible = txp(203);
                    lb_203.Visible = txp(203);
                }
                string k23 = tinhtrang(204);
                if (!string.IsNullOrEmpty(k23))
                {
                    bt_204.Image = Image.FromFile(k23);
                    bt_204.Visible = txp(204);
                    lb_204.Visible = txp(204);
                }
                string k24 = tinhtrang(205);
                if (!string.IsNullOrEmpty(k24))
                {
                    bt_205.Image = Image.FromFile(k24);
                    bt_205.Visible = txp(205);
                    lb_205.Visible = txp(205);
                }
                string k25 = tinhtrang(206);
                if (!string.IsNullOrEmpty(k25))
                {
                    bt_206.Image = Image.FromFile(k25);
                    bt_206.Visible = txp(206);
                    lb_206.Visible = txp(206);
                }
                string k26 = tinhtrang(207);
                if (!string.IsNullOrEmpty(k26))
                {
                    bt_207.Image = Image.FromFile(k26);
                    bt_207.Visible = txp(207);
                    lb_207.Visible = txp(207);
                }
                string k27 = tinhtrang(208);
                if (!string.IsNullOrEmpty(k27))
                {
                    bt_208.Image = Image.FromFile(k27);
                    bt_208.Visible = txp(208);
                    lb_208.Visible = txp(208);
                }
                string k28 = tinhtrang(209);
                if (!string.IsNullOrEmpty(k28))
                {
                    bt_209.Image = Image.FromFile(k28);
                    bt_209.Visible = txp(209);
                    lb_209.Visible = txp(209);
                }
                string k29 = tinhtrang(210);
                if (!string.IsNullOrEmpty(k25))
                {
                    bt_210.Image = Image.FromFile(k29);
                    bt_210.Visible = txp(210);
                    lb_210.Visible = txp(210);
                }
                string k30 = tinhtrang(301);
                if (!string.IsNullOrEmpty(k30))
                {
                    bt_301.Image = Image.FromFile(k30);
                    bt_301.Visible = txp(301);
                    lb_301.Visible = txp(301);
                }
                string k31 = tinhtrang(302);
                if (!string.IsNullOrEmpty(k31))
                {
                    bt_302.Image = Image.FromFile(k31);
                    bt_302.Visible = txp(302);
                    lb_302.Visible = txp(302);
                }
                string k32 = tinhtrang(303);
                if (!string.IsNullOrEmpty(k32))
                {
                    bt_303.Image = Image.FromFile(k32);
                    bt_303.Visible = txp(302);
                    lb_303.Visible = txp(302);
                }
                string k33 = tinhtrang(304);
                if (!string.IsNullOrEmpty(k33))
                {
                    bt_304.Image = Image.FromFile(k33);
                    bt_304.Visible = txp(304);
                    lb_304.Visible = txp(304);
                }
                string k34 = tinhtrang(305);
                if (!string.IsNullOrEmpty(k34))
                {
                    bt_305.Image = Image.FromFile(k34);
                    bt_305.Visible = txp(305);
                    lb_305.Visible = txp(305);
                }
                string k35 = tinhtrang(306);
                if (!string.IsNullOrEmpty(k35))
                {
                    bt_306.Image = Image.FromFile(k35);
                    bt_306.Visible = txp(306);
                    lb_306.Visible = txp(306);
                }
                string k36 = tinhtrang(307);
                if (!string.IsNullOrEmpty(k36))
                {
                    bt_307.Image = Image.FromFile(k36);
                    bt_307.Visible = txp(302);
                    lb_307.Visible = txp(302);
                }
                string k37 = tinhtrang(308);
                if (!string.IsNullOrEmpty(k37))
                {
                    bt_308.Image = Image.FromFile(k37);
                    bt_308.Visible = txp(308);
                    lb_308.Visible = txp(308);
                }
                string k38 = tinhtrang(309);
                if (!string.IsNullOrEmpty(k38))
                {
                    bt_309.Image = Image.FromFile(k38);
                    bt_309.Visible = txp(302);
                    lb_309.Visible = txp(302);
                }
                string k39 = tinhtrang(310);
                if (!string.IsNullOrEmpty(k38))
                {
                    bt_310.Image = Image.FromFile(k39);
                    bt_310.Visible = txp(302);
                    lb_310.Visible = txp(302);
                }
            }
        }
        private void qlks_Load(object sender, EventArgs e)
        {
            frm_load();
            
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.Show();
            //DangNhap dn = new DangNhap();
            //dn.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát?","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void danhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhsachphong p = new danhsachphong();  
            p.ShowDialog();
        }

        private void bt_101_Click(object sender, EventArgs e)
        {
            
            
            phong.maphong = 101;
            phong p = new phong();

            p.ShowDialog(); frm_load();
        }

        private void bt_102_Click(object sender, EventArgs e)
        {
            phong.maphong = 102;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_103_Click(object sender, EventArgs e)
        {
            phong.maphong = 103;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_104_Click(object sender, EventArgs e)
        {
            phong.maphong = 104;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_105_Click(object sender, EventArgs e)
        {
            phong.maphong = 105;
            phong p = new phong();
            p.ShowDialog();
            frm_load();
        }

        private void bt_106_Click(object sender, EventArgs e)
        {
            phong.maphong = 106;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_107_Click(object sender, EventArgs e)
        {
            phong.maphong = 107;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_108_Click(object sender, EventArgs e)
        {
            phong.maphong = 108;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_109_Click(object sender, EventArgs e)
        {
            phong.maphong = 109;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_110_Click(object sender, EventArgs e)
        {
            phong.maphong = 110;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_210_Click(object sender, EventArgs e)
        {
            phong.maphong = 210;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_209_Click(object sender, EventArgs e)
        {
            phong.maphong = 209;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_208_Click(object sender, EventArgs e)
        {
            phong.maphong = 208;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_207_Click(object sender, EventArgs e)
        {
            phong.maphong = 207;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_206_Click(object sender, EventArgs e)
        {
            phong.maphong = 206;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_205_Click(object sender, EventArgs e)
        {
            phong.maphong = 205;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_204_Click(object sender, EventArgs e)
        {
            phong.maphong = 204;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_203_Click(object sender, EventArgs e)
        {
            phong.maphong = 203;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_202_Click(object sender, EventArgs e)
        {
            phong.maphong = 202;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_201_Click(object sender, EventArgs e)
        {
            phong.maphong = 201;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_301_Click(object sender, EventArgs e)
        {
            phong.maphong = 301;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_302_Click(object sender, EventArgs e)
        {
            phong.maphong = 302;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_303_Click(object sender, EventArgs e)
        {
            phong.maphong = 303;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_304_Click(object sender, EventArgs e)
        {
            phong.maphong = 304;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_305_Click(object sender, EventArgs e)
        {
            phong.maphong = 305;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_306_Click(object sender, EventArgs e)
        {
            phong.maphong = 306;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_307_Click(object sender, EventArgs e)
        {
            phong.maphong = 307;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_308_Click(object sender, EventArgs e)
        {
            phong.maphong = 308;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_309_Click(object sender, EventArgs e)
        {
            phong.maphong = 309;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_310_Click(object sender, EventArgs e)
        {
            phong.maphong = 310;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

       

       
        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txphong t = new Txphong();
            t.ShowDialog();
        }

        private void sửaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suaphong sp = new suaphong();
            sp.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doimatkhau.taikhoan = nguoi_dn;
            doimatkhau dmk = new doimatkhau();
            dmk.ShowDialog();
        }

        private void lbl_ten_Click(object sender, EventArgs e)
        {

        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timkh tk = new timkh();
            tk.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanhthu dth = new doanhthu();
            dth.ShowDialog();
        }

        private void nền1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt_hinh.Image = Image.FromFile(h1);
        }

        private void nền2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt_hinh.Image = Image.FromFile(h2);
        }

        private void nền3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt_hinh.Image = Image.FromFile(h3);
        }

        private void nền4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt_hinh.Image = Image.FromFile(h4);
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt_hinh.Image = null;
        }

        private void nền5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt_hinh.Image = Image.FromFile(h5);
        }

        private void nền6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt_hinh.Image = Image.FromFile(h6);
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongtin tt = new Thongtin();
            tt.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan hd = new HuongDan();
            hd.ShowDialog();
        }

        private void thêmXóaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txphong tx = new Txphong();
            tx.ShowDialog();
            frm_load();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinnv ttnv = new thongtinnv();
            ttnv.ShowDialog();
        }
    }
}
