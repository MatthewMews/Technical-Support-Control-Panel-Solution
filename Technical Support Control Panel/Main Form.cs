using System;
using System.Windows.Forms;
using System.Diagnostics;
using Technical_Support_Control_Panel;
using System.Runtime.InteropServices;
using Send_Email;
using OfficeApps;

namespace Main_Form
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

            welcome_label.Text += " " + Environment.UserName.ToString().Replace(".", " ");
        }

        private void Office_Shortcuts(object sender, EventArgs e)
        {
            OfficeAppShortcuts.GetShortcuts();
        }

        private void Call_Recordings(object sender, EventArgs e)
        {
            try
            {
                Call_Recordings_Form f2 = new Call_Recordings_Form();
                this.Hide();
                f2.ShowDialog();
                this.Show();
            } catch (Exception Call_Recordings_Button_Exception)
            {
                Email exception = new Email();

                string subject = Call_Recordings_Button_Exception.GetType().Name + " - " + DateTime.Now.ToString();
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string exceptionInfo = "" + Call_Recordings_Button_Exception;

                exception.SendExceptionEmail(subject, userName, exceptionInfo);
            }
        }

        private void Website_Links_Button_Click(object sender, EventArgs e)
        {
            Website_Links f3 = new Website_Links();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Computer_Name_Button_Click(object sender, EventArgs e)
        {
            Process.Start(@"c:\windows\system32\SystemPropertiesComputerName.exe");
        }

        private void Control_Panel_Button(object sender, EventArgs e)
        {
            Process.Start(@"c:\windows\system32\control.exe");
        }

        private void Event_Viewer_Button_Click(object sender, EventArgs e)
        {
            Process.Start(@"c:\windows\system32\eventvwr.exe");
        }

        // Allows the header of the main form to be moved
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Move_Main_Header(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
