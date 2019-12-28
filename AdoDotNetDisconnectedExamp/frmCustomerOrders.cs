using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoDotNetDisconnectedExamp
{
    public partial class frmCustomerOrders : Form
    {
        public frmCustomerOrders()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlDataAdapter da;
        DataSet ds;
        private void frmCustomerOrders_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayConnector"].ConnectionString);
            //con.Open();
            da = new MySqlDataAdapter("select * from InfowayCustomer;select * from InfowayOrders;", con);
            ds = new DataSet();
            da.Fill(ds);
            lstCustomer.DataSource = ds.Tables[0];
            lstCustomer.DisplayMember = "CustomerName";
            lstCustomer.ValueMember = "CustomerId";
            lstCustomer.SelectedIndexChanged += LstCustomer_SelectedIndexChanged;

        }

        private void LstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataView = ds.Tables[1].DefaultView;
            dataView.RowFilter = "CustomerId=" + lstCustomer.SelectedValue;
            dgvCustomerOrder.DataSource = dataView;
        }
    }
}
