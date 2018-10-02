using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Technical_Support_Control_Panel
{
    public partial class Website_Links : Form
    {
        public Website_Links()
        {
            InitializeComponent();
        }

        private void SirPortly_Button_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://intelligent-services-group.sirportly.com");
        }

        private void TheLaundryMail_Button_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://manager.securesuite.io");
        }

        private void Sophos_Button_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://central.sophos.com/manage/login");
        }

        // 'Esc' keyboard press returns to previous form.
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                this.DialogResult = DialogResult.OK;
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Main_Menu_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
