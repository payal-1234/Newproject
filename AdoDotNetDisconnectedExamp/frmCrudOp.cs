using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Text;

using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoDotNetDisconnectedExamp
{
    public partial class frmCrudOp : Form
    {
        public frmCrudOp()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlDataAdapter da;
        DataSet ds;
        MySqlCommand cmd1;
        MySqlCommandBuilder cmd;
        int currentIndex = 0;
        private void frmCrudOp_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayConnector"].ConnectionString);
            //con.Open();
            da = new MySqlDataAdapter("select * from InfowayCustomer;", con);
            cmd = new MySqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            Navigation(currentIndex);
        }

        public void Navigation(int index)
        {
            if(ds.Tables[0].Rows.Count>0)
            {
                txtCustId.Text = ds.Tables[0].Rows[index].ItemArray[0].ToString();
                txtCustName.Text = ds.Tables[0].Rows[index].ItemArray[1].ToString();
                txtCity.Text = ds.Tables[0].Rows[index].ItemArray[2].ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentIndex<ds.Tables[0].Rows.Count-1)
            {
                currentIndex++;
                Navigation(currentIndex);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentIndex = ds.Tables[0].Rows.Count - 1;
            Navigation(currentIndex);
        }

        private void btnFitst_Click(object sender, EventArgs e)
        {

            currentIndex = 0;
            Navigation(currentIndex);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex >0)
            {
                currentIndex--;
                Navigation(currentIndex);
            }
        }

        private void NewData_Click(object sender, EventArgs e)
        {
            txtCustId.Text = string.Empty;
            txtCustName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCustId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow dataRow = ds.Tables[0].NewRow();
            dataRow[0] = txtCustId.Text;
            dataRow[1] = txtCustName.Text;
            dataRow[2] = txtCity.Text;
            ds.Tables[0].Rows.Add(dataRow);
            da.Update(ds.Tables[0] );

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].Rows[currentIndex];
            row[1] = txtCustName.Text;
            row[2] = txtCity.Text;
            da.Update(ds.Tables[0]);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0)
            {
                /* cmd1 = new MySqlCommand("delete from InfowayCustomer where CustomerId=@id", con);
                con.Open();

                 cmd1.Parameters.AddWithValue("@id", currentIndex);
                cmd1.ExecuteNonQuery();
                con.Close();
                da = new MySqlDataAdapter("select * from InfowayCustomer;", con);
                cmd = new MySqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                currentIndex = 0;
                Navigation(currentIndex);*/


                ds.Tables[0].Rows[currentIndex].Delete();
                da.Update(ds.Tables[0]);


                MessageBox.Show("Record Deleted Successfully!");
            
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }
    }
}
