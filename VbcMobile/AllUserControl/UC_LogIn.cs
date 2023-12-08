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
    public partial class UC_LogIn : UserControl
    {
        public UC_LogIn()
        {
            InitializeComponent();
            error.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            panel1.Visible = false;
            this.guna2WinProgressIndicator1.Start();
        }

        int abc = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            abc++;
            if (abc == 5)
            {
                abc = 0;
                if (txtUserName.Text == "vbcmobile" && txtPassword.Text == "vbcmobile")
                {

                    this.Hide();
                    timer1.Stop();


                }
                else
                {
                    panel1.Visible = true;
                    error.Visible = true;
                    timer1.Stop();
                    
                }
            }
        }

        
    }
}
