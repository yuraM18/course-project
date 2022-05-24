namespace TestingInfo.FormsEditor
{
    partial class FMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileDataSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemData = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataAsText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemDataTesting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemDataTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataTestResult = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buttonCreateTestReasult = new System.Windows.Forms.Button();
            this.panelBar = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelLog = new System.Windows.Forms.Label();
            this.panelAuthoriation = new System.Windows.Forms.Panel();
            this.buttonLog = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.panelBack = new System.Windows.Forms.Panel();
            this.buttonExitUser = new System.Windows.Forms.Button();
            this.buttonTestCreate = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.listBoxTest = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAuthoriation.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemData,
            this.ToolStripMenuItemDataHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFileDataSave,
            this.toolStripSeparator1,
            this.ToolStripMenuItemFileExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItemFile.Text = "&Файл";
            // 
            // ToolStripMenuItemFileDataSave
            // 
            this.ToolStripMenuItemFileDataSave.Name = "ToolStripMenuItemFileDataSave";
            this.ToolStripMenuItemFileDataSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItemFileDataSave.Size = new System.Drawing.Size(189, 22);
            this.ToolStripMenuItemFileDataSave.Text = "З&берегти дані";
            this.ToolStripMenuItemFileDataSave.Click += new System.EventHandler(this.ToolStripMenuItemFileDataSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // ToolStripMenuItemFileExit
            // 
            this.ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit";
            this.ToolStripMenuItemFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ToolStripMenuItemFileExit.Size = new System.Drawing.Size(189, 22);
            this.ToolStripMenuItemFileExit.Text = "Ви&хід";
            this.ToolStripMenuItemFileExit.Click += new System.EventHandler(this.ToolStripMenuItemFileExit_Click);
            // 
            // ToolStripMenuItemData
            // 
            this.ToolStripMenuItemData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDataAsText,
            this.toolStripSeparator3,
            this.ToolStripMenuItemDataTesting,
            this.toolStripSeparator4,
            this.ToolStripMenuItemDataTest,
            this.ToolStripMenuItemDataTestResult});
            this.ToolStripMenuItemData.Name = "ToolStripMenuItemData";
            this.ToolStripMenuItemData.Size = new System.Drawing.Size(43, 20);
            this.ToolStripMenuItemData.Text = "Да&ні";
            // 
            // ToolStripMenuItemDataAsText
            // 
            this.ToolStripMenuItemDataAsText.Name = "ToolStripMenuItemDataAsText";
            this.ToolStripMenuItemDataAsText.Size = new System.Drawing.Size(233, 22);
            this.ToolStripMenuItemDataAsText.Text = "Дані &як текст...";
            this.ToolStripMenuItemDataAsText.Click += new System.EventHandler(this.ToolStripMenuItemDataAsText_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(230, 6);
            // 
            // ToolStripMenuItemDataTesting
            // 
            this.ToolStripMenuItemDataTesting.Name = "ToolStripMenuItemDataTesting";
            this.ToolStripMenuItemDataTesting.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ToolStripMenuItemDataTesting.Size = new System.Drawing.Size(233, 22);
            this.ToolStripMenuItemDataTesting.Text = "Створити &тестові дані";
            this.ToolStripMenuItemDataTesting.Click += new System.EventHandler(this.ToolStripMenuItemDataTesting_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(230, 6);
            // 
            // ToolStripMenuItemDataTest
            // 
            this.ToolStripMenuItemDataTest.Name = "ToolStripMenuItemDataTest";
            this.ToolStripMenuItemDataTest.Size = new System.Drawing.Size(233, 22);
            this.ToolStripMenuItemDataTest.Text = "&Тести...";
            this.ToolStripMenuItemDataTest.Click += new System.EventHandler(this.ToolStripMenuItemDataTest_Click_1);
            // 
            // ToolStripMenuItemDataTestResult
            // 
            this.ToolStripMenuItemDataTestResult.Name = "ToolStripMenuItemDataTestResult";
            this.ToolStripMenuItemDataTestResult.Size = new System.Drawing.Size(233, 22);
            this.ToolStripMenuItemDataTestResult.Text = "&Результат тестування...";
            this.ToolStripMenuItemDataTestResult.Click += new System.EventHandler(this.ToolStripMenuItemDataTestResult_Click);
            // 
            // ToolStripMenuItemDataHelp
            // 
            this.ToolStripMenuItemDataHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDataHelpAbout});
            this.ToolStripMenuItemDataHelp.Name = "ToolStripMenuItemDataHelp";
            this.ToolStripMenuItemDataHelp.Size = new System.Drawing.Size(61, 20);
            this.ToolStripMenuItemDataHelp.Text = "&Довідка";
            // 
            // ToolStripMenuItemDataHelpAbout
            // 
            this.ToolStripMenuItemDataHelpAbout.Name = "ToolStripMenuItemDataHelpAbout";
            this.ToolStripMenuItemDataHelpAbout.Size = new System.Drawing.Size(163, 22);
            this.ToolStripMenuItemDataHelpAbout.Text = "Про &програму...";
            this.ToolStripMenuItemDataHelpAbout.Click += new System.EventHandler(this.ToolStripMenuItemDataHelpAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage,
            this.toolStripStatusLabelDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(941, 25);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(830, 20);
            this.toolStripStatusLabelMessage.Spring = true;
            // 
            // toolStripStatusLabelDateTime
            // 
            this.toolStripStatusLabelDateTime.AutoSize = false;
            this.toolStripStatusLabelDateTime.Name = "toolStripStatusLabelDateTime";
            this.toolStripStatusLabelDateTime.Size = new System.Drawing.Size(100, 20);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 500;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 3;
            this.bunifuElipse1.TargetControl = this.buttonMin;
            // 
            // buttonCreateTestReasult
            // 
            this.buttonCreateTestReasult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCreateTestReasult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateTestReasult.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateTestReasult.Location = new System.Drawing.Point(368, 438);
            this.buttonCreateTestReasult.Name = "buttonCreateTestReasult";
            this.buttonCreateTestReasult.Size = new System.Drawing.Size(222, 30);
            this.buttonCreateTestReasult.TabIndex = 15;
            this.buttonCreateTestReasult.Text = "Додати студента";
            this.buttonCreateTestReasult.UseVisualStyleBackColor = false;
            this.buttonCreateTestReasult.Visible = false;
            this.buttonCreateTestReasult.Click += new System.EventHandler(this.buttonCreateTestReasult_Click);
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelBar.Location = new System.Drawing.Point(242, 72);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(8, 100);
            this.panelBar.TabIndex = 15;
            this.panelBar.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(505, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(280, 171);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.Location = new System.Drawing.Point(48, 24);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(54, 21);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "Логін:";
            // 
            // panelAuthoriation
            // 
            this.panelAuthoriation.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelAuthoriation.Controls.Add(this.buttonLog);
            this.panelAuthoriation.Controls.Add(this.checkBox1);
            this.panelAuthoriation.Controls.Add(this.textBoxLog);
            this.panelAuthoriation.Controls.Add(this.textBoxPass);
            this.panelAuthoriation.Controls.Add(this.labelLog);
            this.panelAuthoriation.Controls.Add(this.labelPass);
            this.panelAuthoriation.Location = new System.Drawing.Point(12, 249);
            this.panelAuthoriation.Name = "panelAuthoriation";
            this.panelAuthoriation.Size = new System.Drawing.Size(370, 141);
            this.panelAuthoriation.TabIndex = 13;
            // 
            // buttonLog
            // 
            this.buttonLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLog.ImageKey = "(отсутствует)";
            this.buttonLog.Location = new System.Drawing.Point(108, 101);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(112, 30);
            this.buttonLog.TabIndex = 3;
            this.buttonLog.Text = "увійти";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(230, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Показати пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLog.Location = new System.Drawing.Point(108, 23);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(187, 23);
            this.textBoxLog.TabIndex = 1;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(108, 63);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(187, 23);
            this.textBoxPass.TabIndex = 1;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(32, 64);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(74, 21);
            this.labelPass.TabIndex = 0;
            this.labelPass.Text = "Пароль:";
            // 
            // panelBack
            // 
            this.panelBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBack.BackgroundImage")));
            this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBack.Controls.Add(this.buttonExitUser);
            this.panelBack.Controls.Add(this.buttonTestCreate);
            this.panelBack.Controls.Add(this.buttonMax);
            this.panelBack.Controls.Add(this.buttonMin);
            this.panelBack.Controls.Add(this.buttonCreateTestReasult);
            this.panelBack.Controls.Add(this.panelBar);
            this.panelBack.Controls.Add(this.dataGridView1);
            this.panelBack.Controls.Add(this.panelAuthoriation);
            this.panelBack.Controls.Add(this.listBoxTest);
            this.panelBack.Location = new System.Drawing.Point(0, 36);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(918, 479);
            this.panelBack.TabIndex = 14;
            this.panelBack.Resize += new System.EventHandler(this.panelBack_Resize);
            // 
            // buttonExitUser
            // 
            this.buttonExitUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonExitUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExitUser.Font = new System.Drawing.Font("Magneto", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitUser.Location = new System.Drawing.Point(819, 440);
            this.buttonExitUser.Name = "buttonExitUser";
            this.buttonExitUser.Size = new System.Drawing.Size(85, 28);
            this.buttonExitUser.TabIndex = 19;
            this.buttonExitUser.Text = "Вийти->";
            this.buttonExitUser.UseVisualStyleBackColor = false;
            this.buttonExitUser.Click += new System.EventHandler(this.buttonExitUser_Click);
            // 
            // buttonTestCreate
            // 
            this.buttonTestCreate.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonTestCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTestCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTestCreate.Location = new System.Drawing.Point(120, 397);
            this.buttonTestCreate.Name = "buttonTestCreate";
            this.buttonTestCreate.Size = new System.Drawing.Size(222, 30);
            this.buttonTestCreate.TabIndex = 18;
            this.buttonTestCreate.Text = "Додати тест";
            this.buttonTestCreate.UseVisualStyleBackColor = false;
            this.buttonTestCreate.Click += new System.EventHandler(this.buttonTestCreate_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.BackColor = System.Drawing.Color.Gold;
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMax.Font = new System.Drawing.Font("Mistral", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMax.Location = new System.Drawing.Point(222, 440);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(75, 30);
            this.buttonMax.TabIndex = 17;
            this.buttonMax.Text = "->";
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.Gold;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMin.Font = new System.Drawing.Font("Mistral", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMin.Location = new System.Drawing.Point(64, 440);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(75, 30);
            this.buttonMin.TabIndex = 16;
            this.buttonMin.Text = "<-";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // listBoxTest
            // 
            this.listBoxTest.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxTest.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTest.FormattingEnabled = true;
            this.listBoxTest.ItemHeight = 23;
            this.listBoxTest.Location = new System.Drawing.Point(64, 72);
            this.listBoxTest.Name = "listBoxTest";
            this.listBoxTest.Size = new System.Drawing.Size(147, 96);
            this.listBoxTest.TabIndex = 0;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 576);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelBack);
            this.KeyPreview = true;
            this.Name = "FMain";
            this.Text = "ПО \"Облік тестування\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAuthoriation.ResumeLayout(false);
            this.panelAuthoriation.PerformLayout();
            this.panelBack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileDataSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemData;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataAsText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataTesting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataTest;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataTestResult;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataHelpAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDateTime;
        private System.Windows.Forms.Timer timerTime;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelAuthoriation;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.ListBox listBoxTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button buttonCreateTestReasult;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonTestCreate;
        private System.Windows.Forms.Button buttonExitUser;
    }
}

