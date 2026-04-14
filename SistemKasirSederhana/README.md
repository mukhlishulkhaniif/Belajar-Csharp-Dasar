# PROJECT 03: SISTEM KASIR SEDERHANA

### 📝 Deskripsi
Program sederhana berbasis konsol untuk menghitung totab bayar dari barang yang di beli dan juga menghitung diskon yang di dapatkan.

---

### 💻Fitur Utama
* **Sistem pemilihan barang**: Memungkinkan user memilih barang berdasarkan nomor menu.
* **Sistem Diskon Otomatis**: Memberikan diskon 10% jika total belanja melebihi Rp50.000.
* **Counter Transaksi**: Mencatat berapa banyak transaksi sukses yang dilakukan dalam satu sesi.
* **Looping Transaksi**: Fitur untuk melakukan transaksi berulang kali tanpa harus merestart aplikasi.

---

### 💡Logika Penilaian
* **Validasi**: Menggunakan if (harga > 0) agar jika user salah input, program tidak error.
* **Seleksi**: menggunakan switch untuk menentukan harga dan if-else untuk menentukan diskon.
* **Perulangan**: Menggunakan while agar program terus berjalan selama user masih ingin melakukan transaksi.
* **Modular**: Perhitungan dipisah ke method luar agar Main programnya tidak kepanjangan.

---

### 🛠️Teknik C# yang Digunakan
* **Variabel**: int, double, bool
* **Input & Casting**: ReadLine, Convert
* **Methods**: Menggunakan static int hitung untuk meneerima Arguments (harga & jumlah) dan mengembalikan hasil kali.
* **String Manipulation**: .ToLower()
* 
---
*Latihan Dasar Pemrograman C#*
