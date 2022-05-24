namespace Common.Forms
{
    partial class FSelector
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileDataSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemData = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataTesting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataRecordDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataRecordCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataRecordEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataRecordDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.labelHeader = new System.Windows.Forms.Label();
            this.listBoxIdentifiers = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelHeader, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.listBoxIdentifiers, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.statusStrip1, 0, 4);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 5;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(270, 387);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(270, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFileDataSave,
            this.ToolStripMenuItemFileExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItemFile.Text = "Файл";
            // 
            // ToolStripMenuItemFileDataSave
            // 
            this.ToolStripMenuItemFileDataSave.Name = "ToolStripMenuItemFileDataSave";
            this.ToolStripMenuItemFileDataSave.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemFileDataSave.Text = "Зберегти дані";
            this.ToolStripMenuItemFileDataSave.Click += new System.EventHandler(this.ToolStripMenuItemFileDataSave_Click);
            // 
            // ToolStripMenuItemFileExit
            // 
            this.ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit";
            this.ToolStripMenuItemFileExit.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemFileExit.Text = "Вихід";
            this.ToolStripMenuItemFileExit.Click += new System.EventHandler(this.ToolStripMenuItemFileExit_Click);
            // 
            // ToolStripMenuItemData
            // 
            this.ToolStripMenuItemData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDataTesting,
            this.ToolStripMenuItemDataRecord,
            this.ToolStripMenuItemDataClear});
            this.ToolStripMenuItemData.Name = "ToolStripMenuItemData";
            this.ToolStripMenuItemData.Size = new System.Drawing.Size(43, 20);
            this.ToolStripMenuItemData.Text = "Дані";
            // 
            // ToolStripMenuItemDataTesting
            // 
            this.ToolStripMenuItemDataTesting.Name = "ToolStripMenuItemDataTesting";
            this.ToolStripMenuItemDataTesting.Size = new System.Drawing.Size(192, 22);
            this.ToolStripMenuItemDataTesting.Text = "Створити тестові дані";
            this.ToolStripMenuItemDataTesting.Click += new System.EventHandler(this.ToolStripMenuItemDataTesting_Click);
            // 
            // ToolStripMenuItemDataRecord
            // 
            this.ToolStripMenuItemDataRecord.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDataRecordDetails,
            this.ToolStripMenuItemDataRecordCreate,
            this.ToolStripMenuItemDataRecordEdit,
            this.ToolStripMenuItemDataRecordDelete});
            this.ToolStripMenuItemDataRecord.Name = "ToolStripMenuItemDataRecord";
            this.ToolStripMenuItemDataRecord.Size = new System.Drawing.Size(192, 22);
            this.ToolStripMenuItemDataRecord.Text = "Запис";
            // 
            // ToolStripMenuItemDataRecordDetails
            // 
            this.ToolStripMenuItemDataRecordDetails.Name = "ToolStripMenuItemDataRecordDetails";
            this.ToolStripMenuItemDataRecordDetails.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItemDataRecordDetails.Text = "Переглянути";
            this.ToolStripMenuItemDataRecordDetails.Click += new System.EventHandler(this.ToolStripMenuItemDataRecordDetails_Click);
            // 
            // ToolStripMenuItemDataRecordCreate
            // 
            this.ToolStripMenuItemDataRecordCreate.Name = "ToolStripMenuItemDataRecordCreate";
            this.ToolStripMenuItemDataRecordCreate.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItemDataRecordCreate.Text = "Додати";
            this.ToolStripMenuItemDataRecordCreate.Click += new System.EventHandler(this.ToolStripMenuItemDataRecordCreate_Click);
            // 
            // ToolStripMenuItemDataRecordEdit
            // 
            this.ToolStripMenuItemDataRecordEdit.Name = "ToolStripMenuItemDataRecordEdit";
            this.ToolStripMenuItemDataRecordEdit.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItemDataRecordEdit.Text = "Редагувати";
            this.ToolStripMenuItemDataRecordEdit.Click += new System.EventHandler(this.ToolStripMenuItemDataRecordEdit_Click);
            // 
            // ToolStripMenuItemDataRecordDelete
            // 
            this.ToolStripMenuItemDataRecordDelete.Name = "ToolStripMenuItemDataRecordDelete";
            this.ToolStripMenuItemDataRecordDelete.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItemDataRecordDelete.Text = "Видалити";
            this.ToolStripMenuItemDataRecordDelete.Click += new System.EventHandler(this.ToolStripMenuItemDataRecordDelete_Click);
            // 
            // ToolStripMenuItemDataClear
            // 
            this.ToolStripMenuItemDataClear.Name = "ToolStripMenuItemDataClear";
            this.ToolStripMenuItemDataClear.Size = new System.Drawing.Size(192, 22);
            this.ToolStripMenuItemDataClear.Text = "Видалити усі записи";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(270, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Common.Forms.Properties.Resources.view;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripMenuItemDataRecordDetails_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Common.Forms.Properties.Resources.add;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripMenuItemDataRecordCreate_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Common.Forms.Properties.Resources.edit;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripMenuItemDataRecordEdit_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Common.Forms.Properties.Resources.delete;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.ToolStripMenuItemDataRecordDelete_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(3, 59);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(87, 13);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Список об`єктів";
            // 
            // listBoxIdentifiers
            // 
            this.listBoxIdentifiers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxIdentifiers.FormattingEnabled = true;
            this.listBoxIdentifiers.Location = new System.Drawing.Point(3, 78);
            this.listBoxIdentifiers.Name = "listBoxIdentifiers";
            this.listBoxIdentifiers.Size = new System.Drawing.Size(264, 284);
            this.listBoxIdentifiers.TabIndex = 3;
            this.listBoxIdentifiers.SelectedIndexChanged += new System.EventHandler(this.listBoxIdentifiers_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage,
            this.toolStripStatusLabelTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(270, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(185, 17);
            this.toolStripStatusLabelMessage.Spring = true;
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.AutoSize = false;
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(70, 17);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 500;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // FSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 411);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FSelector";
            this.Text = "Тести";
            this.Load += new System.EventHandler(this.FSelector_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileDataSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemData;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataTesting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataRecord;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataRecordDetails;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataRecordCreate;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataRecordEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataRecordDelete;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataClear;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ListBox listBoxIdentifiers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}