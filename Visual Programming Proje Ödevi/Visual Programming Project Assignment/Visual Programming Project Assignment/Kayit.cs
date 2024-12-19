using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Programming_Project_Assignment
{
    public partial class KayitEkrani : Form
    {
        int? id = null;
        public KayitEkrani(int? Id = null)
        {
            InitializeComponent();
            if (Id != null)
                this.id = Id;
        }
        private void KayitOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text)) 
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz.");
                return;
            }
            else if (id == null)
            {
                string sql = "INSERT INTO Bilgiler (Username, Password, Score) VALUES (@Username, @Password, 0)";
                using (SQLiteConnection conn = Baglan.GetConnection())
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                        cmd.Parameters.AddWithValue("@Score", 0);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ekleme işlemi başarıyla gerçekleşti.");
            }
            this.Close();
        }
    }
}

