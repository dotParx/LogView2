using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadLog_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("logs");
            dt.Clear();
            dt.Columns.Add("LN", typeof(Int16));
            dt.Columns.Add("ID", typeof(String));
            dt.Columns.Add("DATE", typeof(DateTime));
            dt.Columns.Add("USER", typeof(String));
            dt.Columns.Add("IP", typeof(String));
            dt.Columns.Add("MESSAGE", typeof(String));
            string pattern = @"^\((?<id>\d*?)\)\s+(?<date>.{8,10}?)\s+(?<time>.*?) (A|P)M - (?<user>.+?)\s+\((?<ip>\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})\)\> (?<msg>.*)$";
            Int16 linenum = 0;
            
            if(Globals.logName.Length > 3)
            {
                using (var sr = new StreamReader(Globals.logName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        linenum++;
                        Match rgx = Regex.Match(line, pattern);
                        DataRow _toAdd = dt.NewRow();
                        _toAdd["LN"] = linenum;
                        _toAdd["ID"] = int.Parse(rgx.Groups["id"].Value);
                        _toAdd["DATE"] = rgx.Groups["date"] + " " + rgx.Groups["time"];
                        _toAdd["USER"] = rgx.Groups["user"];
                        _toAdd["IP"] = rgx.Groups["ip"];
                        _toAdd["MESSAGE"] = rgx.Groups["msg"];
                        dt.Rows.Add(_toAdd);
                    }
                }
                if (dataSet1.Tables.Contains("logs"))
                {
                    dataSet1.Tables.Remove("logs");
                }
                dataSet1.Tables.Add(dt);
                logLines.Text = "Lines: " + linenum.ToString();
                logView.DataSource = dt;
            }             
        }
        public static class Globals
        {
            public static String logName = ""; // Modifiable in Code
        }
        public static class Filters
        {
            public static DateTime dt_Date;
            public static String s_User = "";
            public static String s_Ip = "";
            public static String s_Msg = "";
        }

        private void logSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    Globals.logName = file;
                    logFileName.Text = "Log: " + file;
                }
                catch (InvalidOperationException)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filter();
        }
        public void filter()
        {
            DataTable table = dataSet1.Tables["logs"];
            string expression;
            expression = "USER LIKE '%" + filterUser.Text + "%' AND IP LIKE '%" + filterIp.Text + "%' AND MESSAGE LIKE '%" + filterMsg.Text + "%'";
            table = table.Select(expression).CopyToDataTable();
            logView.DataSource = table;
        }
        private void filterUser_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
