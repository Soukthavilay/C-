using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapvenha
{
    class Access
    {
        public DateTime datetime { get; set; }
        public string TinhTrang { get; set; }

        public override string ToString()
        {
            return datetime.ToString("dd/MM/yyyy HH:mm:ss") +"\t"+ TinhTrang;
        }
    }
}
