using System.Numerics;

namespace RSA_Playfair
{
    public partial class Main : Form
    {
        public Playfair pf = new Playfair();
        public Main()
        {
            InitializeComponent();
            rsa_btn.Enabled = false;
            rsa_btn.BackColor = Color.Gray;
            pf.Dock = DockStyle.Fill;
            pn_pf.Controls.Add(pf);

            btn_encrypt.Enabled = false;
            btn_decrypt.Enabled = false;

            btn_decrypt.Visible = false;
            btn_encrypt.Visible = false;
        }

        private bool isprime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        private long GCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        private long ModInverse(long e, long phi)
        {
            long t = 0, newT = 1;
            long r = phi, newR = e;

            while (newR != 0)
            {
                long q = r / newR;

                long tempT = t - q * newT;
                t = newT;
                newT = tempT;

                long tempR = r - q * newR;
                r = newR;
                newR = tempR;
            }

            if (r != 1)
                throw new Exception("e không có nghịch đảo modulo theo phi(N).");

            if (t < 0)
                t += phi;

            return t;
        }

        private long GenerateValidE(long phi)
        {
            long[] preferred = { 65537, 257, 17, 5, 3 };

            foreach (long candidate in preferred)
            {
                if (candidate > 1 && candidate < phi && GCD(candidate, phi) == 1)
                    return candidate;
            }

            for (long candidate = 3; candidate < phi; candidate += 2)
            {
                if (GCD(candidate, phi) == 1)
                    return candidate;
            }

            throw new Exception("Không tìm được giá trị e phù hợp.");
        }
        private void btn_generate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num;
            do
            {
                num = rnd.Next(1, int.MaxValue);
            } while (!isprime(num));
            rtb_p.Text = num.ToString();
            do
            {
                num = rnd.Next(1, int.MaxValue);
            } while (!isprime(num));
            rtb_q.Text = num.ToString();
        }
        private void ShowPanel(Panel panelToShow)
        {
            pn_rsa.Visible = false;

            pn_rsa.Enabled = false;

            panelToShow.Visible = true;
            panelToShow.Enabled = true;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(rtb_p.Text.Trim(), out int p) ||
                    !int.TryParse(rtb_q.Text.Trim(), out int q))
                {
                    MessageBox.Show("Vui lòng nhập p và q là số nguyên.");
                    return;
                }

                if (!isprime(p) || !isprime(q))
                {
                    MessageBox.Show("p và q phải là số nguyên tố.");
                    return;
                }

                if (p == q)
                {
                    MessageBox.Show("p và q phải khác nhau.");
                    return;
                }

                if (p <= 2 || q <= 2)
                {
                    MessageBox.Show("Nên chọn p và q là số nguyên tố lớn hơn 2.");
                    return;
                }

                long n = (long)p * q;
                long phi = (long)(p - 1) * (q - 1);

                long eValue;
                string eText = rtb_e.Text.Trim();

                if (string.IsNullOrWhiteSpace(eText))
                {
                    eValue = GenerateValidE(phi);
                }
                else
                {
                    if (!long.TryParse(eText, out eValue))
                    {
                        MessageBox.Show("Khóa công khai e phải là số nguyên.");
                        return;
                    }

                    if (eValue <= 1 || eValue >= phi)
                    {
                        MessageBox.Show("e phải thỏa điều kiện: 1 < e < phi(N).");
                        return;
                    }

                    if (GCD(eValue, phi) != 1)
                    {
                        MessageBox.Show("e phải nguyên tố cùng nhau với phi(N).");
                        return;
                    }
                }

                long d = ModInverse(eValue, phi);

                rtb_modulus.Text = n.ToString();
                rtb_phi.Text = phi.ToString();
                rtb_e.Text = eValue.ToString();
                rtb_d.Text = d.ToString();

                MessageBox.Show("Cập nhật tham số RSA thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật tham số: " + ex.Message);
            }
        }

        private void rsa_btn_Click(object sender, EventArgs e)
        {
            rsa_btn.BackColor = Color.Gray;
            pf_btn.BackColor = SystemColors.Control;

            rsa_btn.Enabled = false;
            pf_btn.Enabled = true;

            pn_rsa.Enabled = true;
            pn_rsa.Visible = true;

            pn_pf.Enabled = false;
            pn_pf.Visible = false;

            btn_encrypt.Enabled = true;
            btn_decrypt.Enabled = true;

            btn_decrypt.Visible = true;
            btn_encrypt.Visible = true;


            lb1.Text = "RSA";
        }
        private void pf_btn_Click(object sender, EventArgs e)
        {
            pf_btn.BackColor = Color.Gray;
            rsa_btn.BackColor = SystemColors.Control;

            pf_btn.Enabled = false;
            rsa_btn.Enabled = true;

            pn_rsa.Enabled = false;
            pn_rsa.Visible = false;

            pn_pf.Enabled = true;
            pn_pf.Visible = true;

            btn_encrypt.Enabled = false;
            btn_decrypt.Enabled = false;

            btn_decrypt.Visible = false;
            btn_encrypt.Visible = false;

            lb1.Text = "PlayFair";
        }
        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            string text = rtb_plaintext.Text;
            List<string> result = new();

            foreach (char c in text)
            {
                BigInteger m = (int)c;
                BigInteger ciph = Encrypt(m);
                result.Add(ciph.ToString());
            }

            rtb_ciphertext.Text = string.Join("#", result);
        }
        private BigInteger Encrypt(BigInteger m)
        {
            BigInteger E = BigInteger.Parse(rtb_e.Text);
            BigInteger N = BigInteger.Parse(rtb_modulus.Text);
            return BigInteger.ModPow(m, E, N);

        }
        private BigInteger Decrypt(BigInteger c)
        {
            BigInteger d = BigInteger.Parse(rtb_d.Text);
            BigInteger N = BigInteger.Parse(rtb_modulus.Text);
            return BigInteger.ModPow(c, d, N);
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {

            string[] parts = rtb_ciphertext.Text.Split('#');
            string result = "";

            foreach (string part in parts)
            {
                BigInteger c = BigInteger.Parse(part);
                BigInteger m = Decrypt(c);
                result += (char)(int)m;
            }

            rtb_plaintext.Text = result;
        }
    }
}
