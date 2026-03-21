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
        }

        private void pf_btn_Click(object sender, EventArgs e)
        {
            pf_btn.BackColor = Color.Gray;
            rsa_btn.BackColor = SystemColors.Control;
            pf_btn.Enabled = false;
            rsa_btn.Enabled = true;
            pn_rsa.Enabled = false;
            pn_rsa.Visible = false;
        }
    }
}