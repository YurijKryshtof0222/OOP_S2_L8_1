using OOP_S2_L8.myClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_S2_L8_1.forms
{
    public partial class FilteredDataGridViewForm : Form
    {
        public ProductOrderList ProductOrders { get; set;}
        
        BindingList<ProductOrder> bindingList;

        public FilteredDataGridViewForm()
        {
            InitializeComponent();
        }

        private void FilteredDataGridViewForm_Load(object sender, EventArgs e)
        {
            bindingList = new BindingList<ProductOrder>(ProductOrders);
            dataGridView1.DataSource = bindingList;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
