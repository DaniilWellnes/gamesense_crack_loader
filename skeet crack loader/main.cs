﻿/* created by wellnes#5190 */
using System;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace gamesense_crack
{
    public partial class main : Form
    {
        string version = "1"; 
        public main()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler((o, e) =>
            {
                base.Capture = false;
                Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref message);
            });
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.1d) == 1) timer.Stop();
            });
            timer.Interval = 20;
            timer.Start();
        }

        private void main_Load(object sender, EventArgs e)
        {
            pic_load.Enabled = true; pic_load.Visible = true;
            pic_load.Location = new Point(204, 160); pic_load.Size = new Size(197, 146);
            main_panel.Visible = false; main_panel.Enabled = false;
            cheat_load.Enabled = false; cheat_load.Text = "START LOAD";

            sub_expires_in.Text = "LIFETIME";

            cheat_undetect.Enabled = false; cheat_undetect.Visible = false;
            cheat_detect.Enabled = false; cheat_detect.Visible = false;
            cheat_undetect.Location = new Point(0, 22); cheat_undetect.Size = new Size(32, 34);
            cheat_detect.Location = new Point(0, 22); cheat_detect.Size = new Size(32, 34);
            pic_icon.Enabled = false; pic_icon.Visible = false;
            close_skeet.Visible = false; close_skeet.Enabled = false;

            cheat_load.Visible = false; cheat_load.Enabled = false;

            WebClient w_cheat_status_text = new WebClient();
            WebClient w_last_upd_date = new WebClient();
            last_upd.Text = w_last_upd_date.DownloadString("https://raw.githubusercontent.com/DaniilWellnes/addition/main/gamesense_crack/data.txt");
            string cheat_status_text = w_cheat_status_text.DownloadString("https://raw.githubusercontent.com/DaniilWellnes/addition/main/gamesense_crack/cheat_status.txt");
            if (cheat_status_text.Contains("0"))
            {
                cheat_status.Text = "UNDETECT"; cheat_status.BackColor = ForeColor = System.Drawing.Color.LimeGreen;
                cheat_undetect.Visible = true; cheat_undetect.Enabled = true;
                cheat_load.Enabled = true;
            }
            else
            {
                cheat_status.Text = "DETECT"; cheat_status.ForeColor = System.Drawing.Color.Red;
                cheat_detect.Visible = true; cheat_detect.Enabled = true;
            }

        }

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            timeLeft = 30;
            timer1.Start();
        }
        Random randomizer = new Random();
        int addend1;
        int addend2;
        int timeLeft;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                account_id.Text = Environment.UserName;
                pic_load.Visible = false; pic_load.Enabled = false;
                pic_icon.Enabled = false; pic_icon.Visible = true;
                main_panel.Visible = true; main_panel.Enabled = true;
                close_skeet.Visible = true; close_skeet.Enabled = true;
                cheat_load.Visible = true;

            } timer2.Stop();
        }

        private void pic_load_Click(object sender, EventArgs e)
        {

        }
        private void account_id_Click(object sender, EventArgs e)
        {

        }

        private void sub_expires_in_Click(object sender, EventArgs e)
        {

        }

        private void close_skeet_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cheat_status_Click(object sender, EventArgs e)
        {

        }


        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void cheat_load_Click(object sender, EventArgs e)
        {
            cheat_load.Enabled = false;
            cheat_load.Text = "Inject...";
            await Task.Delay(4000);
            /*WebClient wb = new WebClient();
            string mainpath = "C:\\" + dll_name + ".dll";
            wb.DownloadFile(dll_link, mainpath);

            Process.Start("steam://rungameid/730");
            await Task.Delay(time_to_wait);
            Process csgo = Process.GetProcessesByName("csgo").FirstOrDefault();
            Process[] csgo_array = Process.GetProcessesByName("csgo");
            if (csgo_array.Length != 0)
            {
                injector.BasicInject.Inject(mainpath, "csgo");
                Console.Read();
                await Task.Delay(3000);
                csgo.WaitForExit();
                if (File.Exists(mainpath))
                {
                    File.Delete(mainpath);
                }
                await Task.Delay(5000);
                Application.Exit();
            }
            else
            {
                this.Hide();
                var main = new error();
                main.Closed += (s, args) => this.Close();
                main.Show();
            }*/

            this.Hide();
            var main = new loading();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] ida64 = Process.GetProcessesByName("ida64");
            Process[] ida32 = Process.GetProcessesByName("ida32");
            Process[] ollydbg = Process.GetProcessesByName("ollydbg");
            Process[] ollydbg64 = Process.GetProcessesByName("ollydbg64");
            Process[] loaddll = Process.GetProcessesByName("loaddll");
            Process[] httpdebugger = Process.GetProcessesByName("httpdebugger");
            Process[] windowrenamer = Process.GetProcessesByName("windowrenamer");
            Process[] processhacker = Process.GetProcessesByName("processhacker");
            Process[] processhacker2 = Process.GetProcessesByName("Process Hacker");
            Process[] processhacker3 = Process.GetProcessesByName("ProcessHacker");
            Process[] HxD = Process.GetProcessesByName("HxD");
            Process[] parsecd = Process.GetProcessesByName("parsecd");
            Process[] ida = Process.GetProcessesByName("ida");
            Process[] dnSpy = Process.GetProcessesByName("dnSpy");
            if (ida64.Length != 0 || ida32.Length != 0 || ollydbg.Length != 0 || ollydbg64.Length != 0 || loaddll.Length != 0 || httpdebugger.Length != 0 || windowrenamer.Length != 0 || processhacker.Length != 0 || processhacker2.Length != 0 || processhacker3.Length != 0 || HxD.Length != 0 || ida.Length != 0 || parsecd.Length != 0 || dnSpy.Length != 0)
            {
                Application.Exit();
            }
        }

    }
}
/* created by wellnes#5190 */