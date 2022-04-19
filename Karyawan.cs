using System;

namespace ResponsiPemrograman4298
{
    class Karyawan
    {
        public string? Nama{get;set;}
        public int NIK{get;set;}
        public int Gaji{get;set;}

        public int KenaikanGaji(int gaji1)
        {
            int total_gaji=0;
            total_gaji = gaji1 + gaji1*(10/100);
            return total_gaji;
        }

    }
}