using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VbcMobile.AllUserControl
{
    public partial class UC_Add_New_Item : UserControl
    {
        function fn = new function();
        String query;

        public UC_Add_New_Item()
        {
            InitializeComponent();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItem.Text != "" && txtBrandName.Text != "" && txtModle.Text != "" && txtModleNumber.Text != "" && txtQty.Text != "" && txtAddNote.Text != "" && txtPrice.Text != "")
            {


                String item = txtItem.Text;
                String brand = txtBrandName.Text;
                String modle = txtModle.Text;
                String modNumber = txtModleNumber.Text;
                Int64 qnty = Int64.Parse(txtQty.Text);
                String note = txtAddNote.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                String sdate = DateTime.Now.ToString("yyyyMMdd");
                String optime = DateTime.Now.ToString("hh:mm:ss");

                query = "insert into addItem(iname,bname,mdname,mdnum,qty,note,price,date1,otime) values('" + item + "','" + brand + "','" + modle + "','" + modNumber + "','" + qnty + "','" + note + "','" + price + "','" + sdate + "','" + optime + "')";
                fn.setData(query);

                txtItem.SelectedIndex = -1;
                txtModle.Clear();
                txtModleNumber.Clear();
                txtBrandName.StartIndex = -1;
                txtQty.Clear();
                txtAddNote.Clear();
                txtPrice.Clear();



            }
            else
            {
                MessageBox.Show("Please Fill All Data ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            txtItem.StartIndex = -1;
            txtModle.Clear();
            txtModleNumber.Clear();
            txtBrandName.StartIndex = -1;
            txtQty.Clear();
            txtAddNote.Clear();
            txtPrice.Clear();



        }

        private void txtBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
