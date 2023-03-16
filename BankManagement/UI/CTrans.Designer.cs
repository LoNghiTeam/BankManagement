﻿namespace BankManagement
{
    partial class CTrans
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvTrans = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbMaGD = new System.Windows.Forms.CheckBox();
            this.cbNgGui = new System.Windows.Forms.CheckBox();
            this.cbNgNhan = new System.Windows.Forms.CheckBox();
            this.cbTien = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dpNgayGD = new RJCodeAdvance.RJControls.RJDatePicker();
            this.tbxMaGD = new RJCodeAdvance.RJControls.RJTextBox();
            this.tbxNgGui = new RJCodeAdvance.RJControls.RJTextBox();
            this.tbxNgNhan = new RJCodeAdvance.RJControls.RJTextBox();
            this.tbxTienGD = new RJCodeAdvance.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new RJCodeAdvance.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTrans)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvTrans);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 431);
            this.panel1.TabIndex = 4;
            // 
            // dtgvTrans
            // 
            this.dtgvTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTrans.Location = new System.Drawing.Point(439, 55);
            this.dtgvTrans.Name = "dtgvTrans";
            this.dtgvTrans.RowHeadersWidth = 51;
            this.dtgvTrans.RowTemplate.Height = 24;
            this.dtgvTrans.Size = new System.Drawing.Size(430, 376);
            this.dtgvTrans.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm tuỳ chọn";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbMaGD);
            this.flowLayoutPanel1.Controls.Add(this.cbNgGui);
            this.flowLayoutPanel1.Controls.Add(this.cbNgNhan);
            this.flowLayoutPanel1.Controls.Add(this.cbTien);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(863, 34);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbMaGD
            // 
            this.cbMaGD.AutoSize = true;
            this.cbMaGD.Checked = true;
            this.cbMaGD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMaGD.Location = new System.Drawing.Point(3, 3);
            this.cbMaGD.Name = "cbMaGD";
            this.cbMaGD.Size = new System.Drawing.Size(193, 20);
            this.cbMaGD.TabIndex = 2;
            this.cbMaGD.Text = "Tìm kiếm theo mã giao dịch";
            this.cbMaGD.UseVisualStyleBackColor = true;
            // 
            // cbNgGui
            // 
            this.cbNgGui.AutoSize = true;
            this.cbNgGui.Location = new System.Drawing.Point(202, 3);
            this.cbNgGui.Name = "cbNgGui";
            this.cbNgGui.Size = new System.Drawing.Size(192, 20);
            this.cbNgGui.TabIndex = 1;
            this.cbNgGui.Text = "Tìm kiếm theo mã người gửi";
            this.cbNgGui.UseVisualStyleBackColor = true;
            // 
            // cbNgNhan
            // 
            this.cbNgNhan.AutoSize = true;
            this.cbNgNhan.Location = new System.Drawing.Point(400, 3);
            this.cbNgNhan.Name = "cbNgNhan";
            this.cbNgNhan.Size = new System.Drawing.Size(203, 20);
            this.cbNgNhan.TabIndex = 0;
            this.cbNgNhan.Text = "Tìm kiếm theo mã người nhận";
            this.cbNgNhan.UseVisualStyleBackColor = true;
            // 
            // cbTien
            // 
            this.cbTien.AutoSize = true;
            this.cbTien.Location = new System.Drawing.Point(609, 3);
            this.cbTien.Name = "cbTien";
            this.cbTien.Size = new System.Drawing.Size(213, 20);
            this.cbTien.TabIndex = 4;
            this.cbTien.Text = "Tìm kiếm theo số tiền giao dịch";
            this.cbTien.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.dpNgayGD);
            this.groupBox2.Controls.Add(this.tbxMaGD);
            this.groupBox2.Controls.Add(this.tbxNgGui);
            this.groupBox2.Controls.Add(this.tbxNgNhan);
            this.groupBox2.Controls.Add(this.tbxTienGD);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 376);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm nâng cao";
            // 
            // dpNgayGD
            // 
            this.dpNgayGD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpNgayGD.BorderSize = 0;
            this.dpNgayGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpNgayGD.Location = new System.Drawing.Point(131, 166);
            this.dpNgayGD.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpNgayGD.Name = "dpNgayGD";
            this.dpNgayGD.Size = new System.Drawing.Size(280, 35);
            this.dpNgayGD.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dpNgayGD.TabIndex = 14;
            this.dpNgayGD.TextColor = System.Drawing.Color.White;
            // 
            // tbxMaGD
            // 
            this.tbxMaGD.BackColor = System.Drawing.SystemColors.Window;
            this.tbxMaGD.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxMaGD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxMaGD.BorderRadius = 0;
            this.tbxMaGD.BorderSize = 2;
            this.tbxMaGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaGD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxMaGD.Location = new System.Drawing.Point(131, 22);
            this.tbxMaGD.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMaGD.Multiline = false;
            this.tbxMaGD.Name = "tbxMaGD";
            this.tbxMaGD.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxMaGD.PasswordChar = false;
            this.tbxMaGD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxMaGD.PlaceholderText = "";
            this.tbxMaGD.Size = new System.Drawing.Size(280, 35);
            this.tbxMaGD.TabIndex = 9;
            this.tbxMaGD.Texts = "";
            this.tbxMaGD.UnderlinedStyle = false;
            // 
            // tbxNgGui
            // 
            this.tbxNgGui.BackColor = System.Drawing.SystemColors.Window;
            this.tbxNgGui.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxNgGui.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxNgGui.BorderRadius = 0;
            this.tbxNgGui.BorderSize = 2;
            this.tbxNgGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNgGui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxNgGui.Location = new System.Drawing.Point(131, 70);
            this.tbxNgGui.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNgGui.Multiline = false;
            this.tbxNgGui.Name = "tbxNgGui";
            this.tbxNgGui.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxNgGui.PasswordChar = false;
            this.tbxNgGui.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxNgGui.PlaceholderText = "";
            this.tbxNgGui.Size = new System.Drawing.Size(280, 35);
            this.tbxNgGui.TabIndex = 10;
            this.tbxNgGui.Texts = "";
            this.tbxNgGui.UnderlinedStyle = false;
            // 
            // tbxNgNhan
            // 
            this.tbxNgNhan.BackColor = System.Drawing.SystemColors.Window;
            this.tbxNgNhan.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxNgNhan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxNgNhan.BorderRadius = 0;
            this.tbxNgNhan.BorderSize = 2;
            this.tbxNgNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNgNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxNgNhan.Location = new System.Drawing.Point(131, 118);
            this.tbxNgNhan.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNgNhan.Multiline = false;
            this.tbxNgNhan.Name = "tbxNgNhan";
            this.tbxNgNhan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxNgNhan.PasswordChar = false;
            this.tbxNgNhan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxNgNhan.PlaceholderText = "";
            this.tbxNgNhan.Size = new System.Drawing.Size(280, 35);
            this.tbxNgNhan.TabIndex = 11;
            this.tbxNgNhan.Texts = "";
            this.tbxNgNhan.UnderlinedStyle = false;
            // 
            // tbxTienGD
            // 
            this.tbxTienGD.BackColor = System.Drawing.SystemColors.Window;
            this.tbxTienGD.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxTienGD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxTienGD.BorderRadius = 0;
            this.tbxTienGD.BorderSize = 2;
            this.tbxTienGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTienGD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxTienGD.Location = new System.Drawing.Point(131, 214);
            this.tbxTienGD.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTienGD.Multiline = false;
            this.tbxTienGD.Name = "tbxTienGD";
            this.tbxTienGD.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxTienGD.PasswordChar = false;
            this.tbxTienGD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxTienGD.PlaceholderText = "";
            this.tbxTienGD.Size = new System.Drawing.Size(280, 35);
            this.tbxTienGD.TabIndex = 12;
            this.tbxTienGD.Texts = "";
            this.tbxTienGD.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mã giao dịch: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã người gửi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã người nhận:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày giao dịch;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số tiền giao dịch:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(131, 265);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(280, 40);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm nâng cao";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // CTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CTrans";
            this.Size = new System.Drawing.Size(869, 431);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTrans)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvTrans;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox cbNgNhan;
        private System.Windows.Forms.CheckBox cbNgGui;
        private System.Windows.Forms.CheckBox cbMaGD;
        private System.Windows.Forms.CheckBox cbTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private RJCodeAdvance.RJControls.RJDatePicker dpNgayGD;
        private RJCodeAdvance.RJControls.RJTextBox tbxMaGD;
        private RJCodeAdvance.RJControls.RJTextBox tbxNgGui;
        private RJCodeAdvance.RJControls.RJTextBox tbxNgNhan;
        private RJCodeAdvance.RJControls.RJTextBox tbxTienGD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJButton btnTimKiem;
    }
}