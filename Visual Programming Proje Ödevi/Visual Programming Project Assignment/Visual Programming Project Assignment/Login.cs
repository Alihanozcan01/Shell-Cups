using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Visual_Programming_Project_Assignment
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
            if (OyunEkrani.grafikForm == null)
            {
                OyunEkrani.grafikForm = new Grafik();
            }
            LoadData();
            OyunEkrani.grafikForm.UpdateChart(bardak1Count, bardak2Count, bardak3Count); 
        }
        private int bardak1Count = 0;
        private int bardak2Count = 0;
        private int bardak3Count = 0;
        private void LoadData()
        {
            string filePath = Path.Combine(Application.StartupPath, "bardakCounts.txt");
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= 3)
                {
                    int.TryParse(lines[0], out bardak1Count);
                    int.TryParse(lines[1], out bardak2Count);
                    int.TryParse(lines[2], out bardak3Count);
                }
            }
        }
        private void istatistikler_Click(object sender, EventArgs e)
        {
            Grafik grafikForm = OyunEkrani.grafikForm; 
            this.Hide();
            grafikForm.ShowDialog();
            this.Show();
        }
        private void Logİn_Click(object sender, EventArgs e)
        {
            string username = textBoxKullaniciadi.Text;
            string password = textBoxParola.Text;

            if (CRUD.KullaniciDogrula(username, password))
            {
                OyunEkrani form2 = new OyunEkrani(username);
                this.Hide();
                form2.ShowDialog();
                this.Show();

                textBoxKullaniciadi.Text = string.Empty;
                textBoxParola.Text = string.Empty;

                string sql = "UPDATE Bilgiler SET LastLogin = @LastLogin WHERE Username = @Username";
                using (SQLiteConnection conn = Baglan.GetConnection())
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@LastLogin", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Username", username);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }
        private void SingUp_Click(object sender, EventArgs e)
        {
            KayitEkrani form3 = new KayitEkrani();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }
        private void dünyaSiralamasi_Click(object sender, EventArgs e)
        {
            DünyaSiralamasi form4 = new DünyaSiralamasi();
            this.Hide();
            form4.ShowDialog();
            this.Show();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

