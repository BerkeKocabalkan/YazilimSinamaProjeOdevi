using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update mesage to txtStatus
            listBox1.Invoke((MethodInvoker)delegate ()
            {
                var deger = e.MessageString.Substring(0, e.MessageString.Length - 1);
                listBox1.Items.Add(deger);
                e.ReplyLine(string.Format("Sen: {0}", e.MessageString));
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Start server host
            btnStart.Enabled = false;

            try
            {
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
                server.Start(ip, Convert.ToInt32(txtPort.Text));
                listBox1.Items.Add("Server starting...");
            }
            catch (Exception)
            {
                listBox1.Items.Add("Server Başlatılırken hata oluştu");
                throw;
            }
            
        }
    }
}
