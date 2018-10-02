using System;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using OfficeApps;

namespace Send_Email
{
    public class Email
    {
        private static bool dialogIsAlreadyRunning = false;
              
        internal void SendExceptionEmail(string subject, string userName, string exceptionInfo)
        {
            if(!OfficeAppShortcuts.CheckOutlookExists())
            {
                MessageBox.Show("Error. Unable to detect Outlook, please install Outlook before attempting to send a bug report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;                
            }

            Outlook.Application outlook = new Outlook.Application();

            if (dialogIsAlreadyRunning == true)
            {
                MessageBox.Show("An Outlook window is already open to send a bug report.\n\nPlease send or close the current Outlook window " +
                    "in order to send this report.", "Unable to send bug report", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            dialogIsAlreadyRunning = true;

            DialogResult dialogresult = MessageBox.Show($"An error has occurred. Do you wish to send a bug report?", "An error has occurred!",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);

            if (dialogresult == DialogResult.Yes)
            {
                Outlook._MailItem MailItem = (Outlook._MailItem)outlook.CreateItem(Outlook.OlItemType.olMailItem);

                MailItem.To = "bugs@companyname.co.uk";
                MailItem.Subject = subject;
                MailItem.HTMLBody = $"<html><body> The user <strong>{userName}</strong> has reported the following exception error: <br><br> {exceptionInfo} </body></html>";
                try
                {
                    MailItem.Display(true);
                } catch
                {
                    // add error here for if dialog box is already open.
                    Marshal.ReleaseComObject(outlook);
                    Marshal.ReleaseComObject(MailItem);
                    dialogIsAlreadyRunning = false;
                }

                Marshal.ReleaseComObject(outlook);
                Marshal.ReleaseComObject(MailItem);              
            }

            dialogIsAlreadyRunning = false;

            Technical_Support_Control_Panel.Call_Recordings_Form ResetSettings = new Technical_Support_Control_Panel.Call_Recordings_Form();

            ResetSettings.ResetComboBoxSettings();        
        }


        // The below code is made to notify users when their call recording folder has been deleted. However I decided against intergrating this into the program as I
        // don't beleive it is necessary.


        //internal void SendDirectoryDeletedEmail(string userName, string directoryName)
        //{
        //    //string emailAddress = String.Empty;

            //DialogResult dialogresult = MessageBox.Show($"Are you sure you wish to send a Directory Deleted email to {userName}", "Send Email?",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if(dialogresult == DialogResult.Yes)
            //{
            //    Outlook._MailItem MailItem = (Outlook._MailItem)outlook.CreateItem(Outlook.OlItemType.olMailItem);

            //    switch (userName) // StreamReader needs to be added in order to find out the users. Should use the StaffListCheck class for this.
            //    {
            //        
            //    }

            //    if(emailAddress == null)
            //    {
            //        MessageBox.Show("An error has occured. Email address is null", "Technical Support Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    MailItem.To = emailAddress;
            //    MailItem.Subject = $"Call Recording Deletion: {directoryName}";
            //    MailItem.HTMLBody = $"<html><body>Hello {userName},<br>This is an automated email to notify you that the directory <strong>{directoryName}</strong>" +
            //        $"has been deleted.</body></html>";
            //    MailItem.Display(true);

            //    Marshal.ReleaseComObject(outlook);
            //    Marshal.ReleaseComObject(MailItem);
            //}
        //}
    }
}
