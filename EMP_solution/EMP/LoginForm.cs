using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EMP.DAL;
using EMP.DTO;
using EMP.Classes;

namespace EMP
{
    public partial class LoginForm : Form
    {
        private static LoginForm instance;

        public String txtHello
        {
            get { return txtUserName.Text; }
        }

        public static LoginForm Instance { get => instance??new LoginForm(); set => instance = value; }

        public LoginForm()
        {
            InitializeComponent();
        }
        RegForm Regfrm = new RegForm();
        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            picUserName.Image = Properties.Resources.user_login2;
            panel1.BackColor = Color.FromArgb(247, 131, 172);
            txtUserName.ForeColor = Color.FromArgb(247, 131, 172);

            picPass.Image = Properties.Resources.lock_login;
            panel2.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            picPass.Image = Properties.Resources.lock2;
            panel2.BackColor = Color.FromArgb(247, 131, 172);
            txtUserName.ForeColor = Color.FromArgb(247, 131, 172);

            picUserName.Image = Properties.Resources.user_login;
            panel1.BackColor = Color.WhiteSmoke;
            txtUserName.ForeColor = Color.WhiteSmoke;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtUserName.Focus();
            txtUserName.Clear();
            picUserName.Image = Properties.Resources.user_login2;
            panel1.BackColor = Color.FromArgb(247, 131, 172);
            txtUserName.ForeColor = Color.FromArgb(247, 131, 172);

            picPass.Image = Properties.Resources.lock_login;
            panel2.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;
        }
        #region clear and change color when TAB
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtUserName.Clear();
            picUserName.Image = Properties.Resources.user_login2;
            panel1.BackColor = Color.FromArgb(247, 131, 172);
            txtUserName.ForeColor = Color.FromArgb(247, 131, 172);

            picPass.Image = Properties.Resources.lock_login;
            panel2.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.Clear();
            picPass.Image = Properties.Resources.lock2;
            panel2.BackColor = Color.FromArgb(247, 131, 172);
            txtUserName.ForeColor = Color.FromArgb(247, 131, 172);

            picUserName.Image = Properties.Resources.user_login;
            panel1.BackColor = Color.WhiteSmoke;
            txtUserName.ForeColor = Color.WhiteSmoke;
        }
        #endregion

        private void btnRegister_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Regfrm.Left += 5;
            if (Regfrm.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                Regfrm.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Regfrm.Left -= 5;
            if (Regfrm.Left <= 800)
            {
                timer2.Stop();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Regfrm.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult tmp = MessageBox.Show("Are you sure want to exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tmp == DialogResult.Yes)
                Environment.Exit(1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPass.Text;

            if (username.Equals("HuyDuc") && password.Equals("adminHuyDuc"))
            {
                Constant.isAdmin = true;
            }

            User user = UserDAL.Instance.login(username, password);

            if (user != null)
            {
                Regfrm.Close();
                this.Hide();

                MainForm Mainfrm = new MainForm();
                Mainfrm.Show();

                Mainfrm.take_txtHello = "Hello, " + txtHello;
                Constant.id = user.Id;
                Constant.user_name = user.Username;
            }

            else
            {
                MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
