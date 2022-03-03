using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonversi
{
    class ProgramSuhu
    {
        /// <summary>
        /// Deklarasi
        /// </summary>
        double celcius, fahrenheit, reamur, kelvin;

        public void inputCelcius()
        {
            Console.WriteLine(" =========================================");
            Console.WriteLine(" |     Konversi Suhu : From Celcius      |");
            Console.WriteLine(" =========================================");

            Console.Write(" Masukkan suhu (Celcius) = "); 
            celcius = Convert.ToDouble(Console.ReadLine());
        }
        public void inputFahrenheit()
        {
            Console.WriteLine(" =========================================");
            Console.WriteLine(" |    Konversi Suhu : From Fahrenheit   |");
            Console.WriteLine(" =========================================");

            Console.Write(" Masukkan suhu (Fahrenheit) = "); 
            fahrenheit = Convert.ToDouble(Console.ReadLine());
        }
        public void inputReamur()
        {
            Console.WriteLine(" =========================================");
            Console.WriteLine(" |     Konversi Suhu : From Reamur     |");
            Console.WriteLine(" =========================================");

            Console.Write(" Masukkan suhu (Reamur) = "); 
            reamur = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Method Input Kelvin
        /// </summary>
        public void inputKelvin()
        {
            Console.WriteLine(" =========================================");
            Console.WriteLine(" |    Konversi Suhu : From Kelvin       |");
            Console.WriteLine(" =========================================");

            Console.Write(" Masukkan suhu (Kelvin) = "); 
            kelvin = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Method Operasi Aritmatika
        /// </summary>
        /// <param name="c"></param>
        public void konversiCelcius(double c)
        {
            fahrenheit = (c * 1.8) + 32;
            reamur = c * 0.8;
            kelvin = c + 273.15;
            Console.WriteLine("\n");
        }
        public void konversiFahrenheit(double f)
        {
            celcius = (f - 32) * 5 / 9;
            reamur = (f - 32) * 4 / 9;
            kelvin = (f - 32) * 5 / 9 + 273.15;
            Console.WriteLine("\n");
        }
        public void konversiReamur(double r)
        {
            celcius = r * 5 / 4;
            fahrenheit = r * 9 / 4 + 32;
            kelvin = r * 5 / 4 + 273;
            Console.WriteLine("\n");
        }
        public void konversiKelvin(double k)
        {
            celcius = k - 273.15;
            fahrenheit = (k - 273.15) * 9 / 5;
            reamur = (k - 273) * 4 / 5;
            Console.WriteLine("\n");
        }
        /// <summary>
        /// Method Untuk Menampilkan Hasil
        /// </summary>
        public void hasilCelcius()
        {
            Console.Clear();
            Console.WriteLine(" ========================================");
            Console.WriteLine(" |    Hasil Konversi Suhu From Celcius");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" | FAHRENHEIT  =  " + fahrenheit);
            Console.WriteLine(" | REAMUR      =  " + reamur);
            Console.WriteLine(" | KELVIN      =  " + kelvin);
            Console.WriteLine(" ========================================");
            Console.WriteLine("Terimakasih Telah Menggunakan Program Ini :)");
            Console.ReadKey();
            Console.Clear();
        }
        
        public void hasilFahrenheit()
        {
            Console.Clear();
            Console.WriteLine(" ========================================");
            Console.WriteLine(" |    Hasil Konversi Suhu From Fahrenheit");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" | CELCIUS  =  " + celcius);
            Console.WriteLine(" | REAMUR      =  " + reamur);
            Console.WriteLine(" | KELVIN      =  " + kelvin);
            Console.WriteLine(" ========================================");
            Console.WriteLine("Terimakasih Telah Menggunakan Program Ini :)");
            Console.ReadKey();
            Console.Clear();
        }

        public void hasilReamur()
        {
            Console.Clear();
            Console.WriteLine(" ========================================");
            Console.WriteLine(" |    Hasil Konversi Suhu From Reamur");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" | CELCIUS  =  " + celcius);
            Console.WriteLine(" | Fahrenheit      =  " + fahrenheit);
            Console.WriteLine(" | KELVIN      =  " + kelvin);
            Console.WriteLine(" ========================================");
            Console.WriteLine("Terimakasih Telah Menggunakan Program Ini :)");
            Console.ReadKey();
            Console.Clear();
        }

        public void hasilKelvin()
        {
            Console.Clear();
            Console.WriteLine(" ========================================");
            Console.WriteLine(" |    Hasil Konversi Suhu From Kelvin");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" | CELCIUS  =  " + celcius);
            Console.WriteLine(" | Fahrenheit      =  " + fahrenheit);
            Console.WriteLine(" | Reamur      =  " + reamur);
            Console.WriteLine(" ========================================");
            Console.WriteLine("Terimakasih Telah Menggunakan Program Ini :)");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Switch
        /// </summary>
        public void mainMenu()
        {
            ProgramSuhu ps = new ProgramSuhu();
            while (true)
            {
                Console.WriteLine("Menu Utama" +
                "\n[1] Konversi Celcius" +
                "\n[2] Konversi Fahrenheit" +
                "\n[3] Konversi Reamur"+
                "\n[4] Konversi Kelvin"+
                "\n[5] Keluar" );
                Console.Write("Pilihan : ");
                int pilihan = int.Parse(Console.ReadLine());
                switch (pilihan)
                {
                    case 1:
                        ps.inputCelcius();
                        ps.konversiCelcius(ps.celcius);
                        ps.hasilCelcius();
                        break;
                    case 2:
                        ps.inputFahrenheit();
                        ps.konversiFahrenheit(ps.fahrenheit);
                        ps.hasilFahrenheit();
                        break;
                    case 3:
                        ps.inputReamur();
                        ps.konversiReamur(ps.reamur);
                        ps.hasilReamur();
                        break;
                    case 4:
                        ps.inputKelvin();
                        ps.konversiKelvin(ps.kelvin);
                        ps.hasilKelvin();
                        break;
                    case 5:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Pilihan Tidak Terdaftar Silahkan Pilih Kembali");
                        break;
                }

            }
        }
        /// <summary>
        /// Memanggil Switch Pada Halaman Awal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ProgramSuhu ps = new ProgramSuhu();
            ps.mainMenu();
        }
    }
}
