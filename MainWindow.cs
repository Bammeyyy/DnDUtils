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
    }
}
