using System.Collections.Generic;

namespace BrawlhallaPingChecker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            serverSelecter = new ServerSelecter();
            // 
            // MainForm
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Brawlhalla Ping Checker - /u/CallMeSometimeNever";
            this.ResumeLayout(false);
            //
            // ChangeServers
            //
            this.ChangeServers = new System.Windows.Forms.Button();
            this.ChangeServers.AutoSize = true;
            this.ChangeServers.Text = "Change Servers";
            this.ChangeServers.Size = new System.Drawing.Size(220, 20);
            this.ChangeServers.Location = new System.Drawing.Point(10, 2);

            this.ChangeServers.Click += (sender, e) =>
            {
                System.IO.File.WriteAllText(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + @"\BrawlhallaPingChecker\config.txt", CreateConfigFile());

                this.Controls.Clear();
                this.Panels.Clear();

                ReadConfigFile();
               
                InitializeComponent();
                AddPanelsToForm();
                AddRefreshAll();
            };

            this.Controls.Add(ChangeServers);

        }

        #endregion

        private void CreateNewPanel(string labelName, string pingIP)
        {
            System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel();
            System.Windows.Forms.Label serverName = new System.Windows.Forms.Label();
            System.Windows.Forms.Label pingNumber = new System.Windows.Forms.Label();
            System.Windows.Forms.Button refreshPing = new System.Windows.Forms.Button();

            //Initialize components
            panel.AutoSize = true;
            panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            serverName.AutoSize = true;
            serverName.Text = labelName;
            serverName.Size = new System.Drawing.Size(100, 20);
            serverName.Location = new System.Drawing.Point(15, 5);

            pingNumber.AutoSize = true;
            pingNumber.Text = "0";
            pingNumber.Size = new System.Drawing.Size(40, 20);
            pingNumber.Location  = new System.Drawing.Point(100, 5);

            refreshPing.AutoSize = true;
            refreshPing.Text = "Refresh";
            refreshPing.Size = new System.Drawing.Size(75, 25);
            refreshPing.Location = new System.Drawing.Point(155, 0);
            refreshPing.Click += (sender, e) =>
            {
                pingNumber.Text = "Pinging...";
                this.Refresh();
                using (System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping())
                {
                    System.Net.NetworkInformation.PingReply reply = p.Send(pingIP);
                    if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                    {
                        pingNumber.Text = reply.RoundtripTime.ToString();                          
                    }
                    else
                    {
                        pingNumber.Text = "ERROR";
                    }
                    this.Refresh();
                }
            };

            panel.Controls.Add(serverName);
            panel.Controls.Add(pingNumber);
            panel.Controls.Add(refreshPing);

            Panels.Add(panel);
        }

        private void AddPanelsToForm()
        {
            this.Panels.Reverse();
            for (int i = 0; i < Panels.Count; i++)
            {
                Panels[i].Location = new System.Drawing.Point(0, 28 * (i + 1));
                this.Controls.Add(Panels[i]);
            }
        }

        private void AddRefreshAll()
        {
            RefreshAll = new System.Windows.Forms.Button();
            RefreshAll.Text = "Refresh All";
            RefreshAll.Size = new System.Drawing.Size(220, 30);
            RefreshAll.Location = new System.Drawing.Point(10, (Panels.Count + 1) * 28);
            RefreshAll.AutoSize = true;

            RefreshAll.Click += (sender, e) =>
            {
                foreach (System.Windows.Forms.Panel panel in Panels)
                {
                    foreach (System.Windows.Forms.Control control in panel.Controls)
                    {
                        if (control.GetType() == typeof(System.Windows.Forms.Button))
                        {
                            (control as System.Windows.Forms.Button).PerformClick();
                        }
                    }
                }
            };

            this.Controls.Add(RefreshAll);
        }

        private ServerSelecter serverSelecter;
        private System.Windows.Forms.Button ChangeServers;
        private List<System.Windows.Forms.Panel> Panels = new List<System.Windows.Forms.Panel>();
        private System.Windows.Forms.Button RefreshAll;
    }
}

