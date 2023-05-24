using OOP_S2_L8.myClasses;
using OOP_S2_L8_1.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_S2_L8_1
{
    public partial class MainForm : Form
    {
        ProductOrderList productOrderList = new ProductOrderList();

        BindingList<ProductOrder> bindingList;

        public MainForm()
        {
            InitializeComponent();
            bindingList = new BindingList<ProductOrder>(productOrderList);
        }

        private void refreshDataGridView()
        {
            bindingList = new BindingList<ProductOrder>(productOrderList);
            dataGridView1.DataSource = bindingList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingList;
        }

        private void addNewProductBtn_Click(object sender, EventArgs e)
        {
            AddNewProductForm form = new AddNewProductForm();
            form.ProductOrders = productOrderList;
            form.ShowDialog();

            refreshDataGridView();
        }

        private void readFromXMLbtn_Click(object sender, EventArgs e)
        {
            try
            {
                productOrderList = productOrderList.readFromFile(xmlFileTB.Text);
                refreshDataGridView();
            }
            catch (FileNotFoundException exc)
            {
                MessageBox.Show("Файл не знайдений!", "Помилка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Помлилка у структркрі XML-документа.Не вдалось обробити файл!", "Помилка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Не вдалось обробити файл!", "Помилка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void writeToXmlBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ви впевнені що хочете перезаписати цей файл?", "Підтвердження", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.OK)
            {
                productOrderList.writeToFile(xmlFileTB.Text);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            productOrderList.Sort();
            refreshDataGridView();
        }

        private void showOnlyWithDsicontBtn_Click(object sender, EventArgs e)
        {
            FilteredDataGridViewForm form = new FilteredDataGridViewForm();
            form.ProductOrders = productOrderList.prodictsWithDiscount();
            form.Show();
        }

    }
}
