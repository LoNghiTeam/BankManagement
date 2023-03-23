namespace BankManagement
{
    partial class CTaiKhoan
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
            this.dtgvBank = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dpNgaySinh = new RJCodeAdvance.RJControls.RJDatePicker();
            this.tbxName = new RJCodeAdvance.RJControls.RJTextBox();
            this.tbxSTK = new RJCodeAdvance.RJControls.RJTextBox();
            this.tbxSDT = new RJCodeAdvance.RJControls.RJTextBox();
            this.tbxQueQuan = new RJCodeAdvance.RJControls.RJTextBox();
            this.tbxCCCD = new RJCodeAdvance.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new RJCodeAdvance.RJControls.RJButton();
            this.btnSua = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBank)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvBank
            // 
            this.dtgvBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBank.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvBank.Location = new System.Drawing.Point(431, 0);
            this.dtgvBank.Name = "dtgvBank";
            this.dtgvBank.RowHeadersWidth = 51;
            this.dtgvBank.RowTemplate.Height = 24;
            this.dtgvBank.Size = new System.Drawing.Size(405, 360);
            this.dtgvBank.TabIndex = 0;
            this.dtgvBank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBank_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBank);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 360);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dpNgaySinh);
            this.panel2.Controls.Add(this.tbxName);
            this.panel2.Controls.Add(this.tbxSTK);
            this.panel2.Controls.Add(this.tbxSDT);
            this.panel2.Controls.Add(this.tbxQueQuan);
            this.panel2.Controls.Add(this.tbxCCCD);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 360);
            this.panel2.TabIndex = 1;
            // 
            // dpNgaySinh
            // 
            this.dpNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpNgaySinh.BorderSize = 0;
            this.dpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpNgaySinh.Location = new System.Drawing.Point(104, 189);
            this.dpNgaySinh.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpNgaySinh.Name = "dpNgaySinh";
            this.dpNgaySinh.Size = new System.Drawing.Size(308, 35);
            this.dpNgaySinh.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dpNgaySinh.TabIndex = 2;
            this.dpNgaySinh.TextColor = System.Drawing.Color.White;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxName.BorderRadius = 0;
            this.tbxName.BorderSize = 2;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxName.Location = new System.Drawing.Point(104, 45);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Multiline = false;
            this.tbxName.Name = "tbxName";
            this.tbxName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxName.PasswordChar = false;
            this.tbxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxName.PlaceholderText = "";
            this.tbxName.Size = new System.Drawing.Size(308, 35);
            this.tbxName.TabIndex = 1;
            this.tbxName.Texts = "";
            this.tbxName.UnderlinedStyle = false;
            // 
            // tbxSTK
            // 
            this.tbxSTK.BackColor = System.Drawing.SystemColors.Window;
            this.tbxSTK.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxSTK.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxSTK.BorderRadius = 0;
            this.tbxSTK.BorderSize = 2;
            this.tbxSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxSTK.Location = new System.Drawing.Point(104, 93);
            this.tbxSTK.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSTK.Multiline = false;
            this.tbxSTK.Name = "tbxSTK";
            this.tbxSTK.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxSTK.PasswordChar = false;
            this.tbxSTK.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxSTK.PlaceholderText = "";
            this.tbxSTK.Size = new System.Drawing.Size(308, 35);
            this.tbxSTK.TabIndex = 1;
            this.tbxSTK.Texts = "";
            this.tbxSTK.UnderlinedStyle = false;
            // 
            // tbxSDT
            // 
            this.tbxSDT.BackColor = System.Drawing.SystemColors.Window;
            this.tbxSDT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxSDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxSDT.BorderRadius = 0;
            this.tbxSDT.BorderSize = 2;
            this.tbxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxSDT.Location = new System.Drawing.Point(104, 141);
            this.tbxSDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSDT.Multiline = false;
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxSDT.PasswordChar = false;
            this.tbxSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxSDT.PlaceholderText = "";
            this.tbxSDT.Size = new System.Drawing.Size(308, 35);
            this.tbxSDT.TabIndex = 1;
            this.tbxSDT.Texts = "";
            this.tbxSDT.UnderlinedStyle = false;
            // 
            // tbxQueQuan
            // 
            this.tbxQueQuan.BackColor = System.Drawing.SystemColors.Window;
            this.tbxQueQuan.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxQueQuan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxQueQuan.BorderRadius = 0;
            this.tbxQueQuan.BorderSize = 2;
            this.tbxQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQueQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxQueQuan.Location = new System.Drawing.Point(104, 237);
            this.tbxQueQuan.Margin = new System.Windows.Forms.Padding(4);
            this.tbxQueQuan.Multiline = false;
            this.tbxQueQuan.Name = "tbxQueQuan";
            this.tbxQueQuan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxQueQuan.PasswordChar = false;
            this.tbxQueQuan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxQueQuan.PlaceholderText = "";
            this.tbxQueQuan.Size = new System.Drawing.Size(308, 35);
            this.tbxQueQuan.TabIndex = 1;
            this.tbxQueQuan.Texts = "";
            this.tbxQueQuan.UnderlinedStyle = false;
            // 
            // tbxCCCD
            // 
            this.tbxCCCD.BackColor = System.Drawing.SystemColors.Window;
            this.tbxCCCD.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxCCCD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxCCCD.BorderRadius = 0;
            this.tbxCCCD.BorderSize = 2;
            this.tbxCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCCCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxCCCD.Location = new System.Drawing.Point(104, 285);
            this.tbxCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCCCD.Multiline = false;
            this.tbxCCCD.Name = "tbxCCCD";
            this.tbxCCCD.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxCCCD.PasswordChar = false;
            this.tbxCCCD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxCCCD.PlaceholderText = "";
            this.tbxCCCD.Size = new System.Drawing.Size(308, 35);
            this.tbxCCCD.TabIndex = 1;
            this.tbxCCCD.Texts = "";
            this.tbxCCCD.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên KH:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "STK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quê quán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "CCCD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hành động";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.Controls.Add(this.btnSua);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(830, 191);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 0;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 0;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(159, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // CTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CTaiKhoan";
            this.Size = new System.Drawing.Size(836, 572);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBank)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBank;
        private System.Windows.Forms.GroupBox groupBox1;
        private RJCodeAdvance.RJControls.RJButton btnSua;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJTextBox tbxName;
        private RJCodeAdvance.RJControls.RJTextBox tbxSTK;
        private RJCodeAdvance.RJControls.RJTextBox tbxSDT;
        private RJCodeAdvance.RJControls.RJTextBox tbxQueQuan;
        private RJCodeAdvance.RJControls.RJTextBox tbxCCCD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJDatePicker dpNgaySinh;
        private RJCodeAdvance.RJControls.RJButton btnThem;
    }
}
