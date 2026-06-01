using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RSA_Playfair
{
    public partial class Playfair : UserControl
    {
        public Playfair()
        {
            InitializeComponent();
            rtb_key.TextChanged += (s, e) => UpdatePlayFair();
            //rtb_input.TextChanged += (s, e) => UpdatePlayFair();
        }

        private PlayfairCipher pfc;

        private void ShowMatrix(char[,] matrix)
        {
            RichTextBox[] boxes =
            {
                richTextBox1, richTextBox2, richTextBox3, richTextBox4, richTextBox5,
                richTextBox6, richTextBox7, richTextBox8, richTextBox9, richTextBox10,
                richTextBox11, richTextBox12, richTextBox13, richTextBox14, richTextBox15,
                richTextBox16, richTextBox17, richTextBox18, richTextBox19, richTextBox20,
                richTextBox21, richTextBox22, richTextBox23, richTextBox24, richTextBox25
            };
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    boxes[k++].Text = matrix[i, j].ToString();
                }
            }
        }

        private void UpdatePlayFair()
        {
            string key = rtb_key.Text;

            if (string.IsNullOrWhiteSpace(key))
            {
                rtb_output.Clear();
                pfc = null;
                return;
            }

            pfc = new PlayfairCipher(key);

            ShowMatrix(pfc.GetMatrix());
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            if (pfc == null)
            {
                MessageBox.Show("Vui lòng nhập key!");
                return;
            }

            if (string.IsNullOrWhiteSpace(rtb_input.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung!");
                return;
            }
            label4.Text = "Plaintext input";
            label3.Text = "Ciphertext output";
            string output = pfc.Encrypt(rtb_input.Text);
            rtb_output.Text = output;
        }
        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (pfc == null)
            {
                MessageBox.Show("Vui lòng nhập key!");
                return;
            }

            if (string.IsNullOrWhiteSpace(rtb_input.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung!");
                return;
            }
            label4.Text = "Ciphertext input";
            label3.Text = "Plaintext output";
            string output = pfc.Decrypt(rtb_input.Text);

            rtb_output.Text = output;
        }

        private void rtb_output_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class PlayfairCipher
    {
        private char[,] matrix = new char[5, 5];
        private (int, int)[] pos = new (int, int)[26];

        public PlayfairCipher(string key)
        {
            string fullKey = NormalizeKey(key);

            int idx = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = fullKey[idx++];
                    pos[matrix[i, j] - 'A'] = (i, j);
                }
            }

            pos['J' - 'A'] = pos['I' - 'A'];
        }

        private string NormalizeKey(string key)
        {
            StringBuilder result = new StringBuilder();
            bool[] used = new bool[26];

            foreach (char ch in key)
            {
                if (char.IsLetter(ch))
                {
                    char c = char.ToUpper(ch);
                    if (c == 'J') c = 'I';

                    if (!used[c - 'A'])
                    {
                        used[c - 'A'] = true;
                        result.Append(c);
                    }
                }
            }

            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (c == 'J') continue;
                if (!used[c - 'A'])
                {
                    used[c - 'A'] = true;
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private string NormalizeText(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    char c = char.ToUpper(ch);
                    if (c == 'J') c = 'I';
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private string PreparePlaintext(string text)
        {
            string s = NormalizeText(text);
            StringBuilder prepared = new StringBuilder();

            for (int i = 0; i < s.Length;)
            {
                char a = s[i];
                char b;

                if (i + 1 < s.Length)
                {
                    b = s[i + 1];
                    if (a == b)
                    {
                        prepared.Append(a).Append('X');
                        i++;
                    }
                    else
                    {
                        prepared.Append(a).Append(b);
                        i += 2;
                    }
                }
                else
                {
                    prepared.Append(a).Append('X');
                    i++;
                }
            }

            return prepared.ToString();
        }

        private (char, char) EncryptPair(char a, char b)
        {
            var (r1, c1) = pos[a - 'A'];
            var (r2, c2) = pos[b - 'A'];

            if (r1 == r2)
                return (matrix[r1, (c1 + 1) % 5], matrix[r2, (c2 + 1) % 5]);

            if (c1 == c2)
                return (matrix[(r1 + 1) % 5, c1], matrix[(r2 + 1) % 5, c2]);

            return (matrix[r1, c2], matrix[r2, c1]);
        }

        public string Encrypt(string text)
        {
            string prepared = PreparePlaintext(text);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < prepared.Length; i += 2)
            {
                var (a, b) = EncryptPair(prepared[i], prepared[i + 1]);
                result.Append(a).Append(b);
            }

            return result.ToString();
        }

        private (char, char) DecryptPair(char a, char b)
        {
            var (r1, c1) = pos[a - 'A'];
            var (r2, c2) = pos[b - 'A'];

            if (r1 == r2)
                return (matrix[r1, (c1 + 4) % 5], matrix[r2, (c2 + 4) % 5]);

            if (c1 == c2)
                return (matrix[(r1 + 4) % 5, c1], matrix[(r2 + 4) % 5, c2]);

            return (matrix[r1, c2], matrix[r2, c1]);
        }
        public string Decrypt(string text)
        {
            string s = NormalizeText(text);
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < s.Length - 1; i += 2)
            {
                var (a, b) = DecryptPair(s[i], s[i + 1]);
                ans.Append(a).Append(b);
            }
            return ans.ToString();
        }
        public char[,] GetMatrix()
        {
            return matrix;
        }
    }
}
