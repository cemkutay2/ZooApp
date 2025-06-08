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
    public partial class AddVisitorForm: Form
    {
        string connectionString = "Server=localhost;Database=ZooDB;Trusted_Connection=True;";
        public AddVisitorForm()
        {
            InitializeComponent();
        }

        private void AddVisitorForm_Load(object sender, EventArgs e)
        {
            cmbBox_TicketType.SelectedIndex = 0;
        }

        private void btn_SaveVisitor_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Visitors (FullName, VisitDate, TicketType) OUTPUT INSERTED.VisitorID VALUES (@name, @date, @ticket)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtBox_FullName.Text);
                    cmd.Parameters.AddWithValue("@date", dtp_VisitDate.Value);
                    cmd.Parameters.AddWithValue("@ticket", cmbBox_TicketType.SelectedItem.ToString());

                    int visitorID = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show("Yeni ziyaretçi başarıyla eklendi. Ziyaretçi ID: " + visitorID);

                    string queryVisits = "INSERT INTO Visits (VisitorID, VisitTime) VALUES (@visitorID, @visitTime)";
                    SqlCommand cmdVisits = new SqlCommand(queryVisits, conn);
                    cmdVisits.Parameters.AddWithValue("@visitorID", visitorID);
                    cmdVisits.Parameters.AddWithValue("@visitTime", DateTime.Now);

                    cmdVisits.ExecuteNonQuery();


                    MessageBox.Show("Ziyaretçi başarıyla eklendi.");
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
