using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace Visual_Programming_Project_Assignment
{
    public partial class OyunEkrani : Form
    {
        private string currentUser;
        private int bardak1Count = 0;
        private int bardak2Count = 0;
        private int bardak3Count = 0;
        private int count = 0;
        public static Grafik grafikForm;
        public OyunEkrani(string username)
        {
            InitializeComponent();
            currentUser = username;
            buttonPanel.SendToBack();
            bardak1.BringToFront();
            bardak2.BringToFront();
            bardak3.BringToFront();
            randomSec();
            if (grafikForm == null)
            {
                grafikForm = new Grafik();
            }
            LoadData(); 
            grafikForm.UpdateChart(bardak1Count, bardak2Count, bardak3Count); 
        }
        public void randomSec()
        {
            Ball1.Visible = true;
            Ball2.Visible = true;
            Ball3.Visible = true;
            bardak1.Visible = true;
            bardak2.Visible = true;
            bardak3.Visible = true;

            Random random = new Random();
            int sayi = random.Next(1, 4);
            if (sayi == 1)
            {
                Ball2.Visible = false;
                Ball3.Visible = false;
            }
            else if (sayi == 2)
            {
                Ball1.Visible = false;
                Ball3.Visible = false;
            }
            else if (sayi == 3)
            {
                Ball1.Visible = false;
                Ball2.Visible = false;
            }
        }
        private void bardak1_Click(object sender, EventArgs e)
        {
            bardak1.Visible = false;
            bardak2.Visible = false;
            bardak3.Visible = false;
            if (Ball1.Visible)
            {
                count++;
                labelPuan.Text = "Puanınız : " + count;
                CRUD.SkorGuncelle(currentUser, count);
                MessageBox.Show("Doğru bildiniz!");
            }
            else
            {
                count = 0;
                labelPuan.Text = "Puanınız : " + count;
                MessageBox.Show("Yanlış bildiniz!");
            }
            bardak1Count++;
            grafikForm.UpdateChart(bardak1Count, bardak2Count, bardak3Count);
            SaveData(); 
            randomSec();
        }
        private void bardak2_Click(object sender, EventArgs e)
        {
            bardak1.Visible = false;
            bardak2.Visible = false;
            bardak3.Visible = false;
            if (Ball2.Visible)
            {
                count++;
                labelPuan.Text = "Puanınız : " + count;
                CRUD.SkorGuncelle(currentUser, count);
                MessageBox.Show("Doğru bildiniz!");
            }
            else
            {
                count = 0;
                labelPuan.Text = "Puanınız : " + count;
                MessageBox.Show("Yanlış bildiniz!");
            }
            bardak2Count++;
            grafikForm.UpdateChart(bardak1Count, bardak2Count, bardak3Count);
            SaveData(); 
            randomSec();
        }
        private void bardak3_Click(object sender, EventArgs e)
        {
            bardak1.Visible = false;
            bardak2.Visible = false;
            bardak3.Visible = false;
            if (Ball3.Visible)
            {
                count++;
                labelPuan.Text = "Puanınız : " + count;
                CRUD.SkorGuncelle(currentUser, count);
                MessageBox.Show("Doğru bildiniz!");
            }
            else
            {
                count = 0;
                labelPuan.Text = "Puanınız : " + count;
                MessageBox.Show("Yanlış bildiniz!");
            }
            bardak3Count++;
            grafikForm.UpdateChart(bardak1Count, bardak2Count, bardak3Count);
            SaveData(); 
            randomSec();
        }
        private void SaveData()
        {
            string filePath = Path.Combine(Application.StartupPath, "bardakCounts.txt");
            string[] lines = { bardak1Count.ToString(), bardak2Count.ToString(), bardak3Count.ToString() };
            File.WriteAllLines(filePath, lines);
        }
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
    }
}






