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
            PopulateTreningData();
            hideData();
            hideOvelse();
            
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
            string query = "SELECT * FROM TreningData a " +
                "INNER JOIN ØvelseTreningData b ON a.Id = b.TreningDataId " +
                "WHERE b.ØvelseId = @ØvelseId " +
                "ORDER BY Vekt DESC";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ØvelseId", listOvelser.SelectedValue);
                DataTable treningDataTable = new DataTable();
                
                adapter.Fill(treningDataTable);

                treningDataTable.Columns.Add("Multi", typeof(string), "Vekt + ' kilo ' +Reps + ' reps' + ' ' +Person");
                listTreningData.DisplayMember = "Multi";
                listTreningData.ValueMember = "Id";
                listTreningData.DataSource = treningDataTable;
            }
        }
        private void btnSlettOvelse_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Øvelse WHERE id = @ØvelseId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ØvelseId", listOvelser.SelectedValue);
                DataTable treningDataTable = new DataTable();
                adapter.Fill(treningDataTable);
            }
            PopulateOvelser();
        }
        private void btnSlettData_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM ØvelseTreningData WHERE TreningDataId = @TreningDataId;" +
                "DELETE FROM TreningData WHERE id=@TreningDataId";
            //string query = "DELETE FROM TreningData WHERE id = @TreningDataId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@TreningDataId", listTreningData.SelectedValue);
                DataTable treningDataTable = new DataTable();
                adapter.Fill(treningDataTable);
            }
            PopulateTreningData();
        }
        private void listOvelser_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTreningData();
        }
        private void listTreningData_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listTreningData.SelectedValue.ToString());
        }
        private void btnNyOvelse_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Øvelse VALUES(@OvelseNavn)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@OvelseNavn", txtOvelseNavn.Text);
                command.ExecuteScalar();
                connection.Close();
            }
            PopulateOvelser();
        }
        //Legg til TreningData, henter ut Id og får koblet det til valgt øvelse
        private void btnLeggTilData_Click(object sender, EventArgs e)
        {
            int treningID = 0;
            string query = "INSERT INTO TreningData VALUES(@TreningDataVekt, @TreningDataRep, @Dato, @Person)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@TreningDataVekt", txtVekt.Text);
                command.Parameters.AddWithValue("@TreningDataRep", txtRep.Text);
                command.Parameters.AddWithValue("@Dato", DateTime.Today);
                command.Parameters.AddWithValue("@Person", txtPerson.Text);
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
        //Gjemmer labels, tekstbokser og knapper for å editere / legge til valg. 
        private void hideOvelse()
        {
            btnNyOvelse.Visible = false;
            txtOvelseNavn.Visible = false;           
            lblNavnOvelse.Visible = false;            
            btnSlettOvelse.Visible = false;
        }
        private void hideData()
        {
            txtRep.Visible = false;
            txtVekt.Visible = false;
            btnLeggTilData.Visible = false;
            lblRep.Visible = false;
            lblVekt.Visible = false;
            btnSlettData.Visible = false;
            lblPerson.Visible = false;
            txtPerson.Visible = false;
        }
        //Viser labels, tekstbokser og knapper for å editere / legge til valg. 
        private void showOvelse()
        {
            btnNyOvelse.Visible = true;
            txtOvelseNavn.Visible = true;
            lblNavnOvelse.Visible = true;
            btnSlettOvelse.Visible = true;
        }
        private void showData()
        {
            txtRep.Visible = true;
            txtVekt.Visible = true;
            //datePicker.Visible = true;
            //lblDato.Visible = true;
            btnLeggTilData.Visible = true;
            lblVekt.Visible = true;
            lblRep.Visible = true;  
            btnSlettData.Visible = true;
            lblPerson.Visible = true;
            //txtPerson.Visible = true;
        }
        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (btnNyOvelse.Visible == false)
            {
                showOvelse();
                btnShowHide.Text = "Skjul valg";
            }
            else
            {
                hideOvelse();
                btnShowHide.Text = "Vis valg";
            }
        }

        private void btnShowHideData_Click(object sender, EventArgs e)
        {
            if (btnLeggTilData.Visible == false)
            {
                showData();
                btnShowHideData.Text = "Skjul valg";
            }
            else
            {
                hideData();
                btnShowHideData.Text = "Vis valg";
            }

        }
        private void comboboxNavn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboboxNavn.SelectedIndex == 0)
            {
                txtPerson.Text = "Frida";
            }
            else if(comboboxNavn.SelectedIndex == 1)
            {
                txtPerson.Text = "Dag";
            }
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
