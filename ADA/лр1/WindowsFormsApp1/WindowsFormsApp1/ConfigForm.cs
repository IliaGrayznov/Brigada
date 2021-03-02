using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ConfigForm : Form
    {
        bool stop = false;
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(Conf);
            th.Start();
        }

        private void Conf()
        {
            var process = new Process();
            process.StartInfo.FileName = "ipconfig";
            if (checkBox1.Checked) process.StartInfo.Arguments += " /all ";
            process.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            //  process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();


            StreamReader st = process.StandardOutput;
            while (!st.EndOfStream)
            {
                if (stop)
                {
                    st.Close();
                    stop = !stop;
                    break;
                }
                textBox1.Invoke(new MethodInvoker(() => {
                    textBox1.AppendText(st.ReadLine() + Environment.NewLine);
                }), null);
            }

            process.WaitForExit();
        }
    }
}
