namespace CRM02
{
    partial class frmTraCuuThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuThongTin));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTraCuu = new System.Windows.Forms.Button();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageThongTin = new System.Windows.Forms.TabPage();
            this.textBoxTieuChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDiemThuong = new System.Windows.Forms.Label();
            this.labelHang = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.tabPageDonHang = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageThongTin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPageDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 55);
            this.panel1.TabIndex = 4;
            // 
            // buttonTraCuu
            // 
            this.buttonTraCuu.BackColor = System.Drawing.Color.Transparent;
            this.buttonTraCuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTraCuu.BackgroundImage")));
            this.buttonTraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTraCuu.FlatAppearance.BorderSize = 0;
            this.buttonTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTraCuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTraCuu.Location = new System.Drawing.Point(669, 18);
            this.buttonTraCuu.Name = "buttonTraCuu";
            this.buttonTraCuu.Size = new System.Drawing.Size(32, 32);
            this.buttonTraCuu.TabIndex = 3;
            this.buttonTraCuu.UseVisualStyleBackColor = false;
            this.buttonTraCuu.Click += new System.EventHandler(this.buttonTraCuu_Click);
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSDT.Location = new System.Drawing.Point(463, 21);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(203, 29);
            this.textBoxSDT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(288, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "    Nhập số điện thoại:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxSDT);
            this.panel2.Controls.Add(this.buttonTraCuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 68);
            this.panel2.TabIndex = 5;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageThongTin);
            this.tabControlMain.Controls.Add(this.tabPageDonHang);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 123);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(989, 385);
            this.tabControlMain.TabIndex = 14;
            // 
            // tabPageThongTin
            // 
            this.tabPageThongTin.Controls.Add(this.textBoxTieuChi);
            this.tabPageThongTin.Controls.Add(this.label6);
            this.tabPageThongTin.Controls.Add(this.panel3);
            this.tabPageThongTin.Location = new System.Drawing.Point(4, 26);
            this.tabPageThongTin.Name = "tabPageThongTin";
            this.tabPageThongTin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThongTin.Size = new System.Drawing.Size(981, 355);
            this.tabPageThongTin.TabIndex = 0;
            this.tabPageThongTin.Text = "Thông tin của tôi";
            this.tabPageThongTin.UseVisualStyleBackColor = true;
            // 
            // textBoxTieuChi
            // 
            this.textBoxTieuChi.BackColor = System.Drawing.Color.White;
            this.textBoxTieuChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTieuChi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxTieuChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTieuChi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTieuChi.Location = new System.Drawing.Point(278, 57);
            this.textBoxTieuChi.Multiline = true;
            this.textBoxTieuChi.Name = "textBoxTieuChi";
            this.textBoxTieuChi.ReadOnly = true;
            this.textBoxTieuChi.Size = new System.Drawing.Size(700, 295);
            this.textBoxTieuChi.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tiêu chí thăng hạng của siêu thị:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelDiemThuong);
            this.panel3.Controls.Add(this.labelHang);
            this.panel3.Controls.Add(this.labelHoTen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 349);
            this.panel3.TabIndex = 14;
            // 
            // labelDiemThuong
            // 
            this.labelDiemThuong.AutoSize = true;
            this.labelDiemThuong.Location = new System.Drawing.Point(18, 88);
            this.labelDiemThuong.Name = "labelDiemThuong";
            this.labelDiemThuong.Size = new System.Drawing.Size(114, 17);
            this.labelDiemThuong.TabIndex = 11;
            this.labelDiemThuong.Text = "Điểm thưởng: N/A";
            // 
            // labelHang
            // 
            this.labelHang.AutoSize = true;
            this.labelHang.Location = new System.Drawing.Point(18, 54);
            this.labelHang.Name = "labelHang";
            this.labelHang.Size = new System.Drawing.Size(136, 17);
            this.labelHang.TabIndex = 10;
            this.labelHang.Text = "Hạnh Thành Viên: N/A";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.Location = new System.Drawing.Point(6, 15);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(177, 25);
            this.labelHoTen.TabIndex = 9;
            this.labelHoTen.Text = "UNKNOWN NAME";
            // 
            // tabPageDonHang
            // 
            this.tabPageDonHang.Controls.Add(this.dataGridView1);
            this.tabPageDonHang.Location = new System.Drawing.Point(4, 26);
            this.tabPageDonHang.Name = "tabPageDonHang";
            this.tabPageDonHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDonHang.Size = new System.Drawing.Size(981, 355);
            this.tabPageDonHang.TabIndex = 1;
            this.tabPageDonHang.Text = "Đơn hàng của tôi";
            this.tabPageDonHang.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(975, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // frmTraCuuThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 508);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTraCuuThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Thông Tin Khách Hàng - Siêu thị Walcool";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageThongTin.ResumeLayout(false);
            this.tabPageThongTin.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPageDonHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTraCuu;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageThongTin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDiemThuong;
        private System.Windows.Forms.Label labelHang;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.TabPage tabPageDonHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxTieuChi;
    }
}