namespace OOP_S2_L8_1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addNewProductBtn = new System.Windows.Forms.Button();
            this.readFromXMLbtn = new System.Windows.Forms.Button();
            this.writeToXmlBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.xmlFileTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sortBtn = new System.Windows.Forms.Button();
            this.showOnlyWithDsicontBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // addNewProductBtn
            // 
            this.addNewProductBtn.Location = new System.Drawing.Point(569, 401);
            this.addNewProductBtn.Name = "addNewProductBtn";
            this.addNewProductBtn.Size = new System.Drawing.Size(145, 29);
            this.addNewProductBtn.TabIndex = 1;
            this.addNewProductBtn.Text = "Додати нову інформацію";
            this.addNewProductBtn.UseVisualStyleBackColor = true;
            this.addNewProductBtn.Click += new System.EventHandler(this.addNewProductBtn_Click);
            // 
            // readFromXMLbtn
            // 
            this.readFromXMLbtn.Location = new System.Drawing.Point(608, 369);
            this.readFromXMLbtn.Name = "readFromXMLbtn";
            this.readFromXMLbtn.Size = new System.Drawing.Size(106, 29);
            this.readFromXMLbtn.TabIndex = 2;
            this.readFromXMLbtn.Text = "Зчитувати з XML";
            this.readFromXMLbtn.UseVisualStyleBackColor = true;
            this.readFromXMLbtn.Click += new System.EventHandler(this.readFromXMLbtn_Click);
            // 
            // writeToXmlBtn
            // 
            this.writeToXmlBtn.Location = new System.Drawing.Point(720, 369);
            this.writeToXmlBtn.Name = "writeToXmlBtn";
            this.writeToXmlBtn.Size = new System.Drawing.Size(106, 29);
            this.writeToXmlBtn.TabIndex = 3;
            this.writeToXmlBtn.Text = "Записати в XML";
            this.writeToXmlBtn.UseVisualStyleBackColor = true;
            this.writeToXmlBtn.Click += new System.EventHandler(this.writeToXmlBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(720, 401);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(106, 29);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Вийти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // xmlFileTB
            // 
            this.xmlFileTB.Location = new System.Drawing.Point(477, 378);
            this.xmlFileTB.Name = "xmlFileTB";
            this.xmlFileTB.Size = new System.Drawing.Size(125, 20);
            this.xmlFileTB.TabIndex = 5;
            this.xmlFileTB.Text = "books";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "назва XML файлу:";
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(13, 372);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(277, 26);
            this.sortBtn.TabIndex = 7;
            this.sortBtn.Text = "Сортувати за зростанням кількості замовлення.";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // showOnlyWithDsicontBtn
            // 
            this.showOnlyWithDsicontBtn.Location = new System.Drawing.Point(13, 401);
            this.showOnlyWithDsicontBtn.Name = "showOnlyWithDsicontBtn";
            this.showOnlyWithDsicontBtn.Size = new System.Drawing.Size(277, 23);
            this.showOnlyWithDsicontBtn.TabIndex = 8;
            this.showOnlyWithDsicontBtn.Text = "Вивести усіх клієнтів, яким була надана знижка.";
            this.showOnlyWithDsicontBtn.UseVisualStyleBackColor = true;
            this.showOnlyWithDsicontBtn.Click += new System.EventHandler(this.showOnlyWithDsicontBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 434);
            this.Controls.Add(this.showOnlyWithDsicontBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xmlFileTB);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.writeToXmlBtn);
            this.Controls.Add(this.readFromXMLbtn);
            this.Controls.Add(this.addNewProductBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Список замовлень продукцій в магазині";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addNewProductBtn;
        private System.Windows.Forms.Button readFromXMLbtn;
        private System.Windows.Forms.Button writeToXmlBtn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox xmlFileTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button showOnlyWithDsicontBtn;
    }
}

