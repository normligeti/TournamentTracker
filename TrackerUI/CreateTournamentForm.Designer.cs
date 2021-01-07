namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.removeSelectedPlayerButton = new System.Windows.Forms.Button();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.removeSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // removeSelectedPlayerButton
            // 
            this.removeSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeSelectedPlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeSelectedPlayerButton.Location = new System.Drawing.Point(874, 170);
            this.removeSelectedPlayerButton.Name = "removeSelectedPlayerButton";
            this.removeSelectedPlayerButton.Size = new System.Drawing.Size(109, 77);
            this.removeSelectedPlayerButton.TabIndex = 7;
            this.removeSelectedPlayerButton.Text = "Remove Selected";
            this.removeSelectedPlayerButton.UseVisualStyleBackColor = true;
            this.removeSelectedPlayerButton.Click += new System.EventHandler(this.removeSelectedPlayerButton_Click);
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(21, 117);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(426, 35);
            this.tournamentNameValue.TabIndex = 0;
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 30;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(522, 117);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(327, 182);
            this.tournamentTeamsListBox.TabIndex = 6;
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(21, 302);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(426, 38);
            this.selectTeamDropDown.TabIndex = 3;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentNameLabel.Location = new System.Drawing.Point(14, 77);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(229, 37);
            this.tournamentNameLabel.TabIndex = 16;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentLabel.Location = new System.Drawing.Point(12, 9);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(324, 50);
            this.createTournamentLabel.TabIndex = 14;
            this.createTournamentLabel.Text = "Create Tournament";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamLabel.Location = new System.Drawing.Point(14, 262);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(154, 37);
            this.selectTeamLabel.TabIndex = 22;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamButton.Location = new System.Drawing.Point(143, 358);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(182, 47);
            this.addTeamButton.TabIndex = 4;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(339, 593);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(327, 66);
            this.createTournamentButton.TabIndex = 10;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(143, 420);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(182, 47);
            this.createPrizeButton.TabIndex = 5;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.entryFeeLabel.Location = new System.Drawing.Point(12, 188);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(122, 37);
            this.entryFeeLabel.TabIndex = 26;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(140, 191);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(147, 35);
            this.entryFeeValue.TabIndex = 1;
            this.entryFeeValue.Text = "0";
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(515, 77);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(193, 37);
            this.tournamentPlayersLabel.TabIndex = 28;
            this.tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizesLabel.Location = new System.Drawing.Point(515, 328);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(84, 37);
            this.prizesLabel.TabIndex = 31;
            this.prizesLabel.Text = "Prizes";
            // 
            // removeSelectedPrizeButton
            // 
            this.removeSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeSelectedPrizeButton.Location = new System.Drawing.Point(874, 421);
            this.removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            this.removeSelectedPrizeButton.Size = new System.Drawing.Size(109, 77);
            this.removeSelectedPrizeButton.TabIndex = 9;
            this.removeSelectedPrizeButton.Text = "Remove Selected";
            this.removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            this.removeSelectedPrizeButton.Click += new System.EventHandler(this.removeSelectedPrizeButton_Click);
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 30;
            this.prizesListBox.Location = new System.Drawing.Point(522, 368);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(327, 182);
            this.prizesListBox.TabIndex = 8;
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(338, 268);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(109, 30);
            this.createNewTeamLink.TabIndex = 2;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLink_LinkClicked);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 720);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.removeSelectedPrizeButton);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.removeSelectedPlayerButton);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeSelectedPlayerButton;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.Button removeSelectedPrizeButton;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
    }
}