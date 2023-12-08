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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace VbcMobile.AllUserControl
{
    public partial class UC_Add_To_Repair : UserControl
    {
        function fn = new function();
        String query;
        public UC_Add_To_Repair()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text != "" && txtModel.Text != "" && txtModleNumber.Text != "" && txtIssue.Text != "" && txtCustomer.Text != "" && txtPhone.Text != "" && txtPrice.Text != "")
            {

                String brand = txtBrand.Text;
                String modle = txtModel.Text;
                String modNumber = txtModleNumber.Text;
                String note = txtIssue.Text;
                String Cuname = txtCustomer.Text;
                Int64 phone = Int64.Parse(txtPhone.Text);
                String add = txtAddress.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                String sdate = DateTime.Now.ToString("yyyyMMdd");
                String optime = DateTime.Now.ToString("hh:mm:ss");

                query = "insert into repair(rebrand,modname,modnum,issue,curname,cusphone,curaddress,rprice,rdate,rtime) values('" + brand + "','" + modle + "','" + modNumber + "','" + note + "','" + Cuname + "','" + phone + "','" + add + "','"+price+"','" + sdate + "','" + optime + "')";
                fn.setData(query);

                
                txtBrand.Clear();
                txtModel.Clear();
                txtModleNumber.Clear();
                txtIssue.SelectedIndex = -1;
                txtCustomer.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
                txtPrice.Clear();
                

            }
            else
            {
                MessageBox.Show("Please Fill All Data ", "VBC Mobile Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBrand.Clear();
            txtModel.Clear();
            txtModleNumber.Clear();
            txtIssue.SelectedIndex = -1;
            txtCustomer.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtPrice.Clear();
        }
    }
}
