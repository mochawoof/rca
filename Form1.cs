using System.Diagnostics;

namespace rca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean usingcmd = true;

        private void getIPConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.FileName = (usingcmd == true) ? "cmd.exe" : "powershell.exe";
            psi.Arguments = "/c ipconfig";
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            p.StartInfo = psi;
            p.Start();
            textBox1.Text += p.StandardOutput.ReadToEnd() + "\n\n";
        }

        private void usingCmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usingcmd = !usingcmd;
            if (usingcmd)
            {
                usingCmdToolStripMenuItem.Text = "Using cmd";
            }
            else
            {
                usingCmdToolStripMenuItem.Text = "Using powershell";
            }
        }

        private void clearConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void aboutRCA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Remote Control Application version 1.\n\nThis software is freely available at https://github.com/mochawoof/rca.", "About RCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
