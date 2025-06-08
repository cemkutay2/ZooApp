using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class Form1: Form
    {
        string connectionString = "Server=localhost;Database=ZooDB;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAnimals();
            LoadVisitors();
        }

        private void LoadAnimals(string search = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Animals";
                if (!string.IsNullOrWhiteSpace(search))
                    query += " WHERE Name LIKE @search";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrWhiteSpace(search))
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Animals.DataSource = dt;
            }
        }

        private void LoadVisitors(string search = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Visitors";
                if (!string.IsNullOrWhiteSpace(search))
                    query += " WHERE FullName LIKE @search";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrWhiteSpace(search))
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Visitors.DataSource = dt;
            }
        }
        void LoadVisits(DateTime start, DateTime end)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                v.VisitID,
                vis.FullName AS VisitorName,
                v.VisitTime
            FROM Visits v
            INNER JOIN Visitors vis ON v.VisitorID = vis.VisitorID
            WHERE v.VisitTime BETWEEN @start AND @end
            ORDER BY v.VisitTime";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Visits.DataSource = dt;
            }
        }

        private void btn_AnimalSearch_Click(object sender, EventArgs e)
        {
            LoadAnimals(txtBox_Animal.Text.Trim());
        }

        private void btn_AnimalNewEntry_Click(object sender, EventArgs e)
        {
            AddAnimalForm addAnimalForm = new AddAnimalForm();
            addAnimalForm.ShowDialog();
            LoadAnimals();
        }

        private void btn_AnimalDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Animals.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seçilen hayvanı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = Convert.ToInt32(dataGridView_Animals.SelectedRows[0].Cells["AnimalID"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Animals WHERE AnimalID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    LoadAnimals();
                }
            }
        }

        private void btn_VisitorSearch_Click(object sender, EventArgs e)
        {
            LoadVisitors(txtBox_Visitor.Text.Trim());
        }

        private void btn_VisitorNewEntry_Click(object sender, EventArgs e)
        {
            new AddVisitorForm().ShowDialog();
            LoadVisitors();
        }

        private void btn_VisitorDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Visitors.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seçilen ziyaretçiyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                int id = Convert.ToInt32(dataGridView_Visitors.SelectedRows[0].Cells["VisitorID"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Visitors WHERE VisitorID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    LoadVisitors();
                }
            }
        }

        private void btn_SearchDates_Click(object sender, EventArgs e)
        {
            DateTime start = dtp_Start.Value.Date;
            DateTime end = dtp_End.Value.Date;
            LoadVisits(start, end);
        }
    }

}
