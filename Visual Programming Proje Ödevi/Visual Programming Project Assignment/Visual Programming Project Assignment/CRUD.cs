using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Programming_Project_Assignment
{
    public class CRUD
    {
        public static DataTable Listele(string sql)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = Baglan.GetConnection())
            {
                conn.Open();
                SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql, conn);
                adtr.Fill(dt);
            }
            return dt;
        }
        public static bool ESG(string sql)
        {
            int dogrula = 0;
            using (SQLiteConnection conn = Baglan.GetConnection())
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                dogrula = command.ExecuteNonQuery();
            }
            return dogrula > 0;
        }
        public static bool KullaniciDogrula(string username, string password)
        {
            bool result = false;
            using (SQLiteConnection conn = Baglan.GetConnection())
            {
                conn.Open();
                string sql = "SELECT COUNT(1) FROM Bilgiler WHERE Username = @Username AND Password = @Password";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    result = count > 0;
                }
            }
            return result;
        }
        public static void SkorGuncelle(string username, int newScore)
        {
            int mevcutSkor = MevcutSkor(username);
            if (newScore > mevcutSkor)
            {
                using (SQLiteConnection conn = Baglan.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE Bilgiler SET Score = @Score WHERE Username = @Username";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Score", newScore);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        public static int MevcutSkor(string username)
        {
            int mevcutSkor = 0;
            using (SQLiteConnection conn = Baglan.GetConnection())
            {
                conn.Open();
                string sql = "SELECT Score FROM Bilgiler WHERE Username = @Username";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    mevcutSkor = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return mevcutSkor;
        }
    }
}
