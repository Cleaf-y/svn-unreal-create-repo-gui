namespace svn_unreal_create_repo_gui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listLog.BeginUpdate();
            ListViewItem item = new ListViewItem();
            item.Text = "≤‚ ‘";
            listLog.Items.Add(item);
            listLog.EndUpdate();

        }

        private void btnClearName_Click(object sender, EventArgs e)
        {
            txtNewRepoName.Text = "";
            txtNewRepoName.Focus();
        }
    }
}