using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Programming_Project_Assignment
{
    public partial class DünyaSiralamasi : Form
    {
        public DünyaSiralamasi()
        {
            InitializeComponent();
            Listele();
        }
        private void Listele()
        {
            string sql = "SELECT Username, Score FROM Bilgiler ORDER BY Score DESC";
            dataGridView1.DataSource = CRUD.Listele(sql);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }
    }
}