namespace WinForms02
{
    partial class LoginControl
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
            emailLabel = new Label();
            emailTextBox = new TextBox();
            signinButton = new Button();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            showPassword = new CheckBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            signinLabel = new Label();
            registerLink = new LinkLabel();
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
            tableLayoutPanel1.Controls.Add(registerLink, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(6, 5, 6, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1060, 638);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(emailLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(emailTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(signinButton, 0, 3);
            tableLayoutPanel2.Controls.Add(passwordTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(passwordLabel, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(359, 217);
            tableLayoutPanel2.Margin = new Padding(6, 5, 6, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(341, 202);
            tableLayoutPanel2.TabIndex = 0;
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
            emailLabel.Size = new Size(158, 50);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(176, 13);
            emailTextBox.Margin = new Padding(6, 5, 6, 5);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(159, 23);
            emailTextBox.TabIndex = 1;
            // 
            // signinButton
            // 
            tableLayoutPanel2.SetColumnSpan(signinButton, 2);
            signinButton.Dock = DockStyle.Fill;
            signinButton.Location = new Point(3, 153);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(335, 46);
            signinButton.TabIndex = 6;
            signinButton.Text = "Sign In";
            signinButton.UseVisualStyleBackColor = true;
            signinButton.Click += signinButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(176, 63);
            passwordTextBox.Margin = new Padding(6, 5, 6, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(159, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordLabel.ImageAlign = ContentAlignment.MiddleLeft;
            passwordLabel.Location = new Point(6, 50);
            passwordLabel.Margin = new Padding(6, 0, 6, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(158, 50);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(showPassword, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Left;
            tableLayoutPanel3.Location = new Point(709, 215);
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
            showPassword.Location = new Point(3, 54);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(105, 45);
            showPassword.TabIndex = 0;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(signinLabel, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(356, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(347, 206);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // signinLabel
            // 
            signinLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signinLabel.AutoSize = true;
            signinLabel.Font = new Font("Corbel", 38F, FontStyle.Bold, GraphicsUnit.Point, 204);
            signinLabel.ForeColor = Color.FromArgb(64, 0, 0);
            signinLabel.Location = new Point(3, 68);
            signinLabel.Name = "signinLabel";
            signinLabel.Size = new Size(341, 68);
            signinLabel.TabIndex = 0;
            signinLabel.Text = "Sign In";
            signinLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerLink
            // 
            registerLink.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            registerLink.AutoSize = true;
            registerLink.Location = new Point(356, 424);
            registerLink.Name = "registerLink";
            registerLink.Size = new Size(347, 15);
            registerLink.TabIndex = 3;
            registerLink.TabStop = true;
            registerLink.Text = "Don't have account? Register";
            registerLink.TextAlign = ContentAlignment.TopCenter;
            registerLink.LinkClicked += registerLink_LinkClicked;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "LoginControl";
            Size = new Size(1060, 638);
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
        private Label emailLabel;
        private TextBox emailTextBox;
        private Button signinButton;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckBox showPassword;
        private TableLayoutPanel tableLayoutPanel4;
        private Label signinLabel;
        private LinkLabel registerLink;
    }
}
