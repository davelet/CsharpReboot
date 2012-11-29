using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Process process = new Process();

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("hello world.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("hello world.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            //运行CMD的SHUTDOWN命令
            process.StandardInput.WriteLine("shutdown -a");
            //process.StandardInput.WriteLine("exit");
            process.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            //运行CMD的SHUTDOWN命令
            process.StandardInput.WriteLine("shutdown -s -t 100");
            //process.StandardInput.WriteLine("exit");
            process.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            //运行CMD的SHUTDOWN命令
            process.StandardInput.WriteLine("shutdown -r -t 100");
            process.Close();
        }

    }
}
