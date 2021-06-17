using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4132021.DTO
{
    class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public DateTime NS { get; set; }
        public bool Gender { get; set; }
        public int ID_Lop { get; set;  }

        public static implicit operator SV(string v)
        {
            throw new NotImplementedException();
        }
    }
}
