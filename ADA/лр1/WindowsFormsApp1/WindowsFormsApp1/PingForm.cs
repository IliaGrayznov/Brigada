using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class PingForm : Form
    {
        bool stop = false;
        uint n;
        public PingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(Ping);
            th.Start();
        }

        private void Ping()
        {
            var process = new Process();
            process.StartInfo.FileName = "ping";
            process.StartInfo.Arguments = IPtextBox.Text;
            if (checkBox1.Checked) process.StartInfo.Arguments += " -t ";
            if (uint.TryParse(NtextBox.Text, out n))
            {
                process.StartInfo.Arguments += " -n " + NtextBox.Text; 
            }
            if (uint.TryParse(TimetextBox.Text, out n))
            {
                process.StartInfo.Arguments += " -w " + TimetextBox.Text;
            }
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
                    textBox1.AppendText(st.ReadLine()+Environment.NewLine);
                }), null);
            }

            process.WaitForExit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop = !stop;
        }
    }
}
