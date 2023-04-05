﻿namespace BankManagement
{
    partial class FLaiSuat
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChange = new RJCodeAdvance.RJControls.RJButton();
            this.tbxNewRate = new RJCodeAdvance.RJControls.RJTextBox();
            this.cbTypeRate = new RJCodeAdvance.RJControls.RJComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSoDu = new System.Windows.Forms.Label();
            this.lblNguoiNhan = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(327, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lãi suất";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnChange);
            this.panel3.Controls.Add(this.tbxNewRate);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblSoDu);
            this.panel3.Controls.Add(this.lblNguoiNhan);
            this.panel3.Controls.Add(this.lblRate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbTypeRate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 133);
            this.panel3.TabIndex = 2;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChange.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChange.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChange.BorderRadius = 0;
            this.btnChange.BorderSize = 0;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(244, 78);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(71, 32);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Thay đổi";
            this.btnChange.TextColor = System.Drawing.Color.White;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tbxNewRate
            // 
            this.tbxNewRate.BackColor = System.Drawing.SystemColors.Window;
            this.tbxNewRate.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxNewRate.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxNewRate.BorderRadius = 0;
            this.tbxNewRate.BorderSize = 2;
            this.tbxNewRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxNewRate.Location = new System.Drawing.Point(89, 81);
            this.tbxNewRate.Multiline = false;
            this.tbxNewRate.Name = "tbxNewRate";
            this.tbxNewRate.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbxNewRate.PasswordChar = false;
            this.tbxNewRate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxNewRate.PlaceholderText = "";
            this.tbxNewRate.Size = new System.Drawing.Size(150, 29);
            this.tbxNewRate.TabIndex = 5;
            this.tbxNewRate.Texts = "";
            this.tbxNewRate.UnderlinedStyle = false;
            this.tbxNewRate._TextChanged += new System.EventHandler(this.tbxNewRate__TextChanged);
            // 
            // cbTypeRate
            // 
            this.cbTypeRate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTypeRate.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTypeRate.BorderSize = 1;
            this.cbTypeRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTypeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTypeRate.ForeColor = System.Drawing.Color.DimGray;
            this.cbTypeRate.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTypeRate.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTypeRate.ListTextColor = System.Drawing.Color.DimGray;
            this.cbTypeRate.Location = new System.Drawing.Point(92, 7);
            this.cbTypeRate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbTypeRate.MinimumSize = new System.Drawing.Size(150, 25);
            this.cbTypeRate.Name = "cbTypeRate";
            this.cbTypeRate.Padding = new System.Windows.Forms.Padding(1);
            this.cbTypeRate.Size = new System.Drawing.Size(229, 25);
            this.cbTypeRate.TabIndex = 3;
            this.cbTypeRate.Texts = "";
            this.cbTypeRate.OnSelectedIndexChanged += new System.EventHandler(this.cbTypeRate_OnSelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lãi suất mới (%):";
            // 
            // lblSoDu
            // 
            this.lblSoDu.AutoSize = true;
            this.lblSoDu.Location = new System.Drawing.Point(124, 61);
            this.lblSoDu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoDu.Name = "lblSoDu";
            this.lblSoDu.Size = new System.Drawing.Size(0, 13);
            this.lblSoDu.TabIndex = 2;
            // 
            // lblNguoiNhan
            // 
            this.lblNguoiNhan.AutoSize = true;
            this.lblNguoiNhan.Location = new System.Drawing.Point(124, 35);
            this.lblNguoiNhan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNguoiNhan.Name = "lblNguoiNhan";
            this.lblNguoiNhan.Size = new System.Drawing.Size(0, 13);
            this.lblNguoiNhan.TabIndex = 2;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(93, 51);
            this.lblRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(21, 13);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lãi suất hiện tại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn loại lãi suất:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankManagement.Properties.Resources.Asset_2_4x;
            this.pictureBox1.Location = new System.Drawing.Point(120, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 118);
            this.panel1.TabIndex = 2;
            // 
            // FLaiSuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FLaiSuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DieuChinhLaiSuat";
            this.Load += new System.EventHandler(this.FLaiSuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private RJCodeAdvance.RJControls.RJButton btnChange;
        private RJCodeAdvance.RJControls.RJTextBox tbxNewRate;
        private RJCodeAdvance.RJControls.RJComboBox cbTypeRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSoDu;
        private System.Windows.Forms.Label lblNguoiNhan;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}