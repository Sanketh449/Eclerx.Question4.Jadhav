using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Eclerx.Question4.Jadhav
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
        }


        public void ClearText()
        {
            TxtEmployeeId.Text = "";
            TxtEmployeeName.Clear();
            TxtSalary.Text = "";
            TxtEmployeeType.Text= "";
            TxtEmployeeId.Focus();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["Training"].ConnectionString);
            }

        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["Training"].ConnectionString))

            {
                using (cmd = new SqlCommand("usp_AddNewEmployee", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds = new DataSet();

                    adapter.Fill(ds, "Employee");
                    DataRow dr = ds.Tables["Employee"].NewRow();
                    dr["cEmployeeId"] = TxtEmployeeId.Text;
                    dr["vEmployeeName"] = TxtEmployeeName.Text;
                    dr["mSalary"] = TxtSalary.Text;
                    dr["vEmployeeType"] = TxtEmployeeType.Text;

                    ds.Tables["Employee"].Rows.Add(dr);
                    adapter.Update(ds, "Employee");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    GridEmployee.DataSource = dt;
                }
            
            }
        }

        private void TxtReset_Click(object sender, EventArgs e)
        {
            this.ClearText();
        }
    }
}
