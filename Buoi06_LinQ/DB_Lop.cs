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
            return qlsv.Lops.Select(l => new {l.MaLop, l.TenLop, l.MaKhoa});
        }
    }
}
