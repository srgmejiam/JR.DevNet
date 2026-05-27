namespace UI
{
    partial class Login
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            button2 = new Button();
            textBox2 = new TextBox();
            lblTitulo = new Label();
            lblUsuario = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 5);
            tableLayoutPanel1.Controls.Add(textBox2, 0, 4);
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(lblUsuario, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Controls.Add(panel1, 0, 5);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.30027437F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5263157F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7894735F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4401913F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.4449768F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.272728F));
            tableLayoutPanel1.Size = new Size(770, 458);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(388, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 90);
            panel2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Location = new Point(111, 29);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            tableLayoutPanel1.SetColumnSpan(textBox2, 2);
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(23, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(724, 40);
            textBox2.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitulo, 2);
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Arial Black", 14F);
            lblTitulo.ForeColor = Color.Blue;
            lblTitulo.Location = new Point(23, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(724, 26);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Login";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblUsuario, 2);
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(23, 46);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(724, 43);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            lblUsuario.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox1
            // 
            tableLayoutPanel1.SetColumnSpan(textBox1, 2);
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(23, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(724, 40);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 110);
            label1.Name = "label1";
            label1.Size = new Size(724, 65);
            label1.TabIndex = 3;
            label1.Text = "Contraseña";
            label1.TextAlign = ContentAlignment.BottomLeft;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(23, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 90);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(111, 29);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 325);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 110);
            dataGridView1.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 458);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private Label lblUsuario;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private DataGridView dataGridView1;
    }
}