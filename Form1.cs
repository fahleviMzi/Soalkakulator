using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belajarkalulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // menampilkan hasil dari fungis terbilang ke textbox 2 berdasarkan angka dari textbox 1
            if (txt1.Text == "" || txt2.Text == "")
            {
                MessageBox.Show("Textbox Masih Ada Yang kosong", "Hati - Hati", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt1.Focus();
            }
            else
            {
                int a, b, c;

                a = int.Parse(this.txt1.Text);
                b = int.Parse(this.txt2.Text);
                c = a + b;
                this.hasil.Text = Convert.ToString(c);
                bilang.Text = this.terbilang(Convert.ToInt32(c)).TrimStart();
            }
        }
        private string terbilang(int angka)
        {
            string strterbilang = "";
            // membuat array untuk mengubah 1 - 11 menjadi terbilang
            string[] a = { "", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas" };

             if(angka < 12)
            {
                strterbilang = " " + a[angka];
            }
            else if (angka < 20)
            {
                strterbilang = this.terbilang(angka - 10) + " Belas";
            }
            else if (angka < 100)
            {
                strterbilang = this.terbilang(angka / 10) + " Puluh" + this.terbilang(angka % 10);
            }
            else if (angka < 200)
            {
                strterbilang = " Seratus" + this.terbilang(angka - 100);
            }
            else if (angka < 1000)
            {
                strterbilang = this.terbilang(angka / 100) + " Ratus" + this.terbilang(angka % 100);
            }
            else if (angka < 2000)
            {
                strterbilang = " Seribu" + this.terbilang(angka - 1000);
            }
            else if (angka < 1000000)
            {
                strterbilang = this.terbilang(angka / 1000) + " Ribu" + this.terbilang(angka % 1000);
            }
            else if (angka < 1000000000)
            {
                strterbilang = this.terbilang(angka / 1000000) + " Juta" + this.terbilang(angka % 1000000);
            }

            // menghilangkan multiple space
            strterbilang = System.Text.RegularExpressions.Regex.Replace(strterbilang, @"^\s+|\s+$", " ");
            // mengembalikan hasil terbilang
            return strterbilang;
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                MessageBox.Show("Textbox Masih Ada Yang kosong", "Hati - Hati", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt1.Focus();
            }
            else
            {
                int a, b, c;

                a = int.Parse(this.txt1.Text);
                b = int.Parse(this.txt2.Text);
                c = a - b;
                this.hasil.Text = Convert.ToString(c);
                bilang.Text = this.terbilang(c).TrimStart();
            }
        }

        private void kali_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                MessageBox.Show("Textbox Masih Ada Yang kosong", "Hati - Hati", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt1.Focus();
            }
            else
            {
                int a, b, c;

                a = int.Parse(this.txt1.Text);
                b = int.Parse(this.txt2.Text);
                c = a * b;
                this.hasil.Text = Convert.ToString(c);
                bilang.Text = this.terbilang(Convert.ToInt32(c)).TrimStart();
            }
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                MessageBox.Show("Textbox Masih Ada Yang kosong", "Hati - Hati", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt1.Focus();
            }
            else
            {
                double a, b, c;
                decimal bagi;
                a = double.Parse(this.txt1.Text);
                b = double.Parse(this.txt2.Text);
                c = a / b;
                bagi = Convert.ToInt32(c);
                this.hasil.Text = Convert.ToString(c);
                bilang.Text = this.terbilang(Convert.ToInt32(c)).TrimStart();
            }
        }

        private void txtNis(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNis1(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) == false && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
