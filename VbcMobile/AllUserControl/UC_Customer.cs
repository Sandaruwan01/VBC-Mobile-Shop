using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VbcMobile.AllUserControl
{
    public partial class UC_Customer : UserControl
    {
        function fn = new function();
        String query;
        public UC_Customer()
        {
            InitializeComponent();
        }

       

        //******************REQUIRED METHODS**********************
        public void setComboBox(string query, ComboBox combo) 
        {
            SqlDataReader sdr = fn.getForCombo(query); //select modle from Item
            while (sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }

        private void UC_Customer_Enter(object sender, EventArgs e)
        {
            txtItem.Items.Clear(); //without this code items will be adds multiple time
            query = "select distinct Iname from addItem";  // distinct for take unique single value from the Item list
            setComboBox(query, txtItem);
            
        }
        

        private void txtItem_SelectedIndexChanged(object sender, EventArgs e)
        { 
            txtBrand.Items.Clear();
            String Iname = txtItem.Text;
            query = "select distinct bname from addItem where Iname = '"+Iname+"'";
            setComboBox(query, txtBrand);
        }

        private void txtBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModle.Items.Clear();
            String bname = txtBrand.Text;
            query = " select distinct mdName from addItem where bname = '"+bname+"'";
            setComboBox(query, txtModle);
        }

        private void txtModle_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModleNumber.Items.Clear();
            String mdName = txtModle.Text;
            query = "select distinct mdnum from addItem where mdName = '" + mdName + "'";
            setComboBox(query, txtModleNumber);
        }

        private void txtModleNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            query = "select * from addItem where mdnum = '" + txtModleNumber.Text + "'";
            DataSet ds = fn.GetData(query);

           
            txtPrice.Text = ds.Tables[0].Rows[0][7].ToString();
            
        }

        private void btnPurches_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtNumber.Text != "" && txtAddress.Text !="" && txtItem.Text !="" && txtBrand.Text !="" && txtModle.Text !="" && txtModleNumber.Text !="" && txtImei.Text !="" && txtPrice.Text !="" ) 
            
            {


                String name = txtName.Text;
                Int64 phone = Int64.Parse(txtNumber.Text);
                String address = txtAddress.Text;
                String item = txtItem.Text;
                String bname = txtBrand.Text;
                String mdName = txtModle.Text;
                String mdnum = txtModleNumber.Text;
                String imeinum = txtImei.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                String sodate = DateTime.Now.ToString("yyyyMMdd");
                String sotime = DateTime.Now.ToString("hh:mm:ss");

                query = "insert into sold(cusname,cuphone,cuaddress,item,brand,modle,modnum,imei,price,sdate,stime) values('" + name + "','" + phone + "','" + address + "','" + item + "','" + bname + "','" + mdName + "','" + mdnum + "','" + imeinum + "','" + price + "','"+sodate+"','"+sotime+"')";
                fn.setData(query);

                txtName.Clear();
                txtAddress.Clear();
                txtNumber.Clear();
                txtItem.SelectedIndex = -1;
                txtBrand.SelectedIndex = -1;
                txtModle.SelectedIndex = -1;
                txtModleNumber.SelectedIndex = -1;
                txtImei.Clear();
                txtPrice.Clear();

                


            }

            else
            {
                MessageBox.Show("Please Fill All Records ", "Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
