using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TojasManufaktura
{
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; private set; }
        public FrmMain()
        {
            ConnectionString =
               @"Server = (localdb)\MSSQLLocalDB;" +
                "Database = TojasGyar;";
            InitializeComponent();
        }

        private void BtnKilepes_Click(object sender, EventArgs e)
            => this.Close();

        private void BtnTermeles_Click(object sender, EventArgs e)
            => new FrmTermeles(ConnectionString).ShowDialog();
    }
}
