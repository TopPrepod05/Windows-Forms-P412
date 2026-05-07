namespace WinForms02
{
    partial class RegisterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            signupButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            showPassword = new CheckBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            signupLabel = new Label();
            loginLink = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Controls.Add(loginLink, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(6, 5, 6, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(965, 638);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(passwordLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(passwordTextBox, 1, 2);
            tableLayoutPanel2.Controls.Add(usernameLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(usernameTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(emailLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(emailTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(signupButton, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(327, 217);
            tableLayoutPanel2.Margin = new Padding(6, 5, 6, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(309, 202);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordLabel.ImageAlign = ContentAlignment.MiddleLeft;
            passwordLabel.Location = new Point(6, 100);
            passwordLabel.Margin = new Padding(6, 0, 6, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(142, 50);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(160, 113);
            passwordTextBox.Margin = new Padding(6, 5, 6, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(143, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            usernameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            usernameLabel.Location = new Point(6, 50);
            usernameLabel.Margin = new Padding(6, 0, 6, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(142, 50);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username:";
            usernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            usernameTextBox.Location = new Point(160, 63);
            usernameTextBox.Margin = new Padding(6, 5, 6, 5);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(143, 23);
            usernameTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailLabel.ImageAlign = ContentAlignment.MiddleLeft;
            emailLabel.Location = new Point(6, 0);
            emailLabel.Margin = new Padding(6, 0, 6, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(142, 50);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(160, 13);
            emailTextBox.Margin = new Padding(6, 5, 6, 5);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(143, 23);
            emailTextBox.TabIndex = 1;
            // 
            // signupButton
            // 
            tableLayoutPanel2.SetColumnSpan(signupButton, 2);
            signupButton.Dock = DockStyle.Fill;
            signupButton.Location = new Point(3, 153);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(303, 46);
            signupButton.TabIndex = 6;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(showPassword, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Left;
            tableLayoutPanel3.Location = new Point(645, 215);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(111, 206);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // showPassword
            // 
            showPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showPassword.AutoSize = true;
            showPassword.FlatStyle = FlatStyle.Flat;
            showPassword.Location = new Point(3, 105);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(105, 45);
            showPassword.TabIndex = 0;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(signupLabel, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(324, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(315, 206);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // signupLabel
            // 
            signupLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupLabel.AutoSize = true;
            signupLabel.Font = new Font("Corbel", 38F, FontStyle.Bold, GraphicsUnit.Point, 204);
            signupLabel.ForeColor = Color.FromArgb(64, 0, 0);
            signupLabel.Location = new Point(3, 68);
            signupLabel.Name = "signupLabel";
            signupLabel.Size = new Size(309, 68);
            signupLabel.TabIndex = 0;
            signupLabel.Text = "Sign Up";
            signupLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginLink
            // 
            loginLink.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginLink.AutoSize = true;
            loginLink.Location = new Point(324, 424);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(315, 15);
            loginLink.TabIndex = 3;
            loginLink.TabStop = true;
            loginLink.Text = "Already have account? Login";
            loginLink.TextAlign = ContentAlignment.TopCenter;
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // RegisterControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "RegisterControl";
            Size = new Size(965, 638);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Button signupButton;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckBox showPassword;
        private TableLayoutPanel tableLayoutPanel4;
        private Label signupLabel;
        private LinkLabel loginLink;
    }
}
