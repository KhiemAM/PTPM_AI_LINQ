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
    public partial class SinhVienForm : Form
    {
        DB_SinhVien sv = new DB_SinhVien();
        DB_Khoa khoa = new DB_Khoa();
        DB_Lop lop = new DB_Lop();
        public SinhVienForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            btnClose.Click += BtnClose_Click;
            this.Load += SinhVienForm_Load;
            cboMaKhoa.SelectedIndexChanged += CboMaKhoa_SelectedIndexChanged;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            if(sv.deleteSinhVien(maSV))
            {
                MessageBox.Show("Xoa sinh vien thanh cong");
                loadSinhVien();
                return;
            }
            MessageBox.Show("Xoa sinh vien khong thanh cong");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.MaSinhVien = txtMaSV.Text;
            sinhVien.HoTen = txtHoTen.Text;
            bool isNgaySinh = DateTime.TryParse(txtNgaySinh.Text, out DateTime result);
            if (isNgaySinh)
            {
                sinhVien.NgaySinh = result;
            }
            else
            {
                MessageBox.Show("Ngay sinh khong hop le");
                return;
            }
            sinhVien.MaLop = cboMaLop.SelectedValue.ToString();
            if(sv.updateSinhVien(sinhVien))
            {
                MessageBox.Show("Cap nhat thanh cong");
                loadSinhVien();
                return;
            }
            MessageBox.Show("Cap nhat khong thanh cong");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.MaSinhVien = txtMaSV.Text;
            sinhVien.HoTen = txtHoTen.Text;
            bool isNgaySinh = DateTime.TryParse(txtNgaySinh.Text, out DateTime result);
            if(isNgaySinh)
            {
                sinhVien.NgaySinh = result;
            }
            else
            {
                MessageBox.Show("Ngay sinh khong hop le");
                return;
            }
            sinhVien.MaLop = cboMaLop.SelectedValue.ToString();
            if(sv.addSinhVien(sinhVien))
            {
                MessageBox.Show("Them sinh vien thanh cong");
                loadSinhVien();
                return;
            }
            MessageBox.Show("Them sinh vien khong thanh cong");
        }

        private void CboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCboLop();
        }

        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            loadSinhVien();

            cboMaKhoa.DataSource = khoa.loadKhoa();
            cboMaKhoa.DisplayMember = "TenKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";

            loadCboLop();
        }

        public void loadSinhVien()
        {
            dgvSinhVien.DataSource = sv.loadSinhVien();
        }

        public void loadCboLop()
        {
            string maKhoa = cboMaKhoa.SelectedValue.ToString();
            cboMaLop.DataSource = lop.loadLopByMaKhoa(maKhoa);
            cboMaLop.DisplayMember = "TenLop";
            cboMaLop.ValueMember = "MaLop";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
