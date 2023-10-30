using Guna.UI2.AnimatorNS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VbcMobile.AllUserControl
{
    public partial class UC_Sold : UserControl
    {
        function fn = new function();
        String query;
        public UC_Sold()
        {
            InitializeComponent();
        }

        private void UC_Sold_Enter(object sender, EventArgs e)
        {
            query = "select * from sold";
            DataSet ds = fn.GetData(query);
            SoldDataGrid.DataSource = ds.Tables[0];

            query = "select * from completed_rep";
            DataSet ds1 = fn.GetData(query);
            SoldDataGrid2.DataSource = ds1.Tables[0];
        }
        Boolean flag;
        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSearchBy.SelectedIndex == 0)
            {
                flag = false;
                labelTOSET.Text = "Enter Customer Name";
            }
            else if(txtSearchBy.SelectedIndex == 1)
            {
                flag = true;
                labelTOSET.Text = "Enter Phone Number";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                query = "select* from sold where cusname like '"+txtSearch.Text+"%'";
                DataSet ds =fn.GetData(query);
                SoldDataGrid.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select *from sold where cuphone like '"+txtSearch.Text+"%' ";
                DataSet ds =fn.GetData(query);
                SoldDataGrid.DataSource = ds.Tables[0];
            }
        }
    }
    

    




}
