using System;
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
    public partial class UC_Repair_Center : UserControl
    {
        function fn = new function();
        String query;
        public UC_Repair_Center()
        {
            InitializeComponent();
        }

        private void UC_Repair_Center_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "select *from repair";
            DataSet ds = fn.GetData(query);
            dgRepairStock.DataSource = ds.Tables[0];

        }
        private void UC_Repair_Center_Enter(object sender, EventArgs e)
        {
            query = "select *from repair";
            DataSet ds = fn.GetData(query);
            dgRepairStock.DataSource = ds.Tables[0];
            

        }
        int bid;
        private void dgRepairStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRepairStock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dgRepairStock.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            query = "select * from repair where mid = " + bid + "";
            DataSet ds = fn.GetData(query);

            lblBrand.Text = ds.Tables[0].Rows[0][1].ToString();
            lblModel.Text = ds.Tables[0].Rows[0][2].ToString();
            lblModNo.Text = ds.Tables[0].Rows[0][3].ToString();
            lblIssue.Text = ds.Tables[0].Rows[0][4].ToString();
            lblStatus2.Text = ds.Tables[0].Rows[0][5].ToString();
            lblName.Text = ds.Tables[0].Rows[0][6].ToString();
            lblPhone.Text = ds.Tables[0].Rows[0][7].ToString();
            lblSet.Text = ds.Tables[0].Rows[0][9].ToString();
            
            // retrive the price from dataset
            String priceAsString = ds.Tables[0].Rows[0][9].ToString();
            //convert the string price to double
            if(double.TryParse(priceAsString, out double priceValue))
            {
                String formattedPrice = priceValue.ToString("N2");
                lblPrice.Text = formattedPrice;
                
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update repair set status1 = '"+cbStatus.Text+"' where mid="+bid+" ";
            if (MessageBox.Show("Are You Sure..? " , "VBC Mobile Management System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fn.setData(query);
                cbStatus.SelectedIndex = -1;
                
            }
            else
            {
                MessageBox.Show("You Cancelled The Operation.", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            loadData();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (lblBrand.Text != "" && lblModel.Text != "" && lblModNo.Text != ""  && lblName.Text != "" && lblPhone.Text != "" && lblStatus2.Text == "Completed")
            {

                String brand1 = lblBrand.Text;
                String modle1 = lblModel.Text;
                String modNumber1 = lblModNo.Text;
                String Cuname1 = lblName.Text;
                Int64 phone1 = Int64.Parse(lblPhone.Text);
                String note0 = lblIssue.Text;
                Int64 price1= Int64.Parse(lblSet.Text);
                String sdate1 = DateTime.Now.ToString("yyyyMMdd");
                String optime1 = DateTime.Now.ToString("hh:mm:ss");

                query = "insert into completed_rep(brand1,mname1,mnum1,cname1,cpnum1,note1,price1,comdate,comtime) values('" + brand1 + "','" + modle1 + "','" + modNumber1 + "','" + Cuname1 + "','" + phone1 + "','" + note0 + "','" + price1 + "','" + sdate1 + "','" + optime1 + "')";
                if (MessageBox.Show("Are You Sure This Is " + lblStatus2.Text + "", "VBC Mobile Management System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    fn.setData(query);
                    cbStatus.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("You Cancelled The Operation.", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }
            else
            {
                MessageBox.Show("Please Make Status As Completed ", "VBC Mobile Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //for searching

        Boolean flag;

        private void txtSearchBy2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy2.SelectedIndex == 0)
            {
                flag = false;
                labelTOSET2.Text = "Enter Customer Name";
            }
            else if (txtSearchBy2.SelectedIndex == 1)
            {
                flag = true;
                labelTOSET2.Text = "Enter Phone Number";
            }
        }
        private void btnSearch2_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                query = "select * from repair where curname like '" + txtSearch2.Text + "%'";
                DataSet ds = fn.GetData(query);
                dgRepairStock.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from repair where cusphone like '" + txtSearch2.Text + "%' ";
                DataSet ds = fn.GetData(query);
                dgRepairStock.DataSource = ds.Tables[0];
            }
        }
    }
}
