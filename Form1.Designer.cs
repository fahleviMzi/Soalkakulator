namespace belajarkalulator
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
            this.tambah = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bilang = new System.Windows.Forms.TextBox();
            this.hasil = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kurang = new System.Windows.Forms.Button();
            this.kali = new System.Windows.Forms.Button();
            this.bagi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tambah
            // 
            this.tambah.Location = new System.Drawing.Point(65, 79);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(75, 23);
            this.tambah.TabIndex = 3;
            this.tambah.Text = "+";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(65, 53);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 2;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNis1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Angka 2";
            // 
            // bilang
            // 
            this.bilang.Enabled = false;
            this.bilang.Location = new System.Drawing.Point(65, 145);
            this.bilang.Multiline = true;
            this.bilang.Name = "bilang";
            this.bilang.Size = new System.Drawing.Size(159, 52);
            this.bilang.TabIndex = 3;
            // 
            // hasil
            // 
            this.hasil.AutoSize = true;
            this.hasil.Location = new System.Drawing.Point(71, 215);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(30, 13);
            this.hasil.TabIndex = 2;
            this.hasil.Text = "Hasil";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(65, 27);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 1;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNis);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Angka 1";
            // 
            // kurang
            // 
            this.kurang.Location = new System.Drawing.Point(146, 79);
            this.kurang.Name = "kurang";
            this.kurang.Size = new System.Drawing.Size(75, 23);
            this.kurang.TabIndex = 4;
            this.kurang.Text = "-";
            this.kurang.UseVisualStyleBackColor = true;
            this.kurang.Click += new System.EventHandler(this.kurang_Click);
            // 
            // kali
            // 
            this.kali.Location = new System.Drawing.Point(65, 110);
            this.kali.Name = "kali";
            this.kali.Size = new System.Drawing.Size(75, 23);
            this.kali.TabIndex = 5;
            this.kali.Text = "x";
            this.kali.UseVisualStyleBackColor = true;
            this.kali.Click += new System.EventHandler(this.kali_Click);
            // 
            // bagi
            // 
            this.bagi.Location = new System.Drawing.Point(146, 110);
            this.bagi.Name = "bagi";
            this.bagi.Size = new System.Drawing.Size(75, 23);
            this.bagi.TabIndex = 6;
            this.bagi.Text = "/";
            this.bagi.UseVisualStyleBackColor = true;
            this.bagi.Click += new System.EventHandler(this.bagi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hasil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bagi);
            this.Controls.Add(this.kali);
            this.Controls.Add(this.kurang);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.bilang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.tambah);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bilang;
        private System.Windows.Forms.Label hasil;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kurang;
        private System.Windows.Forms.Button kali;
        private System.Windows.Forms.Button bagi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

