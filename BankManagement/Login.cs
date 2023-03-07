﻿using BankManagement.Controller;
using BankManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class Login : Form
    {
        DangNhap dangNhap = new DangNhap();
        DBConnection DBConnection = new DBConnection();
        public Login()
        {
            InitializeComponent();
        }

        private void icpbMK_MouseUp(object sender, MouseEventArgs e)
        {
            txtMK.UseSystemPasswordChar = true;
        }

        private void icpbMK_MouseDown(object sender, MouseEventArgs e)
        {
            txtMK.UseSystemPasswordChar = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
           txtTK.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (dangNhap.ktDangNhap(txtTK.Text.ToString(), txtMK.Text.ToString()))
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }

        }

        private void lblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.ShowDialog();
        }

        private void txtTK_Enter(object sender, EventArgs e)
        {
            HintTextNormal(txtTK);
        }
        private void txtTK_Leave(object sender, EventArgs e)
        {
            HintTextNormal(txtTK);
        }
        private void txtMK_Leave(object sender, EventArgs e)
        {
            HintTextPW(txtMK);
        }
        private void txtMK_Enter(object sender, EventArgs e)
        {
            HintTextPW(txtMK);
        }
        private void HintTextPW(TextBox tbx)
        {
            tbx.PasswordChar = '\0';
            if (tbx.Text == tbx.Tag.ToString())
            {
                tbx.Text = "";
                tbx.ForeColor = Color.Black;
                tbx.PasswordChar = '●';
            }
            else if (tbx.Text == "")
            {
                tbx.Text = tbx.Tag.ToString();
                tbx.ForeColor = Color.Silver;
            }
            else
            {
                tbx.PasswordChar = '●';
            }
        }
        private void HintTextNormal(TextBox tbx)
        {
            if (tbx.Text == tbx.Tag.ToString())
            {
                tbx.Text = "";
                tbx.ForeColor = Color.Black;
            }
            else if (tbx.Text == "")
            {
                tbx.Text = tbx.Tag.ToString();
                tbx.ForeColor = Color.Silver;
            }
        }
    }
}