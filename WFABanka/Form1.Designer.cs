namespace WFABanka
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnYatır = new System.Windows.Forms.Button();
            this.btnCek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYatir = new System.Windows.Forms.TextBox();
            this.txtCek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYatir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnYatır);
            this.groupBox1.Location = new System.Drawing.Point(55, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(535, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para Yatır";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCek);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnCek);
            this.groupBox2.Location = new System.Drawing.Point(55, 318);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(535, 281);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para Çek";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBakiye);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(628, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Size = new System.Drawing.Size(535, 571);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Bilgileri";
            // 
            // btnYatır
            // 
            this.btnYatır.Location = new System.Drawing.Point(28, 212);
            this.btnYatır.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnYatır.Name = "btnYatır";
            this.btnYatır.Size = new System.Drawing.Size(369, 46);
            this.btnYatır.TabIndex = 0;
            this.btnYatır.Text = "Para Yatır";
            this.btnYatır.UseVisualStyleBackColor = true;
            this.btnYatır.Click += new System.EventHandler(this.btnYatır_Click);
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(28, 209);
            this.btnCek.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(369, 46);
            this.btnCek.TabIndex = 0;
            this.btnCek.Text = "Para Çek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yatırılacak Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çekilecek Tutar:";
            // 
            // txtYatir
            // 
            this.txtYatir.Location = new System.Drawing.Point(28, 101);
            this.txtYatir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtYatir.Name = "txtYatir";
            this.txtYatir.Size = new System.Drawing.Size(369, 35);
            this.txtYatir.TabIndex = 2;
            // 
            // txtCek
            // 
            this.txtCek.Location = new System.Drawing.Point(28, 127);
            this.txtCek.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCek.Name = "txtCek";
            this.txtCek.Size = new System.Drawing.Size(369, 35);
            this.txtCek.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "AD: Mustafa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "SOYAD: YARDIMCI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bakiye:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(121, 166);
            this.lblBakiye.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(0, 29);
            this.lblBakiye.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 645);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYatir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYatır;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBakiye;
    }
}

