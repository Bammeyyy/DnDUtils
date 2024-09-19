namespace DnDUtils
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_initTracker_Click(object sender, EventArgs e)
        {
            InitTracker initTracker = new InitTracker();
            initTracker.Show();
        }

        private void btn_Lookup_Click(object sender, EventArgs e)
        {
            Lookup lookup = new Lookup();
            lookup.Show();
        }
        private void btn_Soundboard_Click(object sender, EventArgs e)
        {
            Soundboard soundboard = new Soundboard();
            soundboard.Show();
        }
    }
}
