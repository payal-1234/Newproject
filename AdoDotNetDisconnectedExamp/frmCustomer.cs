using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoDotNetDisconnectedExamp
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlDataAdapter da;
        DataSet ds;
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayConnector"].ConnectionString);
            //con.Open();
            da = new MySqlDataAdapter("select * from InfowayCustomer",con);
            ds = new DataSet();
            da.Fill(ds, "Customers");
            dgvCustomer.DataSource = ds.Tables[0];

        }
    }
}
