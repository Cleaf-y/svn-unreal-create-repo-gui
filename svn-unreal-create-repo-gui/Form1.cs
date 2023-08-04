

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

            AddLog("程序启动", 0);
        }

        private void btnClearName_Click(object sender, EventArgs e)
        {
            txtNewRepoName.Text = "";
            txtNewRepoName.Focus();
        }

        // <param name="msg">消息内容</param>
        // <param name="type">消息类型</param>
        private void AddLog(string msg, int type)
        {
            listLog.BeginUpdate();
            ListViewItem newLogItem = new ListViewItem("  " + DateTime.Now.ToString("G"), type);
            newLogItem.SubItems.Add(msg);
            listLog.Items.Insert(0, newLogItem);
            listLog.EndUpdate();

        }

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtNewRepoName.Text))
            {
                MessageBox.Show("名称为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewRepoName.Focus();
                return false;
            }
            return true;
        }

        private bool CreateRepo(string repoName)
        {
            return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

            if (CreateRepo(txtNewRepoName.Text))
            {
                AddLog("创建成功", 1);
            }
            else
            {
                AddLog("创建失败", 2);
                txtNewRepoName.SelectAll();
                txtNewRepoName.Focus();
            }
        }
    }
}