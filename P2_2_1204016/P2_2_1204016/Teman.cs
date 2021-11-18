using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204016
{
    public class Teman
    {
        private String nama;
        private String jenis;

        public Teman(String nama, String jenis)
        {

            this.nama = nama;
            this.jenis = jenis;

        }

        public String Jenis
        {
            get
            {
                return jenis;
            }
            set
            {
                jenis = value;
            }
        }
        public String Nama
        {
            get
            {
                return nama;
            }
            set
            {
                nama = value;
            }
        }


    }
}
