using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace KF2服务器重启工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string profile = Application.StartupPath + "\\CrashTool.ini";
        int CrashCount = 0;
        int[] Serverpids;

        private void Catch_Tick(object sender, EventArgs e)
        {
            var index = 0;
            foreach (int pid in Serverpids)
            {
                var state = false;
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.Id == pid)
                    { 
                        state = true;
                        break;
                    }
                }
                if (!state)
                {
                    CrashCount++;
                    this.Text = "KF2Server_CrashTool - 崩溃次数: " + CrashCount;
                    StartServer(ServerList.Items[index].ToString(), index);
                }
                index++;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (ServerList.Items.Count == 0) return;
            if (Start.Text == "启动")
            {
                Start.Text = "停止";
                Import.Enabled = AddServer.Enabled = DelServer.Enabled = false;
                Serverpids = new int[ServerList.Items.Count];
                Catch.Enabled = true;
                var index = 0;
                var profile = "";
                foreach (string ServerArguments in ServerList.Items)
                {
                    StartServer(ServerArguments, index);
                    index++;
                    profile += (ServerArguments + "\r\n");
                }
                WriteProfile(profile);
            }
            else
            {
                Start.Text = "启动";
                Import.Enabled = AddServer.Enabled = DelServer.Enabled = true;
                Catch.Enabled = false;
            }
        }

        private void WriteProfile(string text)
        {
            FileStream stream = File.Create(Application.StartupPath + "\\CrashTool.ini");
            StreamWriter write = new StreamWriter(stream);
            write.Write(text);
            write.Close();
            write.Dispose();
        }

        private void StartServer(string Arguments, int index)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = @"Binaries\win64\KFServer";
                process.StartInfo.Arguments = Arguments;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = false;
                process.Start();
                Serverpids[index] = process.Id;
            }
        }

        private void AddServer_Click(object sender, EventArgs e)
        {
            ServerList.Items.Add("New Server <Select to Edit Server Arguments>");
        }

        private void ServerList_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Writer.Text = ServerList.SelectedItems[0].ToString();
            }catch { }
        }

        private void Writer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = ServerList.SelectedIndex;
                ServerList.Items[index] = Writer.Text;
            }
            catch { }
        }

        private void DelServer_Click(object sender, EventArgs e)
        {
            try
            { 
                ServerList.Items.RemoveAt(ServerList.SelectedIndex);
            }catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(profile))
            {
                using (StreamReader sr = new StreamReader(profile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Trim() != "")
                        {
                            ServerList.Items.Add(line);
                        }
                    }
                }
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Files (CrashTool.ini)|CrashTool.ini"//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
            ServerList.Items.Clear();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Trim() != "")
                    {
                        ServerList.Items.Add(line);
                    }
                }
            }
        }
    }
}
