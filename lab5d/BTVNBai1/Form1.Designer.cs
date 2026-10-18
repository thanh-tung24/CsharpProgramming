namespace BTVNBai1
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
            this.components = new System.ComponentModel.Container();
            this.lblNhapGiay = new System.Windows.Forms.Label();
            this.txtNhapGiay = new System.Windows.Forms.TextBox();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnTamDung = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.lblDongHo = new System.Windows.Forms.Label();
            this.timerDemNguoc = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblNhapGiay
            // 
            this.lblNhapGiay.AutoSize = true;
            this.lblNhapGiay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNhapGiay.Location = new System.Drawing.Point(40, 25);
            this.lblNhapGiay.Name = "lblNhapGiay";
            this.lblNhapGiay.Size = new System.Drawing.Size(155, 23);
            this.lblNhapGiay.TabIndex = 0;
            this.lblNhapGiay.Text = "Nhập thời gian (s):";
            // 
            // txtNhapGiay
            // 
            this.txtNhapGiay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNhapGiay.Location = new System.Drawing.Point(210, 22);
            this.txtNhapGiay.Name = "txtNhapGiay";
            this.txtNhapGiay.Size = new System.Drawing.Size(130, 30);
            this.txtNhapGiay.TabIndex = 1;
            this.txtNhapGiay.Text = "60";
            this.txtNhapGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNhapGiay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapGiay_KeyPress);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBatDau.Location = new System.Drawing.Point(40, 160);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(95, 35);
            this.btnBatDau.TabIndex = 2;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnTamDung
            // 
            this.btnTamDung.Enabled = false;
            this.btnTamDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTamDung.Location = new System.Drawing.Point(145, 160);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.Size = new System.Drawing.Size(95, 35);
            this.btnTamDung.TabIndex = 3;
            this.btnTamDung.Text = "Tạm dừng";
            this.btnTamDung.UseVisualStyleBackColor = true;
            this.btnTamDung.Click += new System.EventHandler(this.btnTamDung_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDatLai.Location = new System.Drawing.Point(250, 160);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(90, 35);
            this.btnDatLai.TabIndex = 4;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // lblDongHo
            // 
            this.lblDongHo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDongHo.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.lblDongHo.ForeColor = System.Drawing.Color.Red;
            this.lblDongHo.Location = new System.Drawing.Point(40, 70);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(300, 70);
            this.lblDongHo.TabIndex = 5;
            this.lblDongHo.Text = "00:01:00";
            this.lblDongHo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerDemNguoc
            // 
            this.timerDemNguoc.Interval = 1000;
            this.timerDemNguoc.Tick += new System.EventHandler(this.timerDemNguoc_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 225);
            this.Controls.Add(this.lblDongHo);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnTamDung);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.txtNhapGiay);
            this.Controls.Add(this.lblNhapGiay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đếm ngược thời gian";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNhapGiay;
        private System.Windows.Forms.TextBox txtNhapGiay;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnTamDung;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Label lblDongHo;
        private System.Windows.Forms.Timer timerDemNguoc;
    }
}