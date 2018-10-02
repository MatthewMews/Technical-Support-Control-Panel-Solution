using System;
using System.IO;
using System.Collections.Generic;

namespace Technical_Support_Control_Panel
{
    class StaffListCheck // Checks to see if there are any folders that should be ignored from the call recordings search.
    {
        public static List<string> testing = new List<string>();

        private static string linesFromFile = String.Empty;

        public static void GetStaffNames()
        {
            switch(Call_Recordings_Form.dirPath)
            {
                case @"FIRST CALL RECORDING PATH": GetIASRecordingsStaffList(); break;
                case @"SECOND CALL RECORDING PATH": GetMedwayRecordingsStaffList(); break;
                case @"THIRD CALL RECORDING PATH": GetTCPRecordingsStaffList(); break;

                default: break;     
            } 
        }

        private static void GetIASRecordingsStaffList()
        {
            using (StreamReader sr = new StreamReader(@"REDACTED TEXT FILE PATH", true))
            {
                while (!sr.EndOfStream)
                {
                    string temp = sr.ReadLine();

                    if (temp != "")
                    {
                        Call_Recordings_Form.excludedNames.Add(temp);
                    }
                }
            }
        }

        private static void GetMedwayRecordingsStaffList()
        {
            using (StreamReader sr = new StreamReader(@"REDACTED TEXT FILE PATH", true))
              {
                while (!sr.EndOfStream)
                {
                    string temp = sr.ReadLine();

                    if (temp != "")
                    {
                        Call_Recordings_Form.excludedNames.Add(temp);
                    }
                }
            }
        }

        private static void GetTCPRecordingsStaffList()
        {
            using (StreamReader sr = new StreamReader(@"REDACTED TEXT FILE PATH", true))
            {
                while (!sr.EndOfStream)
                {
                    string temp = sr.ReadLine();

                    if (temp != "")
                    {
                        Call_Recordings_Form.excludedNames.Add(temp);
                    }
                }
            }
        }
    }
}
