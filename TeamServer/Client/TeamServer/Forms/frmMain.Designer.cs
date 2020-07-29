/*
 * Created by SharpDevelop.
 * User: Wittpoth
 * Date: 09.10.2019
 * Time: 12:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TeamServer
{
	partial class frmMain
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox txt_monday;
		private System.Windows.Forms.RichTextBox txt_tuesday;
		private System.Windows.Forms.RichTextBox txt_wednessday;
		private System.Windows.Forms.RichTextBox txt_thursday;
		private System.Windows.Forms.RichTextBox txt_friday;
		private System.Windows.Forms.Label lbl_Users;
		private System.Windows.Forms.Label lbl_Montag;
		private System.Windows.Forms.Label lbl_Dienstag;
		private System.Windows.Forms.Label lbl_Mittwoch;
		private System.Windows.Forms.Label lbl_Donnerstag;
		private System.Windows.Forms.Label lbl_Freitag;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txt_monday = new System.Windows.Forms.RichTextBox();
            this.txt_tuesday = new System.Windows.Forms.RichTextBox();
            this.txt_wednessday = new System.Windows.Forms.RichTextBox();
            this.txt_thursday = new System.Windows.Forms.RichTextBox();
            this.txt_friday = new System.Windows.Forms.RichTextBox();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.lbl_Montag = new System.Windows.Forms.Label();
            this.lbl_Dienstag = new System.Windows.Forms.Label();
            this.lbl_Mittwoch = new System.Windows.Forms.Label();
            this.lbl_Donnerstag = new System.Windows.Forms.Label();
            this.lbl_Freitag = new System.Windows.Forms.Label();
            this.menu_Main = new System.Windows.Forms.MenuStrip();
            this.synchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chk_Autosynch = new System.Windows.Forms.CheckBox();
            this.cbb_Users = new System.Windows.Forms.ComboBox();
            this.tb_Opacity = new System.Windows.Forms.TrackBar();
            this.chk_OnTop = new System.Windows.Forms.CheckBox();
            this.txt_prio = new System.Windows.Forms.RichTextBox();
            this.lbl_Prio = new System.Windows.Forms.Label();
            this.btn_Download = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.grp_Setting = new System.Windows.Forms.GroupBox();
            this.chk_ShowButtons = new System.Windows.Forms.CheckBox();
            this.chk_Logger = new System.Windows.Forms.CheckBox();
            this.chk_SynchOnChange = new System.Windows.Forms.CheckBox();
            this.lbl_Opacity = new System.Windows.Forms.Label();
            this.rtb_Logview = new System.Windows.Forms.RichTextBox();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.tmr_Time = new System.Windows.Forms.Timer(this.components);
            this.cbb_Presets = new System.Windows.Forms.ComboBox();
            this.btn_InsertPreset = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_NewLine = new System.Windows.Forms.Button();
            this.grp_Features = new System.Windows.Forms.GroupBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.chk_InsertOnSelect = new System.Windows.Forms.CheckBox();
            this.grp_Devtools = new System.Windows.Forms.GroupBox();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zweitesFensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.menu_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Opacity)).BeginInit();
            this.grp_Setting.SuspendLayout();
            this.grp_Features.SuspendLayout();
            this.grp_Devtools.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_monday
            // 
            this.txt_monday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monday.Location = new System.Drawing.Point(179, 56);
            this.txt_monday.Name = "txt_monday";
            this.txt_monday.Size = new System.Drawing.Size(120, 285);
            this.txt_monday.TabIndex = 2;
            this.txt_monday.Text = "";
            this.txt_monday.Click += new System.EventHandler(this.txt_monday_Click);
            // 
            // txt_tuesday
            // 
            this.txt_tuesday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tuesday.Location = new System.Drawing.Point(305, 56);
            this.txt_tuesday.Name = "txt_tuesday";
            this.txt_tuesday.Size = new System.Drawing.Size(120, 285);
            this.txt_tuesday.TabIndex = 2;
            this.txt_tuesday.Text = "";
            this.txt_tuesday.Click += new System.EventHandler(this.txt_tuesday_Click);
            // 
            // txt_wednessday
            // 
            this.txt_wednessday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_wednessday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wednessday.Location = new System.Drawing.Point(431, 56);
            this.txt_wednessday.Name = "txt_wednessday";
            this.txt_wednessday.Size = new System.Drawing.Size(116, 285);
            this.txt_wednessday.TabIndex = 2;
            this.txt_wednessday.Text = "";
            this.txt_wednessday.Click += new System.EventHandler(this.txt_wednessday_Click);
            // 
            // txt_thursday
            // 
            this.txt_thursday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thursday.Location = new System.Drawing.Point(553, 56);
            this.txt_thursday.Name = "txt_thursday";
            this.txt_thursday.Size = new System.Drawing.Size(116, 285);
            this.txt_thursday.TabIndex = 2;
            this.txt_thursday.Text = "";
            this.txt_thursday.Click += new System.EventHandler(this.txt_thursday_Click);
            // 
            // txt_friday
            // 
            this.txt_friday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_friday.Location = new System.Drawing.Point(675, 56);
            this.txt_friday.Name = "txt_friday";
            this.txt_friday.Size = new System.Drawing.Size(116, 285);
            this.txt_friday.TabIndex = 2;
            this.txt_friday.Text = "";
            this.txt_friday.Click += new System.EventHandler(this.txt_friday_Click);
            // 
            // lbl_Users
            // 
            this.lbl_Users.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Users.Location = new System.Drawing.Point(135, 20);
            this.lbl_Users.Name = "lbl_Users";
            this.lbl_Users.Size = new System.Drawing.Size(69, 13);
            this.lbl_Users.TabIndex = 3;
            this.lbl_Users.Text = "User:";
            // 
            // lbl_Montag
            // 
            this.lbl_Montag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Montag.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Montag.Location = new System.Drawing.Point(209, 32);
            this.lbl_Montag.Name = "lbl_Montag";
            this.lbl_Montag.Size = new System.Drawing.Size(73, 21);
            this.lbl_Montag.TabIndex = 4;
            this.lbl_Montag.Text = "Montag";
            // 
            // lbl_Dienstag
            // 
            this.lbl_Dienstag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Dienstag.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dienstag.Location = new System.Drawing.Point(335, 32);
            this.lbl_Dienstag.Name = "lbl_Dienstag";
            this.lbl_Dienstag.Size = new System.Drawing.Size(73, 21);
            this.lbl_Dienstag.TabIndex = 5;
            this.lbl_Dienstag.Text = "Dienstag";
            // 
            // lbl_Mittwoch
            // 
            this.lbl_Mittwoch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Mittwoch.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mittwoch.Location = new System.Drawing.Point(465, 32);
            this.lbl_Mittwoch.Name = "lbl_Mittwoch";
            this.lbl_Mittwoch.Size = new System.Drawing.Size(73, 21);
            this.lbl_Mittwoch.TabIndex = 6;
            this.lbl_Mittwoch.Text = "Mittwoch";
            // 
            // lbl_Donnerstag
            // 
            this.lbl_Donnerstag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Donnerstag.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Donnerstag.Location = new System.Drawing.Point(580, 32);
            this.lbl_Donnerstag.Name = "lbl_Donnerstag";
            this.lbl_Donnerstag.Size = new System.Drawing.Size(73, 21);
            this.lbl_Donnerstag.TabIndex = 7;
            this.lbl_Donnerstag.Text = "Donnerstag";
            // 
            // lbl_Freitag
            // 
            this.lbl_Freitag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Freitag.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Freitag.Location = new System.Drawing.Point(718, 32);
            this.lbl_Freitag.Name = "lbl_Freitag";
            this.lbl_Freitag.Size = new System.Drawing.Size(73, 21);
            this.lbl_Freitag.TabIndex = 8;
            this.lbl_Freitag.Text = "Freitag";
            // 
            // menu_Main
            // 
            this.menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.synchToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.menu_Main.Location = new System.Drawing.Point(0, 0);
            this.menu_Main.Name = "menu_Main";
            this.menu_Main.Size = new System.Drawing.Size(1093, 24);
            this.menu_Main.TabIndex = 10;
            this.menu_Main.Text = "menuStrip1";
            // 
            // synchToolStripMenuItem
            // 
            this.synchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverURLToolStripMenuItem,
            this.uploadToolStripMenuItem,
            this.downloadToolStripMenuItem});
            this.synchToolStripMenuItem.Name = "synchToolStripMenuItem";
            this.synchToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.synchToolStripMenuItem.Text = "Server";
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // chk_Autosynch
            // 
            this.chk_Autosynch.AutoSize = true;
            this.chk_Autosynch.Location = new System.Drawing.Point(15, 19);
            this.chk_Autosynch.Name = "chk_Autosynch";
            this.chk_Autosynch.Size = new System.Drawing.Size(76, 17);
            this.chk_Autosynch.TabIndex = 12;
            this.chk_Autosynch.Text = "Autosynch";
            this.chk_Autosynch.UseVisualStyleBackColor = true;
            this.chk_Autosynch.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbb_Users
            // 
            this.cbb_Users.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbb_Users.FormattingEnabled = true;
            this.cbb_Users.Location = new System.Drawing.Point(171, 17);
            this.cbb_Users.Name = "cbb_Users";
            this.cbb_Users.Size = new System.Drawing.Size(98, 21);
            this.cbb_Users.TabIndex = 13;
            this.cbb_Users.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tb_Opacity
            // 
            this.tb_Opacity.Location = new System.Drawing.Point(299, 15);
            this.tb_Opacity.Minimum = 1;
            this.tb_Opacity.Name = "tb_Opacity";
            this.tb_Opacity.Size = new System.Drawing.Size(107, 45);
            this.tb_Opacity.TabIndex = 14;
            this.tb_Opacity.TickFrequency = 100;
            this.tb_Opacity.Value = 1;
            this.tb_Opacity.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // chk_OnTop
            // 
            this.chk_OnTop.AutoSize = true;
            this.chk_OnTop.Location = new System.Drawing.Point(15, 42);
            this.chk_OnTop.Name = "chk_OnTop";
            this.chk_OnTop.Size = new System.Drawing.Size(92, 17);
            this.chk_OnTop.TabIndex = 17;
            this.chk_OnTop.Text = "Always on top";
            this.chk_OnTop.UseVisualStyleBackColor = true;
            this.chk_OnTop.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // txt_prio
            // 
            this.txt_prio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_prio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_prio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prio.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_prio.Location = new System.Drawing.Point(797, 56);
            this.txt_prio.Name = "txt_prio";
            this.txt_prio.Size = new System.Drawing.Size(116, 285);
            this.txt_prio.TabIndex = 2;
            this.txt_prio.Text = "";
            this.txt_prio.Click += new System.EventHandler(this.txt_prio_Click);
            // 
            // lbl_Prio
            // 
            this.lbl_Prio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Prio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Prio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prio.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Prio.Location = new System.Drawing.Point(831, 30);
            this.lbl_Prio.Name = "lbl_Prio";
            this.lbl_Prio.Size = new System.Drawing.Size(52, 23);
            this.lbl_Prio.TabIndex = 8;
            this.lbl_Prio.Text = "PRIO";
            // 
            // btn_Download
            // 
            this.btn_Download.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Download.Image = ((System.Drawing.Image)(resources.GetObject("btn_Download.Image")));
            this.btn_Download.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Download.Location = new System.Drawing.Point(807, 370);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(106, 32);
            this.btn_Download.TabIndex = 18;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Upload.Image = ((System.Drawing.Image)(resources.GetObject("btn_Upload.Image")));
            this.btn_Upload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Upload.Location = new System.Drawing.Point(807, 428);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(106, 34);
            this.btn_Upload.TabIndex = 19;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // grp_Setting
            // 
            this.grp_Setting.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grp_Setting.Controls.Add(this.chk_InsertOnSelect);
            this.grp_Setting.Controls.Add(this.chk_ShowButtons);
            this.grp_Setting.Controls.Add(this.chk_Logger);
            this.grp_Setting.Controls.Add(this.chk_SynchOnChange);
            this.grp_Setting.Controls.Add(this.lbl_Opacity);
            this.grp_Setting.Controls.Add(this.chk_Autosynch);
            this.grp_Setting.Controls.Add(this.tb_Opacity);
            this.grp_Setting.Controls.Add(this.cbb_Users);
            this.grp_Setting.Controls.Add(this.chk_OnTop);
            this.grp_Setting.Controls.Add(this.lbl_Users);
            this.grp_Setting.Location = new System.Drawing.Point(179, 364);
            this.grp_Setting.Name = "grp_Setting";
            this.grp_Setting.Size = new System.Drawing.Size(412, 100);
            this.grp_Setting.TabIndex = 20;
            this.grp_Setting.TabStop = false;
            this.grp_Setting.Text = "Settings";
            // 
            // chk_ShowButtons
            // 
            this.chk_ShowButtons.AutoSize = true;
            this.chk_ShowButtons.Checked = true;
            this.chk_ShowButtons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ShowButtons.Location = new System.Drawing.Point(139, 47);
            this.chk_ShowButtons.Name = "chk_ShowButtons";
            this.chk_ShowButtons.Size = new System.Drawing.Size(92, 17);
            this.chk_ShowButtons.TabIndex = 21;
            this.chk_ShowButtons.Text = "Show Buttons";
            this.chk_ShowButtons.UseVisualStyleBackColor = true;
            this.chk_ShowButtons.CheckedChanged += new System.EventHandler(this.chk_ShowButtons_CheckedChanged);
            // 
            // chk_Logger
            // 
            this.chk_Logger.AutoSize = true;
            this.chk_Logger.Location = new System.Drawing.Point(139, 70);
            this.chk_Logger.Name = "chk_Logger";
            this.chk_Logger.Size = new System.Drawing.Size(105, 17);
            this.chk_Logger.TabIndex = 20;
            this.chk_Logger.Text = "Advanced Mode";
            this.chk_Logger.UseVisualStyleBackColor = true;
            this.chk_Logger.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chk_SynchOnChange
            // 
            this.chk_SynchOnChange.AutoSize = true;
            this.chk_SynchOnChange.Checked = true;
            this.chk_SynchOnChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_SynchOnChange.Location = new System.Drawing.Point(15, 70);
            this.chk_SynchOnChange.Name = "chk_SynchOnChange";
            this.chk_SynchOnChange.Size = new System.Drawing.Size(110, 17);
            this.chk_SynchOnChange.TabIndex = 19;
            this.chk_SynchOnChange.Text = "Synch on change";
            this.chk_SynchOnChange.UseVisualStyleBackColor = true;
            // 
            // lbl_Opacity
            // 
            this.lbl_Opacity.AutoSize = true;
            this.lbl_Opacity.Location = new System.Drawing.Point(325, 37);
            this.lbl_Opacity.Name = "lbl_Opacity";
            this.lbl_Opacity.Size = new System.Drawing.Size(43, 13);
            this.lbl_Opacity.TabIndex = 18;
            this.lbl_Opacity.Text = "Opacity";
            // 
            // rtb_Logview
            // 
            this.rtb_Logview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtb_Logview.Location = new System.Drawing.Point(12, 56);
            this.rtb_Logview.Name = "rtb_Logview";
            this.rtb_Logview.Size = new System.Drawing.Size(160, 408);
            this.rtb_Logview.TabIndex = 21;
            this.rtb_Logview.Text = "-= LOG =-\n...";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(12, 32);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(33, 13);
            this.lbl_Time.TabIndex = 22;
            this.lbl_Time.Text = "TIME";
            // 
            // tmr_Time
            // 
            this.tmr_Time.Enabled = true;
            this.tmr_Time.Interval = 500;
            this.tmr_Time.Tick += new System.EventHandler(this.tmr_Time_Tick);
            // 
            // cbb_Presets
            // 
            this.cbb_Presets.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbb_Presets.FormattingEnabled = true;
            this.cbb_Presets.Items.AddRange(new object[] {
            "Ganzer Tag: ",
            "---------",
            "Morgens:",
            "Mittags:",
            "Nachmittags:",
            "Abends:",
            "Spätdienst:",
            "Frühdienst:",
            "URLAUB",
            "FREI"});
            this.cbb_Presets.Location = new System.Drawing.Point(6, 37);
            this.cbb_Presets.Name = "cbb_Presets";
            this.cbb_Presets.Size = new System.Drawing.Size(117, 21);
            this.cbb_Presets.TabIndex = 23;
            this.cbb_Presets.SelectedIndexChanged += new System.EventHandler(this.cbb_Presets_SelectedIndexChanged);
            // 
            // btn_InsertPreset
            // 
            this.btn_InsertPreset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_InsertPreset.Location = new System.Drawing.Point(6, 64);
            this.btn_InsertPreset.Name = "btn_InsertPreset";
            this.btn_InsertPreset.Size = new System.Drawing.Size(117, 23);
            this.btn_InsertPreset.TabIndex = 24;
            this.btn_InsertPreset.Text = "Insert Template";
            this.btn_InsertPreset.UseVisualStyleBackColor = true;
            this.btn_InsertPreset.Click += new System.EventHandler(this.btn_InsertPreset_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(194, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(318, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(445, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(561, 32);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 25;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(701, 32);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 25;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(811, 32);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 13);
            this.radioButton6.TabIndex = 25;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Click radiobutton first";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Clear.Location = new System.Drawing.Point(133, 64);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(61, 23);
            this.btn_Clear.TabIndex = 27;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_NewLine
            // 
            this.btn_NewLine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_NewLine.Location = new System.Drawing.Point(127, 37);
            this.btn_NewLine.Name = "btn_NewLine";
            this.btn_NewLine.Size = new System.Drawing.Size(67, 23);
            this.btn_NewLine.TabIndex = 29;
            this.btn_NewLine.Text = "New Line";
            this.btn_NewLine.UseVisualStyleBackColor = true;
            this.btn_NewLine.Click += new System.EventHandler(this.btn_NewLine_Click);
            // 
            // grp_Features
            // 
            this.grp_Features.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grp_Features.Controls.Add(this.cbb_Presets);
            this.grp_Features.Controls.Add(this.btn_NewLine);
            this.grp_Features.Controls.Add(this.btn_InsertPreset);
            this.grp_Features.Controls.Add(this.btn_Clear);
            this.grp_Features.Controls.Add(this.label1);
            this.grp_Features.Location = new System.Drawing.Point(601, 364);
            this.grp_Features.Name = "grp_Features";
            this.grp_Features.Size = new System.Drawing.Size(200, 100);
            this.grp_Features.TabIndex = 30;
            this.grp_Features.TabStop = false;
            this.grp_Features.Text = "Quick Features";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk_InsertOnSelect
            // 
            this.chk_InsertOnSelect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chk_InsertOnSelect.AutoSize = true;
            this.chk_InsertOnSelect.Location = new System.Drawing.Point(250, 70);
            this.chk_InsertOnSelect.Name = "chk_InsertOnSelect";
            this.chk_InsertOnSelect.Size = new System.Drawing.Size(146, 17);
            this.chk_InsertOnSelect.TabIndex = 30;
            this.chk_InsertOnSelect.Text = "Paste Template on select";
            this.chk_InsertOnSelect.UseVisualStyleBackColor = true;
            // 
            // grp_Devtools
            // 
            this.grp_Devtools.Controls.Add(this.button2);
            this.grp_Devtools.Controls.Add(this.button1);
            this.grp_Devtools.Location = new System.Drawing.Point(919, 56);
            this.grp_Devtools.Name = "grp_Devtools";
            this.grp_Devtools.Size = new System.Drawing.Size(162, 408);
            this.grp_Devtools.TabIndex = 32;
            this.grp_Devtools.TabStop = false;
            this.grp_Devtools.Text = "Debug Tools";
            this.grp_Devtools.Visible = false;
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zweitesFensterToolStripMenuItem,
            this.visualsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // visualsToolStripMenuItem
            // 
            this.visualsToolStripMenuItem.Name = "visualsToolStripMenuItem";
            this.visualsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualsToolStripMenuItem.Text = "Visuals";
            this.visualsToolStripMenuItem.Click += new System.EventHandler(this.visualsToolStripMenuItem_Click_1);
            // 
            // serverURLToolStripMenuItem
            // 
            this.serverURLToolStripMenuItem.Name = "serverURLToolStripMenuItem";
            this.serverURLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serverURLToolStripMenuItem.Text = "Server URL";
            this.serverURLToolStripMenuItem.Click += new System.EventHandler(this.serverURLToolStripMenuItem_Click_1);
            // 
            // zweitesFensterToolStripMenuItem
            // 
            this.zweitesFensterToolStripMenuItem.Name = "zweitesFensterToolStripMenuItem";
            this.zweitesFensterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zweitesFensterToolStripMenuItem.Text = "Second Window";
            this.zweitesFensterToolStripMenuItem.Click += new System.EventHandler(this.zweitesFensterToolStripMenuItem_Click_1);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 476);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.grp_Devtools);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.grp_Features);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.rtb_Logview);
            this.Controls.Add(this.grp_Setting);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.lbl_Prio);
            this.Controls.Add(this.lbl_Freitag);
            this.Controls.Add(this.lbl_Donnerstag);
            this.Controls.Add(this.lbl_Mittwoch);
            this.Controls.Add(this.lbl_Dienstag);
            this.Controls.Add(this.lbl_Montag);
            this.Controls.Add(this.txt_prio);
            this.Controls.Add(this.txt_friday);
            this.Controls.Add(this.txt_thursday);
            this.Controls.Add(this.txt_wednessday);
            this.Controls.Add(this.txt_tuesday);
            this.Controls.Add(this.txt_monday);
            this.Controls.Add(this.menu_Main);
            this.MainMenuStrip = this.menu_Main;
            this.Name = "frmMain";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.menu_Main.ResumeLayout(false);
            this.menu_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Opacity)).EndInit();
            this.grp_Setting.ResumeLayout(false);
            this.grp_Setting.PerformLayout();
            this.grp_Features.ResumeLayout(false);
            this.grp_Features.PerformLayout();
            this.grp_Devtools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.MenuStrip menu_Main;
        private System.Windows.Forms.ToolStripMenuItem synchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_Autosynch;
        private System.Windows.Forms.ComboBox cbb_Users;
        private System.Windows.Forms.TrackBar tb_Opacity;
        private System.Windows.Forms.CheckBox chk_OnTop;
        private System.Windows.Forms.RichTextBox txt_prio;
        private System.Windows.Forms.Label lbl_Prio;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.GroupBox grp_Setting;
        private System.Windows.Forms.Label lbl_Opacity;
        private System.Windows.Forms.CheckBox chk_SynchOnChange;
        private System.Windows.Forms.RichTextBox rtb_Logview;
        private System.Windows.Forms.CheckBox chk_Logger;
        private System.Windows.Forms.CheckBox chk_ShowButtons;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Timer tmr_Time;
        private System.Windows.Forms.ComboBox cbb_Presets;
        private System.Windows.Forms.Button btn_InsertPreset;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_NewLine;
        private System.Windows.Forms.GroupBox grp_Features;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk_InsertOnSelect;
        private System.Windows.Forms.GroupBox grp_Devtools;
        private System.Windows.Forms.ToolStripMenuItem serverURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zweitesFensterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}
