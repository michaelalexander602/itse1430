namespace GameManager.Host.Winforms
{
    partial class GameForm
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
            this.namelabel = new System.Windows.Forms.Label();
            this.publisherlabel = new System.Windows.Forms.Label();
            this.Pricelabel = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtPublisher = new System.Windows.Forms.TextBox();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._cbOwned = new System.Windows.Forms.CheckBox();
            this._cbCompleted = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(27, 26);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name";
            // 
            // publisherlabel
            // 
            this.publisherlabel.AutoSize = true;
            this.publisherlabel.Location = new System.Drawing.Point(30, 59);
            this.publisherlabel.Name = "publisherlabel";
            this.publisherlabel.Size = new System.Drawing.Size(50, 13);
            this.publisherlabel.TabIndex = 1;
            this.publisherlabel.Text = "Publisher";
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Location = new System.Drawing.Point(30, 89);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(31, 13);
            this.Pricelabel.TabIndex = 2;
            this.Pricelabel.Text = "Price";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(89, 26);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(100, 20);
            this._txtName.TabIndex = 5;
            // 
            // _txtPublisher
            // 
            this._txtPublisher.Location = new System.Drawing.Point(89, 59);
            this._txtPublisher.Name = "_txtPublisher";
            this._txtPublisher.Size = new System.Drawing.Size(100, 20);
            this._txtPublisher.TabIndex = 6;
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(89, 89);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(100, 20);
            this._txtPrice.TabIndex = 7;
            // 
            // _cbOwned
            // 
            this._cbOwned.AutoSize = true;
            this._cbOwned.Location = new System.Drawing.Point(89, 123);
            this._cbOwned.Name = "_cbOwned";
            this._cbOwned.Size = new System.Drawing.Size(66, 17);
            this._cbOwned.TabIndex = 8;
            this._cbOwned.Text = "Owned?";
            this._cbOwned.UseVisualStyleBackColor = true;
            // 
            // _cbCompleted
            // 
            this._cbCompleted.AutoSize = true;
            this._cbCompleted.Location = new System.Drawing.Point(89, 162);
            this._cbCompleted.Name = "_cbCompleted";
            this._cbCompleted.Size = new System.Drawing.Size(82, 17);
            this._cbCompleted.TabIndex = 9;
            this._cbCompleted.Text = "Completed?";
            this._cbCompleted.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnClose);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 384);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._cbCompleted);
            this.Controls.Add(this._cbOwned);
            this.Controls.Add(this._txtPrice);
            this.Controls.Add(this._txtPublisher);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.Pricelabel);
            this.Controls.Add(this.publisherlabel);
            this.Controls.Add(this.namelabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Detail";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label publisherlabel;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtPublisher;
        private System.Windows.Forms.TextBox _txtPrice;
        private System.Windows.Forms.CheckBox _cbOwned;
        private System.Windows.Forms.CheckBox _cbCompleted;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}