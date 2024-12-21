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
    public partial class UC_RemoveItem : UserControl
    {
        function fn = new function();
        String query;
        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            Dellabel.Text = " How to delete ";
            Dellabel.ForeColor = Color.Blue;
        }

        public void loadData()
        {
            query = "select * from items";
          //  DataSet ds = fn.getData(query);
          //  guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
