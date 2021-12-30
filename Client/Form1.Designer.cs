
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.girdiText = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ciktiText = new System.Windows.Forms.TextBox();
            this.checkSPN = new System.Windows.Forms.CheckBox();
            this.checkSHA = new System.Windows.Forms.CheckBox();
            this.sifreleBTN = new System.Windows.Forms.Button();
            this.cozBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 302);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(181, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Mesaj Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(118, 63);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(12, 64);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(77, 20);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "8910";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(12, 25);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(181, 20);
            this.txtHost.TabIndex = 8;
            this.txtHost.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Host";
            // 
            // girdiText
            // 
            this.girdiText.Location = new System.Drawing.Point(12, 111);
            this.girdiText.Multiline = true;
            this.girdiText.Name = "girdiText";
            this.girdiText.Size = new System.Drawing.Size(181, 43);
            this.girdiText.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(199, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 316);
            this.listBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mesaj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mesajın Şifrelenmiş Hali";
            // 
            // ciktiText
            // 
            this.ciktiText.Location = new System.Drawing.Point(12, 253);
            this.ciktiText.Multiline = true;
            this.ciktiText.Name = "ciktiText";
            this.ciktiText.Size = new System.Drawing.Size(181, 43);
            this.ciktiText.TabIndex = 17;
            // 
            // checkSPN
            // 
            this.checkSPN.AutoSize = true;
            this.checkSPN.Location = new System.Drawing.Point(12, 181);
            this.checkSPN.Name = "checkSPN";
            this.checkSPN.Size = new System.Drawing.Size(63, 17);
            this.checkSPN.TabIndex = 19;
            this.checkSPN.Text = "SPN-16";
            this.checkSPN.UseVisualStyleBackColor = true;
            this.checkSPN.CheckedChanged += new System.EventHandler(this.checkSPN_CheckedChanged);
            // 
            // checkSHA
            // 
            this.checkSHA.AutoSize = true;
            this.checkSHA.Location = new System.Drawing.Point(12, 204);
            this.checkSHA.Name = "checkSHA";
            this.checkSHA.Size = new System.Drawing.Size(69, 17);
            this.checkSHA.TabIndex = 20;
            this.checkSHA.Text = "SHA-256";
            this.checkSHA.UseVisualStyleBackColor = true;
            this.checkSHA.CheckedChanged += new System.EventHandler(this.checkSHA_CheckedChanged);
            // 
            // sifreleBTN
            // 
            this.sifreleBTN.Location = new System.Drawing.Point(118, 173);
            this.sifreleBTN.Name = "sifreleBTN";
            this.sifreleBTN.Size = new System.Drawing.Size(75, 23);
            this.sifreleBTN.TabIndex = 21;
            this.sifreleBTN.Text = "Şifrele";
            this.sifreleBTN.UseVisualStyleBackColor = true;
            this.sifreleBTN.Click += new System.EventHandler(this.sifreleBTN_Click);
            // 
            // cozBTN
            // 
            this.cozBTN.Location = new System.Drawing.Point(118, 198);
            this.cozBTN.Name = "cozBTN";
            this.cozBTN.Size = new System.Drawing.Size(75, 23);
            this.cozBTN.TabIndex = 22;
            this.cozBTN.Text = "Çöz";
            this.cozBTN.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Şifrelemeler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 334);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cozBTN);
            this.Controls.Add(this.sifreleBTN);
            this.Controls.Add(this.checkSHA);
            this.Controls.Add(this.checkSPN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ciktiText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.girdiText);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox girdiText;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ciktiText;
        private System.Windows.Forms.CheckBox checkSPN;
        private System.Windows.Forms.CheckBox checkSHA;
        private System.Windows.Forms.Button sifreleBTN;
        private System.Windows.Forms.Button cozBTN;
        private System.Windows.Forms.Label label5;
    }
}

