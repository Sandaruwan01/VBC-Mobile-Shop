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
    public partial class UC_Reports : UserControl
    {
        function fn = new function();
        String query;

        public UC_Reports()
        {
            InitializeComponent();
        }

        private void btnGo2_Click(object sender, EventArgs e)
        {
            if (combSelect2.Text == "All")
            {
                query = "select distinct brand1,mname1,mnum1,cname1,cpnum1,note1,price1,comdate,comtime from completed_rep order by comdate desc";
                DataSet ds = fn.GetData(query);
                dgComplete.DataSource = ds.Tables[0];

                query = "select sum(price1) from completed_rep";
                DataSet da2 = fn.GetData(query);

                if (da2.Tables.Count > 0 && da2.Tables[0].Rows.Count > 0)
                {
                    object sumValue = da2.Tables[0].Rows[0][0];
                    if (sumValue != DBNull.Value)
                    {
                        double sumAsDouble = Convert.ToDouble(sumValue);
                        lblTotal2.Text = " LKr :  " + sumAsDouble.ToString("0,000.00");

                    }
                    else
                    {
                        lblTotal2.Text = "No Data Available";
                    }
                }
                else
                {
                    lblTotal2.Text = "No Data Available";
                }
            }
            else if (combSelect2.Text == "Period")
            {
                query = "select distinct brand1,mname1,mnum1,cname1,cpnum1,note1,price1,comdate,comtime from completed_rep where comdate between '" + dtFrom2.Value + "' and '" + dtTo2.Value + "' order by comdate desc ";
                DataSet ds = fn.GetData(query);
                dgComplete.DataSource = ds.Tables[0];

                query = "select sum(price1) from completed_rep where comdate between '" + dtFrom2.Value + "' and '" + dtTo2.Value + "' ";
                DataSet da3 = fn.GetData(query);

                if (da3.Tables.Count > 0 && da3.Tables[0].Rows.Count > 0)
                {
                    object sumValue = da3.Tables[0].Rows[0][0];
                    if (sumValue != DBNull.Value)
                    {
                        double sumAsDouble = Convert.ToDouble(sumValue);
                        lblTotal2.Text = " LKr :  " + sumAsDouble.ToString("0,000.00");

                    }
                    else
                    {
                        lblTotal2.Text = "No Data Available";
                    }
                }
                else
                {
                    lblTotal2.Text = "No Data Available";
                }
            }

        }
    }
}
