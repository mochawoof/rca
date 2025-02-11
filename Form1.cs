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
        private int port = 65535;

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

        private void port0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string so = Microsoft.VisualBasic.Interaction.InputBox("Enter a port number from 1-65535. Make sure it is forwarded and not in use.", "Prompt", port + "", 0, 0);
            if (so != null && so.Trim() != "")
            {
                Boolean fail = false;
                try
                {
                    int o = Convert.ToInt32(so);
                    if (o >= 1 && o <= 65535)
                    {
                        port = o;
                        port0ToolStripMenuItem.Text = "Port " + port;
                    } else
                    {
                        fail = true;
                    }
                }
                catch
                {
                    fail = true;
                }

                if (fail)
                {
                    MessageBox.Show("Port must be a number from 1-65535!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
