namespace GUI_Using_SQLite
{
    public partial class pb_led : Form
    {
        public pb_led()
        {
            InitializeComponent();
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_Access.Text = "0";
            label_Username.Text = "--";
            Globals.loggedIn = false;
            pictureBox1.Image = Properties.Resources.redlight;

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logOffToolStripMenuItem_Click(sender, e);
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}