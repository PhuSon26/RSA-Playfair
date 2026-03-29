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

        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {

        }
    }
}