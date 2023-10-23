using System;
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
    public partial class UC_Repair : UserControl
    {
        function fn = new function();
        String query;
        public UC_Repair()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBrandLb.Text !="" && txtModleNameLb.Text !="" && txtModleNumberLb.Text !="" && txtNote.Text !="" && txtCusNameLb.Text !="" && txtPhoneLb.Text !="" && txtaddrLb.Text !="" && txtPriceLb.Text !="" ) 
            
            {

                String brandr = txtBrandLb.Text;
                String rmdname = txtModleNameLb.Text;
                String rmdnum = txtModleNumberLb.Text;
                String rnote = txtNote.Text;
                String cuname = txtCusNameLb.Text;
                Int64 rphone = Int64.Parse(txtPhoneLb.Text);
                String raddress = txtaddrLb.Text;
                Int64 rpprice = Int64.Parse(txtPriceLb.Text);
                String sdate = DateTime.Now.ToString("yyyyMMdd");
                String optime = DateTime.Now.ToString("hh:mm:ss");

                query = "insert into repair(rebrand,modname,modnum,issue,curname,cusphone,curaddress,rprice,rdate,rtime) values ('" + brandr + "','" + rmdname + "','" + rmdnum + "','" + rnote + "','" + cuname + "','" + rphone + "','" + raddress + "','" + rpprice + "','" + sdate + "','" + optime + "')";
                fn.setData(query);

                txtBrandLb.Clear();
                txtModleNameLb.Clear();
                txtModleNumberLb.Clear();
                txtNote.Clear();
                txtCusNameLb.Clear();
                txtPhoneLb.Clear();
                txtaddrLb.Clear();
                txtPriceLb.Clear();

            }
            else
            {
                MessageBox.Show("Please Fill All Data ", "VBC Mobiles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBrandLb.Clear();
            txtModleNameLb.Clear();
            txtModleNumberLb.Clear();
            txtNote.Clear();
            txtCusNameLb.Clear();
            txtPhoneLb.Clear();
            txtaddrLb.Clear();
            txtPriceLb.Clear();

        }
    }
}
