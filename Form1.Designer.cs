namespace rca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            receivingToolStripMenuItem = new ToolStripMenuItem();
            sendingToolStripMenuItem = new ToolStripMenuItem();
            port0ToolStripMenuItem = new ToolStripMenuItem();
            getIPConfigToolStripMenuItem = new ToolStripMenuItem();
            clearConsoleToolStripMenuItem = new ToolStripMenuItem();
            hideConsoleToolStripMenuItem = new ToolStripMenuItem();
            usingCmdToolStripMenuItem = new ToolStripMenuItem();
            aboutRCA1ToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(203, 426);
            textBox1.TabIndex = 0;
            textBox1.Text = "Welcome to RCA 1!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Desktop;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(593, 426);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { receivingToolStripMenuItem, sendingToolStripMenuItem, port0ToolStripMenuItem, getIPConfigToolStripMenuItem, clearConsoleToolStripMenuItem, hideConsoleToolStripMenuItem, usingCmdToolStripMenuItem, aboutRCA1ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // receivingToolStripMenuItem
            // 
            receivingToolStripMenuItem.Image = Properties.Resources.red;
            receivingToolStripMenuItem.Name = "receivingToolStripMenuItem";
            receivingToolStripMenuItem.Size = new Size(109, 20);
            receivingToolStripMenuItem.Text = "Not Receiving";
            // 
            // sendingToolStripMenuItem
            // 
            sendingToolStripMenuItem.BackColor = SystemColors.Control;
            sendingToolStripMenuItem.Image = Properties.Resources.red;
            sendingToolStripMenuItem.Name = "sendingToolStripMenuItem";
            sendingToolStripMenuItem.Size = new Size(101, 20);
            sendingToolStripMenuItem.Text = "Not Sending";
            // 
            // port0ToolStripMenuItem
            // 
            port0ToolStripMenuItem.Name = "port0ToolStripMenuItem";
            port0ToolStripMenuItem.Size = new Size(74, 20);
            port0ToolStripMenuItem.Text = "Port 65534";
            port0ToolStripMenuItem.Click += port0ToolStripMenuItem_Click;
            // 
            // getIPConfigToolStripMenuItem
            // 
            getIPConfigToolStripMenuItem.Name = "getIPConfigToolStripMenuItem";
            getIPConfigToolStripMenuItem.Size = new Size(86, 20);
            getIPConfigToolStripMenuItem.Text = "Get IPConfig";
            getIPConfigToolStripMenuItem.Click += getIPConfigToolStripMenuItem_Click;
            // 
            // clearConsoleToolStripMenuItem
            // 
            clearConsoleToolStripMenuItem.Name = "clearConsoleToolStripMenuItem";
            clearConsoleToolStripMenuItem.Size = new Size(92, 20);
            clearConsoleToolStripMenuItem.Text = "Clear Console";
            clearConsoleToolStripMenuItem.Click += clearConsoleToolStripMenuItem_Click;
            // 
            // hideConsoleToolStripMenuItem
            // 
            hideConsoleToolStripMenuItem.Name = "hideConsoleToolStripMenuItem";
            hideConsoleToolStripMenuItem.Size = new Size(90, 20);
            hideConsoleToolStripMenuItem.Text = "Hide Console";
            hideConsoleToolStripMenuItem.Click += hideConsoleToolStripMenuItem_Click;
            // 
            // usingCmdToolStripMenuItem
            // 
            usingCmdToolStripMenuItem.Name = "usingCmdToolStripMenuItem";
            usingCmdToolStripMenuItem.Size = new Size(76, 20);
            usingCmdToolStripMenuItem.Text = "Using cmd";
            usingCmdToolStripMenuItem.Click += usingCmdToolStripMenuItem_Click;
            // 
            // aboutRCA1ToolStripMenuItem
            // 
            aboutRCA1ToolStripMenuItem.Name = "aboutRCA1ToolStripMenuItem";
            aboutRCA1ToolStripMenuItem.Size = new Size(78, 20);
            aboutRCA1ToolStripMenuItem.Text = "About RCA";
            aboutRCA1ToolStripMenuItem.Click += aboutRCA1ToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(800, 426);
            splitContainer1.SplitterDistance = 203;
            splitContainer1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "RCA 1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem receivingToolStripMenuItem;
        private ToolStripMenuItem sendingToolStripMenuItem;
        private ToolStripMenuItem port0ToolStripMenuItem;
        private ToolStripMenuItem getIPConfigToolStripMenuItem;
        private ToolStripMenuItem usingCmdToolStripMenuItem;
        private ToolStripMenuItem clearConsoleToolStripMenuItem;
        private ToolStripMenuItem aboutRCA1ToolStripMenuItem;
        private ToolStripMenuItem hideConsoleToolStripMenuItem;
        private SplitContainer splitContainer1;
    }
}
