﻿using Guna.UI2.AnimatorNS;
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

     
        private void btnGo_Click(object sender, EventArgs e)
        {
            
            
            if (combSelect.Text == "All")
            {
                query = "select * from sold";
                DataSet ds = fn.GetData(query);
                SoldDataGrid.DataSource = ds.Tables[0];

                query = "select sum(price) from sold";
                DataSet da1 = fn.GetData(query);
                
                if(da1.Tables.Count>0 && da1.Tables[0].Rows.Count>0)
                {
                    object sumValue = da1.Tables[0].Rows[0][0];
                    if(sumValue != DBNull.Value)
                    {
                        double sumAsDouble = Convert.ToDouble(sumValue);
                        lblTotal.Text= " LKr :  "+sumAsDouble.ToString("0,000.00");
                        
                    }
                    else
                    {
                        lblTotal.Text = "No Data Available";
                    }
                }
                else
                {
                    lblTotal.Text = "No Data Available";
                }

            }
            else if (combSelect.Text == "Period")
            {
                query = "select * from sold where sdate between '"+dtFrom.Value+"' and '"+dtTo.Value+"' ";
                DataSet ds = fn.GetData(query);
                SoldDataGrid.DataSource = ds.Tables[0];

                query = "select sum(price) from sold where sdate between '"+dtFrom.Value+"' and '"+dtTo.Value+"' ";
                DataSet da1 = fn.GetData(query);

                if (da1.Tables.Count > 0 && da1.Tables[0].Rows.Count > 0)
                {
                    object sumValue = da1.Tables[0].Rows[0][0];
                    if (sumValue != DBNull.Value)
                    {
                        double sumAsDouble = Convert.ToDouble(sumValue);
                        lblTotal.Text = " LKr :  " + sumAsDouble.ToString("0,000.00");

                    }
                    else
                    {
                        lblTotal.Text = "No Data Available";
                    }
                }
                else
                {
                    lblTotal.Text = "No Data Available";
                }
            }
            
            
           
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
           UC_Sold Lode
                = new UC_Sold();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            UC_Sold Lode = new UC_Sold();
        }

        private void combSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    

    




}
