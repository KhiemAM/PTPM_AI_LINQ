using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_LinQ
{
    public class DB_SinhVien
    {
        QLSINHVIENDataContext qlsv = new QLSINHVIENDataContext();
        public DB_SinhVien()
        {

        }

        public IQueryable<object> loadSinhVien()
        {
            var sinhviens = from sv in qlsv.SinhViens select new { sv.MaSinhVien, sv.HoTen };
            return sinhviens;
        }

        public IQueryable<SinhVien> getFirstSinhVien()
        {
            var sinhvien = (from sv in qlsv.SinhViens select sv).Skip(0).Take(1);
            return sinhvien;
        }

        public IQueryable<SinhVien> getEndSinhVien()
        {
            var sinhvien = (from sv in qlsv.SinhViens select sv).OrderByDescending(sv => sv.MaSinhVien).Skip(0).Take(1);
            return sinhvien;
        }

        public IQueryable<SinhVien> getSinhVien2And3()
        {
            var sinhvien = (from sv in qlsv.SinhViens select sv).Skip(1).Take(2);
            return sinhvien;
        }

        public IQueryable<SinhVien> sapXepGiamDanTheoTen()
        {
            var sinhvien = (from sv in qlsv.SinhViens select sv).OrderByDescending(sv => sv.HoTen);
            return sinhvien;
        }

        public IQueryable<object> getSinhVienLop()
        {
            var sinhviens = qlsv.SinhViens.Join(qlsv.Lops, sv => sv.MaLop, l => l.MaLop, (sv, l) => new { sv.MaSinhVien, sv.HoTen, l.TenLop });
            return sinhviens;

        }

        public IQueryable<object> sumDiemMonHoc()
        {
            var sinhviens = qlsv.Diems.GroupBy(d => d.MaSinhVien).Select(kq => new { Masv = kq.Key, TongDiem = kq.Sum(s => s.Diem1) }).Join(qlsv.SinhViens, kq => kq.Masv, sv => sv.MaSinhVien, (kq, sv) => new { sv.MaSinhVien, sv.HoTen, kq.TongDiem});
            return sinhviens;
        }
    }
}
