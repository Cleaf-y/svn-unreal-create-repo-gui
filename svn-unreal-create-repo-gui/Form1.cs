

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

            AddLog("��������", 0);
        }

        private void btnClearName_Click(object sender, EventArgs e)
        {
            txtNewRepoName.Text = "";
            txtNewRepoName.Focus();
        }

        // <param name="msg">��Ϣ����</param>
        // <param name="type">��Ϣ����</param>
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
                MessageBox.Show("����Ϊ��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                AddLog("�����ɹ�", 1);
            }
            else
            {
                AddLog("����ʧ��", 2);
                txtNewRepoName.SelectAll();
                txtNewRepoName.Focus();
            }
        }
    }
}