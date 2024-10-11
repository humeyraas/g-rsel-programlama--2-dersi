namespace randomsayisayac
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
            components = new System.ComponentModel.Container();
            lblSayi1 = new Label();
            lblSayi2 = new Label();
            lblTimer = new Label();
            lblSkor = new Label();
            tbTahmin = new TextBox();
            btnKontrol = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lblSayi3 = new Label();
            label3 = new Label();
            lblSayi4 = new Label();
            lblTimer2 = new Label();
            tbTahmin2 = new TextBox();
            lblSkor2 = new Label();
            btnKontrol2 = new Button();
            lblToplam = new Label();
            SuspendLayout();
            // 
            // lblSayi1
            // 
            lblSayi1.AutoSize = true;
            lblSayi1.Location = new Point(30, 106);
            lblSayi1.Name = "lblSayi1";
            lblSayi1.Size = new Size(38, 15);
            lblSayi1.TabIndex = 0;
            lblSayi1.Text = "label1";
            // 
            // lblSayi2
            // 
            lblSayi2.AutoSize = true;
            lblSayi2.Location = new Point(210, 106);
            lblSayi2.Name = "lblSayi2";
            lblSayi2.Size = new Size(38, 15);
            lblSayi2.TabIndex = 1;
            lblSayi2.Text = "label2";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(604, 89);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(49, 15);
            lblTimer.TabIndex = 2;
            lblTimer.Text = "00:00:00";
            // 
            // lblSkor
            // 
            lblSkor.AutoSize = true;
            lblSkor.Location = new Point(604, 122);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(33, 15);
            lblSkor.TabIndex = 3;
            lblSkor.Text = "Skor:";
            // 
            // tbTahmin
            // 
            tbTahmin.Location = new Point(290, 103);
            tbTahmin.Name = "tbTahmin";
            tbTahmin.Size = new Size(100, 23);
            tbTahmin.TabIndex = 4;
            // 
            // btnKontrol
            // 
            btnKontrol.Location = new Point(438, 89);
            btnKontrol.Name = "btnKontrol";
            btnKontrol.Size = new Size(119, 48);
            btnKontrol.TabIndex = 5;
            btnKontrol.Text = "KONRTOL ET";
            btnKontrol.UseVisualStyleBackColor = true;
            btnKontrol.Click += btnKontrol_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 106);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 6;
            label1.Text = "+";
            label1.Click += label1_Click;
            // 
            // lblSayi3
            // 
            lblSayi3.AutoSize = true;
            lblSayi3.Location = new Point(30, 232);
            lblSayi3.Name = "lblSayi3";
            lblSayi3.Size = new Size(38, 15);
            lblSayi3.TabIndex = 7;
            lblSayi3.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 232);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 8;
            label3.Text = "X";
            // 
            // lblSayi4
            // 
            lblSayi4.AutoSize = true;
            lblSayi4.Location = new Point(210, 232);
            lblSayi4.Name = "lblSayi4";
            lblSayi4.Size = new Size(38, 15);
            lblSayi4.TabIndex = 9;
            lblSayi4.Text = "label4";
            // 
            // lblTimer2
            // 
            lblTimer2.AutoSize = true;
            lblTimer2.Location = new Point(604, 210);
            lblTimer2.Name = "lblTimer2";
            lblTimer2.Size = new Size(49, 15);
            lblTimer2.TabIndex = 10;
            lblTimer2.Text = "05:00:00";
            // 
            // tbTahmin2
            // 
            tbTahmin2.Location = new Point(290, 224);
            tbTahmin2.Name = "tbTahmin2";
            tbTahmin2.Size = new Size(100, 23);
            tbTahmin2.TabIndex = 11;
            // 
            // lblSkor2
            // 
            lblSkor2.AutoSize = true;
            lblSkor2.Location = new Point(609, 243);
            lblSkor2.Name = "lblSkor2";
            lblSkor2.Size = new Size(33, 15);
            lblSkor2.TabIndex = 12;
            lblSkor2.Text = "Skor:";
            // 
            // btnKontrol2
            // 
            btnKontrol2.Location = new Point(438, 210);
            btnKontrol2.Name = "btnKontrol2";
            btnKontrol2.Size = new Size(119, 48);
            btnKontrol2.TabIndex = 13;
            btnKontrol2.Text = "KONRTOL ET";
            btnKontrol2.UseVisualStyleBackColor = true;
            btnKontrol2.Click += button1_Click;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(447, 334);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(50, 15);
            lblToplam.TabIndex = 14;
            lblToplam.Text = "SONUC:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblToplam);
            Controls.Add(btnKontrol2);
            Controls.Add(lblSkor2);
            Controls.Add(tbTahmin2);
            Controls.Add(lblTimer2);
            Controls.Add(lblSayi4);
            Controls.Add(label3);
            Controls.Add(lblSayi3);
            Controls.Add(label1);
            Controls.Add(btnKontrol);
            Controls.Add(tbTahmin);
            Controls.Add(lblSkor);
            Controls.Add(lblTimer);
            Controls.Add(lblSayi2);
            Controls.Add(lblSayi1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSayi1;
        private Label lblSayi2;
        private Label lblTimer;
        private Label lblSkor;
        private TextBox tbTahmin;
        private Button btnKontrol;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label lblSayi3;
        private Label label3;
        private Label lblSayi4;
        private Label lblTimer2;
        private TextBox tbTahmin2;
        private Label lblSkor2;
        private Button btnKontrol2;
        private Label lblToplam;
    }
}
