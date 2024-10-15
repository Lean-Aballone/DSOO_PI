namespace PI_ComB_Grupo2_ClubDeportivo {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            LoginImageContainer = new TableLayoutPanel();
            LoginFormContainer = new TableLayoutPanel();
            btnIngresar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            LoginImageContainer.SuspendLayout();
            LoginFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginImageContainer
            // 
            LoginImageContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginImageContainer.AutoSize = true;
            LoginImageContainer.ColumnCount = 2;
            LoginImageContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LoginImageContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LoginImageContainer.Controls.Add(LoginFormContainer, 1, 0);
            LoginImageContainer.Controls.Add(pictureBox1, 0, 0);
            LoginImageContainer.Location = new Point(0, 0);
            LoginImageContainer.Name = "LoginImageContainer";
            LoginImageContainer.RowCount = 1;
            LoginImageContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LoginImageContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LoginImageContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LoginImageContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LoginImageContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LoginImageContainer.Size = new Size(800, 450);
            LoginImageContainer.TabIndex = 0;
            LoginImageContainer.Paint += tableLayoutPanel1_Paint;
            // 
            // LoginFormContainer
            // 
            LoginFormContainer.ColumnCount = 1;
            LoginFormContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LoginFormContainer.Controls.Add(btnIngresar, 0, 3);
            LoginFormContainer.Controls.Add(label1, 0, 0);
            LoginFormContainer.Controls.Add(textBox1, 0, 1);
            LoginFormContainer.Controls.Add(textBox2, 0, 2);
            LoginFormContainer.Dock = DockStyle.Top;
            LoginFormContainer.Location = new Point(400, 0);
            LoginFormContainer.Margin = new Padding(0);
            LoginFormContainer.Name = "LoginFormContainer";
            LoginFormContainer.Padding = new Padding(0, 150, 0, 200);
            LoginFormContainer.RowCount = 4;
            LoginFormContainer.RowStyles.Add(new RowStyle());
            LoginFormContainer.RowStyles.Add(new RowStyle());
            LoginFormContainer.RowStyles.Add(new RowStyle());
            LoginFormContainer.RowStyles.Add(new RowStyle());
            LoginFormContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LoginFormContainer.Size = new Size(400, 444);
            LoginFormContainer.TabIndex = 0;
            LoginFormContainer.Paint += LoginFormContainer_Paint;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Location = new Point(110, 266);
            btnIngresar.Margin = new Padding(15);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(180, 35);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresarClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 150);
            label1.Name = "label1";
            label1.Size = new Size(394, 15);
            label1.TabIndex = 1;
            label1.Text = "INGRESO AL SISTEMA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(10, 175);
            textBox1.Margin = new Padding(10);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "USUARIO";
            textBox1.Size = new Size(380, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(10, 218);
            textBox2.Margin = new Padding(10);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "CONTRASEÑA";
            textBox2.Size = new Size(380, 23);
            textBox2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginImageContainer);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            LoginImageContainer.ResumeLayout(false);
            LoginFormContainer.ResumeLayout(false);
            LoginFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected TableLayoutPanel LoginImageContainer;
        protected TableLayoutPanel LoginFormContainer;
        protected Button btnIngresar;
        protected Label label1;
        protected TextBox textBox1;
        protected TextBox textBox2;
        protected PictureBox pictureBox1;
    }
}