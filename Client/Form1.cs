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

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //Connect to server
                client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
                btnConnect.Enabled = false;
                btnSend.Enabled = true;
                MessageBox.Show("Bağlantı başarılı", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server şuan kapalı sonra tekrar deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnConnect.Enabled = true;
                btnSend.Enabled = false;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update message to txtStatus
            listBox1.Invoke((MethodInvoker)delegate ()
            {
                spn_sifreleme spn = new spn_sifreleme(keyText.Text);
                string deger = e.MessageString.Substring(5, e.MessageString.Length - 5).Substring(0, e.MessageString.Length - 6);
                string kisi = e.MessageString.Substring(0, 5);

                listBox1.Items.Add(kisi+spn.decrypt(deger));
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (girdiText.Text == "")
            {
                MessageBox.Show("Veri boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (girdiText.Text.Length % 2 == 1)
                {
                    girdiText.Text += " ";
                }
                spn_sifreleme spn = new spn_sifreleme(girdiText.Text, keyText.Text);
                
                client.WriteLineAndGetReply(spn.encrypt(), TimeSpan.FromSeconds(3));
            }
        }

        private void checkSPN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSPN.Checked == true)
            {
                checkSHA.Checked = false;
            }
        }

        private void checkSHA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSHA.Checked == true)
            {
                checkSPN.Checked = false;
            }
        }

        private void sifreleBTN_Click(object sender, EventArgs e)
        {
            girdiText.Text = turkceKarakterFonk(girdiText.Text);
            if (girdiText.Text == "")
            {
                MessageBox.Show("Veri boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (keyText.Text == "") { MessageBox.Show("Lütfen bir anahtar giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (keyText.Text.Length != 8) { MessageBox.Show("Anahtar 8 karakter olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                if (checkSPN.Checked == true)
                {
                    if (girdiText.Text.Length % 2 == 1)
                    {
                        girdiText.Text += " ";
                    } // çift karakter olması için sona bir boşluk ekliyor
                    spn_sifreleme spn = new spn_sifreleme(girdiText.Text, keyText.Text);
                    ciktiText.Text = spn.encrypt();
                }
                else if (checkSHA.Checked == true)
                {
                    sha_sifreleme sha = new sha_sifreleme(girdiText.Text);
                    ciktiText.Text = sha.encrypt();
                }
                else if (checkSPN.Checked == false && checkSHA.Checked == false)
                {
                    MessageBox.Show("Şifreleme metodu seçiniz ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public string turkceKarakterFonk(string text)
        {
            text = text.Replace("İ", "I");
            text = text.Replace("ı", "i");
            text = text.Replace("Ğ", "G");
            text = text.Replace("ğ", "g");
            text = text.Replace("Ö", "O");
            text = text.Replace("ö", "o");
            text = text.Replace("Ü", "U");
            text = text.Replace("ü", "u");
            text = text.Replace("Ş", "S");
            text = text.Replace("ş", "s");
            text = text.Replace("Ç", "C");
            text = text.Replace("ç", "c");
            return text;
        }
        private void cozBTN_Click(object sender, EventArgs e)
        {
            if (girdiText.Text == "")
            {
                MessageBox.Show("Veri boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (keyText.Text == "") { MessageBox.Show("Lütfen bir anahtar giriniz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (keyText.Text.Length != 8) { MessageBox.Show("Anahtar 8 karakter olmalıdır.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                if (checkSPN.Checked == true)
                {
                    spn_sifreleme spn = new spn_sifreleme(keyText.Text);
                    ciktiText.Text = spn.decrypt(girdiText.Text);
                }
                else if (checkSHA.Checked == true) 
                { 
                    MessageBox.Show("SHA şifreleme Çözülemez. "); 
                }
                else if (checkSPN.Checked == false && checkSHA.Checked == false)
                {
                    MessageBox.Show("Şifreleme metodu seçiniz ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

    }
}