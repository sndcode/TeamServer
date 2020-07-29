using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Drawing;

/*
 * Teamserver Client is a proof of concept software to set tasks of workers for weekdays.
 * 
 * Features : 
 * Secured traffic over HTTPS supported 
 * MYSQL and PHP Backend
 * SQLi save scripts
 * Realtime refreshing system 
 * Templates for the calendar entries
 * Easy UI
 * Settings storing (TODO)
 * Updates notifications
 * Log function to detect problems
 * 
 * 
 */


namespace TeamServer
{
    public partial class frmMain : Form
    {
        //Setting up variables to hold stuff
        public static string appversion             = "0.4.0b";
        public static string s_username             = "";
        public static string server_url             = "";
        public static int global_opacity            = 0;
        //Settingsfile will be stored in the current users appdata folder
        public static string settingspath           = "C:\\users\\" + Environment.UserName + "\\AppData\\Roaming\\teamserver.ini";
        //Setting up the current version of the client
        public static string server_version         = "";
        public static string version_local          = "";
        public static bool serverbranchnewer;
        public static string s_localbranch          = "";
        public static string s_serverbranch         = "";
        public static string server_version_url     =  "/updates/latest.ini";
        public static string userlist_url           = server_url + "/users.ini";
        public static string userlist;
        //Radiobuttons
        public static int radiobutton               = 0;
        
        public bool updateAvailable()
        {
            alog("init settings ini");
            var ini = new classINI(settingspath);
            server_url = ini.Read("url");
            alog("read the settings");
            try
            {
                alog("Checking for update");
                WebClient wc = new WebClient();
                string serverversion_todisplay = wc.DownloadString(server_url + server_version_url);
                alog("parsing server version");
                string serverversion = serverversion_todisplay.Replace(".", "");
                string localversion = appversion.Replace(".", "");
                server_version = serverversion_todisplay;
                version_local = localversion;
                alog("re-store version informations");
                string serverbranch = "";
                string localbranch = "";
                alog("calculating branch");
                if (serverversion.Contains("a"))
                {
                    serverbranch = "alpha";
                }
                else if (serverversion.Contains("b"))
                {
                    serverbranch = "beta";
                }
                else if (serverversion.Contains("r"))
                {
                    serverbranch = "release";
                }
                if (localversion.Contains("a"))
                {
                    localbranch = "alpha";
                }
                else if (localversion.Contains("b"))
                {
                    localbranch = "beta";
                }
                else if (localversion.Contains("r"))
                {
                    localbranch = "release";
                }

                if (serverbranch == "alpha" && localbranch == "alpha")
                {
                    serverbranchnewer = true;
                }
                else if (serverbranch == "alpha" && localbranch == "beta")
                {
                    serverbranchnewer = false;
                }
                else if (serverbranch == "alpha" && localbranch == "release")
                {
                    serverbranchnewer = false;
                }
                else if (serverbranch == "beta" && localbranch == "alpha")
                {
                    serverbranchnewer = true;
                }
                else if (serverbranch == "release" && localbranch == "alpha")
                {
                    serverbranchnewer = true;
                }
                else if (serverbranch == "beta" && localbranch == "beta")
                {
                    serverbranchnewer = false;
                }
                else if (serverbranch == "release" && localbranch == "beta")
                {
                    serverbranchnewer = true;
                }
                //Convert
                s_localbranch = localbranch;
                s_serverbranch = serverbranch;

                alog("branches set.");

                if (serverversion != localversion)
                {
                    string serverversion02  = Regex.Replace(serverversion.Replace("0", "")  , "[^.0-9]", "");
                    string localversion02   = Regex.Replace(localversion.Replace("0", "")   , "[^.0-9]", "");

                    int iserver = Convert.ToInt32(serverversion02);
                    int ilocal  = Convert.ToInt32(localversion02);

                    alog("checking versions against eachother");
                    if (iserver > ilocal && serverbranchnewer)
                    {
                        alog("server is newer");
                        return true;
                    }
                    else if (iserver < ilocal && !serverbranchnewer)
                    {
                        alog("local is newer but not branch");
                        return false;
                    }
                    else if (iserver < ilocal && serverbranchnewer)
                    {
                        alog("local is newer but serverbranch is newer");
                        return true;
                    }
                    else if (iserver > ilocal && !serverbranchnewer)
                    {
                        alog("server is newer and local branch is not newer.");
                        return true;
                    }
                }
                alog("method returned false");
                return false;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                alog("method returned false");
                return false; 
            }
        }
        public static void downloadUserlist()
        {
            try
            {
                WebClient uld = new WebClient();
                userlist = uld.DownloadString(server_url + "/s_totalusers.php");
            }
            catch(Exception e) 
            {
                MessageBox.Show("Please setup teamserver clientsoftware now." +
                    "\nYou will need to enter the domain with URL where your " +
                    "calendar database is located!");
                frmServerurl ss = new frmServerurl();
                ss.ShowDialog();
            }
        }
        public void getUserlist()
        {
            downloadUserlist();
            string str = userlist;
            var strsplited = str.Split(",".ToCharArray());
            foreach (var VARIABLE in strsplited)
            {
                cbb_Users.Items.Add(VARIABLE);
            }
        }
        public static void checkFiles()
        {
            if (!File.Exists(settingspath))
            { 
                var settingFile = File.Create(settingspath); settingFile.Close(); 
            }
        }
        public void alog(string logtext)
        {
            string time = DateTime.Now.ToString();
            rtb_Logview.Invoke(new Action(() =>
            {
                rtb_Logview.AppendText("\n" + "[" + time + "] " + logtext);
                // set the current caret position to the end
                rtb_Logview.SelectionStart = rtb_Logview.Text.Length;
                // scroll it automatically
                rtb_Logview.ScrollToCaret();
            }));
        }
        public static string FontToString(Font font)//https://stackoverflow.com/questions/2207709/convert-font-to-string-and-back-again
        {
            return font.FontFamily.Name + ":" + font.Size + ":" + (int)font.Style;
        }

        public static Font StringToFont(string font)//https://stackoverflow.com/questions/2207709/convert-font-to-string-and-back-again
        {
            string[] parts = font.Split(':');
            if (parts.Length != 3)
                throw new ArgumentException("Not a valid font string", "font");

            Font loadedFont = new Font(parts[0], float.Parse(parts[1]), (FontStyle)int.Parse(parts[2]));
            return loadedFont;
        }
        public void f_init()
        {
            alog("Initializing now");
            rtb_Logview.Visible = false;
            this.Width = 822;
            lbl_Time.Visible = false;
            var inif = new classINI(settingspath);
            string tempfont = inif.Read("font");
            //ts(StringToFont(tempfont));

            alog("UI init done");
            try
            {
                alog("reading settings");
                var ini = new classINI(settingspath);
                server_url = ini.Read("url");
                alog("Checking files");
                checkFiles(); 
                getUserlist(); 
                alog("loading users from database");
                this.Text += " - connected to server on : " + server_url;
            }
            catch(Exception e){
                MessageBox.Show(e.ToString()); ; frmServerurl ss = new frmServerurl();
                ss.ShowDialog();
            }
            
            WebRequest.DefaultWebProxy = null; alog("Proxy set");
            System.Windows.Forms.Timer heartbeat = new System.Windows.Forms.Timer();

            alog("calculating correct opacity");

            tb_Opacity.Value = 10;
            int actualOpacity = 0;
            actualOpacity = tb_Opacity.Value;
            global_opacity = Convert.ToInt32(this.Opacity);
            this.Opacity = ((double)(tb_Opacity.Value) / 10.0);
            alog("opacity set");

        }
        void f_read()
        {
            alog("f_read called");
            //this.Text += " - connected to server on : " + server_url;
            new Thread((reader) =>
            {
                alog("starting new thread");
                Thread.CurrentThread.IsBackground = true;
                try
                {
                    string user = "";
                    WebClient wc = new WebClient();
                    wc.Proxy = null;
                    wc.Encoding = System.Text.Encoding.UTF8;
                    cbb_Users.Invoke(new Action(() =>
                    {
                        s_username = cbb_Users.Text;
                        user = cbb_Users.Text;
                    }));

                    alog("downloading data");

                    string montag       = wc.DownloadString(server_url      + "/s_read.php?user=" + user + "&day=" + "montag");
                    string dienstag     = wc.DownloadString(server_url      + "/s_read.php?user=" + user + "&day=" + "dienstag");
                    string mittwoch     = wc.DownloadString(server_url      + "/s_read.php?user=" + user + "&day=" + "mittwoch");
                    string donnerstag   = wc.DownloadString(server_url      + "/s_read.php?user=" + user + "&day=" + "donnerstag");
                    string freitag      = wc.DownloadString(server_url      + "/s_read.php?user=" + user + "&day=" + "freitag");
                    string prio_text    = wc.DownloadString(server_url      + "/s_read.php?user=" + user + "&day=" + "prio1");

                    wc.Dispose();

                    alog("Closed connection.");
                    alog("download done.");

                    txt_monday.Invoke(new Action(() =>
                    {
                        txt_monday.Text = montag;
                    }));
                    txt_tuesday.Invoke(new Action(() =>
                    {
                        txt_tuesday.Text = dienstag;
                    }));
                    txt_wednessday.Invoke(new Action(() =>
                    {
                        txt_wednessday.Text = mittwoch;
                    }));
                    txt_thursday.Invoke(new Action(() =>
                    {
                        txt_thursday.Text = donnerstag;
                    }));
                    txt_friday.Invoke(new Action(() =>
                    {
                        txt_friday.Text = freitag;
                    }));
                    txt_prio.Invoke(new Action(() =>
                    {
                        txt_prio.Text = prio_text;
                    }));

                    alog("Filled textboxes");
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.ToString());
                }

            }).Start();
            
        }
        void f_write()
        {
            alog("building stack to send");
            string montag       = txt_monday.Text;
            string dienstag     = txt_tuesday.Text;
            string mittwoch     = txt_wednessday.Text;
            string donnerstag   = txt_thursday.Text;
            string freitag      = txt_friday.Text;
            string prio_text    = txt_prio.Text;

            new Thread((writer) =>
            {
                alog("starting new thread");
                string user = "";
                
                Thread.CurrentThread.IsBackground = true;
                cbb_Users.Invoke(new Action(() =>
                {
                    user = cbb_Users.Text;
                }));
                
                WebClient wc = new WebClient();
                wc.Proxy = null;
                wc.Encoding = System.Text.Encoding.UTF8;

                try
                {
                    alog("uploading");
                    wc.UploadString(server_url + "/s_write.php?user=" + user + "&day=" + "montag" + "&text=" + montag, "");
                    wc.UploadString(server_url + "/s_write.php?user=" + user + "&day=" + "dienstag" + "&text=" + dienstag, "");
                    wc.UploadString(server_url + "/s_write.php?user=" + user + "&day=" + "mittwoch" + "&text=" + mittwoch, "");
                    wc.UploadString(server_url + "/s_write.php?user=" + user + "&day=" + "donnerstag" + "&text=" + donnerstag, "");
                    wc.UploadString(server_url + "/s_write.php?user=" + user + "&day=" + "freitag" + "&text=" + freitag, "");
                    wc.UploadString(server_url + "/s_write.php?user=" + user + "&day=" + "prio1" + "&text=" + prio_text, "");
                    wc.Dispose();
                    alog("upload finished");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }).Start();
        }

        public frmMain()
        {
            InitializeComponent();
        }
        void MainFormLoad(object sender, EventArgs e)
        {
            #if DEBUG
            grp_Devtools.Visible = true;
            #endif
            try { f_init(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void f_controls(bool enabled)
        {
            txt_monday.Enabled      = enabled;
            txt_tuesday.Enabled     = enabled;
            txt_wednessday.Enabled  = enabled;
            txt_thursday.Enabled    = enabled;
            txt_friday.Enabled      = enabled;
            cbb_Users.Enabled       = enabled;
            btn_Clear.Enabled       = enabled;
            btn_InsertPreset.Enabled = enabled;
            btn_NewLine.Enabled     = enabled;
        }
        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s_username = cbb_Users.Text;
            if (s_username != "")
            {
                try 
                { 
                    f_controls(false); 
                    f_read(); } 
                catch { }

                f_controls(true);
            }
            else
            {
                MessageBox.Show("No username given");
            }
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            upload();
        }
        void syncher_working(object sender, EventArgs e)
        {
            if (chk_Autosynch.Checked == true)
            {
                f_read();
            }
            else if (chk_Autosynch.Checked == false)
            { }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            alog("autosynch toggled");
            if (chk_Autosynch.Checked == true)
            {
                System.Windows.Forms.Timer syncher = new System.Windows.Forms.Timer();
                syncher.Interval = 5000;
                syncher.Enabled = true;
                syncher.Tick += new EventHandler(syncher_working);
                f_controls(false);
                syncher.Start();
            }
            else if (chk_Autosynch.Checked == false)
            {
                System.Windows.Forms.Timer syncher = new System.Windows.Forms.Timer();
                syncher.Enabled = false;
                syncher.Stop();
                f_controls(true);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            alog("saving settings");
            //var ini = new classINI(settingspath);
            //ini.Write("opacity", global_opacity.ToString());
            //ini.Write("","");
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            alog("Changed opacity , recalculating");
            int actualOpacity;
            actualOpacity = tb_Opacity.Value;
            global_opacity = Convert.ToInt32(ActiveForm.Opacity);
            System.Windows.Forms.Form.ActiveForm.Opacity = ((double)(tb_Opacity.Value) / 10.0);
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_OnTop.Checked == true)
            {
                this.TopMost = true;
            }
            else if (chk_OnTop.Checked == false)
            {
                this.TopMost = false;
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            var ini = new classINI(settingspath);
            try
            {
                server_url = ini.Read("url");
            }
            catch
            {
                server_url = "SET SERVER URL";
            }
            s_username = cbb_Users.Text;
            if (s_username != "")
            {
                try
                {
                    f_controls(false);
                    f_read();
                }
                catch { MessageBox.Show("Connection failed."); }

                f_controls(true);
            }
            else
            {
                MessageBox.Show("No username given");
            }
        }
        public void upload()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to upload this?", "?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (s_username != "" && txt_monday.Text != "")
                {
                    f_write();
                }
                else
                {
                    MessageBox.Show("No username given or empty calendar");
                }
            }
            else if (dialogResult == DialogResult.No)
            { }
        }
        private void btn_Upload_Click(object sender, EventArgs e)
        {
            upload();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            downloadUserlist();
            if (chk_SynchOnChange.Checked)
            {
                f_read();
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(!chk_Logger.Checked)
            {
                lbl_Time.Visible = false;
                rtb_Logview.Visible = false;
                this.Width = 822;
            }
            else
            {
                lbl_Time.Visible = true;
                rtb_Logview.Visible = true;
                this.Width = 1107;
            }
        }

        private void chk_ShowButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowButtons.Checked) 
            {
                btn_Download.Visible = true;
                btn_Upload.Visible = true;
            }
            else
            {
                btn_Download.Visible = false;
                btn_Upload.Visible = false;
            }
        }

        private void tmr_Time_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString();
        }

        public void set_Selected()
        {
            if (radioButton1.Checked)
            {
                radiobutton = 1;
            }
            else if (radioButton2.Checked)
            {
                radiobutton = 2;
            }
            else if (radioButton3.Checked)
            {
                radiobutton = 3;
            }
            else if (radioButton4.Checked)
            {
                radiobutton = 4;
            }
            else if (radioButton5.Checked)
            {
                radiobutton = 5;
            }
            else if (radioButton6.Checked)
            {
                radiobutton = 6;
            }
        }
        private void btn_InsertPreset_Click(object sender, EventArgs e)
        {
            if(cbb_Presets.Text != "")
            {
                set_Selected();
                switch (radiobutton)
                {
                    case 0:
                        MessageBox.Show("Nothing selected.");
                        break;
                    case 1:
                        txt_monday.Text += cbb_Presets.Text + "\n";
                        break;
                    case 2:
                        txt_tuesday.Text += cbb_Presets.Text + "\n";
                        break;
                    case 3:
                        txt_wednessday.Text += cbb_Presets.Text + "\n";
                        break;
                    case 4:
                        txt_thursday.Text += cbb_Presets.Text + "\n";
                        break;
                    case 5:
                        txt_friday.Text += cbb_Presets.Text + "\n";
                        break;
                    case 6:
                        txt_prio.Text += cbb_Presets.Text + "\n";
                        break;
                    default:
                        
                        break;
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            set_Selected();
            switch (radiobutton)
            {
                case 0:
                    MessageBox.Show("Nothing selected.");
                    break;
                case 1:
                    txt_monday.Text = "";
                    break;
                case 2:
                    txt_tuesday.Text = "";
                    break;
                case 3:
                    txt_wednessday.Text = "";
                    break;
                case 4:
                    txt_thursday.Text = "";
                    break;
                case 5:
                    txt_friday.Text = "";
                    break;
                case 6:
                    txt_prio.Text = "";
                    break;
                default:

                    break;
            }
        }

        private void txt_monday_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void txt_tuesday_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void txt_wednessday_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void txt_thursday_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void txt_friday_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
        }

        private void txt_prio_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = true;
        }

        private void btn_NewLine_Click(object sender, EventArgs e)
        {
            set_Selected();
            switch (radiobutton)
            {
                case 0:
                    MessageBox.Show("Nothing selected.");
                    break;
                case 1:
                    txt_monday.Text     += "\n";
                    break;
                case 2:
                    txt_tuesday.Text    += "\n";
                    break;
                case 3:
                    txt_wednessday.Text += "\n";
                    break;
                case 4:
                    txt_thursday.Text   += "\n";
                    break;
                case 5:
                    txt_friday.Text     += "\n";
                    break;
                case 6:
                    txt_prio.Text       += "\n";
                    break;
                default:

                    break;
            }
        }
        public void setFonts(Font fonttouse, Color colortouse)
        {
            rtb_Logview.Font    = fonttouse;
            rtb_Logview.ForeColor = colortouse;
            txt_monday.Font     = fonttouse;
            txt_monday.ForeColor = colortouse;

            txt_tuesday.Font    = fonttouse;
            txt_tuesday.ForeColor = colortouse;

            txt_wednessday.Font = fonttouse;
            txt_wednessday.ForeColor = colortouse;

            txt_thursday.Font   = fonttouse;
            txt_thursday.ForeColor = colortouse;

            txt_friday.Font     = fonttouse;
            txt_friday.ForeColor = colortouse;

            txt_prio.ForeColor = colortouse;
            txt_prio.Font       = fonttouse;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Font test = StringToFont("Font: Name=Microsoft Sans Serif, Size=8,25, Units=3, GdiCharSet=0, GdiVerticalFont=False");
            setFonts(test,Color.Red);
        }

        private void cbb_Presets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(chk_InsertOnSelect.Checked)
            {
                btn_InsertPreset_Click(sender, e);
            }
        }

        private void serverURLToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.TopMost = false;
            chk_OnTop.Checked = false;
            frmServerurl ss = new frmServerurl();
            ss.ShowDialog();
        }

        private void zweitesFensterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Start second instance?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string startpath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName.ToString();
                System.Diagnostics.Process.Start(startpath);
            }
            else if (dialogResult == DialogResult.No)
            { }
        }

        private void visualsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = rtb_Logview.Font;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                setFonts(fontDialog1.Font, fontDialog1.Color);
                //var ini = new classINI(settingspath);
                //ini.Write("font", fontDialog1.Font.ToString());
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (updateAvailable())
            {
                alog("updatecheck returned true");
                DialogResult result = MessageBox.Show("Update ready : " + server_version + "\n" + "Current version installed : " + appversion + "\n" + "Open browser and download ?", "Update", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(server_url + "/updates/version_latest/");
                }
            }
            else if (!updateAvailable())
            {
                alog("updatecheck returned false");
                MessageBox.Show("Nothing new found." + "\n" + "Latest version: " + server_version + "\n" + "Current version installed : " + appversion + "\n");
            }
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.TopMost = false;
            chk_OnTop.Checked = false;
            frmAbout af = new frmAbout();
            af.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(File.Exists(settingspath))
            {
                File.Delete(settingspath);
                Application.Restart();
            }
        }
    }
}
