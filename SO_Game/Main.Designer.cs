namespace SO_Game
{
    partial class Main
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
            this.connect = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassword_TextBox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.signupbutton = new System.Windows.Forms.Button();
            this.PlayerGame = new System.Windows.Forms.RadioButton();
            this.winner = new System.Windows.Forms.RadioButton();
            this.gamesPlayed = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gameid = new System.Windows.Forms.TextBox();
            this.playerName = new System.Windows.Forms.TextBox();
            this.query = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label_users_connected = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(12, 3);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(125, 28);
            this.connect.TabIndex = 0;
            this.connect.Text = "CONNECT";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(12, 404);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(125, 34);
            this.disconnect.TabIndex = 1;
            this.disconnect.Text = "DISCONNECT";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOG IN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "SIGN UP";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(15, 127);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(149, 22);
            this.usernameText.TabIndex = 4;
            this.usernameText.Text = "Username";
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(18, 155);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(152, 22);
            this.passwordText.TabIndex = 5;
            this.passwordText.Text = "Password";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(192, 127);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(152, 22);
            this.email.TabIndex = 6;
            this.email.Text = "Email";
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(192, 155);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(152, 22);
            this.Username_TextBox.TabIndex = 7;
            this.Username_TextBox.Text = "Username";
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(192, 183);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(152, 22);
            this.password_TextBox.TabIndex = 8;
            this.password_TextBox.Text = "Password";
            // 
            // ConfirmPassword_TextBox
            // 
            this.ConfirmPassword_TextBox.Location = new System.Drawing.Point(192, 211);
            this.ConfirmPassword_TextBox.Name = "ConfirmPassword_TextBox";
            this.ConfirmPassword_TextBox.Size = new System.Drawing.Size(150, 22);
            this.ConfirmPassword_TextBox.TabIndex = 9;
            this.ConfirmPassword_TextBox.Text = "Confirm Password";
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(15, 254);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(111, 34);
            this.loginbutton.TabIndex = 10;
            this.loginbutton.Text = "Log In";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // signupbutton
            // 
            this.signupbutton.Location = new System.Drawing.Point(207, 254);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(94, 34);
            this.signupbutton.TabIndex = 11;
            this.signupbutton.Text = "Sign Up";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // PlayerGame
            // 
            this.PlayerGame.AutoSize = true;
            this.PlayerGame.Location = new System.Drawing.Point(368, 127);
            this.PlayerGame.Name = "PlayerGame";
            this.PlayerGame.Size = new System.Drawing.Size(158, 20);
            this.PlayerGame.TabIndex = 12;
            this.PlayerGame.TabStop = true;
            this.PlayerGame.Text = "Players in each game";
            this.PlayerGame.UseVisualStyleBackColor = true;
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.Location = new System.Drawing.Point(368, 157);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(294, 20);
            this.winner.TabIndex = 13;
            this.winner.TabStop = true;
            this.winner.Text = "Winner of a specific game (Provide game ID)";
            this.winner.UseVisualStyleBackColor = true;
            // 
            // gamesPlayed
            // 
            this.gamesPlayed.AutoSize = true;
            this.gamesPlayed.Location = new System.Drawing.Point(368, 185);
            this.gamesPlayed.Name = "gamesPlayed";
            this.gamesPlayed.Size = new System.Drawing.Size(189, 20);
            this.gamesPlayed.TabIndex = 14;
            this.gamesPlayed.TabStop = true;
            this.gamesPlayed.Text = "Games Played by a Player";
            this.gamesPlayed.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Queries:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gameid
            // 
            this.gameid.Location = new System.Drawing.Point(368, 211);
            this.gameid.Name = "gameid";
            this.gameid.Size = new System.Drawing.Size(158, 22);
            this.gameid.TabIndex = 16;
            this.gameid.Text = "Game ID";
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(368, 239);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(158, 22);
            this.playerName.TabIndex = 17;
            this.playerName.Text = "Player Name";
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(368, 276);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(103, 28);
            this.query.TabIndex = 18;
            this.query.Text = "Send request";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(779, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(284, 266);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Connected players";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 230;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(776, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Connected players:";
            // 
            // label_users_connected
            // 
            this.label_users_connected.AutoSize = true;
            this.label_users_connected.Location = new System.Drawing.Point(905, 32);
            this.label_users_connected.Name = "label_users_connected";
            this.label_users_connected.Size = new System.Drawing.Size(14, 16);
            this.label_users_connected.TabIndex = 21;
            this.label_users_connected.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(845, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Show Connected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1008, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "New Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_users_connected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.query);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.gameid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gamesPlayed);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.PlayerGame);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.ConfirmPassword_TextBox);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.Username_TextBox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.connect);
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.TextBox ConfirmPassword_TextBox;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.RadioButton PlayerGame;
        private System.Windows.Forms.RadioButton winner;
        private System.Windows.Forms.RadioButton gamesPlayed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gameid;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_users_connected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button2;
    }
}