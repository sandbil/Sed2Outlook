using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sed2Outlook.CsHTTPServer;

using Microsoft.Win32;

using System.IO;

namespace Sed2Outlook
{
    public partial class Sed2OutlookFrm : Form
    {
        CsHTTPServer.CsHTTPServer HTTPServer;
        private Configuration config = new Configuration(Paths.Executable) ;//new Configuration(Path.GetDirectoryName(Application.ExecutablePath));
        int eX, eY;
        bool fisrtView = true;


        public Sed2OutlookFrm()
        {
            InitializeComponent();
        }


        private void HTTP_PORT_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            Error.SetError(HTTP_PORT, "");
        }

        private void HTTP_PORT_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidPort(HTTP_PORT.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                HTTP_PORT.Select(0, HTTP_PORT.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.Error.SetError(HTTP_PORT, errorMsg);
            }
        }

        public bool ValidPort(string Port, out string errorMessage)
        {
            // Confirm that the Port string is not empty.
            if (Port.Length == 0)
            {
                errorMessage = "Port number is required.";
                return false;
            }

            int Value;
            // Confirm that it is number
            try
            {
                Value = Int32.Parse(Port);
            }
            catch (FormatException)
            {
                errorMessage = "Port number must be 1 to 65535.\n" +
                    "For example '8082' ";
                return false;
            }

            if ((Value > 0) && (Value < 65536))
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "Port number must be 1 to 65535.\n" +
                "For example '8082' ";
            return false;
        }

        private void OpenItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //
            HTTPServer = new MyServer(Convert.ToInt32(HTTP_PORT.Text), SED_SRV.Text);
            HTTPServer.Start();
            //
            HTTP_PORT.Enabled = false;
            SED_SRV.Enabled = false;
            Start.Enabled = false;
            Stop.Enabled = true;
            //
            contextMenu.MenuItems[2].Enabled = false;
            contextMenu.MenuItems[3].Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            //
            HTTPServer.Stop();
            //
            HTTP_PORT.Enabled = true;
            SED_SRV.Enabled = true;
            Stop.Enabled = false;
            Start.Enabled = true;
            //
            contextMenu.MenuItems[3].Enabled = false;
            contextMenu.MenuItems[2].Enabled = true;
        }

        private void Sed2OutlookFrm_Load(object sender, EventArgs e)
        {
            // load configuration
            config.LoadSettings();
            // set window location and size
            this.Location = config.mainWindowLocation;

            //
            SED_SRV.Text = config.serverSed;
            HTTP_PORT.Text = config.httpPort.ToString();
            //
            if (config.startServing)
                Start_Click(this, e);
            //
            startServing.Checked = config.startServing;
            startMinimized.Checked = config.startMinimized;
            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if ((HTTPServer != null) && (HTTPServer.IsAlive))
                HTTPServer.Stop();

            // save configuration
            //
            config.mainWindowLocation = this.Location;
            //
            config.serverSed = SED_SRV.Text;
            config.httpPort = Int32.Parse(HTTP_PORT.Text);

            //
            config.startServing = startServing.Checked;
            config.startMinimized = startMinimized.Checked;

            config.SaveSettings();
            Application.ExitThread();

        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Sed2OutlookFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - eX;
                this.Top += e.Y - eY;
                this.OnMove(e);
            }

        }

        private void Sed2OutlookFrm_Activated(object sender, EventArgs e)
        {
            if ((config.startMinimized) && (fisrtView))
            {
                this.Hide();
                fisrtView = false;
            }

        }

        private void Sed2OutlookFrm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                eX = e.X;
                eY = e.Y;
            }

        }
    }
}
