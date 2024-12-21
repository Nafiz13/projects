using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement.AllUserControls
{
    public partial class UC_UpdateItems : UserControl
    {
        function fn = new function();
        String query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
           // query = "select * from items";
            loadData(query);
        }
        public void loadData(String qur)
        {
            query = qur;
            //  DataSet ds = fn.getData(query);
            //  guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select = from items where name like '" + txtSearchItem.Text + "%'";
          //  DataSet ds = fn.getData(query);
          //  guna2DataGridView1.DataSource = ds.Tables[0]; 
        }
    }
}
