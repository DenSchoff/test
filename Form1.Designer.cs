namespace lab7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            brand = new DataGridViewTextBoxColumn();
            model = new DataGridViewTextBoxColumn();
            cost = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            button4 = new Button();
            textBox4 = new TextBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add-a-Car:";
            // 
            // button1
            // 
            button1.Location = new Point(93, 134);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Add!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 56);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 3;
            label3.Text = "Car model:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 89);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Car price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 23);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Car brand:";
            // 
            // button2
            // 
            button2.Location = new Point(82, 206);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, brand, model, cost });
            dataGridView1.Location = new Point(300, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(553, 416);
            dataGridView1.TabIndex = 2;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 125;
            // 
            // brand
            // 
            brand.HeaderText = "brand";
            brand.MinimumWidth = 6;
            brand.Name = "brand";
            brand.ReadOnly = true;
            brand.Width = 125;
            // 
            // model
            // 
            model.HeaderText = "model";
            model.MinimumWidth = 6;
            model.Name = "model";
            model.ReadOnly = true;
            model.Width = 125;
            // 
            // cost
            // 
            cost.HeaderText = "cost";
            cost.MinimumWidth = 6;
            cost.Name = "cost";
            cost.ReadOnly = true;
            cost.Width = 125;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(12, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 241);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "PaperWork";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(193, 75);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(80, 27);
            textBox6.TabIndex = 6;
            textBox6.Text = "100000000";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 75);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(81, 27);
            textBox5.TabIndex = 5;
            textBox5.Text = "0";
            // 
            // button4
            // 
            button4.Location = new Point(93, 74);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "<= Cost <=";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(93, 27);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 27);
            textBox4.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(6, 26);
            button3.Name = "button3";
            button3.Size = new Size(81, 29);
            button3.TabIndex = 2;
            button3.Text = "Choose:";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 440);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "MyCarDealership";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn model;
        private DataGridViewTextBoxColumn cost;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private Button button3;
        private Button button4;
        private TextBox textBox6;
        private TextBox textBox5;
    }
}
