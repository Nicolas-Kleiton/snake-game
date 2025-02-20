namespace Snake_Game
{
    public partial class Form1 : Form
    {
        Game Game;

        public Form1()
        {
            InitializeComponent();
            Game = new Game(ref Frame, ref LbScore, ref LbScreen);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game.Tick();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.StartGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right){
                Game.Arrow = e.KeyCode;
            }
        }
    }
}
