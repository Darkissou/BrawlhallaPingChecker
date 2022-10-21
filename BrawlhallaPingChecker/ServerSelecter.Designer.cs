using System.Collections.Generic;

namespace BrawlhallaPingChecker
{
    partial class ServerSelecter
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
            selectedServers = new List<string>();

            this.USWLabel = new System.Windows.Forms.Label();
            this.USELabel = new System.Windows.Forms.Label();
            this.EULabel = new System.Windows.Forms.Label();
            this.SEALabel = new System.Windows.Forms.Label();
            this.BRLabel = new System.Windows.Forms.Label();
            this.AUSLabel = new System.Windows.Forms.Label();
            this.MDELabel = new System.Windows.Forms.Label();
            this.SAFLabel = new System.Windows.Forms.Label();
            this.USWCheckbox = new System.Windows.Forms.CheckBox();
            this.USECheckbox = new System.Windows.Forms.CheckBox();
            this.EUCheckbox = new System.Windows.Forms.CheckBox();
            this.SEACheckbox = new System.Windows.Forms.CheckBox();
            this.BRCheckbox = new System.Windows.Forms.CheckBox();
            this.AUSCheckbox = new System.Windows.Forms.CheckBox();
            this.MDECheckbox = new System.Windows.Forms.CheckBox();
            this.SAFCheckbox = new System.Windows.Forms.CheckBox();
            this.ConfirmServers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // USWLabel
            // 
            this.USWLabel.AutoSize = true;
            this.USWLabel.Location = new System.Drawing.Point(10, 10);
            this.USWLabel.Name = "USWLabel";
            this.USWLabel.Size = new System.Drawing.Size(45, 20);
            this.USWLabel.TabIndex = 0;
            this.USWLabel.Text = "US-W";
            // 
            // USELabel
            // 
            this.USELabel.AutoSize = true;
            this.USELabel.Location = new System.Drawing.Point(10, 35);
            this.USELabel.Name = "USELabel";
            this.USELabel.Size = new System.Drawing.Size(45, 20);
            this.USELabel.TabIndex = 1;
            this.USELabel.Text = "US-E";
            // 
            // EULabel
            // 
            this.EULabel.AutoSize = true;
            this.EULabel.Location = new System.Drawing.Point(10, 60);
            this.EULabel.Name = "EULabel";
            this.EULabel.Size = new System.Drawing.Size(45, 20);
            this.EULabel.TabIndex = 2;
            this.EULabel.Text = "EU";
            // 
            // SEALabel
            // 
            this.SEALabel.AutoSize = true;
            this.SEALabel.Location = new System.Drawing.Point(10, 85);
            this.SEALabel.Name = "SEALabel";
            this.SEALabel.Size = new System.Drawing.Size(45, 20);
            this.SEALabel.TabIndex = 3;
            this.SEALabel.Text = "SEA";
            // 
            // BRLabel
            // 
            this.BRLabel.AutoSize = true;
            this.BRLabel.Location = new System.Drawing.Point(10, 110);
            this.BRLabel.Name = "BRLabel";
            this.BRLabel.Size = new System.Drawing.Size(45, 20);
            this.BRLabel.TabIndex = 4;
            this.BRLabel.Text = "BR";
            // 
            // AUSLabel
            // 
            this.AUSLabel.AutoSize = true;
            this.AUSLabel.Location = new System.Drawing.Point(10, 135);
            this.AUSLabel.Name = "AUSLabel";
            this.AUSLabel.Size = new System.Drawing.Size(45, 20);
            this.AUSLabel.TabIndex = 5;
            this.AUSLabel.Text = "AUS";
            // 
            // MDELabel
            // 
            this.MDELabel.AutoSize = true;
            this.MDELabel.Location = new System.Drawing.Point(10, 160);
            this.MDELabel.Name = "MDELabel";
            this.MDELabel.Size = new System.Drawing.Size(45, 20);
            this.MDELabel.TabIndex = 6;
            this.MDELabel.Text = "MDE";
            // 
            // SAFLabel
            // 
            this.SAFLabel.AutoSize = true;
            this.SAFLabel.Location = new System.Drawing.Point(10, 185);
            this.SAFLabel.Name = "SAFLabel";
            this.SAFLabel.Size = new System.Drawing.Size(45, 20);
            this.SAFLabel.TabIndex = 7;
            this.SAFLabel.Text = "SAF";
            // 
            // USWCheckbox
            // 
            this.USWCheckbox.AutoSize = true;
            this.USWCheckbox.Location = new System.Drawing.Point(80, 10);
            this.USWCheckbox.Name = "USWCheckbox";
            this.USWCheckbox.Size = new System.Drawing.Size(40, 20);
            this.USWCheckbox.TabIndex = 8;
            this.USWCheckbox.Text = "Active";
            this.USWCheckbox.UseVisualStyleBackColor = true;
            // 
            // USECheckbox
            // 
            this.USECheckbox.AutoSize = true;
            this.USECheckbox.Location = new System.Drawing.Point(80, 35);
            this.USECheckbox.Name = "USECheckbox";
            this.USECheckbox.Size = new System.Drawing.Size(40, 20);
            this.USECheckbox.TabIndex = 9;
            this.USECheckbox.Text = "Active";
            this.USECheckbox.UseVisualStyleBackColor = true;
            // 
            // EUCheckbox
            // 
            this.EUCheckbox.AutoSize = true;
            this.EUCheckbox.Location = new System.Drawing.Point(80, 60);
            this.EUCheckbox.Name = "EUCheckbox";
            this.EUCheckbox.Size = new System.Drawing.Size(40, 20);
            this.EUCheckbox.TabIndex = 10;
            this.EUCheckbox.Text = "Active";
            this.EUCheckbox.UseVisualStyleBackColor = true;
            // 
            // SEACheckbox
            // 
            this.SEACheckbox.AutoSize = true;
            this.SEACheckbox.Location = new System.Drawing.Point(80, 85);
            this.SEACheckbox.Name = "SEACheckbox";
            this.SEACheckbox.Size = new System.Drawing.Size(40, 20);
            this.SEACheckbox.TabIndex = 11;
            this.SEACheckbox.Text = "Active";
            this.SEACheckbox.UseVisualStyleBackColor = true;
            // 
            // BRCheckbox
            // 
            this.BRCheckbox.AutoSize = true;
            this.BRCheckbox.Location = new System.Drawing.Point(80, 110);
            this.BRCheckbox.Name = "BRCheckbox";
            this.BRCheckbox.Size = new System.Drawing.Size(40, 20);
            this.BRCheckbox.TabIndex = 12;
            this.BRCheckbox.Text = "Active";
            this.BRCheckbox.UseVisualStyleBackColor = true;
            // 
            // AUSCheckbox
            // 
            this.AUSCheckbox.AutoSize = true;
            this.AUSCheckbox.Location = new System.Drawing.Point(80, 135);
            this.AUSCheckbox.Name = "AUSCheckbox";
            this.AUSCheckbox.Size = new System.Drawing.Size(40, 20);
            this.AUSCheckbox.TabIndex = 13;
            this.AUSCheckbox.Text = "Active";
            this.AUSCheckbox.UseVisualStyleBackColor = true;
            // 
            // MDECheckbox
            // 
            this.MDECheckbox.AutoSize = true;
            this.MDECheckbox.Location = new System.Drawing.Point(80, 160);
            this.MDECheckbox.Name = "MDECheckbox";
            this.MDECheckbox.Size = new System.Drawing.Size(40, 20);
            this.MDECheckbox.TabIndex = 14;
            this.MDECheckbox.Text = "Active";
            this.MDECheckbox.UseVisualStyleBackColor = true;
            // 
            // SAFCheckbox
            // 
            this.SAFCheckbox.AutoSize = true;
            this.SAFCheckbox.Location = new System.Drawing.Point(80, 185);
            this.SAFCheckbox.Name = "SAFCheckbox";
            this.SAFCheckbox.Size = new System.Drawing.Size(40, 20);
            this.SAFCheckbox.TabIndex = 15;
            this.SAFCheckbox.Text = "Active";
            this.SAFCheckbox.UseVisualStyleBackColor = true;
            // 
            // ConfirmServers
            // 
            this.ConfirmServers.Location = new System.Drawing.Point(10, 210);
            this.ConfirmServers.Name = "ConfirmServers";
            this.ConfirmServers.Size = new System.Drawing.Size(120, 35);
            this.ConfirmServers.TabIndex = 16;
            this.ConfirmServers.Text = "Confirm";
            this.ConfirmServers.UseVisualStyleBackColor = true;

            
            this.ConfirmServers.Click += (sender, e) =>
            {
                selectedServers.Clear();
                foreach (System.Windows.Forms.Control control in this.Controls)
                {
                    if (control.GetType() == typeof(System.Windows.Forms.CheckBox))
                    {
                        if ((control as System.Windows.Forms.CheckBox).Checked)
                        {
                            selectedServers.Add((control as System.Windows.Forms.CheckBox).Name);
                        }
                    }
                }
                this.Hide();
            };
            
            // 
            // ServerSelecter
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ConfirmServers);
            this.Controls.Add(this.SAFCheckbox);
            this.Controls.Add(this.MDECheckbox);
            this.Controls.Add(this.AUSCheckbox);
            this.Controls.Add(this.BRCheckbox);
            this.Controls.Add(this.SEACheckbox);
            this.Controls.Add(this.EUCheckbox);
            this.Controls.Add(this.USECheckbox);
            this.Controls.Add(this.USWCheckbox);
            this.Controls.Add(this.SAFLabel);
            this.Controls.Add(this.MDELabel);
            this.Controls.Add(this.AUSLabel);
            this.Controls.Add(this.BRLabel);
            this.Controls.Add(this.SEALabel);
            this.Controls.Add(this.EULabel);
            this.Controls.Add(this.USELabel);
            this.Controls.Add(this.USWLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerSelecter";
            this.Text = "ServerSelecter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label USWLabel;
        private System.Windows.Forms.Label USELabel;
        private System.Windows.Forms.Label EULabel;
        private System.Windows.Forms.Label SEALabel;
        private System.Windows.Forms.Label BRLabel;
        private System.Windows.Forms.Label AUSLabel;
        private System.Windows.Forms.Label MDELabel;
        private System.Windows.Forms.Label SAFLabel;
        private System.Windows.Forms.CheckBox USWCheckbox;
        private System.Windows.Forms.CheckBox USECheckbox;
        private System.Windows.Forms.CheckBox EUCheckbox;
        private System.Windows.Forms.CheckBox SEACheckbox;
        private System.Windows.Forms.CheckBox BRCheckbox;
        private System.Windows.Forms.CheckBox AUSCheckbox;
        private System.Windows.Forms.CheckBox MDECheckbox;
        private System.Windows.Forms.CheckBox SAFCheckbox;
        private System.Windows.Forms.Button ConfirmServers;

        public List<string> selectedServers { get; set; }
    }
}