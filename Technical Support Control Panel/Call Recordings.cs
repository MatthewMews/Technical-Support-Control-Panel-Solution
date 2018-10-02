using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Send_Email;

namespace Technical_Support_Control_Panel
{
    public partial class Call_Recordings_Form : Form
    {
        List<string> callRecordingsList = new List<string>();

        private static string debuggingPath = @"C:\Users\Matthew\Desktop\Debugging";
        //private static string debuggingPathTwo = @"Debugging Path Two used to be an server IP."

        public static string dirPath = debuggingPath; // CHANGE THIS WHEN DEBUGGING

        public static List<string> excludedNames = new List<string>();

        private static int numOfFilesNotInADirectory = 0;

        private static string[] callRecordingDirectory = Directory.GetDirectories(dirPath);
        private static bool directoryDeleted = false;

        private static bool firstSearch = true;


        public Call_Recordings_Form()
        {
            InitializeComponent();

            comboBox1.Text = "IAS_CallRecordings"; // The path the program begins with.

            GetCallRecordings();
        }

        public void GetCallRecordings()
        {
            try
            {
                string[] numOfFilesNotInDirectoryArray = Directory.GetFiles(dirPath);
            }
            catch (Exception e)
            {
                Email email = new Email();

                string subject = e.GetType().Name + " - " + DateTime.Now.ToString();
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                string info = "" + e;

                email.SendExceptionEmail(subject, userName, info);

                return;
            }

            dirPath_Label.Text += dirPath;

            information_label.Text += Environment.NewLine;

            StaffListCheck.GetStaffNames();
 

            //            var directoryName = di.EnumerateDirectories("*",System.IO.SearchOption.AllDirectories).Where(d => !excludedNames.Any(e => d.Name.ToLowerInvariant().Contains(e.ToLower())))

            // Get the directory path(s), will allow for deletion later on. 
            var di = new DirectoryInfo(dirPath);
            var directories = di.EnumerateDirectories("*", System.IO.SearchOption.AllDirectories).Where(d => !excludedNames.Any(e => d.Name.Contains(e)))
                                .OrderBy(d => d.LastWriteTime)
                                .Select(file => file.FullName)
                                .ToList();


            // Displays folder names. 
            var directoryNames = new DirectoryInfo(dirPath);
            var directoryName = di.EnumerateDirectories("*",System.IO.SearchOption.AllDirectories).Where(d => !excludedNames.Any(e => d.Name.Contains(e)))
                                .OrderBy(d => d.LastWriteTime)
                                .Select(file => file.Name)
                                .ToList();


            // Shows the date the folder was last modified.
            var dir = new DirectoryInfo(dirPath);
            var creationDate = dir.EnumerateDirectories("*", System.IO.SearchOption.AllDirectories).Where(d => !excludedNames.Any(e => d.Name.Contains(e)))
                                .OrderBy(d => d.LastWriteTime)
                                .Select(d => d.LastWriteTime.ToLongDateString())
                                .ToList();

            int numOfDirectories = 1;

            foreach (var dirName in directoryName)
            {
                if (numOfDirectories > 250) //caps the amount of information displayed at the max amount.
                {
                    break;
                }

                information_label.Text += numOfDirectories++ + ".  " + dirName + Environment.NewLine +
                     "--------------------------------------------------------------"
                      + Environment.NewLine + Environment.NewLine;
            }

            int numOfCallFolders = 1;

            foreach (var callfolder in directories)
            {
                numOfCallFolders++;

                if (numOfCallFolders >= 252) //caps the amount of information displayed at the max amount.
                {
                    break;
                }

                callRecordingsList.Add(callfolder.ToString());                 
            }

            information_label_two.Text += Environment.NewLine;

            int numOfDates = 1;
                
            foreach (var dates in creationDate)
            {
                numOfDates++;

                if (numOfDates > 251)   //caps the amount of information displayed at the max amount.
                {
                    continue;
                }

                information_label_two.Text += dates + Environment.NewLine +
             "-------------------------------------------------------" +
               Environment.NewLine + Environment.NewLine;
            }

            var numOfCallDirectories = callRecordingsList.Count - 1;

            int formHeight = 80;

            for (int i = 0; i < callRecordingsList.Count; i++)
            {
                panel1.Size = new Size(800, formHeight);

                formHeight += 51;

                if (numOfCallDirectories >= 249)
                {
                    panel1.Size = new Size(800, 12850);
                    directoryLimit.Visible = true;
                    break;
                }
            }
     
            DirectoryInfo filesNotInDirectoryPath = new DirectoryInfo(dirPath);

            FileInfo[] filesNotInDirectory = filesNotInDirectoryPath.GetFiles();

            var filesThatAreNotHidden = filesNotInDirectory.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));

            foreach (var file in filesThatAreNotHidden)
            {
                numOfFilesNotInADirectory++;
                Num_Of_Files_Not_In_Directory_Count_Label.Text = numOfFilesNotInADirectory.ToString();
            }

            if (numOfFilesNotInADirectory >= 1)
            {
                Num_Of_Files_Not_In_Directory_Label.ForeColor = Color.Orange;
                Num_Of_Files_Not_In_Directory_Count_Label.ForeColor = Color.Orange;
            }

            // makes the delete button visible for every indexed value in numOfCallDirectories
            for (int i = 0; i <= numOfCallDirectories; i++)
            {
                switch(i)
                {
                    case 0: button1.Visible = true; continue;
                    case 1: button2.Visible = true; continue;
                    case 2: button3.Visible = true; continue;
                    case 3: button4.Visible = true; continue;
                    case 4: button5.Visible = true; continue;
                    case 5: button6.Visible = true; continue;
                    case 6: button7.Visible = true; continue;
                    case 7: button8.Visible = true; continue;
                    case 8: button9.Visible = true; continue;
                    case 9: button10.Visible = true; continue;
                    case 10: button11.Visible = true; continue;
                    case 11: button12.Visible = true; continue;
                    case 12: button13.Visible = true; continue;
                    case 13: button14.Visible = true; continue;
                    case 14: button15.Visible = true; continue;
                    case 15: button16.Visible = true; continue;
                    case 16: button17.Visible = true; continue;
                    case 17: button18.Visible = true; continue;
                    case 18: button19.Visible = true; continue;
                    case 19: button20.Visible = true; continue;
                    case 20: button21.Visible = true; continue;
                    case 21: button22.Visible = true; continue;
                    case 22: button23.Visible = true; continue;
                    case 23: button24.Visible = true; continue;
                    case 24: button25.Visible = true; continue;
                    case 25: button26.Visible = true; continue;
                    case 26: button27.Visible = true; continue;
                    case 27: button28.Visible = true; continue;
                    case 28: button29.Visible = true; continue;
                    case 29: button30.Visible = true; continue;
                    case 30: button31.Visible = true; continue;
                    case 31: button32.Visible = true; continue;
                    case 32: button33.Visible = true; continue;
                    case 33: button34.Visible = true; continue;
                    case 34: button35.Visible = true; continue;
                    case 35: button36.Visible = true; continue;
                    case 36: button37.Visible = true; continue;
                    case 37: button38.Visible = true; continue;
                    case 38: button39.Visible = true; continue;
                    case 39: button40.Visible = true; continue;
                    case 40: button41.Visible = true; continue;
                    case 41: button42.Visible = true; continue;
                    case 42: button43.Visible = true; continue;
                    case 43: button44.Visible = true; continue;
                    case 44: button45.Visible = true; continue;
                    case 45: button46.Visible = true; continue;
                    case 46: button47.Visible = true; continue;
                    case 47: button48.Visible = true; continue;
                    case 48: button49.Visible = true; continue;
                    case 49: button50.Visible = true; continue;
                    case 50: button51.Visible = true; continue;
                    case 51: button52.Visible = true; continue;
                    case 52: button53.Visible = true; continue;
                    case 53: button54.Visible = true; continue;
                    case 54: button55.Visible = true; continue;
                    case 55: button56.Visible = true; continue;
                    case 56: button57.Visible = true; continue;
                    case 57: button58.Visible = true; continue;
                    case 58: button59.Visible = true; continue;
                    case 59: button60.Visible = true; continue;
                    case 60: button61.Visible = true; continue;
                    case 61: button62.Visible = true; continue;
                    case 62: button63.Visible = true; continue;
                    case 63: button64.Visible = true; continue;
                    case 64: button65.Visible = true; continue;
                    case 65: button66.Visible = true; continue;
                    case 66: button67.Visible = true; continue;
                    case 67: button68.Visible = true; continue;
                    case 68: button69.Visible = true; continue;
                    case 69: button70.Visible = true; continue;
                    case 70: button71.Visible = true; continue;
                    case 71: button72.Visible = true; continue;
                    case 72: button73.Visible = true; continue;
                    case 73: button74.Visible = true; continue;
                    case 74: button75.Visible = true; continue;
                    case 75: button76.Visible = true; continue;
                    case 76: button77.Visible = true; continue;
                    case 77: button78.Visible = true; continue;
                    case 78: button79.Visible = true; continue;
                    case 79: button80.Visible = true; continue;
                    case 80: button81.Visible = true; continue;
                    case 81: button82.Visible = true; continue;
                    case 82: button83.Visible = true; continue;
                    case 83: button84.Visible = true; continue;
                    case 84: button85.Visible = true; continue;
                    case 85: button86.Visible = true; continue;
                    case 86: button87.Visible = true; continue;
                    case 87: button88.Visible = true; continue;
                    case 88: button89.Visible = true; continue;
                    case 89: button90.Visible = true; continue;
                    case 90: button91.Visible = true; continue;
                    case 91: button92.Visible = true; continue;
                    case 92: button93.Visible = true; continue;
                    case 93: button94.Visible = true; continue;
                    case 94: button95.Visible = true; continue;
                    case 95: button96.Visible = true; continue;
                    case 96: button97.Visible = true; continue;
                    case 97: button98.Visible = true; continue;
                    case 98: button99.Visible = true; continue;
                    case 99: button100.Visible = true; continue;
                    case 100: button101.Visible = true; continue;
                    case 101: button102.Visible = true;  continue;
                    case 102: button103.Visible = true; continue;
                    case 103: button104.Visible = true; continue;
                    case 104: button105.Visible = true; continue;
                    case 105: button106.Visible = true; continue;
                    case 106: button107.Visible = true; continue;
                    case 107: button108.Visible = true; continue;
                    case 108: button109.Visible = true; continue;
                    case 109: button110.Visible = true; continue;
                    case 110: button111.Visible = true; continue;
                    case 111: button112.Visible = true; continue;
                    case 112: button113.Visible = true; continue;
                    case 113: button114.Visible = true; continue;
                    case 114: button115.Visible = true; continue;
                    case 115: button116.Visible = true; continue;
                    case 116: button117.Visible = true; continue;
                    case 117: button118.Visible = true; continue;
                    case 118: button119.Visible = true; continue;
                    case 119: button120.Visible = true; continue;
                    case 120: button121.Visible = true; continue;
                    case 121: button122.Visible = true; continue;
                    case 122: button123.Visible = true; continue;
                    case 123: button124.Visible = true; continue;
                    case 124: button125.Visible = true; continue;
                    case 125: button126.Visible = true; continue;
                    case 126: button127.Visible = true; continue;
                    case 127: button128.Visible = true; continue;
                    case 128: button129.Visible = true; continue;
                    case 129: button130.Visible = true; continue;
                    case 130: button131.Visible = true; continue;
                    case 131: button132.Visible = true; continue;
                    case 132: button133.Visible = true; continue;
                    case 133: button134.Visible = true; continue;
                    case 134: button135.Visible = true; continue;
                    case 135: button136.Visible = true; continue;
                    case 136: button137.Visible = true; continue;
                    case 137: button138.Visible = true; continue;
                    case 138: button139.Visible = true; continue;
                    case 139: button140.Visible = true; continue;
                    case 140: button141.Visible = true; continue;
                    case 141: button142.Visible = true; continue;
                    case 142: button143.Visible = true; continue;
                    case 143: button144.Visible = true; continue;
                    case 144: button145.Visible = true; continue;
                    case 145: button146.Visible = true; continue;
                    case 146: button147.Visible = true; continue;
                    case 147: button148.Visible = true; continue;
                    case 148: button149.Visible = true; continue;
                    case 149: button150.Visible = true; continue;
                    case 150: button151.Visible = true; continue;
                    case 151: button152.Visible = true; continue;
                    case 152: button153.Visible = true; continue;
                    case 153: button154.Visible = true; continue;
                    case 154: button155.Visible = true; continue;
                    case 155: button156.Visible = true; continue;
                    case 156: button157.Visible = true; continue;
                    case 157: button158.Visible = true; continue;
                    case 158: button159.Visible = true; continue;
                    case 159: button160.Visible = true; continue;
                    case 160: button161.Visible = true; continue;
                    case 161: button162.Visible = true; continue;
                    case 162: button163.Visible = true; continue;
                    case 163: button164.Visible = true; continue;
                    case 164: button165.Visible = true; continue;
                    case 165: button166.Visible = true; continue;
                    case 166: button167.Visible = true; continue;
                    case 167: button168.Visible = true; continue;
                    case 168: button169.Visible = true; continue;
                    case 169: button170.Visible = true; continue;
                    case 170: button171.Visible = true; continue;
                    case 171: button172.Visible = true; continue;
                    case 172: button173.Visible = true; continue;
                    case 173: button174.Visible = true; continue;
                    case 174: button175.Visible = true; continue;
                    case 175: button176.Visible = true; continue;
                    case 176: button177.Visible = true; continue;
                    case 177: button178.Visible = true; continue;
                    case 178: button179.Visible = true; continue;
                    case 179: button180.Visible = true; continue;
                    case 180: button181.Visible = true; continue;
                    case 181: button182.Visible = true; continue;
                    case 182: button183.Visible = true; continue;
                    case 183: button184.Visible = true; continue;
                    case 184: button185.Visible = true; continue;
                    case 185: button186.Visible = true; continue;
                    case 186: button187.Visible = true; continue;
                    case 187: button188.Visible = true; continue;
                    case 188: button189.Visible = true; continue;
                    case 189: button190.Visible = true; continue;
                    case 190: button191.Visible = true; continue;
                    case 191: button192.Visible = true; continue;
                    case 192: button193.Visible = true; continue;
                    case 193: button194.Visible = true; continue;
                    case 194: button195.Visible = true; continue;
                    case 195: button196.Visible = true; continue;
                    case 196: button197.Visible = true; continue;               
                    case 197: button198.Visible = true; continue;
                    case 198: button199.Visible = true; continue;
                    case 199: button200.Visible = true; continue;
                    case 200: button201.Visible = true; continue;
                    case 201: button202.Visible = true; continue;
                    case 202: button203.Visible = true; continue;
                    case 203: button204.Visible = true; continue;
                    case 204: button205.Visible = true; continue;
                    case 205: button206.Visible = true; continue;
                    case 206: button207.Visible = true; continue;
                    case 207: button208.Visible = true; continue;
                    case 208: button209.Visible = true; continue;
                    case 209: button210.Visible = true; continue;
                    case 210: button211.Visible = true; continue;
                    case 211: button212.Visible = true; continue;
                    case 212: button213.Visible = true; continue;
                    case 213: button214.Visible = true; continue;
                    case 214: button215.Visible = true; continue;
                    case 215: button216.Visible = true; continue;
                    case 216: button217.Visible = true; continue;
                    case 217: button218.Visible = true; continue;
                    case 218: button219.Visible = true; continue;
                    case 219: button220.Visible = true; continue;
                    case 220: button221.Visible = true; continue;
                    case 221: button222.Visible = true; continue;
                    case 222: button223.Visible = true; continue;
                    case 223: button224.Visible = true; continue;
                    case 224: button225.Visible = true; continue;
                    case 225: button226.Visible = true; continue;
                    case 226: button227.Visible = true; continue;
                    case 227: button228.Visible = true; continue;
                    case 228: button229.Visible = true; continue;
                    case 229: button230.Visible = true; continue;
                    case 230: button231.Visible = true; continue;
                    case 231: button232.Visible = true; continue;
                    case 232: button233.Visible = true; continue;
                    case 233: button234.Visible = true; continue;
                    case 234: button235.Visible = true; continue;
                    case 235: button236.Visible = true; continue;
                    case 236: button237.Visible = true; continue;
                    case 237: button238.Visible = true; continue;
                    case 238: button239.Visible = true; continue;
                    case 239: button240.Visible = true; continue;
                    case 240: button241.Visible = true; continue;
                    case 241: button242.Visible = true; continue;
                    case 242: button243.Visible = true; continue;
                    case 243: button244.Visible = true; continue;
                    case 244: button245.Visible = true; continue;
                    case 245: button246.Visible = true; continue;
                    case 246: button247.Visible = true; continue;
                    case 247: button248.Visible = true; continue;
                    case 248: button249.Visible = true; continue;
                    case 249: button250.Visible = true; continue;

                    default: break;
                }
            }
        }
        
        private static void ConfirmDeletion(string directoryToDelete)
        {
            if (!Directory.Exists(directoryToDelete))
            {
                MessageBox.Show("Directory no longer exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you wish to delete the following directory?\n" + directoryToDelete, "Delete directory?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        Directory.Delete(directoryToDelete, true);
                        directoryDeleted = true;
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show("Error. Unable to Locate Directory.\n\n" + e, "An error has occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        directoryDeleted = false;
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "IAS_CallRecordings")
            {
                if (firstSearch == true)
                {
                    firstSearch = false;
                    return;
                }
                else
                {
                    dirPath = @"C:\Users\Matthew\Desktop\Debugging";

                    ResetComboBoxSettings();

                    GetCallRecordings();
                }
            }

            if (comboBox1.Text == "MED_CallRecordings")
            {
                dirPath = @"REDACTED CALL RECORDING PATH";

                ResetComboBoxSettings();

                GetCallRecordings();
            }

            if (comboBox1.Text == "TCP_CallRecordings")
            {
                dirPath = @"REDACTED CALL RECORDING PATH";

                ResetComboBoxSettings();

                GetCallRecordings();
            }

            if (comboBox1.Text == "Debugging")
            {
                if (!Directory.Exists(@"C:\Users\Matthew\Desktop\Debugging"))
                {
                    MessageBox.Show("Directory doesn't exist.");
                    return;
                }

                if (firstSearch == true)
                {
                    firstSearch = false;
                    return;
                }
                else
                {
                    ResetComboBoxSettings();

                    dirPath = @"C:\Users\Matthew\Desktop\Debugging";

                    GetCallRecordings();
                }
            }

            if (comboBox1.Text == "Debugging Two")
            {
                if (firstSearch == true)
                {
                    firstSearch = false;
                    return;
                }

                this.Hide();

                dirPath = @"REDACTED CALL RECORDING PATH";

                ResetComboBoxSettings();

                GetCallRecordings();

                this.Show();
            }
        }

        private void Button1_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[0]); if (directoryDeleted == true) {label1.Visible = true; button1.Visible = false; directoryDeleted = false; } return; }
        private void Button2_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[1]); if (directoryDeleted == true) { label2.Visible = true; button2.Visible = false; directoryDeleted = false; } return; }
        private void button3_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[2]); if (directoryDeleted == true) { label3.Visible = true; button3.Visible = false; directoryDeleted = false; } return; }
        private void button4_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[3]); if (directoryDeleted == true) { label4.Visible = true; button4.Visible = false; directoryDeleted = false; } return; }
        private void button5_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[4]); if (directoryDeleted == true) { label5.Visible = true; button5.Visible = false; directoryDeleted = false; } return; }
        private void button6_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[5]); if (directoryDeleted == true) { label6.Visible = true; button6.Visible = false; directoryDeleted = false; } return; }
        private void button7_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[6]); if (directoryDeleted == true) { label7.Visible = true; button7.Visible = false; directoryDeleted = false; } return; }
        private void button8_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[7]); if (directoryDeleted == true) { label8.Visible = true; button8.Visible = false; directoryDeleted = false; } return; }
        private void button9_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[8]); if (directoryDeleted == true) { label9.Visible = true; button9.Visible = false; directoryDeleted = false; } return; }
        private void button10_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[9]); if (directoryDeleted == true) { label10.Visible = true; button10.Visible = false; directoryDeleted = false; } return; }
        private void button11_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[10]); if (directoryDeleted == true) { label11.Visible = true; button11.Visible = false; directoryDeleted = false; } return; }
        private void button12_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[11]); if (directoryDeleted == true) { label12.Visible = true; button12.Visible = false; directoryDeleted = false; } return; }
        private void button13_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[12]); if (directoryDeleted == true) { label13.Visible = true; button13.Visible = false; directoryDeleted = false; } return; }
        private void button14_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[13]); if (directoryDeleted == true) { label14.Visible = true; button14.Visible = false; directoryDeleted = false; } return; }
        private void button15_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[14]); if (directoryDeleted == true) { label15.Visible = true; button15.Visible = false; directoryDeleted = false; } return; }
        private void button16_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[15]); if (directoryDeleted == true) { label16.Visible = true; button16.Visible = false; directoryDeleted = false; } return; }
        private void button17_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[16]); if (directoryDeleted == true) { label17.Visible = true; button17.Visible = false; directoryDeleted = false; } return; }
        private void button18_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[17]); if (directoryDeleted == true) { label18.Visible = true; button18.Visible = false; directoryDeleted = false; } return; }
        private void button19_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[18]); if (directoryDeleted == true) { label19.Visible = true; button19.Visible = false; directoryDeleted = false; } return; }
        private void button20_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[19]); if (directoryDeleted == true) { label20.Visible = true; button20.Visible = false; directoryDeleted = false; } return; }
        private void button21_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[20]); if (directoryDeleted == true) { label21.Visible = true; button21.Visible = false; directoryDeleted = false; } return; }
        private void button22_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[21]); if (directoryDeleted == true) { label22.Visible = true; button22.Visible = false; directoryDeleted = false; } return; }
        private void button23_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[22]); if (directoryDeleted == true) { label23.Visible = true; button23.Visible = false; directoryDeleted = false; } return; }
        private void button24_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[23]); if (directoryDeleted == true) { label24.Visible = true; button24.Visible = false; directoryDeleted = false; } return; }
        private void button25_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[24]); if (directoryDeleted == true) { label25.Visible = true; button25.Visible = false; directoryDeleted = false; } return; }
        private void button26_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[25]); if (directoryDeleted == true) { label26.Visible = true; button26.Visible = false; directoryDeleted = false; } return; }
        private void button27_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[26]); if (directoryDeleted == true) { label27.Visible = true; button27.Visible = false; directoryDeleted = false; } return; }
        private void button28_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[27]); if (directoryDeleted == true) { label28.Visible = true; button28.Visible = false; directoryDeleted = false; } return; }
        private void button29_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[28]); if (directoryDeleted == true) { label29.Visible = true; button29.Visible = false; directoryDeleted = false; } return; }
        private void button30_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[29]); if (directoryDeleted == true) { label30.Visible = true; button30.Visible = false; directoryDeleted = false; } return; }
        private void button31_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[30]); if (directoryDeleted == true) { label31.Visible = true; button31.Visible = false; directoryDeleted = false; } return; }
        private void button32_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[31]); if (directoryDeleted == true) { label32.Visible = true; button32.Visible = false; directoryDeleted = false; } return; }
        private void button33_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[32]); if (directoryDeleted == true) { label33.Visible = true; button33.Visible = false; directoryDeleted = false; } return; }
        private void button34_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[33]); if (directoryDeleted == true) { label34.Visible = true; button34.Visible = false; directoryDeleted = false; } return; }
        private void button35_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[34]); if (directoryDeleted == true) { label35.Visible = true; button35.Visible = false; directoryDeleted = false; } return; }
        private void button36_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[35]); if (directoryDeleted == true) { label36.Visible = true; button36.Visible = false; directoryDeleted = false; } return; }
        private void button37_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[36]); if (directoryDeleted == true) { label37.Visible = true; button37.Visible = false; directoryDeleted = false; } return; }
        private void button38_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[37]); if (directoryDeleted == true) { label38.Visible = true; button38.Visible = false; directoryDeleted = false; } return; }
        private void button39_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[38]); if (directoryDeleted == true) { label39.Visible = true; button39.Visible = false; directoryDeleted = false; } return; }
        private void button40_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[39]); if (directoryDeleted == true) { label40.Visible = true; button40.Visible = false; directoryDeleted = false; } return; }
        private void button41_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[40]); if (directoryDeleted == true) { label41.Visible = true; button41.Visible = false; directoryDeleted = false; } return; }
        private void button42_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[41]); if (directoryDeleted == true) { label42.Visible = true; button42.Visible = false; directoryDeleted = false; } return; }
        private void button43_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[42]); if (directoryDeleted == true) { label43.Visible = true; button43.Visible = false; directoryDeleted = false; } return; }
        private void button44_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[43]); if (directoryDeleted == true) { label44.Visible = true; button44.Visible = false; directoryDeleted = false; } return; }
        private void button45_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[44]); if (directoryDeleted == true) { label45.Visible = true; button45.Visible = false; directoryDeleted = false; } return; }
        private void button46_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[45]); if (directoryDeleted == true) { label46.Visible = true; button46.Visible = false; directoryDeleted = false; } return; }
        private void button47_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[46]); if (directoryDeleted == true) { label47.Visible = true; button47.Visible = false; directoryDeleted = false; } return; }
        private void button48_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[47]); if (directoryDeleted == true) { label48.Visible = true; button48.Visible = false; directoryDeleted = false; } return; }
        private void button49_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[48]); if (directoryDeleted == true) { label49.Visible = true; button49.Visible = false; directoryDeleted = false; } return; }
        private void button50_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[49]); if (directoryDeleted == true) { label50.Visible = true; button50.Visible = false; directoryDeleted = false; } return; }
        private void button51_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[50]); if (directoryDeleted == true) { label51.Visible = true; button51.Visible = false; directoryDeleted = false; } return; }
        private void button52_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[51]); if (directoryDeleted == true) { label52.Visible = true; button52.Visible = false; directoryDeleted = false; } return; }
        private void button53_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[52]); if (directoryDeleted == true) { label53.Visible = true; button53.Visible = false; directoryDeleted = false; } return; }
        private void button54_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[53]); if (directoryDeleted == true) { label54.Visible = true; button54.Visible = false; directoryDeleted = false; } return; }
        private void button55_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[54]); if (directoryDeleted == true) { label55.Visible = true; button55.Visible = false; directoryDeleted = false; } return; }
        private void button56_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[55]); if (directoryDeleted == true) { label56.Visible = true; button56.Visible = false; directoryDeleted = false; } return; }
        private void button57_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[56]); if (directoryDeleted == true) { label57.Visible = true; button57.Visible = false; directoryDeleted = false; } return; }
        private void button58_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[57]); if (directoryDeleted == true) { label58.Visible = true; button58.Visible = false; directoryDeleted = false; } return; }
        private void button59_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[58]); if (directoryDeleted == true) { label59.Visible = true; button59.Visible = false; directoryDeleted = false; } return; }
        private void button60_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[59]); if (directoryDeleted == true) { label60.Visible = true; button60.Visible = false; directoryDeleted = false; } return; }
        private void button61_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[60]); if (directoryDeleted == true) { label61.Visible = true; button61.Visible = false; directoryDeleted = false; } return; }
        private void button62_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[61]); if (directoryDeleted == true) { label62.Visible = true; button62.Visible = false; directoryDeleted = false; } return; }
        private void button63_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[62]); if (directoryDeleted == true) { label63.Visible = true; button63.Visible = false; directoryDeleted = false; } return; }
        private void button64_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[63]); if (directoryDeleted == true) { label64.Visible = true; button64.Visible = false; directoryDeleted = false; } return; }
        private void button65_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[64]); if (directoryDeleted == true) { label65.Visible = true; button65.Visible = false; directoryDeleted = false; } return; }
        private void button66_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[65]); if (directoryDeleted == true) { label66.Visible = true; button66.Visible = false; directoryDeleted = false; } return; }
        private void button67_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[66]); if (directoryDeleted == true) { label67.Visible = true; button67.Visible = false; directoryDeleted = false; } return; }
        private void button68_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[67]); if (directoryDeleted == true) { label68.Visible = true; button68.Visible = false; directoryDeleted = false; } return; }
        private void button69_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[68]); if (directoryDeleted == true) { label69.Visible = true; button69.Visible = false; directoryDeleted = false; } return; }
        private void button70_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[69]); if (directoryDeleted == true) { label70.Visible = true; button70.Visible = false; directoryDeleted = false; } return; }
        private void button71_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[70]); if (directoryDeleted == true) { label71.Visible = true; button71.Visible = false; directoryDeleted = false; } return; }
        private void button72_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[71]); if (directoryDeleted == true) { label72.Visible = true; button72.Visible = false; directoryDeleted = false; } return; }
        private void button73_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[72]); if (directoryDeleted == true) { label73.Visible = true; button73.Visible = false; directoryDeleted = false; } return; }
        private void button74_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[73]); if (directoryDeleted == true) { label74.Visible = true; button74.Visible = false; directoryDeleted = false; } return; }
        private void button75_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[74]); if (directoryDeleted == true) { label75.Visible = true; button75.Visible = false; directoryDeleted = false; } return; }
        private void button76_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[75]); if (directoryDeleted == true) { label76.Visible = true; button76.Visible = false; directoryDeleted = false; } return; }
        private void button77_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[76]); if (directoryDeleted == true) { label77.Visible = true; button77.Visible = false; directoryDeleted = false; } return; }
        private void button78_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[77]); if (directoryDeleted == true) { label78.Visible = true; button78.Visible = false; directoryDeleted = false; } return; }
        private void button79_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[78]); if (directoryDeleted == true) { label79.Visible = true; button79.Visible = false; directoryDeleted = false; } return; }
        private void button80_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[79]); if (directoryDeleted == true) { label80.Visible = true; button80.Visible = false; directoryDeleted = false; } return; }
        private void button81_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[80]); if (directoryDeleted == true) { label81.Visible = true; button81.Visible = false; directoryDeleted = false; } return; }
        private void button82_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[81]); if (directoryDeleted == true) { label82.Visible = true; button82.Visible = false; directoryDeleted = false; } return; }
        private void button83_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[82]); if (directoryDeleted == true) { label83.Visible = true; button83.Visible = false; directoryDeleted = false; } return; }
        private void button84_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[83]); if (directoryDeleted == true) { label84.Visible = true; button84.Visible = false; directoryDeleted = false; } return; }
        private void button85_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[84]); if (directoryDeleted == true) { label85.Visible = true; button85.Visible = false; directoryDeleted = false; } return; }
        private void button86_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[85]); if (directoryDeleted == true) { label86.Visible = true; button86.Visible = false; directoryDeleted = false; } return; }
        private void button87_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[86]); if (directoryDeleted == true) { label87.Visible = true; button87.Visible = false; directoryDeleted = false; } return; }
        private void button88_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[87]); if (directoryDeleted == true) { label88.Visible = true; button88.Visible = false; directoryDeleted = false; } return; }
        private void button89_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[88]); if (directoryDeleted == true) { label89.Visible = true; button89.Visible = false; directoryDeleted = false; } return; }
        private void button90_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[89]); if (directoryDeleted == true) { label90.Visible = true; button90.Visible = false; directoryDeleted = false; } return; }
        private void button91_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[90]); if (directoryDeleted == true) { label91.Visible = true; button91.Visible = false; directoryDeleted = false; } return; }
        private void button92_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[91]); if (directoryDeleted == true) { label92.Visible = true; button92.Visible = false; directoryDeleted = false; } return; }
        private void button93_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[92]); if (directoryDeleted == true) { label93.Visible = true; button93.Visible = false; directoryDeleted = false; } return; }
        private void button94_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[93]); if (directoryDeleted == true) { label94.Visible = true; button94.Visible = false; directoryDeleted = false; } return; }
        private void button95_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[94]); if (directoryDeleted == true) { label95.Visible = true; button95.Visible = false; directoryDeleted = false; } return; }
        private void button96_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[95]); if (directoryDeleted == true) { label96.Visible = true; button96.Visible = false; directoryDeleted = false; } return; }
        private void button97_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[96]); if (directoryDeleted == true) { label97.Visible = true; button97.Visible = false; directoryDeleted = false; } return; }
        private void button98_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[97]); if (directoryDeleted == true) { label98.Visible = true; button98.Visible = false; directoryDeleted = false; } return; }
        private void button99_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[98]); if (directoryDeleted == true) { label99.Visible = true; button99.Visible = false; directoryDeleted = false; } return; }
        private void button100_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[99]); if (directoryDeleted == true) { label100.Visible = true; button100.Visible = false; directoryDeleted = false; } return; }
        private void button101_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[100]); if (directoryDeleted == true) { label101.Visible = true; button101.Visible = false; directoryDeleted = false; } return; }
        private void button102_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[101]); if (directoryDeleted == true) { label102.Visible = true; button102.Visible = false; directoryDeleted = false; } return; }
        private void button103_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[102]); if (directoryDeleted == true) { label103.Visible = true; button103.Visible = false; directoryDeleted = false; } return; }
        private void button104_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[103]); if (directoryDeleted == true) { label104.Visible = true; button104.Visible = false; directoryDeleted = false; } return; }
        private void button105_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[104]); if (directoryDeleted == true) { label105.Visible = true; button105.Visible = false; directoryDeleted = false; } return; }
        private void button106_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[105]); if (directoryDeleted == true) { label106.Visible = true; button106.Visible = false; directoryDeleted = false; } return; }
        private void button107_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[106]); if (directoryDeleted == true) { label107.Visible = true; button107.Visible = false; directoryDeleted = false; } return; }
        private void button108_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[107]); if (directoryDeleted == true) { label108.Visible = true; button108.Visible = false; directoryDeleted = false; } return; }
        private void button109_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[108]); if (directoryDeleted == true) { label109.Visible = true; button109.Visible = false; directoryDeleted = false; } return; }
        private void button110_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[109]); if (directoryDeleted == true) { label110.Visible = true; button110.Visible = false; directoryDeleted = false; } return; }
        private void button111_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[110]); if (directoryDeleted == true) { label111.Visible = true; button111.Visible = false; directoryDeleted = false; } return; }
        private void button112_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[111]); if (directoryDeleted == true) { label112.Visible = true; button112.Visible = false; directoryDeleted = false; } return; }
        private void button113_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[112]); if (directoryDeleted == true) { label113.Visible = true; button113.Visible = false; directoryDeleted = false; } return; }
        private void button114_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[113]); if (directoryDeleted == true) { label114.Visible = true; button114.Visible = false; directoryDeleted = false; } return; }
        private void button115_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[114]); if (directoryDeleted == true) { label115.Visible = true; button115.Visible = false; directoryDeleted = false; } return; }
        private void button116_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[115]); if (directoryDeleted == true) { label116.Visible = true; button116.Visible = false; directoryDeleted = false; } return; }
        private void button117_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[116]); if (directoryDeleted == true) { label117.Visible = true; button117.Visible = false; directoryDeleted = false; } return; }
        private void button118_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[117]); if (directoryDeleted == true) { label118.Visible = true; button118.Visible = false; directoryDeleted = false; } return; }
        private void button119_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[118]); if (directoryDeleted == true) { label119.Visible = true; button119.Visible = false; directoryDeleted = false; } return; }
        private void button120_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[119]); if (directoryDeleted == true) { label120.Visible = true; button120.Visible = false; directoryDeleted = false; } return; }
        private void button121_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[120]); if (directoryDeleted == true) { label121.Visible = true; button121.Visible = false; directoryDeleted = false; } return; }
        private void button122_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[121]); if (directoryDeleted == true) { label122.Visible = true; button122.Visible = false; directoryDeleted = false; } return; }
        private void button123_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[122]); if (directoryDeleted == true) { label123.Visible = true; button123.Visible = false; directoryDeleted = false; } return; }
        private void button124_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[123]); if (directoryDeleted == true) { label124.Visible = true; button124.Visible = false; directoryDeleted = false; } return; }
        private void button125_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[124]); if (directoryDeleted == true) { label125.Visible = true; button125.Visible = false; directoryDeleted = false; } return; }
        private void button126_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[125]); if (directoryDeleted == true) { label126.Visible = true; button126.Visible = false; directoryDeleted = false; } return; }
        private void button127_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[126]); if (directoryDeleted == true) { label127.Visible = true; button127.Visible = false; directoryDeleted = false; } return; }
        private void button128_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[127]); if (directoryDeleted == true) { label128.Visible = true; button128.Visible = false; directoryDeleted = false; } return; }
        private void button129_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[128]); if (directoryDeleted == true) { label129.Visible = true; button129.Visible = false; directoryDeleted = false; } return; }
        private void button130_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[129]); if (directoryDeleted == true) { label130.Visible = true; button130.Visible = false; directoryDeleted = false; } return; }
        private void button131_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[130]); if (directoryDeleted == true) { label131.Visible = true; button131.Visible = false; directoryDeleted = false; } return; }
        private void button132_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[131]); if (directoryDeleted == true) { label132.Visible = true; button132.Visible = false; directoryDeleted = false; } return; }
        private void button133_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[132]); if (directoryDeleted == true) { label133.Visible = true; button133.Visible = false; directoryDeleted = false; } return; }
        private void button134_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[133]); if (directoryDeleted == true) { label134.Visible = true; button134.Visible = false; directoryDeleted = false; } return; }
        private void button135_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[134]); if (directoryDeleted == true) { label135.Visible = true; button135.Visible = false; directoryDeleted = false; } return; }
        private void button136_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[135]); if (directoryDeleted == true) { label136.Visible = true; button136.Visible = false; directoryDeleted = false; } return; }
        private void button137_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[136]); if (directoryDeleted == true) { label137.Visible = true; button137.Visible = false; directoryDeleted = false; } return; }
        private void button138_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[137]); if (directoryDeleted == true) { label138.Visible = true; button138.Visible = false; directoryDeleted = false; } return; }
        private void button139_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[138]); if (directoryDeleted == true) { label139.Visible = true; button139.Visible = false; directoryDeleted = false; } return; }
        private void button140_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[139]); if (directoryDeleted == true) { label140.Visible = true; button140.Visible = false; directoryDeleted = false; } return; }
        private void button141_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[140]); if (directoryDeleted == true) { label141.Visible = true; button141.Visible = false; directoryDeleted = false; } return; }
        private void button142_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[141]); if (directoryDeleted == true) { label142.Visible = true; button142.Visible = false; directoryDeleted = false; } return; }
        private void button143_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[142]); if (directoryDeleted == true) { label143.Visible = true; button143.Visible = false; directoryDeleted = false; } return; }
        private void button144_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[143]); if (directoryDeleted == true) { label144.Visible = true; button144.Visible = false; directoryDeleted = false; } return; }
        private void button145_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[144]); if (directoryDeleted == true) { label145.Visible = true; button145.Visible = false; directoryDeleted = false; } return; }
        private void button146_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[145]); if (directoryDeleted == true) { label146.Visible = true; button146.Visible = false; directoryDeleted = false; } return; }
        private void button147_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[146]); if (directoryDeleted == true) { label147.Visible = true; button147.Visible = false; directoryDeleted = false; } return; }
        private void button148_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[147]); if (directoryDeleted == true) { label148.Visible = true; button148.Visible = false; directoryDeleted = false; } return; }
        private void button149_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[148]); if (directoryDeleted == true) { label149.Visible = true; button149.Visible = false; directoryDeleted = false; } return; }
        private void button150_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[149]); if (directoryDeleted == true) { label150.Visible = true; button150.Visible = false; directoryDeleted = false; } return; }
        private void button151_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[150]); if (directoryDeleted == true) { label151.Visible = true; button151.Visible = false; directoryDeleted = false; } return; }
        private void button152_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[151]); if (directoryDeleted == true) { label152.Visible = true; button152.Visible = false; directoryDeleted = false; } return; }
        private void button153_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[152]); if (directoryDeleted == true) { label153.Visible = true; button153.Visible = false; directoryDeleted = false; } return; }
        private void button154_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[153]); if (directoryDeleted == true) { label154.Visible = true; button154.Visible = false; directoryDeleted = false; } return; }
        private void button155_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[154]); if (directoryDeleted == true) { label155.Visible = true; button155.Visible = false; directoryDeleted = false; } return; }
        private void button156_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[155]); if (directoryDeleted == true) { label156.Visible = true; button156.Visible = false; directoryDeleted = false; } return; }
        private void button157_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[156]); if (directoryDeleted == true) { label157.Visible = true; button157.Visible = false; directoryDeleted = false; } return; }
        private void button158_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[157]); if (directoryDeleted == true) { label158.Visible = true; button158.Visible = false; directoryDeleted = false; } return; }
        private void button159_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[158]); if (directoryDeleted == true) { label159.Visible = true; button159.Visible = false; directoryDeleted = false; } return; }
        private void button160_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[159]); if (directoryDeleted == true) { label160.Visible = true; button160.Visible = false; directoryDeleted = false; } return; }
        private void button161_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[160]); if (directoryDeleted == true) { label161.Visible = true; button161.Visible = false; directoryDeleted = false; } return; }
        private void button162_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[161]); if (directoryDeleted == true) { label162.Visible = true; button162.Visible = false; directoryDeleted = false; } return; }
        private void button163_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[162]); if (directoryDeleted == true) { label163.Visible = true; button163.Visible = false; directoryDeleted = false; } return; }
        private void button164_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[163]); if (directoryDeleted == true) { label164.Visible = true; button164.Visible = false; directoryDeleted = false; } return; }
        private void button165_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[164]); if (directoryDeleted == true) { label165.Visible = true; button165.Visible = false; directoryDeleted = false; } return; }
        private void button166_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[165]); if (directoryDeleted == true) { label166.Visible = true; button166.Visible = false; directoryDeleted = false; } return; }
        private void button167_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[166]); if (directoryDeleted == true) { label167.Visible = true; button167.Visible = false; directoryDeleted = false; } return; }
        private void button168_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[167]); if (directoryDeleted == true) { label168.Visible = true; button168.Visible = false; directoryDeleted = false; } return; }
        private void button169_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[168]); if (directoryDeleted == true) { label169.Visible = true; button169.Visible = false; directoryDeleted = false; } return; }
        private void button170_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[169]); if (directoryDeleted == true) { label170.Visible = true; button170.Visible = false; directoryDeleted = false; } return; }
        private void button171_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[170]); if (directoryDeleted == true) { label171.Visible = true; button171.Visible = false; directoryDeleted = false; } return; }
        private void button172_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[171]); if (directoryDeleted == true) { label172.Visible = true; button172.Visible = false; directoryDeleted = false; } return; }
        private void button173_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[172]); if (directoryDeleted == true) { label173.Visible = true; button173.Visible = false; directoryDeleted = false; } return; }
        private void button174_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[173]); if (directoryDeleted == true) { label174.Visible = true; button174.Visible = false; directoryDeleted = false; } return; }
        private void button175_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[174]); if (directoryDeleted == true) { label175.Visible = true; button175.Visible = false; directoryDeleted = false; } return; }
        private void button176_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[175]); if (directoryDeleted == true) { label176.Visible = true; button176.Visible = false; directoryDeleted = false; } return; }
        private void button177_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[176]); if (directoryDeleted == true) { label177.Visible = true; button177.Visible = false; directoryDeleted = false; } return; }
        private void button178_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[177]); if (directoryDeleted == true) { label178.Visible = true; button178.Visible = false; directoryDeleted = false; } return; }
        private void button179_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[178]); if (directoryDeleted == true) { label179.Visible = true; button179.Visible = false; directoryDeleted = false; } return; }
        private void button180_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[179]); if (directoryDeleted == true) { label180.Visible = true; button180.Visible = false; directoryDeleted = false; } return; }
        private void button181_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[180]); if (directoryDeleted == true) { label181.Visible = true; button181.Visible = false; directoryDeleted = false; } return; }
        private void button182_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[181]); if (directoryDeleted == true) { label182.Visible = true; button182.Visible = false; directoryDeleted = false; } return; }
        private void button183_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[182]); if (directoryDeleted == true) { label183.Visible = true; button183.Visible = false; directoryDeleted = false; } return; }
        private void button184_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[183]); if (directoryDeleted == true) { label184.Visible = true; button184.Visible = false; directoryDeleted = false; } return; }
        private void button185_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[184]); if (directoryDeleted == true) { label185.Visible = true; button185.Visible = false; directoryDeleted = false; } return; }
        private void button186_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[185]); if (directoryDeleted == true) { label186.Visible = true; button186.Visible = false; directoryDeleted = false; } return; }
        private void button187_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[186]); if (directoryDeleted == true) { label187.Visible = true; button187.Visible = false; directoryDeleted = false; } return; }
        private void button188_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[187]); if (directoryDeleted == true) { label188.Visible = true; button188.Visible = false; directoryDeleted = false; } return; }
        private void button189_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[188]); if (directoryDeleted == true) { label189.Visible = true; button189.Visible = false; directoryDeleted = false; } return; }
        private void button190_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[189]); if (directoryDeleted == true) { label190.Visible = true; button190.Visible = false; directoryDeleted = false; } return; }
        private void button191_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[190]); if (directoryDeleted == true) { label191.Visible = true; button191.Visible = false; directoryDeleted = false; } return; }
        private void button192_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[191]); if (directoryDeleted == true) { label192.Visible = true; button192.Visible = false; directoryDeleted = false; } return; }
        private void button193_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[192]); if (directoryDeleted == true) { label193.Visible = true; button193.Visible = false; directoryDeleted = false; } return; }
        private void button194_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[193]); if (directoryDeleted == true) { label194.Visible = true; button194.Visible = false; directoryDeleted = false; } return; }
        private void button195_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[194]); if (directoryDeleted == true) { label195.Visible = true; button195.Visible = false; directoryDeleted = false; } return; }
        private void button196_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[195]); if (directoryDeleted == true) { label196.Visible = true; button196.Visible = false; directoryDeleted = false; } return; }
        private void button197_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[196]); if (directoryDeleted == true) { label197.Visible = true; button197.Visible = false; directoryDeleted = false; } return; }
        private void button198_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[197]); if (directoryDeleted == true) { label198.Visible = true; button198.Visible = false; directoryDeleted = false; } return; }
        private void button199_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[198]); if (directoryDeleted == true) { label199.Visible = true; button199.Visible = false; directoryDeleted = false; } return; }
        private void button200_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[199]); if (directoryDeleted == true) { label200.Visible = true; button200.Visible = false; directoryDeleted = false; } return; }
        private void button201_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[200]); if (directoryDeleted == true) { label201.Visible = true; button201.Visible = false; directoryDeleted = false; } return; }
        private void button202_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[201]); if (directoryDeleted == true) { label202.Visible = true; button202.Visible = false; directoryDeleted = false; } return; }
        private void button203_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[202]); if (directoryDeleted == true) { label203.Visible = true; button203.Visible = false; directoryDeleted = false; } return; }
        private void button204_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[203]); if (directoryDeleted == true) { label204.Visible = true; button204.Visible = false; directoryDeleted = false; } return; }
        private void button205_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[204]); if (directoryDeleted == true) { label205.Visible = true; button205.Visible = false; directoryDeleted = false; } return; }
        private void button206_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[205]); if (directoryDeleted == true) { label206.Visible = true; button206.Visible = false; directoryDeleted = false; } return; }
        private void button207_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[206]); if (directoryDeleted == true) { label207.Visible = true; button207.Visible = false; directoryDeleted = false; } return; }
        private void button208_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[207]); if (directoryDeleted == true) { label208.Visible = true; button208.Visible = false; directoryDeleted = false; } return; }
        private void button209_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[208]); if (directoryDeleted == true) { label209.Visible = true; button209.Visible = false; directoryDeleted = false; } return; }
        private void button210_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[209]); if (directoryDeleted == true) { label210.Visible = true; button210.Visible = false; directoryDeleted = false; } return; }
        private void button211_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[210]); if (directoryDeleted == true) { label211.Visible = true; button211.Visible = false; directoryDeleted = false; } return; }
        private void button212_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[211]); if (directoryDeleted == true) { label212.Visible = true; button212.Visible = false; directoryDeleted = false; } return; }
        private void button213_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[212]); if (directoryDeleted == true) { label213.Visible = true; button213.Visible = false; directoryDeleted = false; } return; }
        private void button214_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[213]); if (directoryDeleted == true) { label214.Visible = true; button214.Visible = false; directoryDeleted = false; } return; }
        private void button215_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[214]); if (directoryDeleted == true) { label215.Visible = true; button215.Visible = false; directoryDeleted = false; } return; }
        private void button216_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[215]); if (directoryDeleted == true) { label216.Visible = true; button216.Visible = false; directoryDeleted = false; } return; }
        private void button217_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[216]); if (directoryDeleted == true) { label217.Visible = true; button217.Visible = false; directoryDeleted = false; } return; }
        private void button218_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[217]); if (directoryDeleted == true) { label218.Visible = true; button218.Visible = false; directoryDeleted = false; } return; }
        private void button219_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[218]); if (directoryDeleted == true) { label219.Visible = true; button219.Visible = false; directoryDeleted = false; } return; }
        private void button220_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[219]); if (directoryDeleted == true) { label220.Visible = true; button220.Visible = false; directoryDeleted = false; } return; }
        private void button221_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[220]); if (directoryDeleted == true) { label221.Visible = true; button221.Visible = false; directoryDeleted = false; } return; }
        private void button222_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[221]); if (directoryDeleted == true) { label222.Visible = true; button222.Visible = false; directoryDeleted = false; } return; }
        private void button223_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[222]); if (directoryDeleted == true) { label223.Visible = true; button223.Visible = false; directoryDeleted = false; } return; }
        private void button224_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[223]); if (directoryDeleted == true) { label224.Visible = true; button224.Visible = false; directoryDeleted = false; } return; }
        private void button225_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[224]); if (directoryDeleted == true) { label225.Visible = true; button225.Visible = false; directoryDeleted = false; } return; }
        private void button226_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[225]); if (directoryDeleted == true) { label226.Visible = true; button226.Visible = false; directoryDeleted = false; } return; }
        private void button227_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[226]); if (directoryDeleted == true) { label227.Visible = true; button227.Visible = false; directoryDeleted = false; } return; }
        private void button228_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[227]); if (directoryDeleted == true) { label228.Visible = true; button228.Visible = false; directoryDeleted = false; } return; }
        private void button229_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[228]); if (directoryDeleted == true) { label229.Visible = true; button229.Visible = false; directoryDeleted = false; } return; }
        private void button230_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[229]); if (directoryDeleted == true) { label230.Visible = true; button230.Visible = false; directoryDeleted = false; } return; }
        private void button231_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[230]); if (directoryDeleted == true) { label231.Visible = true; button231.Visible = false; directoryDeleted = false; } return; }
        private void button232_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[231]); if (directoryDeleted == true) { label232.Visible = true; button232.Visible = false; directoryDeleted = false; } return; }
        private void button233_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[232]); if (directoryDeleted == true) { label233.Visible = true; button233.Visible = false; directoryDeleted = false; } return; }
        private void button234_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[233]); if (directoryDeleted == true) { label234.Visible = true; button234.Visible = false; directoryDeleted = false; } return; }
        private void button235_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[234]); if (directoryDeleted == true) { label235.Visible = true; button235.Visible = false; directoryDeleted = false; } return; }
        private void button236_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[235]); if (directoryDeleted == true) { label236.Visible = true; button236.Visible = false; directoryDeleted = false; } return; }
        private void button237_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[236]); if (directoryDeleted == true) { label237.Visible = true; button237.Visible = false; directoryDeleted = false; } return; }
        private void button238_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[237]); if (directoryDeleted == true) { label238.Visible = true; button238.Visible = false; directoryDeleted = false; } return; }
        private void button239_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[238]); if (directoryDeleted == true) { label239.Visible = true; button239.Visible = false; directoryDeleted = false; } return; }
        private void button240_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[239]); if (directoryDeleted == true) { label240.Visible = true; button240.Visible = false; directoryDeleted = false; } return; }
        private void button241_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[240]); if (directoryDeleted == true) { label241.Visible = true; button241.Visible = false; directoryDeleted = false; } return; }
        private void button242_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[241]); if (directoryDeleted == true) { label242.Visible = true; button242.Visible = false; directoryDeleted = false; } return; }
        private void button243_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[242]); if (directoryDeleted == true) { label243.Visible = true; button243.Visible = false; directoryDeleted = false; } return; }
        private void button244_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[243]); if (directoryDeleted == true) { label244.Visible = true; button244.Visible = false; directoryDeleted = false; } return; }
        private void button245_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[244]); if (directoryDeleted == true) { label245.Visible = true; button245.Visible = false; directoryDeleted = false; } return; }
        private void button246_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[245]); if (directoryDeleted == true) { label246.Visible = true; button246.Visible = false; directoryDeleted = false; } return; }
        private void button247_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[246]); if (directoryDeleted == true) { label247.Visible = true; button247.Visible = false; directoryDeleted = false; } return; }
        private void button248_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[247]); if (directoryDeleted == true) { label248.Visible = true; button248.Visible = false; directoryDeleted = false; } return; }
        private void button249_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[248]); if (directoryDeleted == true) { label249.Visible = true; button249.Visible = false; directoryDeleted = false; } return; }
        private void button250_Click(object sender, EventArgs e) { ConfirmDeletion(callRecordingsList[249]); if (directoryDeleted == true) { label250.Visible = true; button250.Visible = false; directoryDeleted = false; } return; }

        private void ResetDeletedLabels()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            label47.Visible = false;
            label48.Visible = false;
            label49.Visible = false;
            label50.Visible = false;
            label51.Visible = false;
            label52.Visible = false;
            label53.Visible = false;
            label54.Visible = false;
            label55.Visible = false;
            label56.Visible = false;
            label57.Visible = false;
            label58.Visible = false;
            label59.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            label62.Visible = false;
            label63.Visible = false;
            label64.Visible = false;
            label65.Visible = false;
            label66.Visible = false;
            label67.Visible = false;
            label68.Visible = false;
            label69.Visible = false;
            label70.Visible = false;
            label71.Visible = false;
            label72.Visible = false;
            label73.Visible = false;
            label74.Visible = false;
            label75.Visible = false;
            label76.Visible = false;
            label77.Visible = false;
            label78.Visible = false;
            label79.Visible = false;
            label80.Visible = false;
            label81.Visible = false;
            label82.Visible = false;
            label83.Visible = false;
            label84.Visible = false;
            label85.Visible = false;
            label86.Visible = false;
            label87.Visible = false;
            label88.Visible = false;
            label89.Visible = false;
            label90.Visible = false;
            label91.Visible = false;
            label92.Visible = false;
            label93.Visible = false;
            label94.Visible = false;
            label95.Visible = false;
            label96.Visible = false;
            label97.Visible = false;
            label98.Visible = false;
            label99.Visible = false;
            label100.Visible = false;
            label101.Visible = false;
            label102.Visible = false;
            label103.Visible = false;
            label104.Visible = false;
            label105.Visible = false;
            label106.Visible = false;
            label107.Visible = false;
            label108.Visible = false;
            label109.Visible = false;
            label110.Visible = false;
            label111.Visible = false;
            label112.Visible = false;
            label113.Visible = false;
            label114.Visible = false;
            label115.Visible = false;
            label116.Visible = false;
            label117.Visible = false;
            label118.Visible = false;
            label119.Visible = false;
            label120.Visible = false;
            label121.Visible = false;
            label122.Visible = false;
            label123.Visible = false;
            label124.Visible = false;
            label125.Visible = false;
            label126.Visible = false;
            label127.Visible = false;
            label128.Visible = false;
            label129.Visible = false;
            label130.Visible = false;
            label131.Visible = false;
            label132.Visible = false;
            label133.Visible = false;
            label134.Visible = false;
            label135.Visible = false;
            label136.Visible = false;
            label137.Visible = false;
            label138.Visible = false;
            label139.Visible = false;
            label140.Visible = false;
            label141.Visible = false;
            label142.Visible = false;
            label143.Visible = false;
            label144.Visible = false;
            label145.Visible = false;
            label146.Visible = false;
            label147.Visible = false;
            label148.Visible = false;
            label149.Visible = false;
            label150.Visible = false;
            label151.Visible = false;
            label152.Visible = false;
            label153.Visible = false;
            label154.Visible = false;
            label155.Visible = false;
            label156.Visible = false;
            label157.Visible = false;
            label158.Visible = false;
            label159.Visible = false;
            label160.Visible = false;
            label161.Visible = false;
            label162.Visible = false;
            label163.Visible = false;
            label164.Visible = false;
            label165.Visible = false;
            label166.Visible = false;
            label167.Visible = false;
            label168.Visible = false;
            label169.Visible = false;
            label170.Visible = false;
            label171.Visible = false;
            label172.Visible = false;
            label173.Visible = false;
            label174.Visible = false;
            label175.Visible = false;
            label176.Visible = false;
            label177.Visible = false;
            label178.Visible = false;
            label179.Visible = false;
            label180.Visible = false;
            label181.Visible = false;
            label182.Visible = false;
            label183.Visible = false;
            label184.Visible = false;
            label185.Visible = false;
            label186.Visible = false;
            label187.Visible = false;
            label188.Visible = false;
            label189.Visible = false;
            label190.Visible = false;
            label191.Visible = false;
            label192.Visible = false;
            label193.Visible = false;
            label194.Visible = false;
            label195.Visible = false;
            label196.Visible = false;
            label197.Visible = false;
            label198.Visible = false;
            label199.Visible = false;
            label200.Visible = false;
            label201.Visible = false;
            label202.Visible = false;
            label203.Visible = false;
            label204.Visible = false;
            label205.Visible = false;
            label206.Visible = false;
            label207.Visible = false;
            label208.Visible = false;
            label209.Visible = false;
            label210.Visible = false;
            label211.Visible = false;
            label212.Visible = false;
            label213.Visible = false;
            label214.Visible = false;
            label215.Visible = false;
            label216.Visible = false;
            label217.Visible = false;
            label218.Visible = false;
            label219.Visible = false;
            label220.Visible = false;
            label221.Visible = false;
            label222.Visible = false;
            label223.Visible = false;
            label224.Visible = false;
            label225.Visible = false;
            label226.Visible = false;
            label227.Visible = false;
            label228.Visible = false;
            label229.Visible = false;
            label230.Visible = false;
            label231.Visible = false;
            label232.Visible = false;
            label233.Visible = false;
            label234.Visible = false;
            label235.Visible = false;
            label236.Visible = false;
            label237.Visible = false;
            label238.Visible = false;
            label239.Visible = false;
            label240.Visible = false;
            label241.Visible = false;
            label242.Visible = false;
            label243.Visible = false;
            label244.Visible = false;
            label245.Visible = false;
            label246.Visible = false;
            label247.Visible = false;
            label248.Visible = false;
            label249.Visible = false;
            label250.Visible = false;
        }

        internal void ResetComboBoxSettings()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
            button100.Visible = false;
            button101.Visible = false;
            button102.Visible = false;
            button103.Visible = false;
            button104.Visible = false;
            button105.Visible = false;
            button106.Visible = false;
            button107.Visible = false;
            button101.Visible = false;
            button102.Visible = false;
            button103.Visible = false;
            button104.Visible = false;
            button105.Visible = false;
            button106.Visible = false;
            button107.Visible = false;
            button101.Visible = false;
            button102.Visible = false;
            button103.Visible = false;
            button104.Visible = false;
            button105.Visible = false;
            button106.Visible = false;
            button107.Visible = false;
            button108.Visible = false;
            button109.Visible = false;
            button110.Visible = false;
            button111.Visible = false;
            button112.Visible = false;
            button113.Visible = false;
            button114.Visible = false;
            button115.Visible = false;
            button116.Visible = false;
            button117.Visible = false;
            button118.Visible = false;
            button119.Visible = false;
            button130.Visible = false;
            button129.Visible = false;
            button123.Visible = false;
            button128.Visible = false;
            button122.Visible = false;
            button127.Visible = false;
            button121.Visible = false;
            button120.Visible = false;
            button125.Visible = false;
            button126.Visible = false;
            button124.Visible = false;
            button131.Visible = false;
            button132.Visible = false;
            button133.Visible = false;
            button134.Visible = false;
            button135.Visible = false;
            button136.Visible = false;
            button137.Visible = false;
            button138.Visible = false;
            button139.Visible = false;
            button140.Visible = false;
            button141.Visible = false;
            button142.Visible = false;
            button143.Visible = false;
            button144.Visible = false;
            button145.Visible = false;
            button146.Visible = false;
            button147.Visible = false;
            button148.Visible = false;
            button149.Visible = false;
            button150.Visible = false;
            button151.Visible = false;
            button152.Visible = false;
            button153.Visible = false;
            button154.Visible = false;
            button155.Visible = false;
            button156.Visible = false;
            button157.Visible = false;
            button158.Visible = false;
            button159.Visible = false;
            button160.Visible = false;
            button161.Visible = false;
            button162.Visible = false;
            button163.Visible = false;
            button164.Visible = false;
            button165.Visible = false;
            button166.Visible = false;
            button167.Visible = false;
            button168.Visible = false;
            button169.Visible = false;
            button170.Visible = false;
            button171.Visible = false;
            button172.Visible = false;
            button173.Visible = false;
            button174.Visible = false;
            button175.Visible = false;
            button176.Visible = false;
            button177.Visible = false;
            button178.Visible = false;
            button179.Visible = false;
            button180.Visible = false;
            button181.Visible = false;
            button182.Visible = false;
            button183.Visible = false;
            button184.Visible = false;
            button185.Visible = false;
            button186.Visible = false;
            button187.Visible = false;
            button188.Visible = false;
            button189.Visible = false;
            button190.Visible = false;
            button191.Visible = false;
            button192.Visible = false;
            button193.Visible = false;
            button194.Visible = false;
            button195.Visible = false;
            button196.Visible = false;
            button197.Visible = false;
            button198.Visible = false;
            button199.Visible = false;
            button200.Visible = false;
            button201.Visible = false;
            button202.Visible = false;
            button203.Visible = false;
            button204.Visible = false;
            button205.Visible = false;
            button206.Visible = false;
            button207.Visible = false;
            button208.Visible = false;
            button209.Visible = false;
            button210.Visible = false;
            button211.Visible = false;
            button212.Visible = false;
            button213.Visible = false;
            button214.Visible = false;
            button215.Visible = false;
            button216.Visible = false;
            button217.Visible = false;
            button218.Visible = false;
            button219.Visible = false;
            button220.Visible = false;
            button221.Visible = false;
            button222.Visible = false;
            button223.Visible = false;
            button224.Visible = false;
            button225.Visible = false;
            button226.Visible = false;
            button227.Visible = false;
            button228.Visible = false;
            button229.Visible = false;
            button230.Visible = false;
            button231.Visible = false;
            button232.Visible = false;
            button233.Visible = false;
            button234.Visible = false;
            button235.Visible = false;
            button236.Visible = false;
            button237.Visible = false;
            button238.Visible = false;
            button239.Visible = false;
            button240.Visible = false;
            button241.Visible = false;
            button242.Visible = false;
            button243.Visible = false;
            button244.Visible = false;
            button245.Visible = false;
            button246.Visible = false;
            button247.Visible = false;
            button248.Visible = false;
            button249.Visible = false;
            button250.Visible = false;

            ResetDeletedLabels();

            information_label.ResetText();
            information_label_two.ResetText();

            dirPath_Label.Text = "Path: ";

            excludedNames.Clear();

            numOfFilesNotInADirectory = 0;

            Num_Of_Files_Not_In_Directory_Count_Label.Text = "0";
            Num_Of_Files_Not_In_Directory_Label.ForeColor = Color.White;
            Num_Of_Files_Not_In_Directory_Count_Label.ForeColor = Color.White;

            callRecordingsList.Clear();
            panel1.Size = new Size(800, 650);
        }

        // 'Esc' keyboard press returns to previous form.
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                ResetComboBoxSettings();
                firstSearch = true;

                this.Close();
                this.DialogResult = DialogResult.OK;
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Main_Menu_Button_Click(object sender, EventArgs e)
        {
            ResetComboBoxSettings();

            firstSearch = true; // prevent CallRecordings() being called twice upon clicking Call Recordings button.

            DialogResult = DialogResult.OK;
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Debugging Two")
            {
                comboBox1.SelectedIndex = 0;
            }

            ResetComboBoxSettings();

            GetCallRecordings();
        }

        private void F5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                ResetComboBoxSettings();

                GetCallRecordings();
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            firstSearch = true;

            ResetComboBoxSettings();

            DialogResult = DialogResult.OK;
        }
    }
}
