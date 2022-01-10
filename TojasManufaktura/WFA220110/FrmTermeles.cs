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

namespace TojasManufaktura
{
    public partial class FrmTerm : Form
    {
        public string ConnectionString { get; private set; }
        public FrmTerm(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void FrmTermeles_Load(object sender, EventArgs e)
        {
            FillDGV();
            FillCB();
        }

        private void FillDGV()
        {
            //dgv.Rows.Clear();
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand(
                    "SELECT Termeles.Datum, Tojas.Szin, Termeles.Mennyiseg, Nyul.Nev " +
                    "FROM Termeles, Tojas, Nyul " +
                    "WHERE Termeles.TipusId = Tojas.Id " +
                    "AND Termeles.NyulId = Nyul.Id " +
                    "ORDER BY Termeles.Datum;", conn)
                    .ExecuteReader();
                while (r.Read())
                {
                    dgv.Rows.Add(
                        r.GetDateTime(0).ToString("yyyy-MM-dd"),
                        r[1],
                        r[2] + " db",
                        r[3]);
                }

                conn.Close();
            }
        }
        private void FillCB()
        {
            //cbEgg.Items.Clear();
            //cbWorker.Items.Clear();
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand(
                    "SELECT Szin FROM Tojas;", conn)
                    .ExecuteReader();
                while (r.Read()) cbEgg.Items.Add(r[0]);
                r.Close();
                r = new SqlCommand(
                    "SELECT Nev FROM Nyul;", conn)
                    .ExecuteReader();
                while (r.Read()) cbWorker.Items.Add(r[0]);
                conn.Close();
            }
        }

        private void BtnUjbejegyzes_Click(object sender, EventArgs e)
        {
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string ID = $"{cbEgg.SelectedIndex + 1}";
            string workID = $"{cbWorker.SelectedIndex + 1}";
            string amount = $"{nudAmount.Value}";

            string szin = cbEgg.Text;
            string munkas = cbWorker.Text;

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                try
                {
                    string errorMsg = "";
                    if (string.IsNullOrWhiteSpace(szin))
                        errorMsg += "A tojás színe nem maradhat üresen!\n";
                    if (string.IsNullOrWhiteSpace(munkas))
                        errorMsg += "A munkás neve nem maradhat üresen!\n";
                    if (int.Parse(amount) == 0)
                        errorMsg += "A mennyiség nem lehet nulla!\n";
                    if (!string.IsNullOrEmpty(errorMsg))
                        throw new Exception(errorMsg);
                    
                    new SqlCommand(
                        "INSERT INTO Termeles VALUES" +
                        $"('{date}', {ID}, {workID}, {amount});", connection)
                        .ExecuteReader();
                    MessageBox.Show("A bejegyzés sikeresen fel lett véve!");
                    FillDGV();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }
    }
}
