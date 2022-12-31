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
    public partial class Rehber : Form
    {
        public Rehber()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From KISILER", bgl.baglanti());
            da.Fill(dt);
            dgRehber.DataSource= dt;
            txtAD.Focus();
           
        }
        void temizle()
        {
            txtAD.Text = "";
            txtID.Text = "";
            txtMail.Text = "";
            txtSoyad.Text = "";
            mskTel.Text = "";
            txtResim.Text = "";
            txtAD.Focus();
        }
        private void Rehber_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telefonRehberimDataSet.KISILER' table. You can move, or remove it, as needed.
            //this.kISILERTableAdapter.Fill(this.telefonRehberimDataSet.KISILER);
            listele();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            btnShow.Visible=false;
            btnGeri.Visible=true;
            pnlAraclar.Visible = false;
            pnlAraclar.Width = 279;
            guna2Transition1.ShowSync(pnlAraclar);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {

            pnlAraclar.Visible=false;
            btnGeri.Visible=false;
            btnShow.Visible=true;
            pnlAraclar.Width = 88;
            guna2Transition1.ShowSync(pnlAraclar);
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            listele();
            temizle();
        }
        
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(txtAD.Text == "" || txtSoyad.Text == "" || mskTel.Text == "")
            {
                MessageBox.Show("Lütfen Bilgilerinizi Eksiksiz Giriniz");   
            }
            else
            {
                SqlCommand ekle = new SqlCommand("insert into KISILER  (AD,SOYAD,TELEFON,EMAIL,RESIM) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                ekle.Parameters.AddWithValue("@p1", txtAD.Text);
                ekle.Parameters.AddWithValue("@p2", txtSoyad.Text);
                ekle.Parameters.AddWithValue("@p3", mskTel.Text);
                ekle.Parameters.AddWithValue("@p4", txtMail.Text);
                ekle.Parameters.AddWithValue("@p5", txtResim.Text);
                ekle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show(" Kişi Ekleme İşlemi Başarılı");
                listele();
                temizle();
            }
            

        }

        private void dgRehber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgRehber.SelectedCells[0].RowIndex;
            txtID.Text = dgRehber.Rows[secilen].Cells[0].Value.ToString();
            txtAD.Text = dgRehber.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dgRehber.Rows[secilen].Cells[2].Value.ToString();
            mskTel.Text = dgRehber.Rows[secilen].Cells[3].Value.ToString();
            txtMail.Text= dgRehber.Rows[secilen].Cells[4].Value.ToString();
            txtResim.Text= dgRehber.Rows[secilen].Cells[5].Value.ToString();
             
            pbResim.ImageLocation = dgRehber.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var silmek = MessageBox.Show("Kişi Silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(silmek == DialogResult.Yes )
            {
                SqlCommand sil = new SqlCommand("Delete From KISILER where ID=" + txtID.Text, bgl.baglanti());
                sil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kişi Rehberinizden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi");
                listele();
                temizle();
            }
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncelle = MessageBox.Show("Kişi Güncellensin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(guncelle == DialogResult.Yes )
            {
                SqlCommand gncll = new SqlCommand("Update KISILER set AD=@P1,SOYAD=@P2,TELEFON=@P3,EMAIL=@P4,RESIM=@P5 where ID=@p6", bgl.baglanti());
                gncll.Parameters.AddWithValue("@P1", txtAD.Text);
                gncll.Parameters.AddWithValue("@P2", txtSoyad.Text);
                gncll.Parameters.AddWithValue("@P3", mskTel.Text);
                gncll.Parameters.AddWithValue("@P4", txtMail.Text);
                gncll.Parameters.AddWithValue("@P5", txtResim.Text);
                gncll.Parameters.AddWithValue("@P6", txtID.Text);
                gncll.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Güncelleme İptal Edildi");
            }
            
        }

        private void btnResimAktar_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pbResim.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }

        private void txtResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pbResim.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }
    }
}
