using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoDotNetDisconnectedExamp
{
    public partial class frmDropDownList : Form
    {
        public frmDropDownList()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlDataAdapter da;
        DataSet ds;

        private void frmDropDownList_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayConnector"].ConnectionString);
            //con.Open();
            da = new MySqlDataAdapter("select * from InfowayCustomer;select * from InfowayOrders;", con);
            ds = new DataSet();
            da.Fill(ds);
            cbbox.DataSource = ds.Tables[0];
            cbbox.DisplayMember = "CustomerName";

            cbbox.ValueMember = "CustomerId";
            cbbox.SelectedIndexChanged += Cbbox_SelectedIndexChanged;
        }

        private void Cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataView = ds.Tables[1].DefaultView;
            dataView.RowFilter = "CustomerId=" + cbbox.SelectedValue;
            dgvDropDown.DataSource = dataView;
        }
    }
}
