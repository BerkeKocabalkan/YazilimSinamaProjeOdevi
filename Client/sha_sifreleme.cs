using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [Serializable]
    public class sha_sifreleme
    {
        private string girdiText;

        public sha_sifreleme(string girdiText)
        {
            this.girdiText = girdiText;
        }

        public string encrypt()
        {
            SHA256Managed sha256 = new SHA256Managed();
            Byte[] byte_Text = Encoding.ASCII.GetBytes(this.girdiText);
            byte_Text = sha256.ComputeHash(byte_Text);

            StringBuilder sBuilder = new StringBuilder();
            foreach (byte x in byte_Text)
            {
                sBuilder.Append(x.ToString("x2"));
            }

            return sBuilder.ToString();

        }
    }
}
