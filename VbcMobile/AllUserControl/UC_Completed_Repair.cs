using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace VbcMobile.AllUserControl
{
    public partial class UC_Completed_Repair : UserControl
    {
        function fn = new function();
        String query;
        public UC_Completed_Repair()
        {
            InitializeComponent();
        }

        private void UC_Completed_Repair_Enter(object sender, EventArgs e)
        {
            query = "select * from repair";
            DataSet ds = fn.GetData(query);
            RpdGrid.DataSource = ds.Tables[0];

        }
        int bid;
        private void RpdGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RpdGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(RpdGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            query = "select * from repair where mid = "+bid+"";
            DataSet ds =fn.GetData(query);

            lblBrand.Text = ds.Tables[0].Rows[0][1].ToString();
            lblModName.Text = ds.Tables[0].Rows[0][2].ToString();
            lblModNum.Text = ds.Tables[0].Rows[0][3].ToString();
            lblCname.Text = ds.Tables[0].Rows[0][5].ToString();
            lblPhone.Text = ds.Tables[0].Rows[0][6].ToString();
            lblPrice.Text = ds.Tables[0].Rows[0][8].ToString();
            lblNote.Text = ds.Tables[0].Rows[0][4].ToString();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( lblNote.Text != "")
            {

                String brand1 = lblBrand.Text;
                String brand2 = lblModName.Text;
                String brand3 = lblModNum.Text;
                String brand4 = lblCname.Text;
                Int64 brand5 = Int64.Parse(lblPhone.Text);
                String brand6 = lblNote.Text;
                Int64 brand7 = Int64.Parse(lblPrice.Text);
                String sdate = DateTime.Now.ToString("yyyyMMdd");
                String optime = DateTime.Now.ToString("hh:mm:ss");

                query = "insert into completed_rep (brand1,mname1,mnum1,cname1,cpnum1,note1,price1,comdate,comtime) values('" + brand1 + "','" + brand2 + "','" + brand3 + "','" + brand4 + "','" + brand5 + "','" + brand6 + "','" + brand7 + "','" + sdate + "','" + optime + "')";
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("Please Fill All Data ","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
