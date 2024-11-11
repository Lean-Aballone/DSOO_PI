namespace PI_ComB_Grupo2_ClubDeportivo {
    partial class PagoCuota {
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioCuota6 = new RadioButton();
            radioCuota3 = new RadioButton();
            radioCuota1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSpringGreen;
            button2.Dock = DockStyle.Fill;
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(25, 367);
            button2.Margin = new Padding(25);
            button2.Name = "button2";
            button2.Size = new Size(350, 58);
            button2.TabIndex = 4;
            button2.Text = "Generar Comprobante";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.RosyBrown;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(425, 367);
            button3.Margin = new Padding(25);
            button3.Name = "button3";
            button3.Size = new Size(350, 58);
            button3.TabIndex = 3;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(button1, 0, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 43.45238F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.916666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(394, 336);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Dock = DockStyle.Fill;
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(25, 248);
            button1.Margin = new Padding(25);
            button1.Name = "button1";
            button1.Size = new Size(344, 63);
            button1.TabIndex = 5;
            button1.Text = "Pagar";
            button1.UseVisualStyleBackColor = false;
            button1.EnabledChanged += guardarID;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 111);
            label1.Margin = new Padding(3, 0, 3, 10);
            label1.Name = "label1";
            label1.Size = new Size(388, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Número de Identificación de Cuota";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(50, 171);
            textBox1.Margin = new Padding(50, 25, 50, 25);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "0000000000000";
            textBox1.Size = new Size(294, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textOrSelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PapayaWhip;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(450, 80);
            groupBox1.Margin = new Padding(50, 80, 50, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 237);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioCuota6);
            groupBox2.Controls.Add(radioCuota3);
            groupBox2.Controls.Add(radioCuota1);
            groupBox2.Location = new Point(6, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 119);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cuotas";
            groupBox2.Visible = false;
            // 
            // radioCuota6
            // 
            radioCuota6.AutoSize = true;
            radioCuota6.Location = new Point(6, 89);
            radioCuota6.Name = "radioCuota6";
            radioCuota6.Size = new Size(89, 25);
            radioCuota6.TabIndex = 2;
            radioCuota6.TabStop = true;
            radioCuota6.Text = "6 Cuotas";
            radioCuota6.UseVisualStyleBackColor = true;
            // 
            // radioCuota3
            // 
            radioCuota3.AutoSize = true;
            radioCuota3.Location = new Point(6, 59);
            radioCuota3.Name = "radioCuota3";
            radioCuota3.Size = new Size(89, 25);
            radioCuota3.TabIndex = 1;
            radioCuota3.TabStop = true;
            radioCuota3.Text = "3 Cuotas";
            radioCuota3.UseVisualStyleBackColor = true;
            // 
            // radioCuota1
            // 
            radioCuota1.AutoSize = true;
            radioCuota1.Location = new Point(6, 28);
            radioCuota1.Name = "radioCuota1";
            radioCuota1.Size = new Size(82, 25);
            radioCuota1.TabIndex = 0;
            radioCuota1.TabStop = true;
            radioCuota1.Text = "1 Cuota";
            radioCuota1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 84);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tarjeta";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += showCuotas;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Efectivo";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += textOrSelectionChanged;
            // 
            // PagoCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "PagoCuota";
            Text = "PagoCuota";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private RadioButton radioCuota6;
        private RadioButton radioCuota3;
        private RadioButton radioCuota1;
        private Button button1;
    }
}