

using System.Diagnostics;

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

        private void OnError()
        {
            txtNewRepoName.SelectAll();
            txtNewRepoName.Focus();
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
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();

                p.StandardOutput.DiscardBufferedData();
                string strCMD = $"svnadmin create --compatible-version 1.9 --fs-type fsfs G:\\UnrealBackup\\{repoName}";
                p.StandardInput.WriteLine(strCMD + "&exit");
                p.StandardInput.AutoFlush = true;
                p.WaitForExit();
                string strError = p.StandardError.ReadToEnd();
                p.Close();

                if (string.IsNullOrEmpty(strError)) return true;

                if (strError.Contains("exist"))
                {
                    AddLog("已存在这个Repo", 2);
                }
                else
                {
                    MessageBox.Show(strError, "未知错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AddLog("未知错误", 2);
                    AddLog(strError, 2);
                }
                OnError();
                return false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                AddLog(ex.Message, 2);
                OnError();
                return false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

            if (CreateRepo(txtNewRepoName.Text))
            {
                Clipboard.SetDataObject($"file:///G:/UnrealBackup/{txtNewRepoName.Text}");
                string successMsg = $"{txtNewRepoName.Text}创建成功, Repo地址已复制到剪贴板";
                AddLog(successMsg, 1);
                if(MessageBox.Show(successMsg+"\n是否退出？", "创建成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
                
            }
            else
            {
                AddLog("创建失败", 2);
                OnError();
            }
        }
    }
}