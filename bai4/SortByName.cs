using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class SortByName : IComparer<Sinhvien>
    {
        public int Compare([AllowNull] Sinhvien x, [AllowNull] Sinhvien y)
        {
            return x.Hoten1.CompareTo(y.Hoten1);
        }
    }

}
