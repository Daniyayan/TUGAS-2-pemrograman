using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204016
{
    public class istri : Teman
    {
        protected string kemampuan;

        public istri(string jenis, string kemampuan) : base(jenis, kemampuan)
        {


            this.Jenis = jenis;
            this.Nama = "mia khalifa";
            this.kemampuan = kemampuan;
        }

        public string Kemampuan
        {
            get
            {
                return kemampuan;
            }
            set
            {
                kemampuan = value;
            }
        }
    }
}
