namespace asalsayiuygulamasi
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
            tbTahmin = new TextBox();
            btnEnter = new Button();
            lblSayac = new Label();
            lbAsal = new ListBox();
            SuspendLayout();
            // 
            // tbTahmin
            // 
            tbTahmin.Location = new Point(90, 118);
            tbTahmin.Name = "tbTahmin";
            tbTahmin.Size = new Size(100, 23);
            tbTahmin.TabIndex = 0;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(104, 189);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblSayac
            // 
            lblSayac.AutoSize = true;
            lblSayac.Location = new Point(277, 121);
            lblSayac.Name = "lblSayac";
            lblSayac.Size = new Size(40, 15);
            lblSayac.TabIndex = 2;
            lblSayac.Text = "Sayaç:";
            // 
            // lbAsal
            // 
            lbAsal.FormattingEnabled = true;
            lbAsal.ItemHeight = 15;
            lbAsal.Location = new Point(454, 118);
            lbAsal.Name = "lbAsal";
            lbAsal.Size = new Size(120, 94);
            lbAsal.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbAsal);
            Controls.Add(lblSayac);
            Controls.Add(btnEnter);
            Controls.Add(tbTahmin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTahmin;
        private Button btnEnter;
        private Label lblSayac;
        private ListBox lbAsal;
    }
}
