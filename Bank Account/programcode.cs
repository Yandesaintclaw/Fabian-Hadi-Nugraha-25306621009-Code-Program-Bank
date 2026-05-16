using System;
using BankApp; // Menghubungkan ke namespace sebelah biar class BankAccount terbaca

namespace BankApp
{
    class Program // Struktur class untuk menyipan program
    {
        // Menyimpan saldo dari terakhir transaksi
        private BankAccount userAccount = new BankAccount(1000);

        static void Main(string[] args) // Struktur pintu utama dari program
        {
            // Membuat objek dari Program sendiri untuk mancing metode non-static di bawah
            Program aplikasi = new Program();
            
            Console.WriteLine("=== SELAMAT DATANG DI APLIKASI TECHMART BANK ===");
            
            // Panggil fungsi menu untuk pertama kali
            aplikasi.TampilkanMenuUtama();
        }

        // Struktur void untuk menu utama
        public void TampilkanMenuUtama()
        {
            Console.WriteLine("\n=== MENU UTAMA ==="); // Judul menu utama
            Console.WriteLine("1. Jalankan Setor Tunai"); // pilihan menu 1
            Console.WriteLine("2. Jalankan Tarik Tunai"); // pilihan menu 2
            Console.WriteLine("3. Uji Eksploitasi & Keluar Program"); // pilihan menu 3
            Console.Write("Pilih Menu (1-3): ");

            // Menangkap pilihan menu utama yang dipilih user
            string? pilihan = Console.ReadLine(); // Variabel string menggunakan simbol "?" agar bisa terisi dengan null / kosong

            // Struktur switchcase untuk mengatur pilihan user
            switch (pilihan)
            {
                case "1":
                    Console.WriteLine("\n--- PROSES SETOR TUNAI ---"); // judul pilihan 1
                    Console.Write("Masukkan nominal uang yang ingin disetor: "); // Tulisan untuk memasukkan nominal uang setor
                    int nominalSetor = Convert.ToInt32(Console.ReadLine()); // Struktur untuk menangkap nilai yang diinput user
                    
                    userAccount.Setor(nominalSetor); // Memanggil fungsi setor dan saldo utama otomatis menambah
                    userAccount.TampilkanSaldo();    // Menampilan saldo terbarunya
                    
                    TampilkanMenuUtama(); // Struktur agar menu berulang tanpa reset saldo
                    break;

                case "2":
                    Console.WriteLine("\n--- PROSES TARIK TUNAI ---"); // Judul pilihan 2
                    Console.Write("Masukkan nominal uang yang ingin ditarik: "); // Tulisan untuk nominal uang yang ingin ditarik
                    int nominalTarik = Convert.ToInt32(Console.ReadLine()); // Struktur untuk menangkap nominal angka yang diinput user
                    
                    userAccount.TarikTunai(nominalTarik); // Memanggil fungsi tarik dan saldo utama otomatis berkurang
                    userAccount.TampilkanSaldo();        // Menampilkan saldo terbarunya
                    
                    TampilkanMenuUtama(); // Memanggil dirinya sendiri biar menu muter lagi tanpa reset saldo
                    break;

                case "3":
                    Console.WriteLine("\n--- SIMULASI UJI KEAMANAN (EKSPLOITASI) ---"); // Judul pilihan 3
                    Console.Write("Masukkan angka minus berapapun untuk menguji sistem: "); // Tulisan untuk memasukkan angka minus
                    int angkaMinusBerapapun = Convert.ToInt32(Console.ReadLine()); // Struktur untuk menangkap angka negatif yang diinput user / penyerang
                    
                    userAccount.Setor(angkaMinusBerapapun); // Struktur untuk otomatis menolak pilihan di file sebelah
                    
                    Console.WriteLine("\n--- KESIMPULAN EVALUASI AKHIR ---");
                    userAccount.TampilkanSaldo(); // Menunjukan saldo akhir aman dan tidak berkurang
                    Console.WriteLine("[Hasil] Brankas TechMart terbukti aman dari serangan input."); // Tampilan hasil
                    Console.WriteLine("\n[Status] Program Berhasil Dihentikan."); // Menampilkan tulisan bahwa program telah dihentikan
                    // Program berhenti
                    break;

                default:
                    Console.WriteLine("\n[Error] Opsi salah! Ga ada di menu. Silakan coba lagi.");
                    TampilkanMenuUtama(); // Mengulang kembali jika salah ketik menu
                    break;
            }
        }
    }
}