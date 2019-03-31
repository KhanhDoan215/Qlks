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

            lbl_ten.Text = "Chào " + nguoi_dn;
            if(nguoi_dn != "admin")
            {
                sửaPhòngToolStripMenuItem.Enabled = false;
                nhânViênToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
            }

            bt_101.Image = Image.FromFile(tinhtrang(101)); bt_101.Visible = txp(101); lb_101.Visible = txp(101);
            bt_102.Image = Image.FromFile(tinhtrang(102)); bt_102.Visible = txp(102); lb_102.Visible = txp(102);
            bt_103.Image = Image.FromFile(tinhtrang(103)); bt_103.Visible = txp(103); lb_103.Visible = txp(103);
            bt_104.Image = Image.FromFile(tinhtrang(104)); bt_104.Visible = txp(104); lb_104.Visible = txp(104);
            bt_105.Image = Image.FromFile(tinhtrang(105)); bt_105.Visible = txp(105); lb_105.Visible = txp(105);
            bt_106.Image = Image.FromFile(tinhtrang(106)); bt_106.Visible = txp(106); lb_106.Visible = txp(106);
            bt_107.Image = Image.FromFile(tinhtrang(107)); bt_107.Visible = txp(107); lb_107.Visible = txp(107);
            bt_108.Image = Image.FromFile(tinhtrang(108)); bt_108.Visible = txp(108); lb_108.Visible = txp(108);
            bt_109.Image = Image.FromFile(tinhtrang(109)); bt_109.Visible = txp(109); lb_109.Visible = txp(109);
            bt_110.Image = Image.FromFile(tinhtrang(110)); bt_110.Visible = txp(110); lb_110.Visible = txp(110);

            bt_201.Image = Image.FromFile(tinhtrang(201)); bt_201.Visible = txp(201); lb_201.Visible = txp(201);
            bt_202.Image = Image.FromFile(tinhtrang(202)); bt_202.Visible = txp(202); lb_202.Visible = txp(202);
            bt_203.Image = Image.FromFile(tinhtrang(203)); bt_203.Visible = txp(203); lb_203.Visible = txp(203);
            bt_204.Image = Image.FromFile(tinhtrang(204)); bt_204.Visible = txp(204); lb_204.Visible = txp(204);
            bt_205.Image = Image.FromFile(tinhtrang(205)); bt_205.Visible = txp(205); lb_205.Visible = txp(205);
            bt_206.Image = Image.FromFile(tinhtrang(206)); bt_206.Visible = txp(206); lb_206.Visible = txp(206);
            bt_207.Image = Image.FromFile(tinhtrang(207)); bt_207.Visible = txp(207); lb_207.Visible = txp(207);
            bt_208.Image = Image.FromFile(tinhtrang(208)); bt_208.Visible = txp(208); lb_208.Visible = txp(208);
            bt_209.Image = Image.FromFile(tinhtrang(209)); bt_208.Visible = txp(209); lb_209.Visible = txp(209);
            bt_210.Image = Image.FromFile(tinhtrang(210)); bt_210.Visible = txp(210); lb_210.Visible = txp(210);

            bt_301.Image = Image.FromFile(tinhtrang(301)); bt_301.Visible = txp(301); lb_301.Visible = txp(301);
            bt_302.Image = Image.FromFile(tinhtrang(302)); bt_302.Visible = txp(302); lb_302.Visible = txp(302);
            bt_303.Image = Image.FromFile(tinhtrang(303)); bt_303.Visible = txp(303); lb_303.Visible = txp(303);
            bt_304.Image = Image.FromFile(tinhtrang(304)); bt_304.Visible = txp(304); lb_304.Visible = txp(304);
            bt_305.Image = Image.FromFile(tinhtrang(305)); bt_305.Visible = txp(305); lb_305.Visible = txp(305);
            bt_306.Image = Image.FromFile(tinhtrang(306)); bt_306.Visible = txp(306); lb_306.Visible = txp(306);
            bt_307.Image = Image.FromFile(tinhtrang(307)); bt_307.Visible = txp(307); lb_307.Visible = txp(307);
            bt_308.Image = Image.FromFile(tinhtrang(308)); bt_308.Visible = txp(308); lb_308.Visible = txp(308);
            bt_309.Image = Image.FromFile(tinhtrang(309)); bt_309.Visible = txp(309); lb_309.Visible = txp(309);
            bt_310.Image = Image.FromFile(tinhtrang(310)); bt_310.Visible = txp(310); lb_310.Visible = txp(310);

            bt_401.Image = Image.FromFile(tinhtrang(401)); bt_401.Visible = txp(401); lb_401.Visible = txp(401);
            bt_402.Image = Image.FromFile(tinhtrang(402)); bt_402.Visible = txp(402); lb_402.Visible = txp(402);
            bt_403.Image = Image.FromFile(tinhtrang(403)); bt_403.Visible = txp(403); lb_403.Visible = txp(403);
            bt_404.Image = Image.FromFile(tinhtrang(404)); bt_404.Visible = txp(404); lb_404.Visible = txp(404);
            bt_405.Image = Image.FromFile(tinhtrang(405)); bt_405.Visible = txp(405); lb_405.Visible = txp(405);
            bt_406.Image = Image.FromFile(tinhtrang(406)); bt_406.Visible = txp(406); lb_406.Visible = txp(406);
            bt_407.Image = Image.FromFile(tinhtrang(407)); bt_407.Visible = txp(407); lb_407.Visible = txp(407);
            bt_408.Image = Image.FromFile(tinhtrang(408)); bt_408.Visible = txp(408); lb_408.Visible = txp(408);
            bt_409.Image = Image.FromFile(tinhtrang(409)); bt_409.Visible = txp(409); lb_409.Visible = txp(409);
            bt_410.Image = Image.FromFile(tinhtrang(410)); bt_410.Visible = txp(410); lb_410.Visible = txp(410);

            bt_501.Image = Image.FromFile(tinhtrang(501));
            bt_501.Visible = txp(501); lb_501.Visible = txp(501);
            bt_502.Image = Image.FromFile(tinhtrang(502));
            bt_502.Visible = txp(502); lb_502.Visible = txp(502);
            bt_503.Image = Image.FromFile(tinhtrang(503));
            bt_503.Visible = txp(503); lb_503.Visible = txp(503);
            bt_504.Image = Image.FromFile(tinhtrang(504));
            bt_504.Visible = txp(504); lb_504.Visible = txp(504);
            bt_505.Image = Image.FromFile(tinhtrang(505));
            bt_505.Visible = txp(505); lb_505.Visible = txp(505);
            bt_506.Image = Image.FromFile(tinhtrang(506));
            bt_506.Visible = txp(506); lb_506.Visible = txp(506);
            bt_507.Image = Image.FromFile(tinhtrang(507));
            bt_507.Visible = txp(507); lb_507.Visible = txp(507);
            bt_508.Image = Image.FromFile(tinhtrang(508));
            bt_508.Visible = txp(508); lb_508.Visible = txp(508);
            bt_509.Image = Image.FromFile(tinhtrang(509));
            bt_509.Visible = txp(509); lb_509.Visible = txp(509);
            bt_510.Image = Image.FromFile(tinhtrang(510));
            bt_510.Visible = txp(510); lb_510.Visible = txp(510);
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

        private void bt_401_Click(object sender, EventArgs e)
        {
            phong.maphong = 401;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_402_Click(object sender, EventArgs e)
        {
            phong.maphong = 402;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_403_Click(object sender, EventArgs e)
        {
            phong.maphong = 403;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_404_Click(object sender, EventArgs e)
        {
            phong.maphong = 404;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_405_Click(object sender, EventArgs e)
        {
            phong.maphong = 405;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_406_Click(object sender, EventArgs e)
        {
            phong.maphong = 406;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_407_Click(object sender, EventArgs e)
        {
            phong.maphong = 407;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_408_Click(object sender, EventArgs e)
        {
            phong.maphong = 408;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_409_Click(object sender, EventArgs e)
        {
            phong.maphong = 409;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_410_Click(object sender, EventArgs e)
        {
            phong.maphong = 410;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_501_Click(object sender, EventArgs e)
        {
            phong.maphong = 501;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_502_Click(object sender, EventArgs e)
        {
            phong.maphong = 502;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_503_Click(object sender, EventArgs e)
        {
            phong.maphong = 503;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_504_Click(object sender, EventArgs e)
        {
            phong.maphong = 504;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_505_Click(object sender, EventArgs e)
        {
            phong.maphong = 505;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_506_Click(object sender, EventArgs e)
        {
            phong.maphong = 506;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_507_Click(object sender, EventArgs e)
        {
            phong.maphong = 507;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_508_Click(object sender, EventArgs e)
        {
            phong.maphong = 508;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_509_Click(object sender, EventArgs e)
        {
            phong.maphong = 509;
            phong p = new phong();
            p.ShowDialog(); frm_load();
        }

        private void bt_510_Click(object sender, EventArgs e)
        {
            phong.maphong = 510;
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
