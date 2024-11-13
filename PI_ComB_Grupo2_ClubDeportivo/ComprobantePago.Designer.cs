namespace PI_ComB_Grupo2_ClubDeportivo {
    partial class ComprobantePago {
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
            button1 = new Button();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FloralWhite;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button2, 1, 3);
            tableLayoutPanel1.Controls.Add(button1, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(403, 339);
            button2.Name = "button2";
            button2.Size = new Size(394, 108);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 339);
            button1.Name = "button1";
            button1.Size = new Size(394, 108);
            button1.TabIndex = 1;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 50);
            label1.Margin = new Padding(3, 50, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(794, 62);
            label1.TabIndex = 3;
            label1.Text = "COMPROBANTE de PAGO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.PapayaWhip;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 115);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(394, 106);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Socio;
            pictureBox1.Location = new Point(246, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 0);
            label2.Size = new Size(240, 106);
            label2.TabIndex = 0;
            label2.Text = "CLUB DEPORTIVO";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PapayaWhip;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(403, 112);
            label3.Name = "label3";
            label3.Padding = new Padding(15);
            label3.Size = new Size(394, 112);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label4, 2);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 224);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(794, 112);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // ComprobantePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComprobantePago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComprobantePago";
            Load += onLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}