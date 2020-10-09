namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.teamMembersLabel = new System.Windows.Forms.Label();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(874, 305);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(109, 77);
            this.deleteSelectedMemberButton.TabIndex = 31;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneValue);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.emailValue);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(21, 331);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(426, 328);
            this.addNewMemberGroupBox.TabIndex = 35;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createMemberButton.Location = new System.Drawing.Point(122, 262);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(182, 47);
            this.createMemberButton.TabIndex = 26;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cellphoneValue.Location = new System.Drawing.Point(151, 211);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(243, 35);
            this.cellphoneValue.TabIndex = 29;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameValue.Location = new System.Drawing.Point(151, 107);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(243, 35);
            this.lastNameValue.TabIndex = 28;
            // 
            // emailValue
            // 
            this.emailValue.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailValue.Location = new System.Drawing.Point(151, 159);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(243, 35);
            this.emailValue.TabIndex = 27;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cellphoneLabel.Location = new System.Drawing.Point(6, 212);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(116, 32);
            this.cellphoneLabel.TabIndex = 26;
            this.cellphoneLabel.Text = "Cellphone";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNameLabel.Location = new System.Drawing.Point(6, 108);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(122, 32);
            this.lastNameLabel.TabIndex = 24;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emailLabel.Location = new System.Drawing.Point(6, 160);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(69, 32);
            this.emailLabel.TabIndex = 22;
            this.emailLabel.Text = "Email";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameValue.Location = new System.Drawing.Point(151, 55);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(243, 35);
            this.firstNameValue.TabIndex = 21;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 56);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(123, 32);
            this.firstNameLabel.TabIndex = 17;
            this.firstNameLabel.Text = "First Name";
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeamButton.Location = new System.Drawing.Point(522, 593);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(327, 66);
            this.createTeamButton.TabIndex = 34;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addMemberButton.Location = new System.Drawing.Point(143, 265);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(182, 47);
            this.addMemberButton.TabIndex = 33;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(14, 169);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(257, 37);
            this.selectTeamMemberLabel.TabIndex = 32;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(21, 117);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(426, 35);
            this.teamNameValue.TabIndex = 30;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 30;
            this.teamMembersListBox.Location = new System.Drawing.Point(522, 117);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(327, 452);
            this.teamMembersListBox.TabIndex = 29;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(21, 209);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(426, 38);
            this.selectTeamMemberDropDown.TabIndex = 28;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamNameLabel.Location = new System.Drawing.Point(14, 77);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(155, 37);
            this.teamNameLabel.TabIndex = 27;
            this.teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeamLabel.Location = new System.Drawing.Point(12, 9);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(220, 50);
            this.createTeamLabel.TabIndex = 26;
            this.createTeamLabel.Text = "Create Team";
            // 
            // teamMembersLabel
            // 
            this.teamMembersLabel.AutoSize = true;
            this.teamMembersLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamMembersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamMembersLabel.Location = new System.Drawing.Point(515, 77);
            this.teamMembersLabel.Name = "teamMembersLabel";
            this.teamMembersLabel.Size = new System.Drawing.Size(193, 37);
            this.teamMembersLabel.TabIndex = 36;
            this.teamMembersLabel.Text = "Team Members";
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 720);
            this.Controls.Add(this.teamMembersLabel);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Label teamMembersLabel;
    }
}