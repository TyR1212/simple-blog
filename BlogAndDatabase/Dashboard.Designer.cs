namespace BlogAndDatabase
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLabel = new System.Windows.Forms.Label();
            this.postsLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.postButton = new System.Windows.Forms.Button();
            this.postFeedTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.charCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(12, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(124, 29);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // postsLabel
            // 
            this.postsLabel.AutoSize = true;
            this.postsLabel.Location = new System.Drawing.Point(14, 56);
            this.postsLabel.Name = "postsLabel";
            this.postsLabel.Size = new System.Drawing.Size(71, 13);
            this.postsLabel.TabIndex = 1;
            this.postsLabel.Text = "Recent Posts";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(258, 239);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // postTextBox
            // 
            this.postTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postTextBox.Location = new System.Drawing.Point(163, 284);
            this.postTextBox.MaxLength = 275;
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.postTextBox.Size = new System.Drawing.Size(187, 60);
            this.postTextBox.TabIndex = 4;
            this.postTextBox.TextChanged += new System.EventHandler(this.postTextBox_TextChanged);
            this.postTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.postTextBox_KeyDown);
            // 
            // postButton
            // 
            this.postButton.Enabled = false;
            this.postButton.Location = new System.Drawing.Point(258, 350);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(75, 23);
            this.postButton.TabIndex = 5;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // postFeedTextBox
            // 
            this.postFeedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postFeedTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.postFeedTextBox.Location = new System.Drawing.Point(17, 72);
            this.postFeedTextBox.MaxLength = 275;
            this.postFeedTextBox.Multiline = true;
            this.postFeedTextBox.Name = "postFeedTextBox";
            this.postFeedTextBox.ReadOnly = true;
            this.postFeedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.postFeedTextBox.Size = new System.Drawing.Size(333, 161);
            this.postFeedTextBox.TabIndex = 6;
            this.postFeedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.postFeedTextBox.Enter += new System.EventHandler(this.postFeedTextBox_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(293, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // charCountLabel
            // 
            this.charCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.charCountLabel.AutoSize = true;
            this.charCountLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.charCountLabel.Location = new System.Drawing.Point(160, 347);
            this.charCountLabel.Name = "charCountLabel";
            this.charCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.charCountLabel.Size = new System.Drawing.Size(36, 13);
            this.charCountLabel.TabIndex = 8;
            this.charCountLabel.Text = "0/170";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(360, 386);
            this.Controls.Add(this.charCountLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.postFeedTextBox);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.postsLabel);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Feed";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Shown += new System.EventHandler(this.Dashboard_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label postsLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.TextBox postFeedTextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label charCountLabel;
    }
}