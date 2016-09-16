namespace PrjHikariwoAnim
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プロジェクトの新規作成NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プロジェクトを開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プロジェクトを上書き保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ウィンドウWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_ImageList = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_Control = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_Attribute = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.ウィンドウWToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(401, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.プロジェクトの新規作成NToolStripMenuItem,
            this.プロジェクトを開くOToolStripMenuItem,
            this.プロジェクトを上書き保存SToolStripMenuItem,
            this.名前を付けて保存AToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // プロジェクトの新規作成NToolStripMenuItem
            // 
            this.プロジェクトの新規作成NToolStripMenuItem.Name = "プロジェクトの新規作成NToolStripMenuItem";
            this.プロジェクトの新規作成NToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.プロジェクトの新規作成NToolStripMenuItem.Text = "新規作成(&N)";
            // 
            // プロジェクトを開くOToolStripMenuItem
            // 
            this.プロジェクトを開くOToolStripMenuItem.Name = "プロジェクトを開くOToolStripMenuItem";
            this.プロジェクトを開くOToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.プロジェクトを開くOToolStripMenuItem.Text = "開く(&O)";
            // 
            // プロジェクトを上書き保存SToolStripMenuItem
            // 
            this.プロジェクトを上書き保存SToolStripMenuItem.Name = "プロジェクトを上書き保存SToolStripMenuItem";
            this.プロジェクトを上書き保存SToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.プロジェクトを上書き保存SToolStripMenuItem.Text = "上書き保存(&S)";
            // 
            // 名前を付けて保存AToolStripMenuItem
            // 
            this.名前を付けて保存AToolStripMenuItem.Name = "名前を付けて保存AToolStripMenuItem";
            this.名前を付けて保存AToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.名前を付けて保存AToolStripMenuItem.Text = "名前を付けて保存(&A)";
            // 
            // ウィンドウWToolStripMenuItem
            // 
            this.ウィンドウWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenu_ImageList,
            this.TSMenu_Control,
            this.TSMenu_Attribute});
            this.ウィンドウWToolStripMenuItem.Name = "ウィンドウWToolStripMenuItem";
            this.ウィンドウWToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ウィンドウWToolStripMenuItem.Text = "ウィンドウ(&W)";
            // 
            // TSMenu_ImageList
            // 
            this.TSMenu_ImageList.Checked = true;
            this.TSMenu_ImageList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMenu_ImageList.Name = "TSMenu_ImageList";
            this.TSMenu_ImageList.Size = new System.Drawing.Size(152, 22);
            this.TSMenu_ImageList.Text = "イメージリスト(&I)";
            this.TSMenu_ImageList.Click += new System.EventHandler(this.TSMenu_ImageList_Click);
            // 
            // TSMenu_Control
            // 
            this.TSMenu_Control.Checked = true;
            this.TSMenu_Control.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMenu_Control.Name = "TSMenu_Control";
            this.TSMenu_Control.Size = new System.Drawing.Size(152, 22);
            this.TSMenu_Control.Text = "コントロール(&C)";
            this.TSMenu_Control.Click += new System.EventHandler(this.TSMenu_Control_Click);
            // 
            // TSMenu_Attribute
            // 
            this.TSMenu_Attribute.Checked = true;
            this.TSMenu_Attribute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMenu_Attribute.Name = "TSMenu_Attribute";
            this.TSMenu_Attribute.Size = new System.Drawing.Size(152, 22);
            this.TSMenu_Attribute.Text = "アトリビュート(&A)";
            this.TSMenu_Attribute.Click += new System.EventHandler(this.TSMenu_Attribute_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 162);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(401, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 184);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "PrjHikariwoAnim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem プロジェクトの新規作成NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem プロジェクトを開くOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem プロジェクトを上書き保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存AToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem ウィンドウWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMenu_ImageList;
        private System.Windows.Forms.ToolStripMenuItem TSMenu_Control;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.ToolStripMenuItem TSMenu_Attribute;
    }
}

