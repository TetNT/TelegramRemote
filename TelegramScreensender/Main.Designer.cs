
namespace TelegramRemote
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.logList = new System.Windows.Forms.ListBox();
            this.lbMessageInformation = new System.Windows.Forms.Label();
            this.tbScreenSavingPath = new System.Windows.Forms.TextBox();
            this.bSelectPath = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tbBotToken = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFullTextMessage = new System.Windows.Forms.TextBox();
            this.tlFullTextMessage = new System.Windows.Forms.Label();
            this.tlBotToken = new System.Windows.Forms.Label();
            this.tlScreenPath = new System.Windows.Forms.Label();
            this.bShowToken = new System.Windows.Forms.Button();
            this.bBotStart = new System.Windows.Forms.Button();
            this.bBotStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pixelObserverTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logList
            // 
            this.logList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.logList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logList.FormattingEnabled = true;
            this.logList.ItemHeight = 19;
            this.logList.Location = new System.Drawing.Point(16, 15);
            this.logList.Margin = new System.Windows.Forms.Padding(4);
            this.logList.Name = "logList";
            this.logList.Size = new System.Drawing.Size(817, 194);
            this.logList.TabIndex = 0;
            this.logList.Click += new System.EventHandler(this.logList_Click);
            // 
            // lbMessageInformation
            // 
            this.lbMessageInformation.AutoSize = true;
            this.lbMessageInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMessageInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbMessageInformation.Location = new System.Drawing.Point(4, 6);
            this.lbMessageInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMessageInformation.Name = "lbMessageInformation";
            this.lbMessageInformation.Size = new System.Drawing.Size(421, 17);
            this.lbMessageInformation.TabIndex = 2;
            this.lbMessageInformation.Text = "Здесь отображаются подробные данные о сообщении.";
            // 
            // tbScreenSavingPath
            // 
            this.tbScreenSavingPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbScreenSavingPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbScreenSavingPath.Location = new System.Drawing.Point(16, 460);
            this.tbScreenSavingPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbScreenSavingPath.Name = "tbScreenSavingPath";
            this.tbScreenSavingPath.Size = new System.Drawing.Size(261, 22);
            this.tbScreenSavingPath.TabIndex = 3;
            // 
            // bSelectPath
            // 
            this.bSelectPath.AutoSize = true;
            this.bSelectPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSelectPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bSelectPath.Location = new System.Drawing.Point(287, 458);
            this.bSelectPath.Margin = new System.Windows.Forms.Padding(4);
            this.bSelectPath.Name = "bSelectPath";
            this.bSelectPath.Size = new System.Drawing.Size(40, 31);
            this.bSelectPath.TabIndex = 4;
            this.bSelectPath.Text = "...";
            this.bSelectPath.UseVisualStyleBackColor = true;
            this.bSelectPath.Click += new System.EventHandler(this.bSelectPath_Click);
            // 
            // tbBotToken
            // 
            this.tbBotToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbBotToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbBotToken.Location = new System.Drawing.Point(16, 412);
            this.tbBotToken.Margin = new System.Windows.Forms.Padding(4);
            this.tbBotToken.Name = "tbBotToken";
            this.tbBotToken.PasswordChar = '•';
            this.tbBotToken.Size = new System.Drawing.Size(384, 22);
            this.tbBotToken.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(701, 388);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tbFullTextMessage
            // 
            this.tbFullTextMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tbFullTextMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFullTextMessage.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbFullTextMessage.Location = new System.Drawing.Point(459, 26);
            this.tbFullTextMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbFullTextMessage.Multiline = true;
            this.tbFullTextMessage.Name = "tbFullTextMessage";
            this.tbFullTextMessage.ReadOnly = true;
            this.tbFullTextMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFullTextMessage.Size = new System.Drawing.Size(349, 91);
            this.tbFullTextMessage.TabIndex = 7;
            // 
            // tlFullTextMessage
            // 
            this.tlFullTextMessage.AutoSize = true;
            this.tlFullTextMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlFullTextMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlFullTextMessage.Location = new System.Drawing.Point(455, 6);
            this.tlFullTextMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tlFullTextMessage.Name = "tlFullTextMessage";
            this.tlFullTextMessage.Size = new System.Drawing.Size(126, 17);
            this.tlFullTextMessage.TabIndex = 8;
            this.tlFullTextMessage.Text = "Дополнительно";
            // 
            // tlBotToken
            // 
            this.tlBotToken.AutoSize = true;
            this.tlBotToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlBotToken.Location = new System.Drawing.Point(16, 389);
            this.tlBotToken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tlBotToken.Name = "tlBotToken";
            this.tlBotToken.Size = new System.Drawing.Size(83, 17);
            this.tlBotToken.TabIndex = 9;
            this.tlBotToken.Text = "Токен бота";
            // 
            // tlScreenPath
            // 
            this.tlScreenPath.AutoSize = true;
            this.tlScreenPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlScreenPath.Location = new System.Drawing.Point(16, 441);
            this.tlScreenPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tlScreenPath.Name = "tlScreenPath";
            this.tlScreenPath.Size = new System.Drawing.Size(240, 17);
            this.tlScreenPath.TabIndex = 10;
            this.tlScreenPath.Text = "Адрес для сохранения скриншотов";
            // 
            // bShowToken
            // 
            this.bShowToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bShowToken.Location = new System.Drawing.Point(409, 410);
            this.bShowToken.Margin = new System.Windows.Forms.Padding(4);
            this.bShowToken.Name = "bShowToken";
            this.bShowToken.Size = new System.Drawing.Size(100, 28);
            this.bShowToken.TabIndex = 11;
            this.bShowToken.Tag = "hidden";
            this.bShowToken.Text = "Показать";
            this.bShowToken.UseVisualStyleBackColor = true;
            this.bShowToken.Click += new System.EventHandler(this.bShowToken_Click);
            // 
            // bBotStart
            // 
            this.bBotStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bBotStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBotStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bBotStart.Location = new System.Drawing.Point(16, 511);
            this.bBotStart.Margin = new System.Windows.Forms.Padding(4);
            this.bBotStart.Name = "bBotStart";
            this.bBotStart.Size = new System.Drawing.Size(153, 28);
            this.bBotStart.TabIndex = 12;
            this.bBotStart.Text = "Запустить бота";
            this.bBotStart.UseVisualStyleBackColor = false;
            this.bBotStart.Click += new System.EventHandler(this.bBotStart_Click);
            // 
            // bBotStop
            // 
            this.bBotStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBotStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bBotStop.Location = new System.Drawing.Point(677, 511);
            this.bBotStop.Margin = new System.Windows.Forms.Padding(4);
            this.bBotStop.Name = "bBotStop";
            this.bBotStop.Size = new System.Drawing.Size(157, 28);
            this.bBotStop.TabIndex = 13;
            this.bBotStop.Text = "Остановить бота";
            this.bBotStop.UseVisualStyleBackColor = true;
            this.bBotStop.Click += new System.EventHandler(this.bBotStop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbMessageInformation);
            this.panel1.Controls.Add(this.tlFullTextMessage);
            this.panel1.Controls.Add(this.tbFullTextMessage);
            this.panel1.Location = new System.Drawing.Point(16, 231);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 130);
            this.panel1.TabIndex = 14;
            // 
            // pixelObserverTimer
            // 
            this.pixelObserverTimer.Enabled = true;
            this.pixelObserverTimer.Interval = 1000;
            this.pixelObserverTimer.Tick += new System.EventHandler(this.pixelObserverTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(851, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bBotStop);
            this.Controls.Add(this.bBotStart);
            this.Controls.Add(this.bShowToken);
            this.Controls.Add(this.tlScreenPath);
            this.Controls.Add(this.tlBotToken);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbBotToken);
            this.Controls.Add(this.bSelectPath);
            this.Controls.Add(this.tbScreenSavingPath);
            this.Controls.Add(this.logList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Telegram Remote Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox logList;
        private System.Windows.Forms.Label lbMessageInformation;
        private System.Windows.Forms.TextBox tbScreenSavingPath;
        private System.Windows.Forms.Button bSelectPath;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.TextBox tbBotToken;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbFullTextMessage;
        private System.Windows.Forms.Label tlFullTextMessage;
        private System.Windows.Forms.Label tlBotToken;
        private System.Windows.Forms.Label tlScreenPath;
        private System.Windows.Forms.Button bShowToken;
        private System.Windows.Forms.Button bBotStart;
        private System.Windows.Forms.Button bBotStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer pixelObserverTimer;
    }
}

