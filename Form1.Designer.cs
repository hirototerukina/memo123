
namespace memo123
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.txt_memo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上書き保存sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前をつけて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.元に戻すZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切り取りXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼り付けPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ステータスバーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.書式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプを表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_memo
            // 
            this.txt_memo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_memo.Location = new System.Drawing.Point(0, 24);
            this.txt_memo.Multiline = true;
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_memo.Size = new System.Drawing.Size(800, 426);
            this.txt_memo.TabIndex = 0;
            this.txt_memo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.書式ToolStripMenuItem,
            this.表示ToolStripMenuItem,
            this.hELPHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成ToolStripMenuItem,
            this.開くToolStripMenuItem,
            this.上書き保存sToolStripMenuItem,
            this.名前をつけて保存ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 新規作成ToolStripMenuItem
            // 
            this.新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem";
            this.新規作成ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新規作成ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.新規作成ToolStripMenuItem.Tag = "";
            this.新規作成ToolStripMenuItem.Text = "新規作成(&N)";
            this.新規作成ToolStripMenuItem.Click += new System.EventHandler(this.新規作成ToolStripMenuItem_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.開くToolStripMenuItem.Text = "開く(&O)";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 上書き保存sToolStripMenuItem
            // 
            this.上書き保存sToolStripMenuItem.Enabled = false;
            this.上書き保存sToolStripMenuItem.Name = "上書き保存sToolStripMenuItem";
            this.上書き保存sToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.上書き保存sToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.上書き保存sToolStripMenuItem.Text = "上書き保存(&S)";
            this.上書き保存sToolStripMenuItem.Click += new System.EventHandler(this.上書き保存sToolStripMenuItem_Click);
            // 
            // 名前をつけて保存ToolStripMenuItem
            // 
            this.名前をつけて保存ToolStripMenuItem.Name = "名前をつけて保存ToolStripMenuItem";
            this.名前をつけて保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.名前をつけて保存ToolStripMenuItem.Text = "名前をつけて保存(&A)";
            this.名前をつけて保存ToolStripMenuItem.Click += new System.EventHandler(this.名前をつけて保存ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem.Text = "終了(&X)";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click_1);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.元に戻すZToolStripMenuItem,
            this.切り取りXToolStripMenuItem,
            this.コピーCToolStripMenuItem,
            this.貼り付けPToolStripMenuItem,
            this.削除DToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            this.編集EToolStripMenuItem.Click += new System.EventHandler(this.編集EToolStripMenuItem_Click);
            // 
            // 元に戻すZToolStripMenuItem
            // 
            this.元に戻すZToolStripMenuItem.Enabled = false;
            this.元に戻すZToolStripMenuItem.Name = "元に戻すZToolStripMenuItem";
            this.元に戻すZToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.元に戻すZToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.元に戻すZToolStripMenuItem.Text = "元に戻す(&U)";
            this.元に戻すZToolStripMenuItem.Click += new System.EventHandler(this.元に戻すZToolStripMenuItem_Click);
            // 
            // 切り取りXToolStripMenuItem
            // 
            this.切り取りXToolStripMenuItem.Enabled = false;
            this.切り取りXToolStripMenuItem.Name = "切り取りXToolStripMenuItem";
            this.切り取りXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.切り取りXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.切り取りXToolStripMenuItem.Text = "切り取り(&T)";
            this.切り取りXToolStripMenuItem.Click += new System.EventHandler(this.切り取りXToolStripMenuItem_Click);
            // 
            // コピーCToolStripMenuItem
            // 
            this.コピーCToolStripMenuItem.Enabled = false;
            this.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem";
            this.コピーCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.コピーCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.コピーCToolStripMenuItem.Text = "コピー(&C)";
            this.コピーCToolStripMenuItem.Click += new System.EventHandler(this.コピーCToolStripMenuItem_Click);
            // 
            // 貼り付けPToolStripMenuItem
            // 
            this.貼り付けPToolStripMenuItem.Enabled = false;
            this.貼り付けPToolStripMenuItem.Name = "貼り付けPToolStripMenuItem";
            this.貼り付けPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼り付けPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.貼り付けPToolStripMenuItem.Text = "貼り付け(&P)";
            this.貼り付けPToolStripMenuItem.Click += new System.EventHandler(this.貼り付けPToolStripMenuItem_Click);
            // 
            // 削除DToolStripMenuItem
            // 
            this.削除DToolStripMenuItem.Enabled = false;
            this.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem";
            this.削除DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.削除DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.削除DToolStripMenuItem.Text = "削除(&L)";
            this.削除DToolStripMenuItem.Click += new System.EventHandler(this.削除DToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Enabled = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ステータスバーToolStripMenuItem});
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            this.表示ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.表示ToolStripMenuItem.Text = "表示(&V)";
            // 
            // ステータスバーToolStripMenuItem
            // 
            this.ステータスバーToolStripMenuItem.CheckOnClick = true;
            this.ステータスバーToolStripMenuItem.Name = "ステータスバーToolStripMenuItem";
            this.ステータスバーToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ステータスバーToolStripMenuItem.Text = "ステータスバー(&S)";
            this.ステータスバーToolStripMenuItem.Click += new System.EventHandler(this.ステータスバーToolStripMenuItem_Click);
            // 
            // 書式ToolStripMenuItem
            // 
            this.書式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォントFToolStripMenuItem});
            this.書式ToolStripMenuItem.Name = "書式ToolStripMenuItem";
            this.書式ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.書式ToolStripMenuItem.Text = "書式(&O)";
            // 
            // フォントFToolStripMenuItem
            // 
            this.フォントFToolStripMenuItem.Name = "フォントFToolStripMenuItem";
            this.フォントFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.フォントFToolStripMenuItem.Text = "フォント(&F)";
            this.フォントFToolStripMenuItem.Click += new System.EventHandler(this.フォントFToolStripMenuItem_Click);
            // 
            // hELPHToolStripMenuItem
            // 
            this.hELPHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ヘルプを表示ToolStripMenuItem});
            this.hELPHToolStripMenuItem.Name = "hELPHToolStripMenuItem";
            this.hELPHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.hELPHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // ヘルプを表示ToolStripMenuItem
            // 
            this.ヘルプを表示ToolStripMenuItem.Name = "ヘルプを表示ToolStripMenuItem";
            this.ヘルプを表示ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ヘルプを表示ToolStripMenuItem.Text = "ヘルプの表示(&H)";
            this.ヘルプを表示ToolStripMenuItem.Click += new System.EventHandler(this.ヘルプを表示ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txt_memo);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_memo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前をつけて保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規作成ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存sToolStripMenuItem;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切り取りXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼り付けPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コピーCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 元に戻すZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ステータスバーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 書式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプを表示ToolStripMenuItem;
    }
}

