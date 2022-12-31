using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TelefonRehberim
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        void zaman()
        {
            dtpSaat.Value = DateTime.Now;
            dtpTarih.Value = DateTime.Now;
        }
        void temizle()
        {
            txtPassword.Text = string.Empty;
            txtPassword.Focus();
        }
        int hak = 3;

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
         zaman();   
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            SqlCommand giris = new SqlCommand("Select * From Giris where SIFRE=@p1", bgl.baglanti());
            giris.Parameters.AddWithValue("@p1", txtPassword.Text);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                Rehber rb = new Rehber();
                rb.Show();
                this.Hide();
            }
            else
            {
                hak--;
                if(hak == 0)
                {
                    MessageBox.Show("Telefon Kilitlendi");
                    btnGiris.Enabled = false;
                }
                MessageBox.Show("Hatalı Şifre. Tekrar Deneyiniz."," Kalan Deneme Hakkınız: " +hak);
                temizle();

            }
            bgl.baglanti().Close();
        }

    }
}
