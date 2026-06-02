using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
namespace RSA_Playfair
{
    public partial class Main : Form
    {
        public Playfair pf = new Playfair();
        public Main()
        {
            InitializeComponent();
            ApplyCyberBackgroundTheme();
            rsa_btn.BackColor = Color.FromArgb(0, 205, 255);
            rsa_btn.ForeColor = Color.FromArgb(2, 18, 28);

            pf_btn.BackColor = Color.FromArgb(10, 27, 41);
            pf_btn.ForeColor = Color.FromArgb(235, 250, 255);
            pf.Dock = DockStyle.Fill;
            pn_pf.Controls.Add(pf);

            pn_rsa.BringToFront();
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
            rsa_btn.BackColor = Color.FromArgb(0, 205, 255);
            rsa_btn.ForeColor = Color.FromArgb(2, 18, 28);

            pf_btn.BackColor = Color.FromArgb(8, 23, 35);
            pf_btn.ForeColor = Color.White;


            pn_rsa.BringToFront();

            

            btn_encrypt.Enabled = true;
            btn_decrypt.Enabled = true;

            btn_encrypt.Visible = true;
            btn_decrypt.Visible = true;



            lb1.Text = "RSA";
        }
        private void pf_btn_Click(object sender, EventArgs e)
        {
            pf_btn.BackColor = Color.FromArgb(0, 205, 255);
            pf_btn.ForeColor = Color.FromArgb(2, 18, 28);

            rsa_btn.BackColor = Color.FromArgb(8, 23, 35);
            rsa_btn.ForeColor = Color.White;


            pn_pf.BringToFront();

          

            btn_encrypt.Enabled = false;
            btn_decrypt.Enabled = false;

            btn_encrypt.Visible = false;
            btn_decrypt.Visible = false;

            lb1.Text = "PlayFair";
        }
        private int GetBlockSize(BigInteger N)
        {
            int k = 0;
            BigInteger value = 1;

            while (value * 256 < N)
            {
                value *= 256;
                k++;
            }

            return k;
        }

        private BigInteger TextBlockToNumber(string block)
        {
            BigInteger m = 0;
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(block);

            foreach (byte b in bytes)
            {
                m = m * 256 + b;
            }

            return m;
        }

        private string NumberToTextBlock(BigInteger m, int k)
        {
            byte[] bytes = new byte[k];

            for (int i = k - 1; i >= 0; i--)
            {
                bytes[i] = (byte)(m % 256);
                m /= 256;
            }

            return System.Text.Encoding.ASCII.GetString(bytes);
        }

        private List<string> SplitText(string text, int k)
        {
            List<string> list = new();

            for (int i = 0; i < text.Length; i += k)
            {
                string block = text.Substring(i, Math.Min(k, text.Length - i));

                if (block.Length < k)
                    block = block.PadRight(k, ' '); // pad bằng space

                list.Add(block);
            }

            return list;
        }
        //Hàm kiểm tra input
        private bool IsEmpty(params RichTextBox[] boxes)
        {
            foreach (var box in boxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                    return true;
            }
            return false;
        }
        private bool ValidateTextInput(string text)
        {
            foreach (char c in text)
            {
                if (c > 127)
                    return false;
            }
            return true;
        }

        private bool ValidateNumberInput(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c) && c != '#' && !char.IsWhiteSpace(c))
                    return false;
            }
            return true;
        }

        private void btn_en_Click(object sender, EventArgs e)
        {
            if (IsEmpty(rtb_input, rtb_modulus, rtb_e))
            {
                MessageBox.Show("Chưa có input!");
                return;
            }
            if (!ValidateTextInput(rtb_input.Text))
            {
                MessageBox.Show("Encrypt yêu cầu plaintext ASCII.");
                return;
            }
            lb_input.Text = "Plaintext input";
            lb_output.Text = "Ciphertext output";

            BigInteger N = BigInteger.Parse(rtb_modulus.Text);
            BigInteger E = BigInteger.Parse(rtb_e.Text);

            int k = GetBlockSize(N);


            string text = rtb_input.Text;


            List<string> blocks = SplitText(text, k);
            List<string> numberList = new();
            List<string> cipherList = new();

            rtb_seg.Text = string.Join(" # ", blocks.Select(b => b.TrimEnd(' ')));

            foreach (var block in blocks)
            {

                BigInteger m = TextBlockToNumber(block);
                numberList.Add(m.ToString());

                BigInteger c = BigInteger.ModPow(m, E, N);
                cipherList.Add(c.ToString());
            }
            rtb_base.Text = string.Join(" # ", numberList);
            rtb_output.Text = string.Join("#", cipherList);
        }

        private void btn_de_Click(object sender, EventArgs e)
        {
            if (IsEmpty(rtb_input, rtb_modulus, rtb_e))
            {
                MessageBox.Show("Chưa có input!");
                return;
            }
            if (!ValidateNumberInput(rtb_input.Text))
            {
                MessageBox.Show("Decrypt yêu cầu ciphertext dạng số, ngăn cách bởi #.");
                return;
            }
            lb_input.Text = "Ciphertext input";
            lb_output.Text = "Plaintext output";

            BigInteger N = BigInteger.Parse(rtb_modulus.Text);
            BigInteger d = BigInteger.Parse(rtb_d.Text);

            string[] parts = rtb_input.Text.Split('#');
            string result = "";
            int k = GetBlockSize(N);

            List<string> numberList = new();

            List<string> segmentList = new();

            foreach (string part in parts)
            {
                BigInteger c = BigInteger.Parse(part);
                BigInteger m = BigInteger.ModPow(c, d, N);

                numberList.Add(m.ToString());
                string block = NumberToTextBlock(m, k);
                segmentList.Add(block.TrimEnd(' '));

                result += NumberToTextBlock(m, k);
            }
            rtb_seg.Text = string.Join(" # ", segmentList);
            rtb_base.Text = string.Join(" # ", numberList);
            rtb_output.Text = result;
        }
        private void ApplyCyberBackgroundTheme()
        {
            Color darkGlass = Color.FromArgb(8, 20, 32);
            Color darkInput = Color.FromArgb(5, 16, 26);
            Color cyan = Color.FromArgb(0, 205, 255);
            Color purple = Color.FromArgb(118, 92, 255);
            Color white = Color.White;

            // Form chính giữ hình nền
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.FromArgb(5, 14, 22);

            // Panel phải trong suốt để nền liền mạch
            pn_rsa.BackColor = Color.Transparent;
            pn_pf.BackColor = Color.Transparent;
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;

            pn_rsa.BackgroundImage = null;
            pn_pf.BackgroundImage = null;
            panel1.BackgroundImage = null;
            panel2.BackgroundImage = null;
            panel3.BackgroundImage = null;
            panel4.BackgroundImage = null;

            // Title
            lb1.BackColor = Color.FromArgb(8, 20, 32);
            lb1.ForeColor = Color.White;
            lb1.Font = new Font("Segoe UI", 32F, FontStyle.Bold);

            lb2.BackColor = Color.FromArgb(8, 20, 32);
            lb2.ForeColor = Color.White;
            lb2.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lb2.Padding = new Padding(8, 2, 8, 2);

            // Labels nổi hơn
            StyleLabel(label14);
            StyleLabel(label1);
            StyleLabel(label2);
            StyleLabel(label3);
            StyleLabel(label4);
            StyleLabel(label5);
            StyleLabel(label6);
            StyleLabel(label7);
            StyleLabel(label8);
            StyleLabel(label11);
            StyleLabel(label12);
            StyleLabel(lb_input);
            StyleLabel(lb_output);

            // Textbox/RichTextBox không còn trắng gắt
            StyleInput(rtb_p);
            StyleInput(rtb_q);
            StyleInput(rtb_modulus);
            StyleInput(rtb_phi);
            StyleInput(rtb_e);
            StyleInput(rtb_d);
            StyleInput(rtb_input);
            StyleInput(rtb_seg);
            StyleInput(rtb_base);
            StyleInput(rtb_output);

            // Button nổi nhưng không lòe
            StylePrimaryButton(rsa_btn);
            StyleSecondaryButton(pf_btn);

            StylePrimaryButton(btn_generate);
            StylePrimaryButton(btn_en);

            StylePurpleButton(btn_update);
            StylePurpleButton(btn_de);

            // Ẩn 2 button cũ ngoài panel
            btn_encrypt.Visible = false;
            btn_decrypt.Visible = false;
            btn_encrypt.Size = new Size(1, 1);
            btn_decrypt.Size = new Size(1, 1);
        }

        private void StyleLabel(Label label)
        {
            label.BackColor = Color.FromArgb(8, 20, 32);
            label.ForeColor = Color.White;
            label.Font = new Font("Segoe UI", label.Font.Size, FontStyle.Bold);
            label.Padding = new Padding(8, 2, 8, 2);
        }

        private void StyleInput(RichTextBox box)
        {
            box.BackColor = Color.FromArgb(5, 16, 26);
            box.ForeColor = Color.FromArgb(220, 248, 255);
            box.BorderStyle = BorderStyle.FixedSingle;
            box.Font = new Font("Consolas", 14F, FontStyle.Bold);
        }

        private void StylePrimaryButton(Button button)
        {
            button.BackColor = Color.FromArgb(0, 205, 255);
            button.ForeColor = Color.FromArgb(2, 18, 28);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = Color.FromArgb(170, 245, 255);
            button.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
        }

        private void StylePurpleButton(Button button)
        {
            button.BackColor = Color.FromArgb(118, 92, 255);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = Color.FromArgb(210, 205, 255);
            button.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
        }

        private void StyleSecondaryButton(Button button)
        {
            button.BackColor = Color.FromArgb(8, 23, 35);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = Color.FromArgb(0, 205, 255);
            button.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
        }

    }

}
