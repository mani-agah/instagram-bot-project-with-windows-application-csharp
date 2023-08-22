namespace WindowsFormsApp10
{
    partial class Form1
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLgoin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbCmd = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.GbProfile = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GbFollowers = new System.Windows.Forms.GroupBox();
            this.btnFOllowers = new System.Windows.Forms.Button();
            this.dgvFollowers = new System.Windows.Forms.DataGridView();
            this.FollowUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFollower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbFollowing = new System.Windows.Forms.GroupBox();
            this.btnFollowing = new System.Windows.Forms.Button();
            this.dgvFollowing = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbTools = new System.Windows.Forms.GroupBox();
            this.btnUblock = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnUnfllow = new System.Windows.Forms.Button();
            this.btnFollow = new System.Windows.Forms.Button();
            this.txtUserNameForFollow = new System.Windows.Forms.TextBox();
            this.GbBlocked = new System.Windows.Forms.GroupBox();
            this.btnBlocked = new System.Windows.Forms.Button();
            this.dgvBlocked = new System.Windows.Forms.DataGridView();
            this.UserNameBlocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBlocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbDirect = new System.Windows.Forms.GroupBox();
            this.btnSendVideo = new System.Windows.Forms.Button();
            this.txtSendImage = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtUserNameDirect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResentEvents = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.GbCmd.SuspendLayout();
            this.GbProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GbFollowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowers)).BeginInit();
            this.GbFollowing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowing)).BeginInit();
            this.GbTools.SuspendLayout();
            this.GbBlocked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocked)).BeginInit();
            this.GbDirect.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnLgoin);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.txtUserName);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Location = new System.Drawing.Point(12, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(347, 195);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // btnLgoin
            // 
            this.btnLgoin.Location = new System.Drawing.Point(9, 166);
            this.btnLgoin.Name = "btnLgoin";
            this.btnLgoin.Size = new System.Drawing.Size(332, 23);
            this.btnLgoin.TabIndex = 4;
            this.btnLgoin.Text = "Login";
            this.btnLgoin.UseVisualStyleBackColor = true;
            this.btnLgoin.Click += new System.EventHandler(this.btnLgoin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(68, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(273, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(115, 42);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(226, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name or Email:";
            // 
            // GbCmd
            // 
            this.GbCmd.Controls.Add(this.btnResentEvents);
            this.GbCmd.Controls.Add(this.button2);
            this.GbCmd.Controls.Add(this.btnEditProfile);
            this.GbCmd.Location = new System.Drawing.Point(631, 12);
            this.GbCmd.Name = "GbCmd";
            this.GbCmd.Size = new System.Drawing.Size(334, 195);
            this.GbCmd.TabIndex = 1;
            this.GbCmd.TabStop = false;
            this.GbCmd.Text = "Command";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(322, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit Profile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(519, 166);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(75, 23);
            this.btnEditProfile.TabIndex = 0;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            // 
            // GbProfile
            // 
            this.GbProfile.Controls.Add(this.btnAdd);
            this.GbProfile.Controls.Add(this.btnDelete);
            this.GbProfile.Controls.Add(this.pictureBox1);
            this.GbProfile.Location = new System.Drawing.Point(971, 12);
            this.GbProfile.Name = "GbProfile";
            this.GbProfile.Size = new System.Drawing.Size(243, 195);
            this.GbProfile.TabIndex = 2;
            this.GbProfile.TabStop = false;
            this.GbProfile.Text = "Profie Picture";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(81, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(162, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GbFollowers
            // 
            this.GbFollowers.Controls.Add(this.btnFOllowers);
            this.GbFollowers.Controls.Add(this.dgvFollowers);
            this.GbFollowers.Location = new System.Drawing.Point(12, 213);
            this.GbFollowers.Name = "GbFollowers";
            this.GbFollowers.Size = new System.Drawing.Size(253, 478);
            this.GbFollowers.TabIndex = 3;
            this.GbFollowers.TabStop = false;
            this.GbFollowers.Text = "Followers";
            // 
            // btnFOllowers
            // 
            this.btnFOllowers.Location = new System.Drawing.Point(6, 449);
            this.btnFOllowers.Name = "btnFOllowers";
            this.btnFOllowers.Size = new System.Drawing.Size(240, 23);
            this.btnFOllowers.TabIndex = 5;
            this.btnFOllowers.Text = "Show Followers";
            this.btnFOllowers.UseVisualStyleBackColor = true;
            this.btnFOllowers.Click += new System.EventHandler(this.btnFOllowers_Click);
            // 
            // dgvFollowers
            // 
            this.dgvFollowers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFollowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FollowUserName,
            this.nameFollower});
            this.dgvFollowers.Location = new System.Drawing.Point(6, 19);
            this.dgvFollowers.Name = "dgvFollowers";
            this.dgvFollowers.Size = new System.Drawing.Size(240, 424);
            this.dgvFollowers.TabIndex = 0;
            // 
            // FollowUserName
            // 
            this.FollowUserName.HeaderText = "UserName";
            this.FollowUserName.Name = "FollowUserName";
            // 
            // nameFollower
            // 
            this.nameFollower.HeaderText = "Name";
            this.nameFollower.Name = "nameFollower";
            // 
            // GbFollowing
            // 
            this.GbFollowing.Controls.Add(this.btnFollowing);
            this.GbFollowing.Controls.Add(this.dgvFollowing);
            this.GbFollowing.Location = new System.Drawing.Point(283, 213);
            this.GbFollowing.Name = "GbFollowing";
            this.GbFollowing.Size = new System.Drawing.Size(253, 478);
            this.GbFollowing.TabIndex = 6;
            this.GbFollowing.TabStop = false;
            this.GbFollowing.Text = "Following";
            // 
            // btnFollowing
            // 
            this.btnFollowing.Location = new System.Drawing.Point(6, 449);
            this.btnFollowing.Name = "btnFollowing";
            this.btnFollowing.Size = new System.Drawing.Size(240, 23);
            this.btnFollowing.TabIndex = 5;
            this.btnFollowing.Text = "Show Following";
            this.btnFollowing.UseVisualStyleBackColor = true;
            this.btnFollowing.Click += new System.EventHandler(this.btnFollowing_Click_1);
            // 
            // dgvFollowing
            // 
            this.dgvFollowing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFollowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Name});
            this.dgvFollowing.Location = new System.Drawing.Point(6, 19);
            this.dgvFollowing.Name = "dgvFollowing";
            this.dgvFollowing.Size = new System.Drawing.Size(240, 424);
            this.dgvFollowing.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // GbTools
            // 
            this.GbTools.Controls.Add(this.btnUblock);
            this.GbTools.Controls.Add(this.btnBlock);
            this.GbTools.Controls.Add(this.btnUnfllow);
            this.GbTools.Controls.Add(this.btnFollow);
            this.GbTools.Controls.Add(this.txtUserNameForFollow);
            this.GbTools.Location = new System.Drawing.Point(365, 12);
            this.GbTools.Name = "GbTools";
            this.GbTools.Size = new System.Drawing.Size(260, 195);
            this.GbTools.TabIndex = 7;
            this.GbTools.TabStop = false;
            this.GbTools.Text = "Tools";
            // 
            // btnUblock
            // 
            this.btnUblock.Location = new System.Drawing.Point(16, 79);
            this.btnUblock.Name = "btnUblock";
            this.btnUblock.Size = new System.Drawing.Size(215, 23);
            this.btnUblock.TabIndex = 4;
            this.btnUblock.Text = "UnBlock";
            this.btnUblock.UseVisualStyleBackColor = true;
            this.btnUblock.Click += new System.EventHandler(this.btnUblock_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(16, 108);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(215, 23);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnUnfllow
            // 
            this.btnUnfllow.Location = new System.Drawing.Point(16, 166);
            this.btnUnfllow.Name = "btnUnfllow";
            this.btnUnfllow.Size = new System.Drawing.Size(215, 23);
            this.btnUnfllow.TabIndex = 2;
            this.btnUnfllow.Text = "UnFollow";
            this.btnUnfllow.UseVisualStyleBackColor = true;
            this.btnUnfllow.Click += new System.EventHandler(this.btnUnfllow_Click);
            // 
            // btnFollow
            // 
            this.btnFollow.Location = new System.Drawing.Point(16, 137);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(215, 23);
            this.btnFollow.TabIndex = 1;
            this.btnFollow.Text = "Follow";
            this.btnFollow.UseVisualStyleBackColor = true;
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
            // 
            // txtUserNameForFollow
            // 
            this.txtUserNameForFollow.Location = new System.Drawing.Point(16, 20);
            this.txtUserNameForFollow.Multiline = true;
            this.txtUserNameForFollow.Name = "txtUserNameForFollow";
            this.txtUserNameForFollow.Size = new System.Drawing.Size(215, 42);
            this.txtUserNameForFollow.TabIndex = 0;
            this.txtUserNameForFollow.TextChanged += new System.EventHandler(this.txtUserNameForFollow_TextChanged);
            // 
            // GbBlocked
            // 
            this.GbBlocked.Controls.Add(this.btnBlocked);
            this.GbBlocked.Controls.Add(this.dgvBlocked);
            this.GbBlocked.Location = new System.Drawing.Point(542, 213);
            this.GbBlocked.Name = "GbBlocked";
            this.GbBlocked.Size = new System.Drawing.Size(253, 478);
            this.GbBlocked.TabIndex = 7;
            this.GbBlocked.TabStop = false;
            this.GbBlocked.Text = "Blocked User";
            // 
            // btnBlocked
            // 
            this.btnBlocked.Location = new System.Drawing.Point(6, 449);
            this.btnBlocked.Name = "btnBlocked";
            this.btnBlocked.Size = new System.Drawing.Size(240, 23);
            this.btnBlocked.TabIndex = 5;
            this.btnBlocked.Text = "Show Blocked";
            this.btnBlocked.UseVisualStyleBackColor = true;
            // 
            // dgvBlocked
            // 
            this.dgvBlocked.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBlocked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlocked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNameBlocked,
            this.NameBlocked});
            this.dgvBlocked.Location = new System.Drawing.Point(6, 19);
            this.dgvBlocked.Name = "dgvBlocked";
            this.dgvBlocked.Size = new System.Drawing.Size(240, 424);
            this.dgvBlocked.TabIndex = 0;
            this.dgvBlocked.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBlocked_CellContentClick);
            // 
            // UserNameBlocked
            // 
            this.UserNameBlocked.HeaderText = "UserName";
            this.UserNameBlocked.Name = "UserNameBlocked";
            // 
            // NameBlocked
            // 
            this.NameBlocked.HeaderText = "Name";
            this.NameBlocked.Name = "NameBlocked";
            // 
            // GbDirect
            // 
            this.GbDirect.Controls.Add(this.btnSendVideo);
            this.GbDirect.Controls.Add(this.txtSendImage);
            this.GbDirect.Controls.Add(this.btnSend);
            this.GbDirect.Controls.Add(this.txtMessage);
            this.GbDirect.Controls.Add(this.txtUserNameDirect);
            this.GbDirect.Controls.Add(this.label3);
            this.GbDirect.Location = new System.Drawing.Point(801, 213);
            this.GbDirect.Name = "GbDirect";
            this.GbDirect.Size = new System.Drawing.Size(407, 478);
            this.GbDirect.TabIndex = 8;
            this.GbDirect.TabStop = false;
            this.GbDirect.Text = "Direct";
            // 
            // btnSendVideo
            // 
            this.btnSendVideo.Location = new System.Drawing.Point(251, 420);
            this.btnSendVideo.Name = "btnSendVideo";
            this.btnSendVideo.Size = new System.Drawing.Size(103, 23);
            this.btnSendVideo.TabIndex = 5;
            this.btnSendVideo.Text = "Send Video";
            this.btnSendVideo.UseVisualStyleBackColor = true;
            this.btnSendVideo.Click += new System.EventHandler(this.btnSendVideo_Click);
            // 
            // txtSendImage
            // 
            this.txtSendImage.Location = new System.Drawing.Point(129, 420);
            this.txtSendImage.Name = "txtSendImage";
            this.txtSendImage.Size = new System.Drawing.Size(103, 23);
            this.txtSendImage.TabIndex = 4;
            this.txtSendImage.Text = "Send Image";
            this.txtSendImage.UseVisualStyleBackColor = true;
            this.txtSendImage.Click += new System.EventHandler(this.txtSendImage_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(9, 420);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(103, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(9, 72);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(392, 332);
            this.txtMessage.TabIndex = 2;
            // 
            // txtUserNameDirect
            // 
            this.txtUserNameDirect.Location = new System.Drawing.Point(72, 31);
            this.txtUserNameDirect.Name = "txtUserNameDirect";
            this.txtUserNameDirect.Size = new System.Drawing.Size(329, 20);
            this.txtUserNameDirect.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "UserName:";
            // 
            // btnResentEvents
            // 
            this.btnResentEvents.Location = new System.Drawing.Point(6, 47);
            this.btnResentEvents.Name = "btnResentEvents";
            this.btnResentEvents.Size = new System.Drawing.Size(322, 23);
            this.btnResentEvents.TabIndex = 2;
            this.btnResentEvents.Text = "Recent Events";
            this.btnResentEvents.UseVisualStyleBackColor = true;
            this.btnResentEvents.Click += new System.EventHandler(this.btnResentEvents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 703);
            this.Controls.Add(this.GbDirect);
            this.Controls.Add(this.GbBlocked);
            this.Controls.Add(this.GbTools);
            this.Controls.Add(this.GbFollowing);
            this.Controls.Add(this.GbFollowers);
            this.Controls.Add(this.GbProfile);
            this.Controls.Add(this.GbCmd);
            this.Controls.Add(this.gbLogin);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.GbCmd.ResumeLayout(false);
            this.GbProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GbFollowers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowers)).EndInit();
            this.GbFollowing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowing)).EndInit();
            this.GbTools.ResumeLayout(false);
            this.GbTools.PerformLayout();
            this.GbBlocked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocked)).EndInit();
            this.GbDirect.ResumeLayout(false);
            this.GbDirect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnLgoin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbCmd;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.GroupBox GbProfile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GbFollowers;
        private System.Windows.Forms.Button btnFOllowers;
        private System.Windows.Forms.DataGridView dgvFollowers;
        private System.Windows.Forms.GroupBox GbFollowing;
        private System.Windows.Forms.Button btnFollowing;
        private System.Windows.Forms.DataGridView dgvFollowing;
        private System.Windows.Forms.GroupBox GbTools;
        private System.Windows.Forms.Button btnUnfllow;
        private System.Windows.Forms.Button btnFollow;
        private System.Windows.Forms.TextBox txtUserNameForFollow;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.DataGridViewTextBoxColumn FollowUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFollower;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.GroupBox GbBlocked;
        private System.Windows.Forms.Button btnBlocked;
        private System.Windows.Forms.DataGridView dgvBlocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameBlocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBlocked;
        private System.Windows.Forms.Button btnUblock;
        private System.Windows.Forms.GroupBox GbDirect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtUserNameDirect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtSendImage;
        private System.Windows.Forms.Button btnSendVideo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnResentEvents;
    }
}

