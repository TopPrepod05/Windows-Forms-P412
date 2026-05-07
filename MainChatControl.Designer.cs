namespace WinForms02
{
    partial class MainChatControl
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
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            newChatButton = new Button();
            button2 = new Button();
            chatPanel = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            button3 = new Button();
            userText = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            sendMsgBox = new TextBox();
            sendButton = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            label3 = new Label();
            button5 = new Button();
            messagesPanel = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1037, 693);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 15, 70);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.MaximumSize = new Size(400, 0);
            panel1.MinimumSize = new Size(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 687);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(chatPanel, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(400, 687);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(newChatButton, 0, 1);
            tableLayoutPanel3.Controls.Add(button2, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(394, 293);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 74);
            label1.TabIndex = 0;
            label1.Text = "T";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // newChatButton
            // 
            newChatButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            newChatButton.BackColor = Color.FromArgb(102, 63, 228);
            tableLayoutPanel3.SetColumnSpan(newChatButton, 3);
            newChatButton.FlatAppearance.BorderSize = 0;
            newChatButton.FlatStyle = FlatStyle.Flat;
            newChatButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            newChatButton.ForeColor = Color.White;
            newChatButton.Location = new Point(20, 108);
            newChatButton.Margin = new Padding(20);
            newChatButton.Name = "newChatButton";
            newChatButton.Size = new Size(354, 40);
            newChatButton.TabIndex = 1;
            newChatButton.Text = "New Chat";
            newChatButton.UseVisualStyleBackColor = false;
            newChatButton.Click += newChatButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(62, 25, 179);
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
            button2.ForeColor = Color.White;
            button2.Location = new Point(323, 3);
            button2.Name = "button2";
            button2.Size = new Size(68, 68);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = false;
            // 
            // chatPanel
            // 
            chatPanel.AutoScroll = true;
            chatPanel.Dock = DockStyle.Fill;
            chatPanel.Location = new Point(3, 302);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new Size(394, 294);
            chatPanel.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button3, 0, 0);
            tableLayoutPanel4.Controls.Add(userText, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 602);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(394, 82);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(102, 63, 228);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point, 2);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 0;
            button3.Text = "Ы";
            button3.UseVisualStyleBackColor = false;
            // 
            // userText
            // 
            userText.AutoSize = true;
            userText.Dock = DockStyle.Fill;
            userText.Font = new Font("Segoe UI", 28F);
            userText.ForeColor = Color.White;
            userText.Location = new Point(200, 0);
            userText.Name = "userText";
            userText.Size = new Size(191, 82);
            userText.TabIndex = 1;
            userText.Text = "User";
            userText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel5.Controls.Add(messagesPanel, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(409, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(625, 687);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(sendMsgBox, 0, 0);
            tableLayoutPanel6.Controls.Add(sendButton, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 655);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(619, 29);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // sendMsgBox
            // 
            sendMsgBox.Dock = DockStyle.Fill;
            sendMsgBox.Location = new Point(15, 3);
            sendMsgBox.Margin = new Padding(15, 3, 15, 3);
            sendMsgBox.Name = "sendMsgBox";
            sendMsgBox.Size = new Size(560, 23);
            sendMsgBox.TabIndex = 0;
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.FromArgb(255, 238, 0);
            sendButton.Dock = DockStyle.Fill;
            sendButton.FlatAppearance.BorderSize = 0;
            sendButton.FlatStyle = FlatStyle.Flat;
            sendButton.Font = new Font("Segoe UI", 9F);
            sendButton.ForeColor = Color.Black;
            sendButton.Location = new Point(593, 3);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(23, 23);
            sendButton.TabIndex = 1;
            sendButton.Text = ">";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Click += sendButton_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.Controls.Add(label3, 0, 0);
            tableLayoutPanel7.Controls.Add(button5, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(619, 100);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 100);
            label3.TabIndex = 0;
            label3.Text = "Top GPT";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(222, 37, 37);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(541, 27);
            button5.Name = "button5";
            button5.Size = new Size(75, 45);
            button5.TabIndex = 1;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            // 
            // messagesPanel
            // 
            messagesPanel.Dock = DockStyle.Fill;
            messagesPanel.Location = new Point(3, 109);
            messagesPanel.Name = "messagesPanel";
            messagesPanel.Size = new Size(619, 540);
            messagesPanel.TabIndex = 2;
            // 
            // MainChatControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 9, 64);
            Controls.Add(tableLayoutPanel1);
            Name = "MainChatControl";
            Size = new Size(1037, 693);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Button newChatButton;
        private Button button2;
        private Panel chatPanel;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button3;
        private Label userText;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox sendMsgBox;
        private Button sendButton;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label3;
        private Button button5;
        private FlowLayoutPanel messagesPanel;
    }
}
