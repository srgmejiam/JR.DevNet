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
            lblTitulo = new Label();
            panel2 = new Panel();
            btnIniciarSesion = new Button();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnCancelar = new Button();
            lblUsuario = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 5);
            tableLayoutPanel1.Controls.Add(txtPassword, 0, 4);
            tableLayoutPanel1.Controls.Add(txtUsuario, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Controls.Add(panel1, 0, 5);
            tableLayoutPanel1.Controls.Add(lblUsuario, 0, 1);
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
            // panel2
            // 
            panel2.Controls.Add(btnIniciarSesion);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(388, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 90);
            panel2.TabIndex = 6;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIniciarSesion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIniciarSesion.Location = new Point(96, 29);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(161, 29);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // txtPassword
            // 
            tableLayoutPanel1.SetColumnSpan(txtPassword, 2);
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(23, 178);
            txtPassword.MaxLength = 1024;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(724, 40);
            txtPassword.TabIndex = 4;
            // 
            // txtUsuario
            // 
            tableLayoutPanel1.SetColumnSpan(txtUsuario, 2);
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(23, 92);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(724, 40);
            txtUsuario.TabIndex = 2;
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
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(23, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 90);
            panel1.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Location = new Point(86, 29);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(175, 29);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label label1;
        private Panel panel1;
        private Button btnCancelar;
        private Panel panel2;
        private Button btnIniciarSesion;
    }
}