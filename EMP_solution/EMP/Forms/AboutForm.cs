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
using EMP.Classes;
using EMP.DTO;
namespace EMP.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            //ShowDialog();
        }

        private void Cross_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-VQOFGMQ\SQLEXPRESS;Initial Catalog=appmusic;Integrated Security=True");
        private void btnChange_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text == txtConfirmPass.Text)
            {
                User user = UserDAL.Instance.getUserById(Constant.id);
                if (user.Username != txtUsername.Text || user.Password != txtPass.Text)
                {
                    errorProvider1.SetError(txtUsername, "Wrong username or password");
                }
                else
                {
                    if(UserDAL.Instance.updateUser(Constant.id, txtNewPass.Text))
                    {
                        MessageBox.Show("Password Changed !!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!", "Thông báo.");
                    }
                }
            }
            else
            {
                errorProvider1.SetError(txtNewPass, "Unmatch Password");
                errorProvider1.SetError(txtConfirmPass, "Unmatch Password");
            }    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
