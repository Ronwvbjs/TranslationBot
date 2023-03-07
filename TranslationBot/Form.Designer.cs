namespace TranslationBot
{
    partial class Form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.toLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subscriptionKeyLabel = new System.Windows.Forms.Label();
            this.subscriptionKeyTextBox = new System.Windows.Forms.TextBox();
            this.showSubscriptionKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botUserNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botTokenTextBox = new System.Windows.Forms.TextBox();
            this.twitchGroupBox = new System.Windows.Forms.GroupBox();
            this.showBotTokenCheckBox = new System.Windows.Forms.CheckBox();
            this.channelNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.modelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.startButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translationGroupBox = new System.Windows.Forms.GroupBox();
            this.commandNameTextBox = new System.Windows.Forms.TextBox();
            this.commandNameLabel = new System.Windows.Forms.Label();
            this.forceTranslationCheckBox = new System.Windows.Forms.CheckBox();
            this.endTagPatternLabel = new System.Windows.Forms.Label();
            this.beginTagPatternTextBox = new System.Windows.Forms.TextBox();
            this.endTagPatternTextBox = new System.Windows.Forms.TextBox();
            this.beginTagPatternLabel = new System.Windows.Forms.Label();
            this.twitchGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.translationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toLanguageComboBox
            // 
            this.toLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toLanguageComboBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toLanguageComboBox.FormattingEnabled = true;
            this.toLanguageComboBox.Location = new System.Drawing.Point(116, 80);
            this.toLanguageComboBox.Name = "toLanguageComboBox";
            this.toLanguageComboBox.Size = new System.Drawing.Size(121, 23);
            this.toLanguageComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "To-Language:";
            // 
            // subscriptionKeyLabel
            // 
            this.subscriptionKeyLabel.AutoSize = true;
            this.subscriptionKeyLabel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.subscriptionKeyLabel.Location = new System.Drawing.Point(6, 24);
            this.subscriptionKeyLabel.Name = "subscriptionKeyLabel";
            this.subscriptionKeyLabel.Size = new System.Drawing.Size(110, 15);
            this.subscriptionKeyLabel.TabIndex = 4;
            this.subscriptionKeyLabel.Text = "Subscription-Key:";
            // 
            // subscriptionKeyTextBox
            // 
            this.subscriptionKeyTextBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.subscriptionKeyTextBox.Location = new System.Drawing.Point(116, 21);
            this.subscriptionKeyTextBox.Name = "subscriptionKeyTextBox";
            this.subscriptionKeyTextBox.Size = new System.Drawing.Size(225, 23);
            this.subscriptionKeyTextBox.TabIndex = 5;
            this.subscriptionKeyTextBox.UseSystemPasswordChar = true;
            // 
            // showSubscriptionKeyCheckBox
            // 
            this.showSubscriptionKeyCheckBox.AutoSize = true;
            this.showSubscriptionKeyCheckBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.showSubscriptionKeyCheckBox.Location = new System.Drawing.Point(116, 50);
            this.showSubscriptionKeyCheckBox.Name = "showSubscriptionKeyCheckBox";
            this.showSubscriptionKeyCheckBox.Size = new System.Drawing.Size(160, 19);
            this.showSubscriptionKeyCheckBox.TabIndex = 6;
            this.showSubscriptionKeyCheckBox.Text = "Show Subscription-Key";
            this.showSubscriptionKeyCheckBox.UseVisualStyleBackColor = true;
            this.showSubscriptionKeyCheckBox.CheckedChanged += new System.EventHandler(this.ShowSubscriptionKeyCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bot-User-Name:";
            // 
            // botUserNameTextBox
            // 
            this.botUserNameTextBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.botUserNameTextBox.Location = new System.Drawing.Point(116, 22);
            this.botUserNameTextBox.Name = "botUserNameTextBox";
            this.botUserNameTextBox.Size = new System.Drawing.Size(140, 23);
            this.botUserNameTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bot-Token:";
            // 
            // botTokenTextBox
            // 
            this.botTokenTextBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.botTokenTextBox.Location = new System.Drawing.Point(116, 51);
            this.botTokenTextBox.Name = "botTokenTextBox";
            this.botTokenTextBox.Size = new System.Drawing.Size(190, 23);
            this.botTokenTextBox.TabIndex = 10;
            this.botTokenTextBox.UseSystemPasswordChar = true;
            // 
            // twitchGroupBox
            // 
            this.twitchGroupBox.Controls.Add(this.showBotTokenCheckBox);
            this.twitchGroupBox.Controls.Add(this.channelNameTextBox);
            this.twitchGroupBox.Controls.Add(this.label5);
            this.twitchGroupBox.Controls.Add(this.label4);
            this.twitchGroupBox.Controls.Add(this.botUserNameTextBox);
            this.twitchGroupBox.Controls.Add(this.botTokenTextBox);
            this.twitchGroupBox.Controls.Add(this.label2);
            this.twitchGroupBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.twitchGroupBox.Location = new System.Drawing.Point(12, 165);
            this.twitchGroupBox.Name = "twitchGroupBox";
            this.twitchGroupBox.Size = new System.Drawing.Size(360, 144);
            this.twitchGroupBox.TabIndex = 11;
            this.twitchGroupBox.TabStop = false;
            this.twitchGroupBox.Text = "Twitch";
            // 
            // showBotTokenCheckBox
            // 
            this.showBotTokenCheckBox.AutoSize = true;
            this.showBotTokenCheckBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.showBotTokenCheckBox.Location = new System.Drawing.Point(116, 80);
            this.showBotTokenCheckBox.Name = "showBotTokenCheckBox";
            this.showBotTokenCheckBox.Size = new System.Drawing.Size(121, 19);
            this.showBotTokenCheckBox.TabIndex = 7;
            this.showBotTokenCheckBox.Text = "Show Bot-Token";
            this.showBotTokenCheckBox.UseVisualStyleBackColor = true;
            this.showBotTokenCheckBox.CheckedChanged += new System.EventHandler(this.ShowBotTokenCheckBox_CheckedChanged);
            // 
            // channelNameTextBox
            // 
            this.channelNameTextBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.channelNameTextBox.Location = new System.Drawing.Point(116, 110);
            this.channelNameTextBox.Name = "channelNameTextBox";
            this.channelNameTextBox.Size = new System.Drawing.Size(140, 23);
            this.channelNameTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Channel-Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.modelTypeComboBox);
            this.groupBox2.Controls.Add(this.subscriptionKeyLabel);
            this.groupBox2.Controls.Add(this.subscriptionKeyTextBox);
            this.groupBox2.Controls.Add(this.showSubscriptionKeyCheckBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.toLanguageComboBox);
            this.groupBox2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 147);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Microsoft Translator Text API";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Model-Type:";
            // 
            // modelTypeComboBox
            // 
            this.modelTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelTypeComboBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.modelTypeComboBox.FormattingEnabled = true;
            this.modelTypeComboBox.Items.AddRange(new object[] {
            "Statistical Base Machine Translation",
            "Neural Machine Translation"});
            this.modelTypeComboBox.Location = new System.Drawing.Point(116, 109);
            this.modelTypeComboBox.Name = "modelTypeComboBox";
            this.modelTypeComboBox.Size = new System.Drawing.Size(235, 23);
            this.modelTypeComboBox.TabIndex = 7;
            this.modelTypeComboBox.SelectedValueChanged += new System.EventHandler(this.ModelTypeComboBox_SelectedValueChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "chat_history.txt";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(297, 456);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "TranslationBot";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(104, 54);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // translationGroupBox
            // 
            this.translationGroupBox.Controls.Add(this.commandNameTextBox);
            this.translationGroupBox.Controls.Add(this.commandNameLabel);
            this.translationGroupBox.Controls.Add(this.forceTranslationCheckBox);
            this.translationGroupBox.Controls.Add(this.endTagPatternLabel);
            this.translationGroupBox.Controls.Add(this.beginTagPatternTextBox);
            this.translationGroupBox.Controls.Add(this.endTagPatternTextBox);
            this.translationGroupBox.Controls.Add(this.beginTagPatternLabel);
            this.translationGroupBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.translationGroupBox.Location = new System.Drawing.Point(12, 315);
            this.translationGroupBox.Name = "translationGroupBox";
            this.translationGroupBox.Size = new System.Drawing.Size(360, 135);
            this.translationGroupBox.TabIndex = 13;
            this.translationGroupBox.TabStop = false;
            this.translationGroupBox.Text = "Translation";
            // 
            // commandNameTextBox
            // 
            this.commandNameTextBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.commandNameTextBox.Location = new System.Drawing.Point(129, 22);
            this.commandNameTextBox.Name = "commandNameTextBox";
            this.commandNameTextBox.Size = new System.Drawing.Size(140, 23);
            this.commandNameTextBox.TabIndex = 14;
            this.commandNameTextBox.TextChanged += new System.EventHandler(this.InputCommandNameTextBox_TextChanged);
            // 
            // commandNameLabel
            // 
            this.commandNameLabel.AutoSize = true;
            this.commandNameLabel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.commandNameLabel.Location = new System.Drawing.Point(6, 25);
            this.commandNameLabel.Name = "commandNameLabel";
            this.commandNameLabel.Size = new System.Drawing.Size(112, 15);
            this.commandNameLabel.TabIndex = 13;
            this.commandNameLabel.Text = "Command-Name:";
            // 
            // forceTranslationCheckBox
            // 
            this.forceTranslationCheckBox.AutoSize = true;
            this.forceTranslationCheckBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.forceTranslationCheckBox.Location = new System.Drawing.Point(129, 109);
            this.forceTranslationCheckBox.Name = "forceTranslationCheckBox";
            this.forceTranslationCheckBox.Size = new System.Drawing.Size(126, 19);
            this.forceTranslationCheckBox.TabIndex = 7;
            this.forceTranslationCheckBox.Text = "Force Translation";
            this.forceTranslationCheckBox.UseVisualStyleBackColor = true;
            this.forceTranslationCheckBox.CheckedChanged += new System.EventHandler(this.ForceTranslationCheckBox_CheckedChanged);
            // 
            // endTagPatternLabel
            // 
            this.endTagPatternLabel.AutoSize = true;
            this.endTagPatternLabel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.endTagPatternLabel.Location = new System.Drawing.Point(6, 83);
            this.endTagPatternLabel.Name = "endTagPatternLabel";
            this.endTagPatternLabel.Size = new System.Drawing.Size(106, 15);
            this.endTagPatternLabel.TabIndex = 9;
            this.endTagPatternLabel.Text = "End-Tag-Pattern:";
            // 
            // beginTagPatternTextBox
            // 
            this.beginTagPatternTextBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.beginTagPatternTextBox.Location = new System.Drawing.Point(129, 51);
            this.beginTagPatternTextBox.Name = "beginTagPatternTextBox";
            this.beginTagPatternTextBox.Size = new System.Drawing.Size(140, 23);
            this.beginTagPatternTextBox.TabIndex = 8;
            this.beginTagPatternTextBox.TextChanged += new System.EventHandler(this.BeginTagPatternTextBox_TextChanged);
            // 
            // endTagPatternTextBox
            // 
            this.endTagPatternTextBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.endTagPatternTextBox.Location = new System.Drawing.Point(129, 80);
            this.endTagPatternTextBox.Name = "endTagPatternTextBox";
            this.endTagPatternTextBox.Size = new System.Drawing.Size(140, 23);
            this.endTagPatternTextBox.TabIndex = 10;
            this.endTagPatternTextBox.TextChanged += new System.EventHandler(this.EndTagPatternTextBox_TextChanged);
            // 
            // beginTagPatternLabel
            // 
            this.beginTagPatternLabel.AutoSize = true;
            this.beginTagPatternLabel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.beginTagPatternLabel.Location = new System.Drawing.Point(6, 54);
            this.beginTagPatternLabel.Name = "beginTagPatternLabel";
            this.beginTagPatternLabel.Size = new System.Drawing.Size(117, 15);
            this.beginTagPatternLabel.TabIndex = 7;
            this.beginTagPatternLabel.Text = "Begin-Tag-Pattern:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 486);
            this.Controls.Add(this.translationGroupBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.twitchGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "TranslationBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form_ClientSizeChanged);
            this.twitchGroupBox.ResumeLayout(false);
            this.twitchGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.translationGroupBox.ResumeLayout(false);
            this.translationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox toLanguageComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subscriptionKeyLabel;
        private System.Windows.Forms.TextBox subscriptionKeyTextBox;
        private System.Windows.Forms.CheckBox showSubscriptionKeyCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox botUserNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox botTokenTextBox;
        private System.Windows.Forms.GroupBox twitchGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox channelNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox showBotTokenCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox modelTypeComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox translationGroupBox;
        private System.Windows.Forms.CheckBox forceTranslationCheckBox;
        private System.Windows.Forms.Label endTagPatternLabel;
        private System.Windows.Forms.TextBox beginTagPatternTextBox;
        private System.Windows.Forms.TextBox endTagPatternTextBox;
        private System.Windows.Forms.Label beginTagPatternLabel;
        private System.Windows.Forms.TextBox commandNameTextBox;
        private System.Windows.Forms.Label commandNameLabel;
    }
}

