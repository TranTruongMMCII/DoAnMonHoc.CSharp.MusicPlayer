namespace EMP.Forms
{
    partial class PlaylistForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistForm));
            this.TitleBar_panel = new System.Windows.Forms.Panel();
            this.foCUS = new System.Windows.Forms.Panel();
            this.EliteMediaPlayer_label = new System.Windows.Forms.Label();
            this.Cross_Button = new System.Windows.Forms.Button();
            this.Playlist_datagrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFiles_btn = new System.Windows.Forms.Button();
            this.AddFolder_btn = new System.Windows.Forms.Button();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.SavePlaylist_btn = new System.Windows.Forms.Button();
            this.LoadPlaylist_btn = new System.Windows.Forms.Button();
            this.NewPlaylist_btn = new System.Windows.Forms.Button();
            this.Deletion_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete_cmsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.Shuffle_check = new System.Windows.Forms.CheckBox();
            this.Repeat_check = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.txtPrevious = new System.Windows.Forms.Label();
            this.txtNow = new System.Windows.Forms.Label();
            this.txtNext = new System.Windows.Forms.Label();
            this.TitleBar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist_datagrid)).BeginInit();
            this.Menu_panel.SuspendLayout();
            this.Deletion_cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar_panel
            // 
            this.TitleBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.TitleBar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBar_panel.Controls.Add(this.foCUS);
            this.TitleBar_panel.Controls.Add(this.EliteMediaPlayer_label);
            this.TitleBar_panel.Controls.Add(this.Cross_Button);
            this.TitleBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar_panel.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_panel.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBar_panel.Name = "TitleBar_panel";
            this.TitleBar_panel.Size = new System.Drawing.Size(915, 41);
            this.TitleBar_panel.TabIndex = 2;
            this.TitleBar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleBar_panel_Paint);
            this.TitleBar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // foCUS
            // 
            this.foCUS.Location = new System.Drawing.Point(325, 7);
            this.foCUS.Margin = new System.Windows.Forms.Padding(4);
            this.foCUS.Name = "foCUS";
            this.foCUS.Size = new System.Drawing.Size(24, 25);
            this.foCUS.TabIndex = 9;
            // 
            // EliteMediaPlayer_label
            // 
            this.EliteMediaPlayer_label.AutoSize = true;
            this.EliteMediaPlayer_label.BackColor = System.Drawing.Color.Transparent;
            this.EliteMediaPlayer_label.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliteMediaPlayer_label.ForeColor = System.Drawing.Color.White;
            this.EliteMediaPlayer_label.Location = new System.Drawing.Point(8, 5);
            this.EliteMediaPlayer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EliteMediaPlayer_label.Name = "EliteMediaPlayer_label";
            this.EliteMediaPlayer_label.Size = new System.Drawing.Size(151, 29);
            this.EliteMediaPlayer_label.TabIndex = 6;
            this.EliteMediaPlayer_label.Text = "Playlist Menu";
            this.EliteMediaPlayer_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // Cross_Button
            // 
            this.Cross_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cross_Button.FlatAppearance.BorderSize = 0;
            this.Cross_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Cross_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cross_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cross_Button.Location = new System.Drawing.Point(841, 3);
            this.Cross_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Cross_Button.Name = "Cross_Button";
            this.Cross_Button.Size = new System.Drawing.Size(60, 37);
            this.Cross_Button.TabIndex = 2;
            this.Cross_Button.Text = "X";
            this.Cross_Button.UseVisualStyleBackColor = true;
            this.Cross_Button.Click += new System.EventHandler(this.Cross_Button_Click);
            // 
            // Playlist_datagrid
            // 
            this.Playlist_datagrid.AllowDrop = true;
            this.Playlist_datagrid.AllowUserToAddRows = false;
            this.Playlist_datagrid.AllowUserToDeleteRows = false;
            this.Playlist_datagrid.AllowUserToResizeColumns = false;
            this.Playlist_datagrid.AllowUserToResizeRows = false;
            this.Playlist_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Playlist_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Playlist_datagrid.ColumnHeadersHeight = 29;
            this.Playlist_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Playlist_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.Playlist_datagrid.Location = new System.Drawing.Point(494, 130);
            this.Playlist_datagrid.Margin = new System.Windows.Forms.Padding(4);
            this.Playlist_datagrid.Name = "Playlist_datagrid";
            this.Playlist_datagrid.ReadOnly = true;
            this.Playlist_datagrid.RowHeadersWidth = 51;
            this.Playlist_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Playlist_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Playlist_datagrid.Size = new System.Drawing.Size(419, 256);
            this.Playlist_datagrid.TabIndex = 3;
            this.Playlist_datagrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Playlist_datagrid_CellMouseUp);
            this.Playlist_datagrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.Playlist_datagrid_DragDrop);
            this.Playlist_datagrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.Playlist_datagrid_DragEnter);
            // 
            // id
            // 
            this.id.HeaderText = "No.";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // name
            // 
            this.name.HeaderText = "Tên Bài Hát";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // AddFiles_btn
            // 
            this.AddFiles_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.AddFiles_btn.FlatAppearance.BorderSize = 0;
            this.AddFiles_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFiles_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddFiles_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFiles_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFiles_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddFiles_btn.Location = new System.Drawing.Point(14, 426);
            this.AddFiles_btn.Margin = new System.Windows.Forms.Padding(4);
            this.AddFiles_btn.Name = "AddFiles_btn";
            this.AddFiles_btn.Size = new System.Drawing.Size(155, 44);
            this.AddFiles_btn.TabIndex = 4;
            this.AddFiles_btn.Text = "Add Files";
            this.AddFiles_btn.UseVisualStyleBackColor = false;
            this.AddFiles_btn.Click += new System.EventHandler(this.AddFiles_btn_Click);
            // 
            // AddFolder_btn
            // 
            this.AddFolder_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.AddFolder_btn.FlatAppearance.BorderSize = 0;
            this.AddFolder_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFolder_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddFolder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFolder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFolder_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddFolder_btn.Location = new System.Drawing.Point(183, 426);
            this.AddFolder_btn.Margin = new System.Windows.Forms.Padding(4);
            this.AddFolder_btn.Name = "AddFolder_btn";
            this.AddFolder_btn.Size = new System.Drawing.Size(155, 44);
            this.AddFolder_btn.TabIndex = 5;
            this.AddFolder_btn.Text = "Add Folder";
            this.AddFolder_btn.UseVisualStyleBackColor = false;
            this.AddFolder_btn.Click += new System.EventHandler(this.AddFolder_btn_Click);
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.Menu_panel.Controls.Add(this.SavePlaylist_btn);
            this.Menu_panel.Controls.Add(this.LoadPlaylist_btn);
            this.Menu_panel.Controls.Add(this.NewPlaylist_btn);
            this.Menu_panel.Location = new System.Drawing.Point(97, 54);
            this.Menu_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(699, 55);
            this.Menu_panel.TabIndex = 6;
            // 
            // SavePlaylist_btn
            // 
            this.SavePlaylist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.SavePlaylist_btn.FlatAppearance.BorderSize = 0;
            this.SavePlaylist_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SavePlaylist_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.SavePlaylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePlaylist_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlaylist_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SavePlaylist_btn.Location = new System.Drawing.Point(459, 0);
            this.SavePlaylist_btn.Margin = new System.Windows.Forms.Padding(4);
            this.SavePlaylist_btn.Name = "SavePlaylist_btn";
            this.SavePlaylist_btn.Size = new System.Drawing.Size(243, 55);
            this.SavePlaylist_btn.TabIndex = 9;
            this.SavePlaylist_btn.Text = "Save Playlist";
            this.SavePlaylist_btn.UseVisualStyleBackColor = false;
            this.SavePlaylist_btn.Click += new System.EventHandler(this.SavePlaylist_btn_Click);
            // 
            // LoadPlaylist_btn
            // 
            this.LoadPlaylist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.LoadPlaylist_btn.FlatAppearance.BorderSize = 0;
            this.LoadPlaylist_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoadPlaylist_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.LoadPlaylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadPlaylist_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPlaylist_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoadPlaylist_btn.Location = new System.Drawing.Point(229, -1);
            this.LoadPlaylist_btn.Margin = new System.Windows.Forms.Padding(4);
            this.LoadPlaylist_btn.Name = "LoadPlaylist_btn";
            this.LoadPlaylist_btn.Size = new System.Drawing.Size(232, 55);
            this.LoadPlaylist_btn.TabIndex = 8;
            this.LoadPlaylist_btn.Text = "Load Playlist";
            this.LoadPlaylist_btn.UseVisualStyleBackColor = false;
            this.LoadPlaylist_btn.Click += new System.EventHandler(this.LoadPlaylist_btn_Click);
            // 
            // NewPlaylist_btn
            // 
            this.NewPlaylist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.NewPlaylist_btn.FlatAppearance.BorderSize = 0;
            this.NewPlaylist_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewPlaylist_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.NewPlaylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPlaylist_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPlaylist_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NewPlaylist_btn.Location = new System.Drawing.Point(-3, -1);
            this.NewPlaylist_btn.Margin = new System.Windows.Forms.Padding(4);
            this.NewPlaylist_btn.Name = "NewPlaylist_btn";
            this.NewPlaylist_btn.Size = new System.Drawing.Size(232, 55);
            this.NewPlaylist_btn.TabIndex = 7;
            this.NewPlaylist_btn.Text = "New Playlist";
            this.NewPlaylist_btn.UseVisualStyleBackColor = false;
            this.NewPlaylist_btn.Click += new System.EventHandler(this.NewPlaylist_btn_Click);
            // 
            // Deletion_cms
            // 
            this.Deletion_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Deletion_cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Deletion_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete_cmsBtn});
            this.Deletion_cms.Name = "Main_cms";
            this.Deletion_cms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Deletion_cms.Size = new System.Drawing.Size(133, 28);
            this.Deletion_cms.Opening += new System.ComponentModel.CancelEventHandler(this.Deletion_cms_Opening);
            // 
            // delete_cmsBtn
            // 
            this.delete_cmsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.delete_cmsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.delete_cmsBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.delete_cmsBtn.ImageTransparentColor = System.Drawing.Color.Silver;
            this.delete_cmsBtn.Name = "delete_cmsBtn";
            this.delete_cmsBtn.Size = new System.Drawing.Size(132, 24);
            this.delete_cmsBtn.Text = "Remove";
            this.delete_cmsBtn.Click += new System.EventHandler(this.delete_cmsBtn_Click);
            // 
            // axWindowsPlayer
            // 
            this.axWindowsPlayer.Enabled = true;
            this.axWindowsPlayer.Location = new System.Drawing.Point(1, 107);
            this.axWindowsPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.axWindowsPlayer.Name = "axWindowsPlayer";
            this.axWindowsPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsPlayer.OcxState")));
            this.axWindowsPlayer.Size = new System.Drawing.Size(358, 223);
            this.axWindowsPlayer.TabIndex = 11;
            this.axWindowsPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsPlayer_PlayStateChange);
            this.axWindowsPlayer.Enter += new System.EventHandler(this.axWindowsPlayer_Enter);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlay.Location = new System.Drawing.Point(801, 426);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(101, 44);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Location = new System.Drawing.Point(670, 426);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 44);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Shuffle_check
            // 
            this.Shuffle_check.AutoSize = true;
            this.Shuffle_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shuffle_check.Location = new System.Drawing.Point(358, 457);
            this.Shuffle_check.Margin = new System.Windows.Forms.Padding(4);
            this.Shuffle_check.Name = "Shuffle_check";
            this.Shuffle_check.Size = new System.Drawing.Size(109, 33);
            this.Shuffle_check.TabIndex = 10;
            this.Shuffle_check.Text = "Shuffle";
            this.Shuffle_check.UseVisualStyleBackColor = true;
            this.Shuffle_check.CheckedChanged += new System.EventHandler(this.Shuffle_check_CheckedChanged);
            // 
            // Repeat_check
            // 
            this.Repeat_check.AutoSize = true;
            this.Repeat_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repeat_check.Location = new System.Drawing.Point(358, 416);
            this.Repeat_check.Margin = new System.Windows.Forms.Padding(4);
            this.Repeat_check.Name = "Repeat_check";
            this.Repeat_check.Size = new System.Drawing.Size(113, 33);
            this.Repeat_check.TabIndex = 9;
            this.Repeat_check.Text = "Repeat";
            this.Repeat_check.UseVisualStyleBackColor = true;
            this.Repeat_check.CheckedChanged += new System.EventHandler(this.Repeat_check_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(539, 426);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 44);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(494, 390);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(84, 17);
            this.b.TabIndex = 15;
            this.b.Text = "Now playing";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(494, 322);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(63, 17);
            this.a.TabIndex = 16;
            this.a.Text = "Previous";
            this.a.Visible = false;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(494, 390);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(36, 17);
            this.c.TabIndex = 17;
            this.c.Text = "Next";
            this.c.Visible = false;
            // 
            // txtPrevious
            // 
            this.txtPrevious.AutoSize = true;
            this.txtPrevious.Location = new System.Drawing.Point(629, 321);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(0, 17);
            this.txtPrevious.TabIndex = 18;
            // 
            // txtNow
            // 
            this.txtNow.AutoSize = true;
            this.txtNow.Location = new System.Drawing.Point(629, 390);
            this.txtNow.Name = "txtNow";
            this.txtNow.Size = new System.Drawing.Size(0, 17);
            this.txtNow.TabIndex = 18;
            // 
            // txtNext
            // 
            this.txtNext.AutoSize = true;
            this.txtNext.Location = new System.Drawing.Point(629, 390);
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(0, 17);
            this.txtNext.TabIndex = 18;
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(915, 489);
            this.Controls.Add(this.txtNext);
            this.Controls.Add(this.txtNow);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.c);
            this.Controls.Add(this.a);
            this.Controls.Add(this.b);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.axWindowsPlayer);
            this.Controls.Add(this.Shuffle_check);
            this.Controls.Add(this.Repeat_check);
            this.Controls.Add(this.Menu_panel);
            this.Controls.Add(this.AddFolder_btn);
            this.Controls.Add(this.AddFiles_btn);
            this.Controls.Add(this.Playlist_datagrid);
            this.Controls.Add(this.TitleBar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlaylistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "3";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PlaylistForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PlaylistForm_Paint);
            this.TitleBar_panel.ResumeLayout(false);
            this.TitleBar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist_datagrid)).EndInit();
            this.Menu_panel.ResumeLayout(false);
            this.Deletion_cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar_panel;
        private System.Windows.Forms.Panel foCUS;
        private System.Windows.Forms.Label EliteMediaPlayer_label;
        private System.Windows.Forms.Button Cross_Button;
        private System.Windows.Forms.DataGridView Playlist_datagrid;
        private System.Windows.Forms.Button AddFiles_btn;
        private System.Windows.Forms.Button AddFolder_btn;
        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.Button NewPlaylist_btn;
        private System.Windows.Forms.Button SavePlaylist_btn;
        private System.Windows.Forms.Button LoadPlaylist_btn;
        private System.Windows.Forms.ContextMenuStrip Deletion_cms;
        private System.Windows.Forms.ToolStripMenuItem delete_cmsBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsPlayer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox Shuffle_check;
        private System.Windows.Forms.CheckBox Repeat_check;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label txtPrevious;
        private System.Windows.Forms.Label txtNow;
        private System.Windows.Forms.Label txtNext;
    }
}