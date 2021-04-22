using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMP.Classes;
using EMP.DAL;

namespace EMP.Forms
{
    public partial class frmEditDataUser : Form
    {
        private static frmEditDataUser instance;

        public static frmEditDataUser Instance { get => instance ?? new frmEditDataUser(); set => instance = value; }

        public frmEditDataUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Constant.update.Equals("UPDATE"))
            {
                if (this.txtPassword.Text.Length >= 6)
                {
                    UserDAL.Instance.updateUser(Constant.temp_id, txtPassword.Text);
                    this.Close();
                    frmManagement.Instance.Show();
                }
                else
                {
                    MessageBox.Show("Password must have length greater than 6 characters.");
                }
            }
            else
            {
                if (this.txtPassword.Text.Length >= 6)
                {
                    if (UserDAL.Instance.getUserByUserName(txtUsername.Text.Trim()) != null)
                    {
                        MessageBox.Show($"Exist username '{txtUsername.Text}' in database.");
                    }
                    else
                    {
                        UserDAL.Instance.insert(txtUsername.Text, txtPassword.Text);
                        this.Close();
                        frmManagement.Instance.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Password must have length greater than 6 characters.");
                }
            }
        }

        private void frmEditDataUser_Load(object sender, EventArgs e)
        {
            if (Constant.update.Equals("UPDATE"))
            {
                this.txtUsername.ReadOnly = true;
                this.txtUsername.Text = Constant.temp_user;
                this.txtPassword.Focus();
            }
            else
            {
                this.txtUsername.ReadOnly = false;
                this.txtUsername.Text = "";
                this.txtUsername.Focus();
            }
        }

        private void frmEditDataUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmManagement.Instance.Show();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
        }
    }
}
