using System;
using System.Windows.Forms;

namespace TeamServer
{
    public partial class frmServerurl : Form
    {
        public frmServerurl()
        {
            InitializeComponent();
        }
        public string settingspath = "C:\\users\\" + Environment.UserName + "\\AppData\\Roaming\\teamserver.ini";
        private void FrmServerurl_Load(object sender, EventArgs e)
        {
            var ini = new classINI(settingspath);
            try
            {
                txt_URL.Text = ini.Read("url");
            }
            catch
            {
                txt_URL.Text = "enter your server url";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(txt_URL.Text.Contains("http://") && txt_URL.Text != "")
            {
                if (txt_URL.Text != "")
                {
                    savesetting();
                }
                else
                {
                    MessageBox.Show("URL cannot be null");
                }
            }
            else if(!txt_URL.Text.Contains("http://") && txt_URL.Text != "")
            {
                string temp = txt_URL.Text;
                txt_URL.Text = "http://" + temp;
                savesetting();
            }

        }

        public void savesetting()
        {
            var ini = new classINI(settingspath);
            ini.Write("url", txt_URL.Text);
            frmMain.server_url = ini.Read("url");
            frmMain.checkFiles();
            frmMain.downloadUserlist();

            MessageBox.Show("Saved your server URL, the software will restart now and initialize with the new server");
            this.Close();
            Application.Restart();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter a URL to a valid server.\n Example : company.com/teamserver ");
        }
    }
}
