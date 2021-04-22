using EMP.DAL;
using EMP.DTO;
using EMP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP.Forms
{
    public partial class frmManagement : Form
    {
        private static frmManagement instance;
        int rowIndex = -1;

        public static frmManagement Instance {
            get => instance ?? new frmManagement() ;
            set => instance = value; }

        public frmManagement()
        {
            InitializeComponent();
            this.dgvListUser.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvListUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvListUser.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvListUser.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.dgvListSong.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvListSong.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach(DataGridViewColumn column in this.dgvListUser.Columns)
            {
                column.ContextMenuStrip = this.contextMenuStrip;
            }
        }

        private void dgvListSong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmManagement_Load(object sender, EventArgs e)
        {
            populateUser();
        }

        private void populateUser()
        {
            this.dgvListUser.Rows.Clear();
            this.dgvListUser.Refresh();

            List<User> users = UserDAL.Instance.getUsers();
            int i = 1;
            foreach (User user in users)
            {
                int n = this.dgvListUser.Rows.Add();
                this.dgvListUser.Rows[n].Cells[0].Value = i++;
                this.dgvListUser.Rows[n].Cells[1].Value = user.Id;
                this.dgvListUser.Rows[n].Cells[2].Value = user.Username;
                this.dgvListUser.Rows[n].Cells[3].Value = user.Password;
            }

            populateSong(PlaylistDAL.Instance.getAllSongBaseOnSongId(
                PlaylistDAL.Instance.getAllSongIDByUserId(
                    Convert.ToInt32(this.dgvListUser.Rows[0].Cells[1].Value.ToString()))));

            this.dgvListUser.CurrentCell =
                this.dgvListUser.Rows[0].Cells[0];
            this.dgvListUser.Rows[0].Cells[0].Selected = true;
        }

        private void dgvListUser_SelectionChanged(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = this.dgvListUser.SelectedCells[0].RowIndex;
            }
            catch (Exception)
            {
                pos = 0;                
            }
            DataGridViewRow data = (DataGridViewRow)this.dgvListUser.Rows[pos];
            if (data != null)
            {
                List<Song> songs = new List<Song>();
                songs = PlaylistDAL.Instance.getAllSongBaseOnSongId(
                PlaylistDAL.Instance.getAllSongIDByUserId(
                    Convert.ToInt32(data.Cells[1].Value)));

                populateSong(songs);
            }
        }

        private void populateSong(List<Song> songs)
        {
            this.dgvListSong.Rows.Clear();
            this.dgvListSong.Refresh();

            int i = 1;
            foreach (Song song in songs)
            {
                int n = this.dgvListSong.Rows.Add();
                this.dgvListSong.Rows[n].Cells[0].Value = i++;
                this.dgvListSong.Rows[n].Cells[1].Value = Path.GetFileName(song.Url);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgvListUser.Rows[this.rowIndex].IsNewRow)
            {
                //this.dgvListUser.Rows.RemoveAt(this.rowIndex);
                int pos = Convert.ToInt32(this.dgvListUser.Rows[rowIndex].Cells[1].Value);
                PlaylistDAL.Instance.deleteItem(pos);
                UserDAL.Instance.deleteUser(pos);
                ////this.dgvListUser.Rows.RemoveAt(this.rowIndex);
                populateUser();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvListUser_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dgvListSong_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dgvListSong_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.rowIndex = e.RowIndex;
            }
        }

        private void dgvListUser_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.rowIndex = e.RowIndex;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Constant.update = "CREATE";
            this.Close();
            frmEditDataUser.Instance.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Constant.update = "UPDATE";
            DataGridViewRow dataRow = this.dgvListUser.SelectedCells[0].OwningRow;
            if (dataRow == null || dataRow.Cells[0].Value == null)
            {
                MessageBox.Show("Please choose one row data.");
            }
            else
            {
                Constant.temp_id = Convert.ToInt32(dataRow.Cells[1].Value);
                Constant.temp_user = dataRow.Cells[2].Value.ToString();
                this.Close();
                frmEditDataUser.Instance.Show();
            }
        }

        private void frmManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Instance.Show();
        }
    }
}
