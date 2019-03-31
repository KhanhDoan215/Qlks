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
    public partial class timkh : Form
    {
        public timkh()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        private int mp;
        private void bt_tk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tk.Text))
            {
                dt.Clear();
                dt = cl.timkhachang(txt_tk.Text);
                try
                {
                    bt_xoa.Enabled = true;
                    dg.DataSource = dt;
                }
                catch (Exception)
                {
                }
                
            }
            else MessageBox.Show("Nhập !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            bt_xoa.Enabled = false;
            bt_ct.Enabled = false;
            txt_tk.Text = "";
        }
        private void timkh_Load(object sender, EventArgs e)
        {
            load();
        }


        private void dg_Click(object sender, EventArgs e)
        {
            bt_ct.Enabled = true;
            try
            {
                mp = Convert.ToInt32(dg.CurrentRow.Cells["Maphong"].Value);
            }
            catch (Exception)
            {
                
               
            }
            
        }

        private void bt_ct_Click(object sender, EventArgs e)
        {
            phong.maphong = mp;
            phong p = new phong();
            p.Show();

        }
    }
}
