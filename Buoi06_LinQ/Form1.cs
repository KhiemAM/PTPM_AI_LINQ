using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi06_LinQ
{
    public partial class Form1 : Form
    {
        DB_MonHoc mh = new DB_MonHoc();
        DB_SinhVien sv = new DB_SinhVien();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            btn_GetFirst.Click += btn_GetFirst_Click;
            btn_EndSinhVien.Click += btn_EndSinhVien_Click;
            btn_getSinhVien2And3.Click += btn_getSinhVien2And3_Click;
            btn_SXGiamDanTheoTen.Click += btn_SXGiamDanTheoTen_Click;
            btn_GetSVLop.Click += btn_GetSVLop_Click;
        }

        void btn_GetSVLop_Click(object sender, EventArgs e)
        {
            dgv_SinhVien.DataSource = sv.getSinhVienLop();
        }

        void btn_SXGiamDanTheoTen_Click(object sender, EventArgs e)
        {
            dgv_SinhVien.DataSource = sv.sapXepGiamDanTheoTen();
        }

        void btn_getSinhVien2And3_Click(object sender, EventArgs e)
        {
            dgv_SinhVien.DataSource = sv.getSinhVien2And3();
        }

        void btn_EndSinhVien_Click(object sender, EventArgs e)
        {
            dgv_SinhVien.DataSource = sv.getEndSinhVien();
        }

        void btn_GetFirst_Click(object sender, EventArgs e)
        {
            dgv_SinhVien.DataSource = sv.getFirstSinhVien();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            dgv_MonHoc.DataSource = mh.loadMonhoc();
            dgv_SinhVien.DataSource = sv.loadSinhVien();
        }
    }
}
