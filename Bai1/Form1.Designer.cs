namespace Bai1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.gbChon = new System.Windows.Forms.GroupBox();
            this.rdo_BacHai = new System.Windows.Forms.RadioButton();
            this.rdo_BacNhat = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_KetQua = new System.Windows.Forms.TextBox();
            this.btn_Giai = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.gbChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(60, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(202, 24);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // gbChon
            // 
            this.gbChon.Controls.Add(this.rdo_BacHai);
            this.gbChon.Controls.Add(this.rdo_BacNhat);
            this.gbChon.Location = new System.Drawing.Point(30, 50);
            this.gbChon.Name = "gbChon";
            this.gbChon.Size = new System.Drawing.Size(260, 75);
            this.gbChon.TabIndex = 1;
            this.gbChon.TabStop = false;
            this.gbChon.Text = "Bạn vui lòng chọn";
            // 
            // rdo_BacHai
            // 
            this.rdo_BacHai.AutoSize = true;
            this.rdo_BacHai.Location = new System.Drawing.Point(15, 45);
            this.rdo_BacHai.Name = "rdo_BacHai";
            this.rdo_BacHai.Size = new System.Drawing.Size(128, 17);
            this.rdo_BacHai.TabIndex = 1;
            this.rdo_BacHai.Text = "Phương trình bậc hai";
            this.rdo_BacHai.UseVisualStyleBackColor = true;
            this.rdo_BacHai.CheckedChanged += new System.EventHandler(this.rdo_BacHai_CheckedChanged);
            // 
            // rdo_BacNhat
            // 
            this.rdo_BacNhat.AutoSize = true;
            this.rdo_BacNhat.Checked = true;
            this.rdo_BacNhat.Location = new System.Drawing.Point(15, 20);
            this.rdo_BacNhat.Name = "rdo_BacNhat";
            this.rdo_BacNhat.Size = new System.Drawing.Size(133, 17);
            this.rdo_BacNhat.TabIndex = 0;
            this.rdo_BacNhat.TabStop = true;
            this.rdo_BacNhat.Text = "Phương trình bậc nhất";
            this.rdo_BacNhat.UseVisualStyleBackColor = true;
            this.rdo_BacNhat.CheckedChanged += new System.EventHandler(this.rdo_BacNhat_CheckedChanged);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(30, 140);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(44, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "Nhập a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(30, 175);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(44, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Nhập b:";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(30, 210);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(44, 13);
            this.lbl_c.TabIndex = 4;
            this.lbl_c.Text = "Nhập c:";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(30, 245);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(47, 13);
            this.lblKQ.TabIndex = 5;
            this.lblKQ.Text = "Kết quả:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(85, 137);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(120, 20);
            this.txt_a.TabIndex = 6;
            this.txt_a.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(85, 172);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(120, 20);
            this.txt_b.TabIndex = 7;
            this.txt_b.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(85, 207);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(120, 20);
            this.txt_c.TabIndex = 8;
            this.txt_c.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.Location = new System.Drawing.Point(85, 242);
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.ReadOnly = true;
            this.txt_KetQua.Size = new System.Drawing.Size(205, 20);
            this.txt_KetQua.TabIndex = 9;
            // 
            // btn_Giai
            // 
            this.btn_Giai.Enabled = false;
            this.btn_Giai.Location = new System.Drawing.Point(215, 137);
            this.btn_Giai.Name = "btn_Giai";
            this.btn_Giai.Size = new System.Drawing.Size(75, 45);
            this.btn_Giai.TabIndex = 10;
            this.btn_Giai.Text = "Giải";
            this.btn_Giai.UseVisualStyleBackColor = true;
            this.btn_Giai.Click += new System.EventHandler(this.btn_Giai_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(215, 195);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 32);
            this.btn_Thoat.TabIndex = 11;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 280);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Giai);
            this.Controls.Add(this.txt_KetQua);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.gbChon);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giải phương trình bậc 1-2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbChon.ResumeLayout(false);
            this.gbChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox gbChon;
        private System.Windows.Forms.RadioButton rdo_BacHai;
        private System.Windows.Forms.RadioButton rdo_BacNhat;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_KetQua;
        private System.Windows.Forms.Button btn_Giai;
        private System.Windows.Forms.Button btn_Thoat;
    }
}