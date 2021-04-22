namespace EMP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleBar_panel = new System.Windows.Forms.Panel();
            this.btnAdminManagement = new System.Windows.Forms.Button();
            this.foCUS = new System.Windows.Forms.Panel();
            this.Logo_pbox = new System.Windows.Forms.PictureBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.Min_Button = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnExitTop = new System.Windows.Forms.Button();
            this.MainControl_panel = new System.Windows.Forms.Panel();
            this.Replay_btn = new System.Windows.Forms.Button();
            this.Next_btn = new System.Windows.Forms.Button();
            this.Previous_btn = new System.Windows.Forms.Button();
            this.PlayPause_btn = new System.Windows.Forms.Button();
            this.BelowPanel = new System.Windows.Forms.Panel();
            this.btnPlaylistShow = new System.Windows.Forms.Button();
            this.Volume_trackBar = new System.Windows.Forms.TrackBar();
            this.Volume_btn = new System.Windows.Forms.Button();
            this.FullscreenBtn = new System.Windows.Forms.Button();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.Main_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenMedia_option_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPlaylist_option_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.audioPlayerModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_option_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_option_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.Video_panel = new System.Windows.Forms.Panel();
            this.Playlist_FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewPlay = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.TrackBar = new ColorSlider.ColorSlider();
            this.Player_wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.TitleBar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pbox)).BeginInit();
            this.MainControl_panel.SuspendLayout();
            this.BelowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_trackBar)).BeginInit();
            this.Main_cms.SuspendLayout();
            this.Video_panel.SuspendLayout();
            this.Playlist_FlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player_wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar_panel
            // 
            this.TitleBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.TitleBar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBar_panel.Controls.Add(this.btnAdminManagement);
            this.TitleBar_panel.Controls.Add(this.foCUS);
            this.TitleBar_panel.Controls.Add(this.Logo_pbox);
            this.TitleBar_panel.Controls.Add(this.lblHello);
            this.TitleBar_panel.Controls.Add(this.Min_Button);
            this.TitleBar_panel.Controls.Add(this.btnMax);
            this.TitleBar_panel.Controls.Add(this.btnExitTop);
            this.TitleBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar_panel.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_panel.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBar_panel.Name = "TitleBar_panel";
            this.TitleBar_panel.Size = new System.Drawing.Size(1381, 41);
            this.TitleBar_panel.TabIndex = 1;
            this.TitleBar_panel.Click += new System.EventHandler(this.HidePlaylist_OnClick);
            this.TitleBar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleBar_panel_Paint);
            this.TitleBar_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowMainCms_MouseClick);
            this.TitleBar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // btnAdminManagement
            // 
            this.btnAdminManagement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdminManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.btnAdminManagement.FlatAppearance.BorderSize = 0;
            this.btnAdminManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.btnAdminManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAdminManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminManagement.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminManagement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdminManagement.Image = global::EMP.Properties.Resources.btnPlaylist;
            this.btnAdminManagement.Location = new System.Drawing.Point(588, 0);
            this.btnAdminManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdminManagement.Name = "btnAdminManagement";
            this.btnAdminManagement.Size = new System.Drawing.Size(442, 38);
            this.btnAdminManagement.TabIndex = 13;
            this.btnAdminManagement.TabStop = false;
            this.btnAdminManagement.Text = "Administrator management";
            this.btnAdminManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminManagement.UseVisualStyleBackColor = false;
            this.btnAdminManagement.Click += new System.EventHandler(this.btnManagement);
            // 
            // foCUS
            // 
            this.foCUS.Location = new System.Drawing.Point(536, 6);
            this.foCUS.Margin = new System.Windows.Forms.Padding(4);
            this.foCUS.Name = "foCUS";
            this.foCUS.Size = new System.Drawing.Size(24, 25);
            this.foCUS.TabIndex = 9;
            this.foCUS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // Logo_pbox
            // 
            this.Logo_pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo_pbox.Image = global::EMP.Properties.Resources.btnMedia1;
            this.Logo_pbox.Location = new System.Drawing.Point(-3, 0);
            this.Logo_pbox.Margin = new System.Windows.Forms.Padding(4);
            this.Logo_pbox.Name = "Logo_pbox";
            this.Logo_pbox.Size = new System.Drawing.Size(102, 40);
            this.Logo_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_pbox.TabIndex = 0;
            this.Logo_pbox.TabStop = false;
            this.Logo_pbox.Click += new System.EventHandler(this.MainControl_panel_Click);
            this.Logo_pbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.lblHello.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHello.Location = new System.Drawing.Point(108, 6);
            this.lblHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(77, 32);
            this.lblHello.TabIndex = 6;
            this.lblHello.Text = "hello";
            this.lblHello.Click += new System.EventHandler(this.lblHello_Click);
            this.lblHello.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // Min_Button
            // 
            this.Min_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min_Button.FlatAppearance.BorderSize = 0;
            this.Min_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Min_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min_Button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Min_Button.Location = new System.Drawing.Point(1195, 1);
            this.Min_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Min_Button.Name = "Min_Button";
            this.Min_Button.Size = new System.Drawing.Size(60, 38);
            this.Min_Button.TabIndex = 4;
            this.Min_Button.TabStop = false;
            this.Min_Button.Text = "_";
            this.Min_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Min_Button.UseVisualStyleBackColor = true;
            this.Min_Button.Click += new System.EventHandler(this.Min_Button_Click);
            this.Min_Button.MouseLeave += new System.EventHandler(this.CMM_Buttons_Leave);
            this.Min_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Min_Button_Move);
            this.Min_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(1256, 1);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(60, 37);
            this.btnMax.TabIndex = 3;
            this.btnMax.TabStop = false;
            this.btnMax.Text = "1";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            this.btnMax.MouseLeave += new System.EventHandler(this.CMM_Buttons_Leave);
            this.btnMax.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Max_Button_MouseMove);
            this.btnMax.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // btnExitTop
            // 
            this.btnExitTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitTop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitTop.FlatAppearance.BorderSize = 0;
            this.btnExitTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExitTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitTop.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitTop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitTop.Location = new System.Drawing.Point(1317, 1);
            this.btnExitTop.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitTop.Name = "btnExitTop";
            this.btnExitTop.Size = new System.Drawing.Size(60, 37);
            this.btnExitTop.TabIndex = 2;
            this.btnExitTop.TabStop = false;
            this.btnExitTop.Text = "X";
            this.btnExitTop.UseVisualStyleBackColor = true;
            this.btnExitTop.Click += new System.EventHandler(this.btnExitTop_Click);
            this.btnExitTop.MouseLeave += new System.EventHandler(this.CMM_Buttons_Leave);
            this.btnExitTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cross_Button_MouseMove);
            this.btnExitTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // MainControl_panel
            // 
            this.MainControl_panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MainControl_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.MainControl_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainControl_panel.Controls.Add(this.Replay_btn);
            this.MainControl_panel.Controls.Add(this.Next_btn);
            this.MainControl_panel.Controls.Add(this.Previous_btn);
            this.MainControl_panel.Controls.Add(this.PlayPause_btn);
            this.MainControl_panel.Location = new System.Drawing.Point(635, -4);
            this.MainControl_panel.Margin = new System.Windows.Forms.Padding(0);
            this.MainControl_panel.Name = "MainControl_panel";
            this.MainControl_panel.Size = new System.Drawing.Size(267, 47);
            this.MainControl_panel.TabIndex = 0;
            this.MainControl_panel.Click += new System.EventHandler(this.MainControl_panel_Click);
            // 
            // Replay_btn
            // 
            this.Replay_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Replay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.Replay_btn.FlatAppearance.BorderSize = 0;
            this.Replay_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Replay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Replay_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F);
            this.Replay_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Replay_btn.Image = global::EMP.Properties.Resources.replay;
            this.Replay_btn.Location = new System.Drawing.Point(1, -4);
            this.Replay_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Replay_btn.Name = "Replay_btn";
            this.Replay_btn.Size = new System.Drawing.Size(52, 60);
            this.Replay_btn.TabIndex = 11;
            this.Replay_btn.TabStop = false;
            this.Replay_btn.UseVisualStyleBackColor = false;
            this.Replay_btn.Click += new System.EventHandler(this.Replay_btn_Click);
            this.Replay_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.Replay_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Next_btn
            // 
            this.Next_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.Next_btn.FlatAppearance.BorderSize = 0;
            this.Next_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Next_btn.Image = global::EMP.Properties.Resources.next;
            this.Next_btn.Location = new System.Drawing.Point(145, -4);
            this.Next_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(47, 60);
            this.Next_btn.TabIndex = 10;
            this.Next_btn.TabStop = false;
            this.Next_btn.UseVisualStyleBackColor = false;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            this.Next_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.Next_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Previous_btn
            // 
            this.Previous_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Previous_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.Previous_btn.FlatAppearance.BorderSize = 0;
            this.Previous_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Previous_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Previous_btn.Image = global::EMP.Properties.Resources.back;
            this.Previous_btn.Location = new System.Drawing.Point(53, -4);
            this.Previous_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Previous_btn.Name = "Previous_btn";
            this.Previous_btn.Size = new System.Drawing.Size(47, 60);
            this.Previous_btn.TabIndex = 12;
            this.Previous_btn.TabStop = false;
            this.Previous_btn.UseVisualStyleBackColor = false;
            this.Previous_btn.Click += new System.EventHandler(this.Previous_btn_Click);
            this.Previous_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.Previous_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // PlayPause_btn
            // 
            this.PlayPause_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PlayPause_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.PlayPause_btn.FlatAppearance.BorderSize = 0;
            this.PlayPause_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.PlayPause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayPause_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayPause_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayPause_btn.Location = new System.Drawing.Point(100, -2);
            this.PlayPause_btn.Margin = new System.Windows.Forms.Padding(0);
            this.PlayPause_btn.Name = "PlayPause_btn";
            this.PlayPause_btn.Size = new System.Drawing.Size(52, 53);
            this.PlayPause_btn.TabIndex = 8;
            this.PlayPause_btn.TabStop = false;
            this.PlayPause_btn.Text = "▶ ";
            this.PlayPause_btn.UseVisualStyleBackColor = false;
            this.PlayPause_btn.Click += new System.EventHandler(this.PlayPause_btn_Click);
            this.PlayPause_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.PlayPause_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // BelowPanel
            // 
            this.BelowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BelowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.BelowPanel.Controls.Add(this.btnPlaylistShow);
            this.BelowPanel.Controls.Add(this.Volume_trackBar);
            this.BelowPanel.Controls.Add(this.Volume_btn);
            this.BelowPanel.Controls.Add(this.FullscreenBtn);
            this.BelowPanel.Controls.Add(this.MainControl_panel);
            this.BelowPanel.Location = new System.Drawing.Point(0, 650);
            this.BelowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BelowPanel.Name = "BelowPanel";
            this.BelowPanel.Size = new System.Drawing.Size(1381, 47);
            this.BelowPanel.TabIndex = 3;
            this.BelowPanel.Click += new System.EventHandler(this.HidePlaylist_OnClick);
            this.BelowPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowMainCms_MouseClick);
            // 
            // btnPlaylistShow
            // 
            this.btnPlaylistShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaylistShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.btnPlaylistShow.FlatAppearance.BorderSize = 0;
            this.btnPlaylistShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.btnPlaylistShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylistShow.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylistShow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlaylistShow.Image = global::EMP.Properties.Resources.list;
            this.btnPlaylistShow.Location = new System.Drawing.Point(1268, 4);
            this.btnPlaylistShow.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlaylistShow.Name = "btnPlaylistShow";
            this.btnPlaylistShow.Size = new System.Drawing.Size(56, 39);
            this.btnPlaylistShow.TabIndex = 13;
            this.btnPlaylistShow.TabStop = false;
            this.btnPlaylistShow.UseVisualStyleBackColor = false;
            this.btnPlaylistShow.Click += new System.EventHandler(this.btnPlaylistShow_Click_1);
            this.btnPlaylistShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.btnPlaylistShow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Volume_trackBar
            // 
            this.Volume_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Volume_trackBar.AutoSize = false;
            this.Volume_trackBar.LargeChange = 10;
            this.Volume_trackBar.Location = new System.Drawing.Point(143, 9);
            this.Volume_trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.Volume_trackBar.Maximum = 100;
            this.Volume_trackBar.Name = "Volume_trackBar";
            this.Volume_trackBar.Size = new System.Drawing.Size(133, 33);
            this.Volume_trackBar.TabIndex = 8;
            this.Volume_trackBar.TabStop = false;
            this.Volume_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Volume_trackBar.Value = 100;
            this.Volume_trackBar.Scroll += new System.EventHandler(this.Volume_trackBar_Scroll);
            this.Volume_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Volume_btn
            // 
            this.Volume_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Volume_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(106)))));
            this.Volume_btn.FlatAppearance.BorderSize = 0;
            this.Volume_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Volume_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volume_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Volume_btn.Location = new System.Drawing.Point(84, -55);
            this.Volume_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Volume_btn.Name = "Volume_btn";
            this.Volume_btn.Size = new System.Drawing.Size(52, 101);
            this.Volume_btn.TabIndex = 13;
            this.Volume_btn.TabStop = false;
            this.Volume_btn.Text = " 🔊";
            this.Volume_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Volume_btn.UseVisualStyleBackColor = false;
            this.Volume_btn.Click += new System.EventHandler(this.Volume_btn_Click);
            this.Volume_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // FullscreenBtn
            // 
            this.FullscreenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FullscreenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FullscreenBtn.BackgroundImage")));
            this.FullscreenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FullscreenBtn.FlatAppearance.BorderSize = 0;
            this.FullscreenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.FullscreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullscreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullscreenBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FullscreenBtn.Location = new System.Drawing.Point(1337, 11);
            this.FullscreenBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FullscreenBtn.Name = "FullscreenBtn";
            this.FullscreenBtn.Size = new System.Drawing.Size(27, 25);
            this.FullscreenBtn.TabIndex = 5;
            this.FullscreenBtn.TabStop = false;
            this.FullscreenBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FullscreenBtn.UseVisualStyleBackColor = true;
            this.FullscreenBtn.Click += new System.EventHandler(this.FullscreenBtn_Click);
            this.FullscreenBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 700;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Main_cms
            // 
            this.Main_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Main_cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Main_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMedia_option_cms,
            this.NewPlaylist_option_cms,
            this.audioPlayerModeToolStripMenuItem,
            this.About_option_cms,
            this.Exit_option_cms});
            this.Main_cms.Name = "Main_cms";
            this.Main_cms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Main_cms.Size = new System.Drawing.Size(207, 124);
            this.Main_cms.Opening += new System.ComponentModel.CancelEventHandler(this.Main_cms_Opening);
            // 
            // OpenMedia_option_cms
            // 
            this.OpenMedia_option_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.OpenMedia_option_cms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenMedia_option_cms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.OpenMedia_option_cms.ImageTransparentColor = System.Drawing.Color.Silver;
            this.OpenMedia_option_cms.Name = "OpenMedia_option_cms";
            this.OpenMedia_option_cms.Size = new System.Drawing.Size(206, 24);
            this.OpenMedia_option_cms.Text = "Open Media";
            this.OpenMedia_option_cms.Click += new System.EventHandler(this.OpenMedia_option_cms_Click);
            // 
            // NewPlaylist_option_cms
            // 
            this.NewPlaylist_option_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.NewPlaylist_option_cms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NewPlaylist_option_cms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NewPlaylist_option_cms.Name = "NewPlaylist_option_cms";
            this.NewPlaylist_option_cms.Size = new System.Drawing.Size(206, 24);
            this.NewPlaylist_option_cms.Text = "Playlist Menu";
            this.NewPlaylist_option_cms.Click += new System.EventHandler(this.NewPlaylist_option_cms_Click);
            // 
            // audioPlayerModeToolStripMenuItem
            // 
            this.audioPlayerModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.audioPlayerModeToolStripMenuItem.Name = "audioPlayerModeToolStripMenuItem";
            this.audioPlayerModeToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.audioPlayerModeToolStripMenuItem.Text = "Audio/Video Mode";
            this.audioPlayerModeToolStripMenuItem.Click += new System.EventHandler(this.audioPlayerModeToolStripMenuItem_Click);
            // 
            // About_option_cms
            // 
            this.About_option_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.About_option_cms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.About_option_cms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.About_option_cms.Name = "About_option_cms";
            this.About_option_cms.Size = new System.Drawing.Size(206, 24);
            this.About_option_cms.Text = "About";
            this.About_option_cms.Click += new System.EventHandler(this.About_option_cms_Click);
            // 
            // Exit_option_cms
            // 
            this.Exit_option_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Exit_option_cms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Exit_option_cms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Exit_option_cms.Name = "Exit_option_cms";
            this.Exit_option_cms.Size = new System.Drawing.Size(206, 24);
            this.Exit_option_cms.Text = "Exit";
            this.Exit_option_cms.Click += new System.EventHandler(this.Exit_option_cms_Click);
            // 
            // Video_panel
            // 
            this.Video_panel.AllowDrop = true;
            this.Video_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Video_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.Video_panel.BackgroundImage = global::EMP.Properties.Resources.Logo_12;
            this.Video_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Video_panel.Controls.Add(this.Playlist_FlowPanel);
            this.Video_panel.Controls.Add(this.TrackBar);
            this.Video_panel.Controls.Add(this.Player_wmp);
            this.Video_panel.Location = new System.Drawing.Point(0, 39);
            this.Video_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Video_panel.Name = "Video_panel";
            this.Video_panel.Size = new System.Drawing.Size(1381, 614);
            this.Video_panel.TabIndex = 2;
            this.Video_panel.Click += new System.EventHandler(this.Video_panel_Click);
            this.Video_panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.Video_panel_DragDrop);
            this.Video_panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.Video_panel_DragEnter);
            this.Video_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowMainCms_MouseClick);
            // 
            // Playlist_FlowPanel
            // 
            this.Playlist_FlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.Playlist_FlowPanel.Controls.Add(this.btnNewPlay);
            this.Playlist_FlowPanel.Controls.Add(this.btnSettings);
            this.Playlist_FlowPanel.Controls.Add(this.btnAbout);
            this.Playlist_FlowPanel.Controls.Add(this.btnExit);
            this.Playlist_FlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Playlist_FlowPanel.Location = new System.Drawing.Point(0, 5);
            this.Playlist_FlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.Playlist_FlowPanel.Name = "Playlist_FlowPanel";
            this.Playlist_FlowPanel.Size = new System.Drawing.Size(323, 244);
            this.Playlist_FlowPanel.TabIndex = 10;
            this.Playlist_FlowPanel.Visible = false;
            // 
            // btnNewPlay
            // 
            this.btnNewPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.btnNewPlay.FlatAppearance.BorderSize = 0;
            this.btnNewPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.btnNewPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnNewPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPlay.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewPlay.Image = global::EMP.Properties.Resources.btnPlaylist;
            this.btnNewPlay.Location = new System.Drawing.Point(0, 0);
            this.btnNewPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewPlay.Name = "btnNewPlay";
            this.btnNewPlay.Size = new System.Drawing.Size(313, 60);
            this.btnNewPlay.TabIndex = 13;
            this.btnNewPlay.TabStop = false;
            this.btnNewPlay.Text = "New Playlist";
            this.btnNewPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewPlay.UseVisualStyleBackColor = false;
            this.btnNewPlay.Click += new System.EventHandler(this.btnNewPlay_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSettings.Image = global::EMP.Properties.Resources.btnTools;
            this.btnSettings.Location = new System.Drawing.Point(0, 60);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(313, 60);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAbout.Image = global::EMP.Properties.Resources.btnHelp;
            this.btnAbout.Location = new System.Drawing.Point(0, 120);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(313, 60);
            this.btnAbout.TabIndex = 15;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Image = global::EMP.Properties.Resources.btnExit__2_;
            this.btnExit.Location = new System.Drawing.Point(0, 180);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(313, 60);
            this.btnExit.TabIndex = 16;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TrackBar
            // 
            this.TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TrackBar.BarInnerColor = System.Drawing.Color.DimGray;
            this.TrackBar.BarPenColorBottom = System.Drawing.Color.DarkGray;
            this.TrackBar.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.TrackBar.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TrackBar.ElapsedInnerColor = System.Drawing.Color.Silver;
            this.TrackBar.ElapsedPenColorBottom = System.Drawing.Color.DimGray;
            this.TrackBar.ElapsedPenColorTop = System.Drawing.Color.Silver;
            this.TrackBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.TrackBar.ForeColor = System.Drawing.Color.White;
            this.TrackBar.LargeChange = ((uint)(5u));
            this.TrackBar.Location = new System.Drawing.Point(7, 577);
            this.TrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.ScaleDivisions = 10;
            this.TrackBar.ScaleSubDivisions = 5;
            this.TrackBar.ShowDivisionsText = true;
            this.TrackBar.ShowSmallScale = false;
            this.TrackBar.Size = new System.Drawing.Size(1368, 33);
            this.TrackBar.SmallChange = ((uint)(1u));
            this.TrackBar.TabIndex = 8;
            this.TrackBar.Text = "colorSlider1";
            this.TrackBar.ThumbInnerColor = System.Drawing.Color.DimGray;
            this.TrackBar.ThumbOuterColor = System.Drawing.Color.LightCyan;
            this.TrackBar.ThumbPenColor = System.Drawing.Color.Black;
            this.TrackBar.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.TrackBar.ThumbSize = new System.Drawing.Size(16, 16);
            this.TrackBar.TickAdd = 0F;
            this.TrackBar.TickColor = System.Drawing.Color.Maroon;
            this.TrackBar.TickDivide = 0F;
            this.TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar.Value = 0;
            this.TrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseDown);
            this.TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseUp);
            // 
            // Player_wmp
            // 
            this.Player_wmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player_wmp.Enabled = true;
            this.Player_wmp.Location = new System.Drawing.Point(6, 4);
            this.Player_wmp.Margin = new System.Windows.Forms.Padding(4);
            this.Player_wmp.Name = "Player_wmp";
            this.Player_wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player_wmp.OcxState")));
            this.Player_wmp.Size = new System.Drawing.Size(1025, 511);
            this.Player_wmp.TabIndex = 9;
            this.Player_wmp.Visible = false;
            this.Player_wmp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Player_wmp_PlayStateChange);
            this.Player_wmp.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.Player_wmp_MediaChange);
            this.Player_wmp.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.Player_wmp_ClickEvent);
            this.Player_wmp.Enter += new System.EventHandler(this.Player_wmp_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1381, 697);
            this.Controls.Add(this.TitleBar_panel);
            this.Controls.Add(this.BelowPanel);
            this.Controls.Add(this.Video_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Appliction_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Appliction_KeyUp);
            this.TitleBar_panel.ResumeLayout(false);
            this.TitleBar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pbox)).EndInit();
            this.MainControl_panel.ResumeLayout(false);
            this.BelowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Volume_trackBar)).EndInit();
            this.Main_cms.ResumeLayout(false);
            this.Video_panel.ResumeLayout(false);
            this.Playlist_FlowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player_wmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar_panel;
        private System.Windows.Forms.Button FullscreenBtn;
        private System.Windows.Forms.Button Min_Button;
        private System.Windows.Forms.Button btnExitTop;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.PictureBox Logo_pbox;
        private System.Windows.Forms.Panel MainControl_panel;
        private System.Windows.Forms.Button PlayPause_btn;
        private System.Windows.Forms.Panel BelowPanel;
        private System.Windows.Forms.Button Previous_btn;
        private System.Windows.Forms.Button Replay_btn;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.Button Volume_btn;
        private System.Windows.Forms.TrackBar Volume_trackBar;
        private System.Windows.Forms.Panel foCUS;
        private ColorSlider.ColorSlider TrackBar;
        private System.Windows.Forms.Panel Video_panel;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.ContextMenuStrip Main_cms;
        private System.Windows.Forms.ToolStripMenuItem OpenMedia_option_cms;
        private System.Windows.Forms.ToolStripMenuItem NewPlaylist_option_cms;
        private System.Windows.Forms.ToolStripMenuItem About_option_cms;
        private System.Windows.Forms.ToolStripMenuItem Exit_option_cms;
        private AxWMPLib.AxWindowsMediaPlayer Player_wmp;
        private System.Windows.Forms.Button btnPlaylistShow;
        private System.Windows.Forms.FlowLayoutPanel Playlist_FlowPanel;
        private System.Windows.Forms.ToolStripMenuItem audioPlayerModeToolStripMenuItem;
        private System.Windows.Forms.Button btnNewPlay;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnAdminManagement;
    }
}