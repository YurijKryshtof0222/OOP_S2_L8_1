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
    public partial class AddNewProductForm : Form
    {
        public ProductOrderList ProductOrders{ get; set; }

        public AddNewProductForm()
        {
            InitializeComponent();
        }

        private void AddNewProductForm_Load(object sender, EventArgs e)
        {
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ProductOrders.Add(new ProductOrder(
                    clientTB.Text,
                    productNameTB.Text,
                    int.Parse(priceTB.Text),
                    int.Parse(countTB.Text))

                );
                this.Close();
            }
            catch (ArgumentException exc)
            {
                MessageBox.Show("Числові значення не можуть бути від'ємними!", "Помилка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("У полях числових значень не приймаються символи!", "Помилка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}
