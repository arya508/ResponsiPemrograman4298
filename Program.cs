using System;

namespace ResponsiPemrograman4298
{
    class Program
    {
        static void Main(string [] args)
        {
            Karyawan karyawan = new Karyawan();
            Console.Write("Nama : ");
            karyawan.Nama = Console.ReadLine();
            Console.Write("NIK : ");
            karyawan.NIK = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gaji : ");
            karyawan.Gaji = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("No  NIK\tNama\t\tGaji");
            Console.Write("1. {0}",karyawan.NIK);
            Console.Write("\t{0}",karyawan.Nama);
            Console.WriteLine("\t\t{0}",karyawan.Gaji);

            Console.WriteLine("Asyik naik gaji 10%");

            

            Console.WriteLine("No  NIK\tNama\t\tGaji");
            Console.Write("1. {0}",karyawan.NIK);
            Console.Write("\t{0}",karyawan.Nama);
            Console.Write("\t\t{0}",karyawan.KenaikanGaji(karyawan.Gaji));
            Console.ReadKey();
        }
    }
    
}
