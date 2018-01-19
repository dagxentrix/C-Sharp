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

namespace Trening_test
{
    public partial class formMain : Form
    {
        SqlConnection connection;
        string connectionString;


        public formMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Trening_test.Properties.Settings.TreningConnectionString"].ConnectionString;
            PopulateOvelser();
        }
        //Henter ut alle øvelsene
        private void PopulateOvelser()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from Øvelse", connection))
            {
                DataTable ovelseTable = new DataTable();
                adapter.Fill(ovelseTable);

                listOvelser.DisplayMember = "Navn";
                listOvelser.ValueMember = "Id";
                listOvelser.DataSource = ovelseTable;
            }
        }
        //Henter ut TreningData ut i fra hvilke øvelse som er valgt
        private void PopulateTreningData()
        {
            string query = "SELECT a.Vekt FROM TreningData a " +
                "INNER JOIN ØvelseTreningData b ON a.Id = b.TreningDataId " +
                "WHERE b.ØvelseId = @ØvelseId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ØvelseId", listOvelser.SelectedValue);
                DataTable treningDataTable = new DataTable();
                adapter.Fill(treningDataTable);

                listTreningData.DisplayMember = "Vekt";
                listTreningData.ValueMember = "Id";
                listTreningData.DataSource = treningDataTable;
            }
        }

        private void listOvelser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listOvelser.SelectedValue.ToString());
            PopulateTreningData();
        }

        private void listTreningData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Legg til TreningData, henter ut Id og får koblet det til valgt øvelse
        private void btnLeggTilData_Click(object sender, EventArgs e)
        {
            int treningID = 0;
            string query = "INSERT INTO TreningData VALUES(@TreningDataVekt, @TreningDataRep, @Dato)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@TreningDataVekt", txtVekt.Text);
                command.Parameters.AddWithValue("@TreningDataRep", txtVekt.Text);
                command.Parameters.AddWithValue("@Dato", dateTimePicker1.Value);
                command.ExecuteScalar();
                connection.Close();

                SqlCommand treningId = new SqlCommand("select max(id) from TreningData", connection);
                SqlDataReader reader;
                connection.Open();

                reader = treningId.ExecuteReader();

                while (reader.Read())
                {
                    treningID = (reader.GetInt32(0));
                }
                connection.Close();
            }
            query = "INSERT INTO ØvelseTreningData VALUES(@ØvelseId, @TreningDataId)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ØvelseId", listOvelser.SelectedValue);
                command.Parameters.AddWithValue("@TreningDataId", treningID);
                command.ExecuteScalar();
            }
            PopulateTreningData();
        }
    }
}
