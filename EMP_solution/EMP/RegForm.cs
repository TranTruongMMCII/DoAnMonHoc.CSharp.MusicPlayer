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

namespace EMP
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            picUserName.Image = Properties.Resources.user_login2;
            panel1.BackColor = Color.FromArgb(247, 131, 172);
            txtUserName.ForeColor = Color.FromArgb(247, 131, 172);

            picPass.Image = Properties.Resources.lock_login;
            panel2.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;

            picRePass.Image = Properties.Resources.lock_login;
            panel3.BackColor = Color.WhiteSmoke;
            txtRePass.ForeColor = Color.WhiteSmoke;
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

            picRePass.Image = Properties.Resources.lock_login;
            panel3.BackColor = Color.WhiteSmoke;
            txtRePass.ForeColor = Color.WhiteSmoke;


        }

        private void txtRePass_Click(object sender, EventArgs e)
        {
            txtRePass.Clear();
            picRePass.Image = Properties.Resources.lock2;
            panel3.BackColor = Color.FromArgb(247, 131, 172);
            txtUserName.ForeColor = Color.FromArgb(247, 131, 172);

            picUserName.Image = Properties.Resources.user_login;
            panel1.BackColor = Color.WhiteSmoke;
            txtUserName.ForeColor = Color.WhiteSmoke;

            picPass.Image = Properties.Resources.lock_login;
            panel2.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;
        }

        private void RegForm_Shown(object sender, EventArgs e)
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

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtUserName.Clear();
            picUserName.Image = Properties.Resources.user_login2;
            panel1.BackColor = Color.FromArgb(247, 131, 172);
            txtUserName.ForeColor = Color.FromArgb(247, 131, 172);

            picPass.Image = Properties.Resources.lock_login;
            panel2.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;

            picRePass.Image = Properties.Resources.lock_login;
            panel3.BackColor = Color.WhiteSmoke;
            txtRePass.ForeColor = Color.WhiteSmoke;
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

            picRePass.Image = Properties.Resources.lock_login;
            panel3.BackColor = Color.WhiteSmoke;
            txtRePass.ForeColor = Color.WhiteSmoke;
        }

        private void txtRePass_Enter(object sender, EventArgs e)
        {
            txtRePass.Clear();
            picRePass.Image = Properties.Resources.lock2;
            panel3.BackColor = Color.FromArgb(247, 131, 172);
            txtUserName.ForeColor = Color.FromArgb(247, 131, 172);

            picUserName.Image = Properties.Resources.user_login;
            panel1.BackColor = Color.WhiteSmoke;
            txtUserName.ForeColor = Color.WhiteSmoke;

            picPass.Image = Properties.Resources.lock_login;
            panel2.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult tmp = MessageBox.Show("Are you sure want to exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tmp == DialogResult.Yes)
                Environment.Exit(1);
        }

        void Clear()
        {
            txtUserName.Text = txtPass.Text = txtRePass.Text = "";
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length < 6 || txtPass.Text.Length < 6)
            {
                MessageBox.Show("Length of username and password must be more than 6.");
                Clear();
                txtUserName.Focus();
            }
            else if (txtPass.Text != txtRePass.Text)
            {
                MessageBox.Show("Password do not match.");
                Clear();
                txtUserName.Focus();
            }
            else if (UserDAL.Instance.getUserByUserName(txtUserName.Text) != null)
            {
                MessageBox.Show("User name is '" + txtUserName.Text + "' already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
                txtUserName.Focus();
            }
            else
            {
                if (UserDAL.Instance.insert(txtUserName.Text, txtPass.Text))
                {
                    MessageBox.Show("Registration is successful");
                    LoginForm Logfrm = new LoginForm();
                    this.Close();
                    Logfrm.Show();
                }
                else
                {
                    MessageBox.Show("Somthing went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
