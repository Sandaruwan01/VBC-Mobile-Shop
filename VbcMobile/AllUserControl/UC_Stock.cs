using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VbcMobile.AllUserControl
{
    public partial class UC_Stock : UserControl
    {
        function fn = new function();
        String query;
        
        public UC_Stock()
        {
            InitializeComponent();
        }

        private void UC_Stock_Enter(object sender, EventArgs e)
        {   

            query = "select *from addItem";
            DataSet ds = fn.GetData(query);
            DataArray.DataSource = ds.Tables[0];
        }
        int bid;
        private void DataArray_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DataArray.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(DataArray.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            query = "select * from addItem where mid = " + bid + "";
            DataSet ds = fn.GetData(query);

            lblItem.Text = ds.Tables[0].Rows[0][1].ToString();
            lblBrand.Text = ds.Tables[0].Rows[0][2].ToString();
            lblModName.Text = ds.Tables[0].Rows[0][3].ToString();
            lblModNum.Text = ds.Tables[0].Rows[0][4].ToString();
            lblqty.Text = ds.Tables[0].Rows[0][5].ToString();
            
            lblNote.Text = ds.Tables[0].Rows[0][6].ToString();

            // retrive the price from dataset
            String priceAsString = ds.Tables[0].Rows[0][7].ToString();
            //convert the string price to double
            if (double.TryParse(priceAsString, out double priceValue))
            {
                String formattedPrice = priceValue.ToString("N2");
                lblPrice.Text = formattedPrice;
            }

        }

        Boolean flag;

        private void txtSearchBy1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy1.SelectedIndex == 0)
            {
                flag = false;
                labelTOSET1.Text = "Enter Item";
            }
            else if (txtSearchBy1.SelectedIndex == 1)
            {
                flag = true;
                labelTOSET1.Text = "Enter Brand";
            }
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                query = "select* from addItem where iname like '" + txtSearch1.Text + "%'";
                DataSet ds = fn.GetData(query);
                DataArray.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select *from addItem where bname like '" + txtSearch1.Text + "%' ";
                DataSet ds = fn.GetData(query);
                DataArray.DataSource = ds.Tables[0];
            }
        }
    }
}
