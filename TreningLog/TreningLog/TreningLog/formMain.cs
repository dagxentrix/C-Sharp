using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace TreningLog
{
    public partial class formMain : Form
    {
        SqlConnection connection;
        string connectionString;

        public formMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TreningLog.Properties.Settings.WorkoutConnectionString"].ConnectionString;
            populateOvelser();

        }
        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void populateOvelser()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Øvelser", connection))
            {
                DataTable ovelserTable = new DataTable();
                adapter.Fill(ovelserTable);
                listOvelser.DisplayMember = "Navn";
                listOvelser.ValueMember = "Id";

                listOvelser.DataSource = ovelserTable;
            }
        }

        private void populateLog()
        {
            string query =
           
            "SELECT a.Vekt FROM Log a" +
                "INNER JOIN ØvelserLog b ON a.Id = b.LogId" +
                "WHERE b.ØvelserId = @ØvelserId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ØvelserId", listOvelser.SelectedValue);

                DataTable logTable = new DataTable();
                adapter.Fill(logTable);

                listLog.DisplayMember = "Vekt";
                listLog.ValueMember = "Id";
                listLog.DataSource = logTable;
            }
        }

        private void listOvelser_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listOvelser.SelectedValue.ToString());
            populateLog();
        }

        private void btnLeggTilOvelse_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Øvelser VALUES(@ØvelserNavn, @Type)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ØvelserNavn", txtOvelse.Text);
                command.Parameters.AddWithValue("@Type", txtType.Text);
                command.ExecuteScalar();
            }

            populateOvelser();
        }
    }
}
