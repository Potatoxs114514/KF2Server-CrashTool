namespace KF2服务器重启工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Catch = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.ServerList = new System.Windows.Forms.ListBox();
            this.AddServer = new System.Windows.Forms.Button();
            this.DelServer = new System.Windows.Forms.Button();
            this.Writer = new System.Windows.Forms.TextBox();
            this.Import = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Catch
            // 
            this.Catch.Interval = 10000;
            this.Catch.Tick += new System.EventHandler(this.Catch_Tick);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(308, 130);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "启动";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ServerList
            // 
            this.ServerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerList.FormattingEnabled = true;
            this.ServerList.ItemHeight = 12;
            this.ServerList.Location = new System.Drawing.Point(12, 10);
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(290, 112);
            this.ServerList.TabIndex = 0;
            this.ServerList.SelectedValueChanged += new System.EventHandler(this.ServerList_SelectedValueChanged);
            // 
            // AddServer
            // 
            this.AddServer.Location = new System.Drawing.Point(308, 10);
            this.AddServer.Name = "AddServer";
            this.AddServer.Size = new System.Drawing.Size(75, 23);
            this.AddServer.TabIndex = 3;
            this.AddServer.Text = "添加";
            this.AddServer.UseVisualStyleBackColor = true;
            this.AddServer.Click += new System.EventHandler(this.AddServer_Click);
            // 
            // DelServer
            // 
            this.DelServer.Location = new System.Drawing.Point(308, 39);
            this.DelServer.Name = "DelServer";
            this.DelServer.Size = new System.Drawing.Size(75, 23);
            this.DelServer.TabIndex = 4;
            this.DelServer.Text = "删除";
            this.DelServer.UseVisualStyleBackColor = true;
            this.DelServer.Click += new System.EventHandler(this.DelServer_Click);
            // 
            // Writer
            // 
            this.Writer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Writer.Location = new System.Drawing.Point(12, 130);
            this.Writer.Name = "Writer";
            this.Writer.Size = new System.Drawing.Size(290, 21);
            this.Writer.TabIndex = 5;
            this.Writer.TextChanged += new System.EventHandler(this.Writer_TextChanged);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(308, 68);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(75, 23);
            this.Import.TabIndex = 6;
            this.Import.Text = "导入";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 163);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Writer);
            this.Controls.Add(this.DelServer);
            this.Controls.Add(this.AddServer);
            this.Controls.Add(this.ServerList);
            this.Controls.Add(this.Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KF2Server_CrashTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Catch;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ListBox ServerList;
        private System.Windows.Forms.Button AddServer;
        private System.Windows.Forms.Button DelServer;
        private System.Windows.Forms.TextBox Writer;
        private System.Windows.Forms.Button Import;
    }
}

