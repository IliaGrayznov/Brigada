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
    public partial class ARPForm : Form
    {
        bool stop = false;
        uint n;
        public ARPForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(ARP);
            th.Start();
        }
        private void ARP()
        {
            var process = new Process();
            process.StartInfo.FileName = "arp";
            if (aradioButton1.Checked) process.StartInfo.Arguments += " -a ";
            if (sradioButton2.Checked)
            {
                process.StartInfo.Arguments += " -s ";
                IPtextBox.Enabled = true;
                MACtextBox.Enabled = true;
                if (uint.TryParse(IPtextBox.Text, out n))
                    process.StartInfo.Arguments += " " + IPtextBox.Text+ " ";
                if (uint.TryParse(MACtextBox.Text, out n))
                    process.StartInfo.Arguments += " " + MACtextBox.Text + " ";
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
                    textBox1.AppendText(st.ReadLine() + Environment.NewLine);
                }), null);
            }

            process.WaitForExit();
        }
    }
}
