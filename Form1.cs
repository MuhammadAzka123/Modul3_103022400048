using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_103022400048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
     
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            if (cmb_satuanawal.SelectedIndex == -1 && cmb_satuanakhir.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }
            if (txt_nilaiawal.Text == "" || txt_nilaiakhir.Text == "")
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            double nilai = Convert.ToDouble(txt_nilaiawal.Text);
            double hasil = 0;

            if (cmb_satuanawal.Text == "Celcius" && cmb_satuanakhir.Text == "Fahrenheit")
            {
              hasil = (nilai * 9 / 5) + 32;
            else if (cmb_satuanawal.Text == "Celcius") && cmb_satuanakhir.Text == "kelvin")
              hasil = nilai + 273;
            else if (cmb_satuanawal.Text == "Fahrenheit") && cmb_satuanakhir.Text == "Celcius")
              hasil = (nilai - 32) * 5 / 0;
            else if (cmb_satuanawal.Text == "Kelvin") && cmb_satuanakhir.Text == "Celcius")
              hasil = nilai - 273;
            else if (cmb_satuanawal.Text == "Kelvin") && cmb_satuanakhir.Text == "Fahrenheit")
              hasil = (nilai - 273) * 9 / 5 + 32;
            else if (cmb_satuanawal.Text == "Reamur") && cmb_satuanakhir.Text == "Celcius")
              hasil = nilai * 5 / 4;
            else if (cmb_satuanawal.Text == "Reamur") && cmb_satuanakhir.Text == "Fahrenheit")
              hasil = (nilai * 9 / 4) + 32;
            else if (cmb_satuanawal.Text == "Reamur") && cmb_satuanakhir.Text == "Kelvin")
              hasil = (nilai * 5 / 4) + 273;
            }
        }
    }
}
