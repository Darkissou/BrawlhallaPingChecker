using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrawlhallaPingChecker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CheckForExistingConfig();
            ReadConfigFile();
            AddPanelsToForm();
            AddRefreshAll();
            
        }

        private void CheckForExistingConfig()
        {
            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\BrawlhallaPingChecker\config.txt"))
            {
                return;
            }
            else
            {
                MessageBox.Show("Config file not detected! Please select the servers you want to ping.", "Config file not found!");
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\BrawlhallaPingChecker\config.txt");
                fileInfo.Directory.Create();
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\BrawlhallaPingChecker\config.txt", CreateConfigFile());
            }
        }

        private string CreateConfigFile()
        {
            List<string> config = new List<string>();

            serverSelecter.ShowDialog();

            foreach (string server in serverSelecter.selectedServers)
            {
                switch (server)
                {
                    case "USWCheckbox":
                        config.Add("US-W, pingtest-cal.brawlhalla.com");
                        break;
                    case "USECheckbox":
                        config.Add("US-E, pingtest-atl.brawlhalla.com");
                        break;
                    case "EUCheckbox":
                        config.Add("Europe, pingtest-ams.brawlhalla.com");
                        break;
                    case "SEACheckbox":
                        config.Add("Southeast Asia, pingtest-sgp.brawlhalla.com");
                        break;
                    case "BRCheckbox":
                        config.Add("Brazil, pingtest-brs.brawlhalla.com");
                        break;
                    case "AUSCheckbox":
                           config.Add("Australia, pingtest-aus.brawlhalla.com");
                        break;
                    default:
                        MessageBox.Show("crap");
                        break;
                }
            }
            return String.Join("; ", config);
        }

        private void ReadConfigFile()
        {
            string[] servers = null;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\BrawlhallaPingChecker\config.txt"))
            {
                servers = reader.ReadToEnd().Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);
            }
            if (servers.Length < 1)
            {
                MessageBox.Show("Server configs are corrupted! Please make a new one.", "An error occured!");
                return;
            }
            foreach (string server in servers)
            {
                string serverName = server.Split(new string[] { ", " }, StringSplitOptions.None)[0];
                string pingAddress = server.Split(new string[] { ", " }, StringSplitOptions.None)[1];

                CreateNewPanel(serverName, pingAddress);
            }
        }
    }
}
