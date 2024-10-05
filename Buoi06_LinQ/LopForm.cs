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
    public partial class LopForm : Form
    {
        DB_Khoa khoas = new DB_Khoa();
        DB_Lop lops = new DB_Lop();
        public LopForm()
        {
            InitializeComponent();
            this.Load += LopForm_Load;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvLop.SelectionChanged += DgvLop_SelectionChanged;
        }


        private void DgvLop_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLop.SelectedRows.Count > 0)
            {
                txtMaLop.Text = dgvLop.CurrentRow.Cells[0].Value.ToString();
                txtTenLop.Text = dgvLop.CurrentRow.Cells[1].Value.ToString();
                cboKhoa.Text = dgvLop.CurrentRow.Cells[2].Value.ToString();
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(lops.deleteLop(txtMaLop.Text))
            {
                MessageBox.Show("Xoa thanh cong");
                loadLop();
                return;
            }
            MessageBox.Show("Xoa khong thanh cong");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop();
            lop.MaLop = txtMaLop.Text;
            lop.TenLop = txtTenLop.Text;
            lop.MaKhoa = cboKhoa.SelectedValue.ToString();
            if(lops.updateLop(lop))
            {
                MessageBox.Show("Cap nhat thanh cong");
                loadLop();
                return;
            }
            MessageBox.Show("Cap nhat khong thanh cong");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(lops.checkPrimaryKey(txtMaLop.Text))
            {
                MessageBox.Show("Trung khoa chinh!");
                return;
            }

            Lop lop = new Lop();
            lop.MaLop = txtMaLop.Text;
            lop.TenLop = txtTenLop.Text;
            lop.MaKhoa = cboKhoa.SelectedValue.ToString();

            if (lops.addLop(lop))
            {
                MessageBox.Show("Them thanh cong!");
                loadLop();
                return;
            }
            MessageBox.Show("Them khong thanh cong");

        }

        private void LopForm_Load(object sender, EventArgs e)
        {
            cboKhoa.DataSource = khoas.loadKhoa();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";

            loadLop();
        }

        public void loadLop()
        {
            dgvLop.DataSource = lops.loadLop();
        }

    }
}
