namespace BTVN1
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
            this.tabTuDien = new System.Windows.Forms.TabControl();
            this.tabAnhViet = new System.Windows.Forms.TabPage();
            this.lblNghiaAV = new System.Windows.Forms.Label();
            this.lblTuAV = new System.Windows.Forms.Label();
            this.txtNghiaAV = new System.Windows.Forms.TextBox();
            this.lstTuAV = new System.Windows.Forms.ListBox();
            this.cboTuAV = new System.Windows.Forms.ComboBox();
            this.tabVietAnh = new System.Windows.Forms.TabPage();
            this.lblNghiaVA = new System.Windows.Forms.Label();
            this.lblTuVA = new System.Windows.Forms.Label();
            this.txtNghiaVA = new System.Windows.Forms.TextBox();
            this.lstTuVA = new System.Windows.Forms.ListBox();
            this.cboTuVA = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabTuDien.SuspendLayout();
            this.tabAnhViet.SuspendLayout();
            this.tabVietAnh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTuDien
            // 
            this.tabTuDien.Controls.Add(this.tabAnhViet);
            this.tabTuDien.Controls.Add(this.tabVietAnh);
            this.tabTuDien.Location = new System.Drawing.Point(12, 12);
            this.tabTuDien.Name = "tabTuDien";
            this.tabTuDien.SelectedIndex = 0;
            this.tabTuDien.Size = new System.Drawing.Size(560, 340);
            this.tabTuDien.TabIndex = 0;
            // 
            // tabAnhViet
            // 
            this.tabAnhViet.Controls.Add(this.lblNghiaAV);
            this.tabAnhViet.Controls.Add(this.lblTuAV);
            this.tabAnhViet.Controls.Add(this.txtNghiaAV);
            this.tabAnhViet.Controls.Add(this.lstTuAV);
            this.tabAnhViet.Controls.Add(this.cboTuAV);
            this.tabAnhViet.Location = new System.Drawing.Point(4, 25);
            this.tabAnhViet.Name = "tabAnhViet";
            this.tabAnhViet.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnhViet.Size = new System.Drawing.Size(552, 311);
            this.tabAnhViet.TabIndex = 0;
            this.tabAnhViet.Text = "ANH - VIỆT";
            this.tabAnhViet.UseVisualStyleBackColor = true;
            // 
            // lblNghiaAV
            // 
            this.lblNghiaAV.AutoSize = true;
            this.lblNghiaAV.Location = new System.Drawing.Point(260, 15);
            this.lblNghiaAV.Name = "lblNghiaAV";
            this.lblNghiaAV.Size = new System.Drawing.Size(68, 16);
            this.lblNghiaAV.TabIndex = 4;
            this.lblNghiaAV.Text = "Tiếng Việt";
            // 
            // lblTuAV
            // 
            this.lblTuAV.AutoSize = true;
            this.lblTuAV.Location = new System.Drawing.Point(15, 15);
            this.lblTuAV.Name = "lblTuAV";
            this.lblTuAV.Size = new System.Drawing.Size(70, 16);
            this.lblTuAV.TabIndex = 3;
            this.lblTuAV.Text = "Tiếng Anh";
            // 
            // txtNghiaAV
            // 
            this.txtNghiaAV.Location = new System.Drawing.Point(263, 38);
            this.txtNghiaAV.Multiline = true;
            this.txtNghiaAV.Name = "txtNghiaAV";
            this.txtNghiaAV.ReadOnly = true;
            this.txtNghiaAV.Size = new System.Drawing.Size(270, 255);
            this.txtNghiaAV.TabIndex = 2;
            // 
            // lstTuAV
            // 
            this.lstTuAV.FormattingEnabled = true;
            this.lstTuAV.ItemHeight = 16;
            this.lstTuAV.Location = new System.Drawing.Point(18, 70);
            this.lstTuAV.Name = "lstTuAV";
            this.lstTuAV.Size = new System.Drawing.Size(225, 228);
            this.lstTuAV.TabIndex = 1;
            this.lstTuAV.SelectedIndexChanged += new System.EventHandler(this.lstTuAV_SelectedIndexChanged);
            this.lstTuAV.DoubleClick += new System.EventHandler(this.lstTuAV_DoubleClick);
            // 
            // cboTuAV
            // 
            this.cboTuAV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTuAV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTuAV.FormattingEnabled = true;
            this.cboTuAV.Location = new System.Drawing.Point(18, 38);
            this.cboTuAV.Name = "cboTuAV";
            this.cboTuAV.Size = new System.Drawing.Size(225, 24);
            this.cboTuAV.TabIndex = 0;
            this.cboTuAV.SelectedIndexChanged += new System.EventHandler(this.cboTuAV_SelectedIndexChanged);
            this.cboTuAV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTuAV_KeyDown);
            // 
            // tabVietAnh
            // 
            this.tabVietAnh.Controls.Add(this.lblNghiaVA);
            this.tabVietAnh.Controls.Add(this.lblTuVA);
            this.tabVietAnh.Controls.Add(this.txtNghiaVA);
            this.tabVietAnh.Controls.Add(this.lstTuVA);
            this.tabVietAnh.Controls.Add(this.cboTuVA);
            this.tabVietAnh.Location = new System.Drawing.Point(4, 25);
            this.tabVietAnh.Name = "tabVietAnh";
            this.tabVietAnh.Padding = new System.Windows.Forms.Padding(3);
            this.tabVietAnh.Size = new System.Drawing.Size(552, 311);
            this.tabVietAnh.TabIndex = 1;
            this.tabVietAnh.Text = "VIỆT - ANH";
            this.tabVietAnh.UseVisualStyleBackColor = true;
            // 
            // lblNghiaVA
            // 
            this.lblNghiaVA.AutoSize = true;
            this.lblNghiaVA.Location = new System.Drawing.Point(260, 15);
            this.lblNghiaVA.Name = "lblNghiaVA";
            this.lblNghiaVA.Size = new System.Drawing.Size(70, 16);
            this.lblNghiaVA.TabIndex = 4;
            this.lblNghiaVA.Text = "Tiếng Anh";
            // 
            // lblTuVA
            // 
            this.lblTuVA.AutoSize = true;
            this.lblTuVA.Location = new System.Drawing.Point(15, 15);
            this.lblTuVA.Name = "lblTuVA";
            this.lblTuVA.Size = new System.Drawing.Size(68, 16);
            this.lblTuVA.TabIndex = 3;
            this.lblTuVA.Text = "Tiếng Việt";
            // 
            // txtNghiaVA
            // 
            this.txtNghiaVA.Location = new System.Drawing.Point(263, 38);
            this.txtNghiaVA.Multiline = true;
            this.txtNghiaVA.Name = "txtNghiaVA";
            this.txtNghiaVA.ReadOnly = true;
            this.txtNghiaVA.Size = new System.Drawing.Size(270, 255);
            this.txtNghiaVA.TabIndex = 2;
            // 
            // lstTuVA
            // 
            this.lstTuVA.FormattingEnabled = true;
            this.lstTuVA.ItemHeight = 16;
            this.lstTuVA.Location = new System.Drawing.Point(18, 70);
            this.lstTuVA.Name = "lstTuVA";
            this.lstTuVA.Size = new System.Drawing.Size(225, 228);
            this.lstTuVA.TabIndex = 1;
            this.lstTuVA.SelectedIndexChanged += new System.EventHandler(this.lstTuVA_SelectedIndexChanged);
            this.lstTuVA.DoubleClick += new System.EventHandler(this.lstTuVA_DoubleClick);
            // 
            // cboTuVA
            // 
            this.cboTuVA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTuVA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTuVA.FormattingEnabled = true;
            this.cboTuVA.Location = new System.Drawing.Point(18, 38);
            this.cboTuVA.Name = "cboTuVA";
            this.cboTuVA.Size = new System.Drawing.Size(225, 24);
            this.cboTuVA.TabIndex = 0;
            this.cboTuVA.SelectedIndexChanged += new System.EventHandler(this.cboTuVA_SelectedIndexChanged);
            this.cboTuVA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTuVA_KeyDown);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(472, 360);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 32);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 400);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabTuDien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabTuDien.ResumeLayout(false);
            this.tabAnhViet.ResumeLayout(false);
            this.tabAnhViet.PerformLayout();
            this.tabVietAnh.ResumeLayout(false);
            this.tabVietAnh.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabTuDien;
        private System.Windows.Forms.TabPage tabAnhViet;
        private System.Windows.Forms.Label lblNghiaAV;
        private System.Windows.Forms.Label lblTuAV;
        private System.Windows.Forms.TextBox txtNghiaAV;
        private System.Windows.Forms.ListBox lstTuAV;
        private System.Windows.Forms.ComboBox cboTuAV;
        private System.Windows.Forms.TabPage tabVietAnh;
        private System.Windows.Forms.Label lblNghiaVA;
        private System.Windows.Forms.Label lblTuVA;
        private System.Windows.Forms.TextBox txtNghiaVA;
        private System.Windows.Forms.ListBox lstTuVA;
        private System.Windows.Forms.ComboBox cboTuVA;
        private System.Windows.Forms.Button btnThoat;
    }
}