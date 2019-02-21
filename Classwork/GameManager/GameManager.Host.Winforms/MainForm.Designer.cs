namespace GameManager.Host.Winforms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miGameAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._miGameEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._miGameDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._listGames = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // _miFileExit
            // 
            this._miFileExit.Name = "_miFileExit";
            this._miFileExit.Size = new System.Drawing.Size(92, 22);
            this._miFileExit.Text = "E&xit";
            this._miFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miGameAdd,
            this._miGameEdit,
            this.toolStripSeparator1,
            this._miGameDelete});
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gamesToolStripMenuItem.Text = "&Games";
            // 
            // _miGameAdd
            // 
            this._miGameAdd.Name = "_miGameAdd";
            this._miGameAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this._miGameAdd.Size = new System.Drawing.Size(180, 22);
            this._miGameAdd.Text = "&Add";
            this._miGameAdd.Click += new System.EventHandler(this.OnGameAdd);
            // 
            // _miGameEdit
            // 
            this._miGameEdit.Name = "_miGameEdit";
            this._miGameEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Insert)));
            this._miGameEdit.Size = new System.Drawing.Size(180, 22);
            this._miGameEdit.Text = "&Edit";
            this._miGameEdit.Click += new System.EventHandler(this.OnGameEdit);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // _miGameDelete
            // 
            this._miGameDelete.Name = "_miGameDelete";
            this._miGameDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._miGameDelete.Size = new System.Drawing.Size(180, 22);
            this._miGameDelete.Text = "&Delete";
            this._miGameDelete.Click += new System.EventHandler(this.OnGameDelete);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // _miHelpAbout
            // 
            this._miHelpAbout.Name = "_miHelpAbout";
            this._miHelpAbout.Size = new System.Drawing.Size(107, 22);
            this._miHelpAbout.Text = "&About";
            this._miHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // _listGames
            // 
            this._listGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listGames.FormattingEnabled = true;
            this._listGames.Location = new System.Drawing.Point(0, 24);
            this._listGames.Name = "_listGames";
            this._listGames.Size = new System.Drawing.Size(800, 426);
            this._listGames.TabIndex = 1;
            this._listGames.SelectedIndexChanged += new System.EventHandler(this.OnGameSelected);
            this._listGames.DoubleClick += new System.EventHandler(this.OnGameEdit);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._listGames);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Game Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miGameAdd;
        private System.Windows.Forms.ToolStripMenuItem _miGameEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _miGameDelete;
        private System.Windows.Forms.ToolStripMenuItem _miHelpAbout;
        private System.Windows.Forms.ListBox _listGames;
    }
}

