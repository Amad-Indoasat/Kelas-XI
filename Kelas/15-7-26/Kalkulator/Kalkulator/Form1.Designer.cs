namespace Kalkulator
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
            lblAngka1 = new Label();
            textBoxAngka1 = new TextBox();
            textBoxAngka2 = new TextBox();
            lblAngka2 = new Label();
            lblhasil = new Label();
            BtnTambah = new Button();
            labelAksi = new Label();
            label1 = new Label();
            BtnKurang = new Button();
            BtnKali = new Button();
            BtnBagi = new Button();
            labelHasil = new Label();
            SuspendLayout();
            // 
            // lblAngka1
            // 
            lblAngka1.AutoSize = true;
            lblAngka1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAngka1.Location = new Point(21, 40);
            lblAngka1.Name = "lblAngka1";
            lblAngka1.Size = new Size(80, 21);
            lblAngka1.TabIndex = 0;
            lblAngka1.Text = "Angka 1 :";
            // 
            // textBoxAngka1
            // 
            textBoxAngka1.Location = new Point(12, 64);
            textBoxAngka1.Name = "textBoxAngka1";
            textBoxAngka1.Size = new Size(338, 23);
            textBoxAngka1.TabIndex = 1;
            // 
            // textBoxAngka2
            // 
            textBoxAngka2.Location = new Point(12, 130);
            textBoxAngka2.Name = "textBoxAngka2";
            textBoxAngka2.Size = new Size(338, 23);
            textBoxAngka2.TabIndex = 3;
            // 
            // lblAngka2
            // 
            lblAngka2.AutoSize = true;
            lblAngka2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAngka2.Location = new Point(21, 106);
            lblAngka2.Name = "lblAngka2";
            lblAngka2.Size = new Size(80, 21);
            lblAngka2.TabIndex = 2;
            lblAngka2.Text = "Angka 2 :";
            // 
            // lblhasil
            // 
            lblhasil.AutoSize = true;
            lblhasil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblhasil.Location = new Point(12, 186);
            lblhasil.Name = "lblhasil";
            lblhasil.Size = new Size(56, 21);
            lblhasil.TabIndex = 4;
            lblhasil.Text = "Hasil :";
            // 
            // BtnTambah
            // 
            BtnTambah.Location = new Point(12, 286);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(352, 23);
            BtnTambah.TabIndex = 5;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // labelAksi
            // 
            labelAksi.AutoSize = true;
            labelAksi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelAksi.Location = new Point(168, 264);
            labelAksi.Name = "labelAksi";
            labelAksi.Size = new Size(37, 19);
            labelAksi.TabIndex = 6;
            labelAksi.Text = "Aksi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(100, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 7;
            label1.Text = "Kalkulator";
            // 
            // BtnKurang
            // 
            BtnKurang.Location = new Point(12, 315);
            BtnKurang.Name = "BtnKurang";
            BtnKurang.Size = new Size(352, 23);
            BtnKurang.TabIndex = 8;
            BtnKurang.Text = "Kurang";
            BtnKurang.UseVisualStyleBackColor = true;
            BtnKurang.Click += BtnKurang_Click;
            // 
            // BtnKali
            // 
            BtnKali.Location = new Point(12, 344);
            BtnKali.Name = "BtnKali";
            BtnKali.Size = new Size(352, 23);
            BtnKali.TabIndex = 9;
            BtnKali.Text = "Kali";
            BtnKali.UseVisualStyleBackColor = true;
            BtnKali.Click += BtnKali_Click;
            // 
            // BtnBagi
            // 
            BtnBagi.Location = new Point(12, 373);
            BtnBagi.Name = "BtnBagi";
            BtnBagi.Size = new Size(352, 23);
            BtnBagi.TabIndex = 10;
            BtnBagi.Text = "Bagi";
            BtnBagi.UseVisualStyleBackColor = true;
            BtnBagi.Click += BtnBagi_Click;
            // 
            // labelHasil
            // 
            labelHasil.AutoSize = true;
            labelHasil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelHasil.Location = new Point(74, 186);
            labelHasil.Name = "labelHasil";
            labelHasil.Size = new Size(19, 21);
            labelHasil.TabIndex = 11;
            labelHasil.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 450);
            Controls.Add(labelHasil);
            Controls.Add(BtnBagi);
            Controls.Add(BtnKali);
            Controls.Add(BtnKurang);
            Controls.Add(label1);
            Controls.Add(labelAksi);
            Controls.Add(BtnTambah);
            Controls.Add(lblhasil);
            Controls.Add(textBoxAngka2);
            Controls.Add(lblAngka2);
            Controls.Add(textBoxAngka1);
            Controls.Add(lblAngka1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAngka1;
        private TextBox textBoxAngka1;
        private TextBox textBoxAngka2;
        private Label lblAngka2;
        private Label lblhasil;
        private Button BtnTambah;
        private Label labelAksi;
        private Label label1;
        private Button BtnKurang;
        private Button BtnKali;
        private Button BtnBagi;
        private Label labelHasil;
    }
}
