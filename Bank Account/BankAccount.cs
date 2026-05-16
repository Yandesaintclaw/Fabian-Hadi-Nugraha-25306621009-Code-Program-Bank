using System;

namespace BankApp
{
    public class BankAccount
    {
        // Tempat menyimpan saldo berjalan (saldo saat ini)
        private int saldo;

        // Struktur untuk menerima saldo awal 
        public BankAccount(int saldoAwal)
        {
            saldo = saldoAwal;
        }

        // Struktur untuk memunculkan informasi saldo terakhir
        public void TampilkanSaldo()
        {
            Console.WriteLine("[TechMart Bank] Total saldo Anda sekarang: Rp" + saldo);
        }

        // Logika if-else untuk validasi setor tunai
        public void Setor(int jumlah)
        {
            if (jumlah > 0)
            {
                saldo = saldo + jumlah;
                Console.WriteLine("[NOTIFIKASI] Mantap! Setor tunai sebesar Rp" + jumlah + " berhasil diproses."); // Notifikasi jika setor tunai berhasil
            }
            else
            {
                Console.WriteLine("[PERINGATAN SISTEM] Transaksi ditolak! Angka " + jumlah + " tidak masuk akal untuk setor tunai."); // Notifikasi jika transaksi gagal
            }
        }

        // Struktur untuk mengatur pilihan tarik tunai
        public void TarikTunai(int jumlah) // Struktur penyimpan untuk program tarik tunai
        {
            if (jumlah > 0 && jumlah <= saldo) // Angka harus lebih dari 0 dan tidak boleh kurang dari 0
            {
                saldo = saldo - jumlah; // jumlah saldo dikurang dengan saldo tarik tunai
                Console.WriteLine("[NOTIFIKASI] Sukses! Uang tunai Rp" + jumlah + " telah dikeluarkan."); // Notifikasi penarikan tunai berhasil
            }
            else
            {
                Console.WriteLine("[PERINGATAN SISTEM] Transaksi gagal! Saldo TechMart Anda tidak cukup atau input salah."); 
                // Notifikasi jika saldo kurang untuk tarik tunai atau penarikan melebihi saldo atau input angka kurang dari 0
            }
        }
    }
}