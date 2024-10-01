using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_LinQ
{
    public class DB_MonHoc
    {
        QLSINHVIENDataContext qlsv = new QLSINHVIENDataContext();
        public DB_MonHoc()
        {

        }

        public IQueryable<MonHoc> loadMonhoc()
        {
            var monhocs = from mh in qlsv.MonHocs select mh;
            return monhocs;
        }

    }
}
