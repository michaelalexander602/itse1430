namespace Nile.Windows
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miProductAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._miProductEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._miProductDelete = new System.Windows.Forms.ToolStripMenuItem();
            this._gridProducts = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDiscontinuedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainMenu
            // 
            this._mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._mainMenu.Location = new System.Drawing.Point(0, 0);
            this._mainMenu.Name = "_mainMenu";
            this._mainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this._mainMenu.Size = new System.Drawing.Size(1103, 28);
            this._mainMenu.TabIndex = 0;
            this._mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // _miFileExit
            // 
            this._miFileExit.Name = "_miFileExit";
            this._miFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this._miFileExit.Size = new System.Drawing.Size(161, 26);
            this._miFileExit.Text = "E&xit";
            this._miFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miProductAdd,
            this._miProductEdit,
            this.toolStripSeparator1,
            this._miProductDelete});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.productToolStripMenuItem.Text = "&Product";
            // 
            // _miProductAdd
            // 
            this._miProductAdd.Name = "_miProductAdd";
            this._miProductAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this._miProductAdd.Size = new System.Drawing.Size(160, 26);
            this._miProductAdd.Text = "&Add";
            this._miProductAdd.Click += new System.EventHandler(this.OnProductAdd);
            // 
            // _miProductEdit
            // 
            this._miProductEdit.Name = "_miProductEdit";
            this._miProductEdit.Size = new System.Drawing.Size(160, 26);
            this._miProductEdit.Text = "&Edit";
            this._miProductEdit.Click += new System.EventHandler(this.OnProductEdit);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // _miProductDelete
            // 
            this._miProductDelete.Name = "_miProductDelete";
            this._miProductDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._miProductDelete.Size = new System.Drawing.Size(160, 26);
            this._miProductDelete.Text = "&Delete";
            this._miProductDelete.Click += new System.EventHandler(this.OnProductDelete);
            // 
            // _gridProducts
            // 
            this._gridProducts.AllowUserToAddRows = false;
            this._gridProducts.AllowUserToDeleteRows = false;
            this._gridProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._gridProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._gridProducts.AutoGenerateColumns = false;
            this._gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.isDiscontinuedDataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this._gridProducts.DataSource = this._bsProducts;
            this._gridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridProducts.Location = new System.Drawing.Point(0, 28);
            this._gridProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._gridProducts.Name = "_gridProducts";
            this._gridProducts.ReadOnly = true;
            this._gridProducts.RowHeadersVisible = false;
            this._gridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridProducts.Size = new System.Drawing.Size(1103, 437);
            this._gridProducts.TabIndex = 1;
            this._gridProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnEditRow);
            this._gridProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownGrid);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 300F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C2";
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // isDiscontinuedDataGridViewCheckBoxColumn
            // 
            this.isDiscontinuedDataGridViewCheckBoxColumn.DataPropertyName = "IsDiscontinued";
            this.isDiscontinuedDataGridViewCheckBoxColumn.HeaderText = "Is Discontinued?";
            this.isDiscontinuedDataGridViewCheckBoxColumn.Name = "isDiscontinuedDataGridViewCheckBoxColumn";
            this.isDiscontinuedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDiscontinuedDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // _bsProducts
            // 
            this._bsProducts.AllowNew = false;
            this._bsProducts.DataSource = typeof(Nile.Product);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 465);
            this.Controls.Add(this._gridProducts);
            this.Controls.Add(this._mainMenu);
            this.MainMenuStrip = this._mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Nile";
            this._mainMenu.ResumeLayout(false);
            this._mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miProductAdd;
        private System.Windows.Forms.ToolStripMenuItem _miProductEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _miProductDelete;
        private System.Windows.Forms.DataGridView _gridProducts;
        private System.Windows.Forms.BindingSource _bsProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDiscontinuedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

