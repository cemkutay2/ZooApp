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
    public partial class AddAnimalForm: Form
    {
        string connectionString = "Server=localhost;Database=ZooDB;Trusted_Connection=True;";
        public AddAnimalForm()
        {
            InitializeComponent();
        }

        private void AddAnimalForm_Load(object sender, EventArgs e)
        {
            cmbBox_Health.SelectedIndex = 0;
        }

        private void btn_SaveAnimal_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Animals (Name, Species, BirthDate, Habitat, HealthStatus) VALUES (@name, @species, @birthdate, @habitat, @health)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtBox_AnimalName.Text);
                    cmd.Parameters.AddWithValue("@species", txtBox_Species.Text);
                    cmd.Parameters.AddWithValue("@birthdate", dtp_BirthDate.Value);
                    cmd.Parameters.AddWithValue("@habitat", txtBox_Habitat.Text);
                    cmd.Parameters.AddWithValue("@health", cmbBox_Health.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yeni hayvan başarıyla eklendi.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
