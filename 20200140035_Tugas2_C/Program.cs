using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _20200140035_Tugas2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-O9A7AIAD;database=Exercise_Bakery;Integrated Security = TRUE");
                con.Open();

                SqlCommand ll = new SqlCommand("insert into Pembeli (Id_pembeli, nama_pembeli, alamat_pembeli, noHP_pembeli) values ('1006','Lalapo','Padang','082250505010')"+
                    "insert into Pembeli (Id_pembeli, nama_pembeli, alamat_pembeli, noHP_pembeli) values ('1007', 'Finanda','Bengkulu','082250505020')", con);
                ll.ExecuteNonQuery();

                SqlCommand ll2 = new SqlCommand("insert into Cake (Kode_cake, nama_cake, harga_cake) values ('C1006E','Brownies','30000')" +
                    "insert into Cake (Kode_cake, nama_cake, harga_cake) values ('C1007E','Chiffon','50000')", con);
                ll2.ExecuteNonQuery();

                SqlCommand ll3 = new SqlCommand("insert into Penjual (Id_penjual, nama_penjual, alamat_penjual, noHP_penjual) values ('2025','Aqila','Wonosobo','082288228827')" +
                    "insert into Penjual (Id_penjual, nama_penjual, alamat_penjual, noHP_penjual) values ('2026','Naffisa','Pacitan','082288228828')", con);
                ll3.ExecuteNonQuery();

                SqlCommand ll4 = new SqlCommand("insert into Transaksi (Kode_transaksi, Id_penjual,nama_cake, jumlah_cake, tanggal_transaksi, total_harga) values ('123456789100006','2025','Dessert','2','2022-01-06','40000')"+
                    "insert into Transaksi (Kode_transaksi, Id_penjual,nama_cake, jumlah_cake, tanggal_transaksi, total_harga) values ('123456789100007','2026','Sponge','1','2022-01-07','40000')", con);
                ll4.ExecuteNonQuery();

                SqlCommand ll5 = new SqlCommand("insert into Pembelian (Id_pembeli, Kode_cake, quantity) values ('1006','C1006E','1')"+
                    "insert into Pembelian(Id_pembeli, Kode_cake, quantity) values('1007', 'C1007E', '1')", con) ;
                ll5.ExecuteNonQuery();

                SqlCommand ll6 = new SqlCommand("insert into Detail_Transaksi (Kode_cake, Kode_transaksi, jenis_transaksi) values ('C1006E','123456789100006','Cash')" +
                    "insert into Detail_Transaksi (Kode_cake, Kode_transaksi, jenis_transaksi) values ('C1007E','123456789100007','Cash')", con);
                ll6.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}