using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AdoDotNetDisconnectedExamp
{
    public partial class search : Form
    {
        MySqlConnection con;
        MySqlDataAdapter da;
        DataSet ds;
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {
           
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayConnector"].ConnectionString);
            //con.Open();
            string s = txtrollnumber.Text;
            string sql = "select * from employee where  id = " + s;
            da = new MySqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds, "Customers");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
