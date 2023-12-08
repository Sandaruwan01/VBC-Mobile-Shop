using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VbcMobile.AllUserControl
{
    public partial class UC_Reports2 : UserControl
    {
        function fn = new function();
        String query;
        public UC_Reports2()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "All")
            {
                query = " select item,brand,modle,modnum,price, count(*) as QTy from sold  where sdate between '" + dtFrom3.Value+"' and '"+dtTo3.Value+ "' group by item,brand,modle,modnum,price order by QTy desc ";
                DataSet ds = fn.GetData(query);
                ReportDG.DataSource = ds.Tables[0];

            }
            else if (comboBox1.Text == "Back Cover")
            {
                query = " select item,brand,modle,modnum,price, count(*) as QTy from sold  where sdate between '" + dtFrom3.Value + "' and '" + dtTo3.Value + "' and item = 'Back Cover' group by item,brand,modle,modnum,price order by QTy desc ";
                DataSet ds = fn.GetData(query);
                ReportDG.DataSource = ds.Tables[0];

            }
            else if (comboBox1.Text == "Charger")
            {
                query = " select item,brand,modle,modnum,price, count(*) as QTy from sold  where sdate between '" + dtFrom3.Value + "' and '" + dtTo3.Value + "' and item = 'Charger' group by item,brand,modle,modnum,price order by QTy desc ";
                DataSet ds = fn.GetData(query);
                ReportDG.DataSource = ds.Tables[0];

            }
            else if (comboBox1.Text == "Head Set")
            {
                query = " select item,brand,modle,modnum,price, count(*) as QTy from sold  where sdate between '" + dtFrom3.Value + "' and '" + dtTo3.Value + "' and item = 'Head Set' group by item,brand,modle,modnum,price order by QTy desc ";
                DataSet ds = fn.GetData(query);
                ReportDG.DataSource = ds.Tables[0];

            }
            else if (comboBox1.Text == "New Phone")
            {
                query = " select item,brand,modle,modnum,price, count(*) as QTy from sold  where sdate between '" + dtFrom3.Value + "' and '" + dtTo3.Value + "' and item = 'New Phone' group by item,brand,modle,modnum,price order by QTy desc ";
                DataSet ds = fn.GetData(query);
                ReportDG.DataSource = ds.Tables[0];

            }
            else if (comboBox1.Text == "Power Bank")
            {
                query = " select item,brand,modle,modnum,price, count(*) as QTy from sold  where sdate between '" + dtFrom3.Value + "' and '" + dtTo3.Value + "' and item = 'Power Bank' group by item,brand,modle,modnum,price order by QTy desc ";
                DataSet ds = fn.GetData(query);
                ReportDG.DataSource = ds.Tables[0];

            }
            else if (comboBox1.Text == "Specker")
            {
                query = " select item,brand,modle,modnum,price, count(*) as QTy from sold  where sdate between '" + dtFrom3.Value + "' and '" + dtTo3.Value + "' and item = 'Specker' group by item,brand,modle,modnum,price order by QTy desc ";
                DataSet ds = fn.GetData(query);
                ReportDG.DataSource = ds.Tables[0];

            }
            else if (comboBox1.Text == "Other")
            {
                query = " select item,brand,modle,modnum,price, count(*) as QTy from sold  where sdate between '" + dtFrom3.Value + "' and '" + dtTo3.Value + "' and item = 'Other' group by item,brand,modle,modnum,price order by QTy desc ";
                DataSet ds = fn.GetData(query);
                ReportDG.DataSource = ds.Tables[0];

            }
            else if (comboBox1.Text == "Temperd Glass")
            {
                query = " select item,brand,modle,modnum,price, count(*) as QTy from sold  where sdate between '" + dtFrom3.Value + "' and '" + dtTo3.Value + "' and item = 'Temperd Glass' group by item,brand,modle,modnum,price order by QTy desc ";
                DataSet ds = fn.GetData(query);
                ReportDG.DataSource = ds.Tables[0];

            }

        }

        private void btnGo2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "All")
            {
                query = " select brand1,mname1,mnum1,note1,price1, count(*) as QTy from completed_rep  where comdate between '" + dtFrom4.Value + "' and '" + dtTo4.Value + "' group by brand1,mname1,mnum1,note1,price1 order by QTy desc ";
                DataSet ds = fn.GetData(query);
                ReportDG2.DataSource = ds.Tables[0];

            }
            


        }

        
       
    }

}
