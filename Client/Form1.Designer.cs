
namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtHost = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.girdiText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.keyText = new MetroFramework.Controls.MetroTextBox();
            this.checkSPN = new MetroFramework.Controls.MetroCheckBox();
            this.checkSHA = new MetroFramework.Controls.MetroCheckBox();
            this.sifreleBTN = new MetroFramework.Controls.MetroButton();
            this.cozBTN = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.ciktiText = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(206, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 368);
            this.listBox1.TabIndex = 15;
            // 
            // txtHost
            // 
            this.txtHost.Enabled = false;
            this.txtHost.Location = new System.Drawing.Point(19, 82);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(181, 23);
            this.txtHost.TabIndex = 26;
            this.txtHost.Text = "127.0.0.1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Host";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(19, 136);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 23);
            this.txtPort.TabIndex = 29;
            this.txtPort.Text = "8910";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(125, 136);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 30;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 162);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Mesaj";
            // 
            // girdiText
            // 
            this.girdiText.Location = new System.Drawing.Point(19, 184);
            this.girdiText.Multiline = true;
            this.girdiText.Name = "girdiText";
            this.girdiText.Size = new System.Drawing.Size(181, 43);
            this.girdiText.TabIndex = 32;
            this.girdiText.Text = "127.0.0.1";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(19, 230);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Anahtar";
            // 
            // keyText
            // 
            this.keyText.Location = new System.Drawing.Point(19, 252);
            this.keyText.MaxLength = 8;
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(181, 23);
            this.keyText.TabIndex = 34;
            // 
            // checkSPN
            // 
            this.checkSPN.AutoSize = true;
            this.checkSPN.Location = new System.Drawing.Point(19, 309);
            this.checkSPN.Name = "checkSPN";
            this.checkSPN.Size = new System.Drawing.Size(62, 15);
            this.checkSPN.TabIndex = 35;
            this.checkSPN.Text = "SPN-16";
            this.checkSPN.UseVisualStyleBackColor = true;
            this.checkSPN.CheckedChanged += new System.EventHandler(this.checkSPN_CheckedChanged);
            // 
            // checkSHA
            // 
            this.checkSHA.AutoSize = true;
            this.checkSHA.Location = new System.Drawing.Point(19, 330);
            this.checkSHA.Name = "checkSHA";
            this.checkSHA.Size = new System.Drawing.Size(69, 15);
            this.checkSHA.TabIndex = 36;
            this.checkSHA.Text = "SHA-256";
            this.checkSHA.UseVisualStyleBackColor = true;
            this.checkSHA.CheckedChanged += new System.EventHandler(this.checkSHA_CheckedChanged);
            // 
            // sifreleBTN
            // 
            this.sifreleBTN.Location = new System.Drawing.Point(124, 297);
            this.sifreleBTN.Name = "sifreleBTN";
            this.sifreleBTN.Size = new System.Drawing.Size(75, 23);
            this.sifreleBTN.TabIndex = 37;
            this.sifreleBTN.Text = "Şifrele";
            this.sifreleBTN.Click += new System.EventHandler(this.sifreleBTN_Click);
            // 
            // cozBTN
            // 
            this.cozBTN.Location = new System.Drawing.Point(124, 326);
            this.cozBTN.Name = "cozBTN";
            this.cozBTN.Size = new System.Drawing.Size(75, 23);
            this.cozBTN.TabIndex = 38;
            this.cozBTN.Text = "Çöz";
            this.cozBTN.Click += new System.EventHandler(this.cozBTN_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(18, 284);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 39;
            this.metroLabel5.Text = "Şifrelemeler";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(19, 356);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(146, 19);
            this.metroLabel6.TabIndex = 40;
            this.metroLabel6.Text = "Mesajın Şifrelenmiş Hali";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(19, 427);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(181, 23);
            this.btnSend.TabIndex = 41;
            this.btnSend.Text = "Mesaj Gönder";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ciktiText
            // 
            this.ciktiText.Location = new System.Drawing.Point(19, 378);
            this.ciktiText.Multiline = true;
            this.ciktiText.Name = "ciktiText";
            this.ciktiText.Size = new System.Drawing.Size(181, 43);
            this.ciktiText.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 472);
            this.Controls.Add(this.ciktiText);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cozBTN);
            this.Controls.Add(this.sifreleBTN);
            this.Controls.Add(this.checkSHA);
            this.Controls.Add(this.checkSPN);
            this.Controls.Add(this.keyText);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.girdiText);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTextBox txtHost;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox girdiText;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox keyText;
        private MetroFramework.Controls.MetroCheckBox checkSPN;
        private MetroFramework.Controls.MetroCheckBox checkSHA;
        private MetroFramework.Controls.MetroButton sifreleBTN;
        private MetroFramework.Controls.MetroButton cozBTN;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroTextBox ciktiText;
    }
}

