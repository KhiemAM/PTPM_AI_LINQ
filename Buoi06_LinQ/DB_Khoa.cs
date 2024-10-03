using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_LinQ
{
    public class DB_Khoa
    {
        QLSINHVIEN_PTPM_AIDataContext qlsv = new QLSINHVIEN_PTPM_AIDataContext();
        public DB_Khoa() { }

        public IQueryable<Khoa> loadKhoa()
        {
            var khoas = qlsv.Khoas.Select(kh => kh);

            return khoas;
        }
    }
}
