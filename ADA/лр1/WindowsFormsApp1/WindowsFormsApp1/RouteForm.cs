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
    public partial class RouteForm : Form
    {
        bool stop = false;
        uint n;
        public RouteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(ROU);
            th.Start();
        }

        private void ROU()
        {
            var process = new Process();
            process.StartInfo.FileName = "route";
            if (FcheckBox.Checked) process.StartInfo.Arguments += " -f ";
            if (PcheckBox.Checked) process.StartInfo.Arguments += " -p ";
            if (PradioButton.Checked) process.StartInfo.Arguments += " print ";
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
