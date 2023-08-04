namespace svn_unreal_create_repo_gui
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            txtNewRepoName = new TextBox();
            btnClearName = new Button();
            btnCreate = new Button();
            listLog = new ListView();
            TypeAndTime = new ColumnHeader();
            LogMessage = new ColumnHeader();
            imgState = new ImageList(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNewRepoName);
            groupBox1.Location = new Point(21, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 65);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "输入新Repo的名称";
            // 
            // txtNewRepoName
            // 
            txtNewRepoName.Location = new Point(22, 26);
            txtNewRepoName.Name = "txtNewRepoName";
            txtNewRepoName.Size = new Size(414, 23);
            txtNewRepoName.TabIndex = 0;
            // 
            // btnClearName
            // 
            btnClearName.Location = new Point(301, 107);
            btnClearName.Name = "btnClearName";
            btnClearName.Size = new Size(85, 29);
            btnClearName.TabIndex = 1;
            btnClearName.Text = "清空";
            btnClearName.UseVisualStyleBackColor = true;
            btnClearName.Click += btnClearName_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LightSteelBlue;
            btnCreate.Location = new Point(392, 107);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(86, 29);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "确认创建";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // listLog
            // 
            listLog.Columns.AddRange(new ColumnHeader[] { TypeAndTime, LogMessage });
            listLog.LargeImageList = imgState;
            listLog.Location = new Point(21, 167);
            listLog.Name = "listLog";
            listLog.Size = new Size(457, 130);
            listLog.SmallImageList = imgState;
            listLog.StateImageList = imgState;
            listLog.TabIndex = 3;
            listLog.UseCompatibleStateImageBehavior = false;
            listLog.View = View.Details;
            // 
            // TypeAndTime
            // 
            TypeAndTime.Text = "时间";
            TypeAndTime.Width = 160;
            // 
            // LogMessage
            // 
            LogMessage.Text = "内容";
            LogMessage.Width = 270;
            // 
            // imgState
            // 
            imgState.ColorDepth = ColorDepth.Depth16Bit;
            imgState.ImageStream = (ImageListStreamer)resources.GetObject("imgState.ImageStream");
            imgState.TransparentColor = Color.Transparent;
            imgState.Images.SetKeyName(0, "Info");
            imgState.Images.SetKeyName(1, "Success");
            imgState.Images.SetKeyName(2, "Error");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 309);
            Controls.Add(listLog);
            Controls.Add(btnCreate);
            Controls.Add(btnClearName);
            Controls.Add(groupBox1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "创建一个新的本地SVN Repo";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnClearName;
        private Button btnCreate;
        private TextBox txtNewRepoName;
        private ListView listLog;
        private ImageList imgState;
        private ColumnHeader TypeAndTime;
        private ColumnHeader LogMessage;
    }
}