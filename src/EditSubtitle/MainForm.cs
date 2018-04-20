using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace EditSubtitle
{
    public partial class MainForm : Form
    {
        bool okKeyChar = false;
        string[] fileData;

        public MainForm()
        {
            InitializeComponent();
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "\\d+") && !okKeyChar)
                e.Handled = true;
        }

        private void txtTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Clear ||
                e.KeyData == Keys.OemBackslash || e.KeyData == Keys.Back)
                okKeyChar = true;
            else okKeyChar = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    txtOpenPath.Text = openFileDialog1.FileName;
                    fileData = File.ReadAllLines(txtOpenPath.Text, Encoding.Default);
                }
                else txtOpenPath.Text = "";
            }
            checkButtonEnables();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = saveFileDialog1.FileName;
            }
            checkButtonEnables();
        }

        private void checkButtonEnables()
        {
            if (txtSavePath.Text != string.Empty && txtOpenPath.Text != string.Empty && txtTime.Text != string.Empty)
            {
                btnTtBack.Enabled = true;
                btnTtForward.Enabled = true;
            }
            else
            {
                btnTtBack.Enabled = false;
                btnTtForward.Enabled = false;
            }
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnables();
        }

        private void btnTtBack_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(txtSavePath.Text, compileSubtitle(true, int.Parse(txtTime.Text)));
        }

        private void btnTtForward_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(txtSavePath.Text, compileSubtitle(false, int.Parse(txtTime.Text)));
        }

        private string[] compileSubtitle(bool backward, int second)
        {
            List<string> lstFile = new List<string>();
            int s_sec = 0, s_min = 0, s_hour = 0; // start time
            int e_sec = 0, e_min = 0, e_hour = 0; // end time
            int s, m, h;
            string sms, ems;
            prbDone.Maximum = fileData.Length;
            prbDone.Value = 0;
            //
            // convert second to hour, min, sec
            //
            if (second >= 60)
            {
                m = second / 60;
                s = second % 60;
                if (m >= 60)
                {
                    h = m / 60;
                    m %= 60;
                }
                else h = 0;
            }
            else
            {
                m = h = 0;
                s = second;
            }
            //
            // read all line of subtitle
            //
            for (int line = 0; line < fileData.Length; line++)
            {
                if (fileData[line].ValidateTimeLine())
                {
                    //
                    // exmaple:
                    //         00:02:03,669 --> 00:02:07,506
                    //         0123456789          0123456789
                    //                   0123456789
                    //          
                    string strLine = fileData[line];
                    s_hour = s_min = s_sec = 0;
                    e_hour = e_min = e_sec = 0;

                    try
                    {
                        //
                        // start Hour
                        s_hour = Convert.ToInt32(strLine.Substring(0, 2));
                        //
                        // start Minute
                        s_min = Convert.ToInt32(strLine.Substring(3, 2));
                        //
                        // start Second
                        s_sec = Convert.ToInt32(strLine.Substring(6, 2));
                        //
                        // start Mili Second
                        sms = strLine.Substring(9, 3);
                        //
                        // end Hour
                        e_hour = Convert.ToInt32(strLine.Substring(17, 2));
                        //
                        // end Minute
                        e_min = Convert.ToInt32(strLine.Substring(20, 2));
                        //
                        // end Second
                        e_sec = Convert.ToInt32(strLine.Substring(23, 2));
                        //
                        // end Mili Second
                        ems = strLine.Substring(26, 3);
                        //
                        // add or subtruct second of subtitle
                        //
                        TimeSpan startTime = new TimeSpan(s_hour, s_min, s_sec);
                        TimeSpan endTime = new TimeSpan(e_hour, e_min, e_sec);
                        TimeSpan unTructTime = new TimeSpan(h, m, s);

                        if (backward) // subtruct
                        {
                            startTime = startTime.Subtract(unTructTime);
                            endTime = endTime.Subtract(unTructTime);
                        }
                        else // add
                        {
                            startTime = startTime.Add(unTructTime);
                            endTime = endTime.Add(unTructTime);
                        }
                        //
                        // convert to time line string
                        //
                        string ss, sm, sh, es, em, eh;

                        ss = (startTime.Seconds >= 10) ? "" : "0";
                        if (startTime.Seconds < 0) ss = "00";
                        else ss += startTime.Seconds.ToString();

                        sm = (startTime.Minutes >= 10) ? "" : "0";
                        if (startTime.Minutes < 0) sm = "00";
                        else sm += startTime.Minutes.ToString();

                        sh = (startTime.Hours >= 10) ? "" : "0";
                        if (startTime.Hours < 0) sh = "00";
                        else sh += startTime.Hours.ToString();

                        es = (endTime.Seconds >= 10) ? "" : "0";
                        if (endTime.Seconds < 0) es = "00";
                        else es += endTime.Seconds.ToString();

                        em = (endTime.Minutes >= 10) ? "" : "0";
                        if (endTime.Minutes < 0) em = "00";
                        else em += endTime.Minutes.ToString();

                        eh = (endTime.Hours >= 10) ? "" : "0";
                        if (endTime.Hours < 0) eh = "00";
                        else eh += endTime.Hours.ToString();
                        //
                        // set to array
                        // 
                        lstFile.Add(string.Format(System.Globalization.CultureInfo.CurrentCulture,
                            "{0}:{1}:{2},{3} --> {4}:{5}:{6},{7}", sh, sm, ss, sms, eh, em, es, ems));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return fileData;
                    }
                }
                else lstFile.Add(fileData[line]);

                prbDone.Value++;
            }


            return lstFile.ToArray();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBoxForm about = new AboutBoxForm();
            about.ShowDialog();
        }
    }

    public static class MyExtensions
    {
        public static bool ValidateTimeLine(this string timeLine)
        {
            //Regex exp = new Regex(@"\d\d\:\d\d\:\d\d\,\d\d\d\s\-\-\>\s\d\d\:\d\d\:\d\d\,\d\d\d");
            Regex exp = new Regex(@"^\d{2}:\d{2}:\d{2},\d{3}\s-->\s\d{2}:\d{2}:\d{2},\d{3}$");
            return exp.IsMatch(timeLine);
        }
    }
}
