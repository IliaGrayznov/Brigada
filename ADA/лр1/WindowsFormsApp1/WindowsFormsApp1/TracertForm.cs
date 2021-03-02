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
    public partial class TracertForm : Form
    {
        bool stop = false;
        uint n;
        public TracertForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(Trac);
            th.Start();
        }

        private void Trac()
        {
            var process = new Process();
            process.StartInfo.FileName = "tracert";
            if (uint.TryParse(textBoxH.Text, out n))
            {
                process.StartInfo.Arguments += " -h " + textBoxH.Text;
            }
            if (uint.TryParse(TimetextBox.Text, out n))
            {
                process.StartInfo.Arguments += " -w " + TimetextBox.Text;
            }
            process.StartInfo.Arguments +=" " + IPtextbox.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            stop = !stop;
        }
    }
}
