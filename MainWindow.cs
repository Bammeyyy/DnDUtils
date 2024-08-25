namespace DnDUtils
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_initTracker_Click(object sender, EventArgs e)
<<<<<<< Updated upstream
        {

        }

        private void btn_soundboard_Click(object sender, EventArgs e)
=======
>>>>>>> Stashed changes
        {
            InitTracker initTracker = new InitTracker();
            initTracker.Show();
        }
    }
}