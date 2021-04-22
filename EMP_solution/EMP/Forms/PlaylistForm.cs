using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using EMP.Classes;
using System.IO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using EMP.DAL;
using EMP.DTO;
using System.Linq;
using System.Media;

namespace EMP.Forms
{
    public partial class PlaylistForm : Form
    {
        List<string> song_url = new List<string>();
        int rowIndex = -1;
        bool isClick = false;
        WMPLib.IWMPPlaylist playlist;
        public PlaylistForm()
        {
            InitializeComponent();
            //if (!Playlist.IsPlaylistEmpty) UpdateDataGrid();
            StylizeDataGrid();
            //DoClearPlaylist = false;
        }

        public bool DoClearPlaylist { get; set; }

        #region TitleBar

        #region fields

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        private void TitleBar_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        private void Cross_Button_Click(object sender, EventArgs e)
        {
            axWindowsPlayer.close();
            MainForm.Instance.Show();
            this.Close();
        }

        #endregion

        #region Playlist Events

        private void AddFiles_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog
            {
                Multiselect = true,
                //Filter = "Wav(*.wav)|*.wav|Acc(*.aac)|*.aac|Wma(*.wma)|*.wma|Wmv(*.wmv)|*.wmv|Avi(*.avi)|*.avi|Mpg(*.mpg)|*.mpg|Mpeg(*.mpeg)|*.mpeg|M1v(*.m1v)|*.m1v|Mp2(*.mp2)|*.mp2|Mp3(*.mp3)|*.mp3|Mpa(*.mpa)|*.mpa|Mpe(*.mpe)|*.mpe|M3u(*.m3u)|*.m3u|Mp4(*.mp4)|*.mp4|Mov(*.mov)|*.mov|3g2(*.3g2)|*.3g2|3gp2(*.3gp2)|*.3gp2|3gp(*.3gp)|*.3gp|3gpp(*.3gpp)|*.3gpp|M4a(*.m4a)|*.m4a|Cda(*.cda)|*.cda|Aif(*.aif)|*.aif|Aifc(*.aifc)|*.aifc|Aiff(*.aiff)|*.aiff|Mid(*.mid)|*.mid|Midi(*.midi)|*.midi|Rmi(*.rmi)|*.rmi|All files (*.*)|*.*",
                Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV",
                DefaultExt = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV"
            };

            if (od.ShowDialog() == DialogResult.OK)
            {
                this.Playlist_datagrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                foreach (string file in od.FileNames)
                {
                    song_url.Add(file);

                }
            }
            song_url = song_url.Distinct().ToList();
            int i = 1;
            foreach (string file in song_url)
            {
                int n = this.Playlist_datagrid.Rows.Add();
                this.Playlist_datagrid.Rows[n].Cells[0].Value = i++;
                this.Playlist_datagrid.Rows[n].Cells[1].Value = Path.GetFileName(file);
            }
            UpdateDataGrid();
        }

        private void AddFolder_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                string path = fb.SelectedPath;
                string[] songs = Directory.GetFiles(path);
                this.Playlist_datagrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                foreach (string file in songs)
                {
                    song_url.Add(file);
                }
            }
            song_url = song_url.Distinct().ToList();
            int i = 1;
            foreach (string file in song_url)
            {
                int n = this.Playlist_datagrid.Rows.Add();
                this.Playlist_datagrid.Rows[n].Cells[0].Value = i++;
                this.Playlist_datagrid.Rows[n].Cells[1].Value = Path.GetFileName(file);
            }
            UpdateDataGrid();
        }

        private void SavePlaylist_btn_Click(object sender, EventArgs e)
        {
            PlaylistDAL.Instance.deleteItem(Constant.id);

            foreach (string file in song_url)
            {
                if (SongDAL.Instance.getSongByURL(file) == null)
                {
                    SongDAL.Instance.insert(file);
                }
            }

            int count = 0;
            foreach (string file in song_url)
            {
                int id_song = SongDAL.Instance.getIdBySongUrl(file);
                if (!PlaylistDAL.Instance.getItem(Constant.id, id_song))
                {
                    if (PlaylistDAL.Instance.insert(Constant.id, id_song))
                    {
                        count++;
                    }
                    else
                    {
                        MessageBox.Show("Somethine went wrong!", "Thông báo");
                        return;
                    }
                }
            }

            if (count == song_url.Count)
            {
                MessageBox.Show("Lưu playlist thành công", "Thông báo");
            }
        }

        private void NewPlaylist_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Create New Playlist?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DoClearPlaylist = true;
                ClearDataGrid();
            }
        }

        private void LoadPlaylist_btn_Click(object sender, EventArgs e)
        {
            List<Song> songs = PlaylistDAL.Instance.getAllSongBaseOnSongId(
                PlaylistDAL.Instance.getAllSongIDByUserId(Constant.id));
            this.Playlist_datagrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (Song song in songs)
            {
                song_url.Add(song.Url);
            }
            song_url = song_url.Distinct().ToList();
            int i = 1;
            foreach (string file in song_url)
            {
                int n = this.Playlist_datagrid.Rows.Add();
                this.Playlist_datagrid.Rows[n].Cells[0].Value = i++;
                this.Playlist_datagrid.Rows[n].Cells[1].Value = Path.GetFileName(file);
            }
            UpdateDataGrid();
        }

        #endregion

        #region Private Methods

        private void StylizeDataGrid()
        {
            Playlist_datagrid.BorderStyle = BorderStyle.None;
            Playlist_datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Playlist_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Playlist_datagrid.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            Playlist_datagrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Playlist_datagrid.BackgroundColor = Color.White;
            Playlist_datagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Playlist_datagrid.EnableHeadersVisualStyles = false;
            Playlist_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Playlist_datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 12, FontStyle.Bold);
            Playlist_datagrid.DefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            Playlist_datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 59, 122);
            Playlist_datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void UpdateDataGrid()
        {
            //List<string> songs = new List<string>();
            //foreach(DataGridViewRow dataRow in this.Playlist_datagrid.Rows)
            //{
            //    songs.Add(dataRow.Cells[1].Value.ToString());
            //}

            //songs = songs.Distinct().ToList();
            if (this.Playlist_datagrid.Rows.Count != 0)
            {
                Playlist_datagrid.Rows.Clear();
            }
            playlist = axWindowsPlayer.playlistCollection.newPlaylist("myplaylist");
            WMPLib.IWMPMedia media;
            int i = 1;
            foreach (string song in song_url)
            {
                int n = this.Playlist_datagrid.Rows.Add();
                this.Playlist_datagrid.Rows[n].Cells[0].Value = i++;
                this.Playlist_datagrid.Rows[n].Cells[1].Value = Path.GetFileName(song);
                media = axWindowsPlayer.newMedia(song);
                playlist.appendItem(media);
            }

            axWindowsPlayer.currentPlaylist = playlist;
        }

        public void ClearDataGrid()
        {
            if (this.Playlist_datagrid.Rows.Count != 0)
            {
                Playlist_datagrid.Rows.Clear();
            }

            Repeat_check.Checked = AutoPlaylist.AllowRepitition;
            Shuffle_check.Checked = AutoPlaylist.AllowShuffle;
        }


        #endregion

        #region PlayLabel Events
        #endregion

        private void PlaylistForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void Play_lebel_Click(object sender, EventArgs e)
        {

        }

        private void Playlist_datagrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Playlist_datagrid.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.Playlist_datagrid.CurrentCell = this.Playlist_datagrid.Rows[e.RowIndex].Cells[1];
                this.Deletion_cms.Show(this.Playlist_datagrid, e.Location);
                this.Deletion_cms.Show(Cursor.Position);
            }
        }

        private void delete_cmsBtn_Click(object sender, EventArgs e)
        {
            if (!this.Playlist_datagrid.Rows[this.rowIndex].IsNewRow)
            {
                this.Playlist_datagrid.Rows.RemoveAt(this.rowIndex);
                this.song_url.RemoveAt(this.rowIndex);
            }
            UpdateDataGrid();
        }

        private void Playlist_datagrid_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Playlist_datagrid_DragDrop(object sender, DragEventArgs e)
        {
            //try
            //{
            //    string[] filenames = e.Data.GetData(DataFormats.FileDrop) as string[];
            //    FileAttributes fa = File.GetAttributes(filenames[0]);
            //    if (fa == FileAttributes.Directory)
            //    {
            //        foreach (string s in filenames)
            //           // Playlist.AddFolder(s);
            //    }
            //    else Playlist.AddFiles(filenames);
            //}
            //catch { }
            //finally { UpdateDataGrid(); }
        }

        private void PlaylistForm_Load(object sender, EventArgs e)
        {
            this.axWindowsPlayer.settings.autoStart = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Playlist_datagrid.Rows.Count != 0)
            {
                if (!isClick)
                {
                    isClick = true;
                    btnPlay.Text = "Pause";
                    axWindowsPlayer.Ctlcontrols.play();
                }
                else
                {
                    isClick = false;
                    btnPlay.Text = "Play";
                    axWindowsPlayer.Ctlcontrols.pause();
                }
            }
        }

        private void axWindowsPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (isClick)
            {
                axWindowsPlayer.Ctlcontrols.next();
            }
        }

        private void axWindowsPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (this.axWindowsPlayer.currentMedia != null)
                {
                    this.txtNow.Text = (this.axWindowsPlayer.currentMedia.name);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isClick)
            {
                axWindowsPlayer.Ctlcontrols.previous();
            }
        }

        private void Shuffle_check_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Shuffle_check.Checked)
            {
                if (this.Repeat_check.Checked)
                {
                    this.Repeat_check.Checked = !this.Repeat_check.Checked;
                }
                axWindowsPlayer.settings.setMode("shuffle", true);
            }
            else
            {
                axWindowsPlayer.settings.setMode("shuffle", false);
            }
        }

        private void Repeat_check_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Repeat_check.Checked)
            {
                if (this.Shuffle_check.Checked)
                {
                    this.Shuffle_check.Checked = !this.Shuffle_check.Checked;
                }
                axWindowsPlayer.settings.setMode("loop", true);
            }
            else
            {
                axWindowsPlayer.settings.setMode("loop", false);
            }
        }

        private void TitleBar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Deletion_cms_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}