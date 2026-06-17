namespace popka.Forms
{
    partial class EditForm
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
            btnExit = new Button();
            btnAdd = new Button();
            btnupdate = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(713, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 31);
            btnExit.TabIndex = 0;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 390);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 31);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(108, 390);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(75, 31);
            btnupdate.TabIndex = 2;
            btnupdate.Text = "Обновить";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(254, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(534, 197);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 99);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 128);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 157);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(171, 23);
            textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 186);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(171, 23);
            textBox7.TabIndex = 10;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(12, 215);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(171, 23);
            textBox8.TabIndex = 11;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(12, 244);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(171, 23);
            textBox9.TabIndex = 12;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(12, 273);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(171, 23);
            textBox10.TabIndex = 13;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(12, 302);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(171, 23);
            textBox11.TabIndex = 14;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(12, 331);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(171, 23);
            textBox12.TabIndex = 15;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(209, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 31);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnupdate);
            Controls.Add(btnAdd);
            Controls.Add(btnExit);
            Name = "EditForm";
            Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnAdd;
        private Button btnupdate;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button btnDelete;
    }
}