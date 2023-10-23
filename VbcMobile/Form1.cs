using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VbcMobile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Application Exit Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        // When the application load, these forms are not load, load when only after the requred button press
        private void Form1_Load(object sender, EventArgs e)
        {
            uC_Add_New_Item1.Visible = false;
            uC_Customer1.Visible = false;
            uC_Stock1.Visible = false;
            uC_Sold1.Visible = false;
            uC_Delete1.Visible = false;
            uC_Repair1.Visible = false;
            uC_Completed_Repair1.Visible=false;

            enebleDisable(false,false,false);

        }
        // Requred Buttons and load events
        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            uC_Add_New_Item1.Visible = true;
            uC_Add_New_Item1.BringToFront();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            uC_Customer1.Visible = true;
            uC_Customer1.BringToFront();
        }

        private void btnRepairCenter_Click(object sender, EventArgs e)
        {
            uC_Repair1.Visible = true;
            uC_Repair1.BringToFront();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            uC_Stock1.Visible = true;
            uC_Stock1.BringToFront();
        }

        private void btnSoled_Click(object sender, EventArgs e)
        {
            uC_Sold1.Visible = true;
            uC_Sold1.BringToFront();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            uC_Completed_Repair1.Visible=true;
            uC_Completed_Repair1.BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            enebleDisable(true, true, true);
        }

        //when click on cancel then the password box need to hide
        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            enebleDisable(false, false, false);

        }


        //******************************   Requred ************************************
        // A method created for Enable and Desable the Password Feiled. 
        public void enebleDisable(Boolean txtbox, Boolean btn1, Boolean btn2)
        {
            txtPassword.Visible = txtbox;
            btnVerify.Visible = btn1;
            btnCancel.Visible = btn2;
        }
        
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "vbcmobile") 
            {
                panel2.Enabled = true;
                uC_Delete1.Visible = true;
                uC_Delete1.BringToFront();
                enebleDisable(false,false,false);
                txtPassword.Clear();
            }
            else
            {
                txtPassword.Clear();
            }
        }

        
    }
}
