using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204016
{
    public class Program
    {
        static void Main(string[] args)
        {


            istri istrih = new istri("TEMAN ", "ISTRI");

            Console.WriteLine("Nama  {0} dia adalah  {1} saya namun di kemudianhari dia menjadi \"{2}\" saya", istrih.Nama, istrih.Jenis, istrih.Kemampuan);
            Console.WriteLine();


        }
    }
}
