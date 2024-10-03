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
        }

        private void LopForm_Load(object sender, EventArgs e)
        {
            cboKhoa.DataSource = khoas.loadKhoa();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";

            dgvLop.DataSource = lops.loadLop();
        }


    }
}
