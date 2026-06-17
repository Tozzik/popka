namespace popka.Forms
{
    partial class ShopForm
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnCreateOrder = new Button();
            btnExitShop = new Button();
            btnEdit = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(798, 310);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(315, 7);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(75, 31);
            btnCreateOrder.TabIndex = 2;
            btnCreateOrder.Text = " Заказы";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnExitShop
            // 
            btnExitShop.Location = new Point(685, 401);
            btnExitShop.Name = "btnExitShop";
            btnExitShop.Size = new Size(75, 23);
            btnExitShop.TabIndex = 3;
            btnExitShop.Text = "Назад";
            btnExitShop.UseVisualStyleBackColor = true;
            btnExitShop.Click += btnExitShop_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(408, 7);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(108, 31);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Редактирование";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(660, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Общестроительные материалы", "Стеновые и фасадные материалы", "Сухие строительные смеси и гидроизоляция", "Ручной инструмент", "Защита лица, глаз, головы" });
            comboBox1.Location = new Point(522, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(btnEdit);
            Controls.Add(btnExitShop);
            Controls.Add(btnCreateOrder);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ShopForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopForm";
            Load += ShopForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnCreateOrder;
        private Button btnExitShop;
        private Button btnEdit;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}