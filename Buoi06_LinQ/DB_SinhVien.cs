using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_LinQ
{
    public class DB_SinhVien
    {
        QLSINHVIEN_PTPM_AIDataContext qlsv = new QLSINHVIEN_PTPM_AIDataContext();
        public DB_SinhVien()
        {

        }

        public IQueryable loadSinhVien()
        {
            return qlsv.SinhViens.Join(qlsv.Lops, sv => sv.MaLop, l => l.MaLop, (sv, l) => new { sv.MaSinhVien, sv.HoTen, sv.NgaySinh, l.TenLop });
        }

        public bool addSinhVien(SinhVien sv)
        {
            try
            {
                qlsv.SinhViens.InsertOnSubmit(sv);
                qlsv.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateSinhVien(SinhVien sv)
        {
            try
            {
                SinhVien sinhVien = qlsv.SinhViens.Where(s => s.MaSinhVien == sv.MaSinhVien).FirstOrDefault();
                sinhVien.HoTen = sv.HoTen;
                sinhVien.NgaySinh = sv.NgaySinh;
                sinhVien.MaLop = sv.MaLop;
                qlsv.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteSinhVien(string pMaSV)
        {
            try
            {
                SinhVien sinhVien = qlsv.SinhViens.Where(s => s.MaSinhVien == pMaSV).FirstOrDefault();
                qlsv.SinhViens.DeleteOnSubmit(sinhVien);
                qlsv.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
