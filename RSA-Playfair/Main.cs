namespace RSA_Playfair
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
            } while (isprime(num));
            rtb_p.Text = num.ToString();
            do
            {
                num = rnd.Next(1, int.MaxValue);
            } while (isprime(num));
            rtb_q.Text = num.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}