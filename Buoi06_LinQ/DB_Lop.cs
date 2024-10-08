using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_LinQ
{
    public class DB_Lop
    {
        QLSINHVIEN_PTPM_AIDataContext qlsv = new QLSINHVIEN_PTPM_AIDataContext();
        public DB_Lop() { }

        public IQueryable loadLop()
        {
            return qlsv.Lops.Join(qlsv.Khoas, l => l.MaKhoa, kh => kh.MaKhoa, (l, kh) => new { l.MaLop, l.TenLop, kh.TenKhoa });
        }

        public IQueryable loadLopByMaKhoa(string pMaKhoa)
        {
            return qlsv.Lops.Where(l => l.MaKhoa == pMaKhoa);
        }

        public bool addLop(Lop pLop)
        {
            try
            {
                qlsv.Lops.InsertOnSubmit(pLop);
                qlsv.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool checkPrimaryKey(string pMaLop)
        {
            Lop lop = qlsv.Lops.Where(l => l.MaLop == pMaLop).FirstOrDefault();
            if(lop != null)
            {
                return true;
            }
            return false;
        }

        public bool updateLop(Lop pLop)
        {
            Lop lop = qlsv.Lops.Where(l => l.MaLop == pLop.MaLop).FirstOrDefault();
            if (lop != null)
            {
                lop.TenLop = pLop.TenLop;
                lop.MaKhoa = pLop.MaKhoa;
                qlsv.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool deleteLop(string pMaLop)
        {
            Lop lop = qlsv.Lops.Where(l => l.MaLop == pMaLop).FirstOrDefault();
            if (lop != null)
            {
                qlsv.Lops.DeleteOnSubmit(lop);
                qlsv.SubmitChanges();
                return true;
            }
            return false;
        }

    }
}
