using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.BCDH.VinhLong.ViewModels
{
    public class ChartInputByMonth
    {
        public string maPhanMem { get; set; }
        public string fields { get; set; }
        public string values { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public string maDonVi { get; set; }
    }
}
