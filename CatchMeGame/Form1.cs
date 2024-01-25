namespace CatchMeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Game has started.\nYou must click button for winning.\n" +
                "You should be careful, because button can run from you :)", "Game Rules", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button_CatchMe_MouseEnter(object sender, EventArgs e)
        {
            var rnd = new Random();
            int maxWidth = ClientSize.Width - button_CatchMe.Size.Width;
            int maxHeight = ClientSize.Height - button_CatchMe.Size.Height;

            button_CatchMe.Location = new Point(rnd.Next(0, maxWidth), (rnd.Next(0, maxHeight)));
        }

        private void button_CatchMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats, you catched me :)", "Wining Notification", MessageBoxButtons.OK);
            Close();
        }
    }
}