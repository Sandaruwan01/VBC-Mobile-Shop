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
    public partial class UC_Delete : UserControl
    {
        function fn = new function();
        String query;
        public UC_Delete()
        {
            InitializeComponent();
        }

        private void UC_Delete_Enter(object sender, EventArgs e)
        {
            query = "select * from addItem ";
            DataSet ds = fn.GetData(query);
            DeletingDataGrid.DataSource = ds.Tables[0];
        }

        private void txtDelete_TextChanged(object sender, EventArgs e)
        {
            query = "select * from addItem where iname like '" + txtDelete.Text + "%' or mdnum like '"+txtDelete.Text+"%'";
            DataSet ds =fn.GetData(query);
            DeletingDataGrid.DataSource = ds.Tables[0];
        }
        int bid;
        private void DeletingDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DeletingDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(DeletingDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "delete from addItem where mid = " + bid + "";
            if (MessageBox.Show("Deleting Record Of " + bid + "", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("You Cancelled The Operation.","Undo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
