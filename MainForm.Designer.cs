namespace INFILM
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.sepToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mSorting = new System.Windows.Forms.ToolStripMenuItem();
            this.SortingDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.SortingRating = new System.Windows.Forms.ToolStripMenuItem();
            this.SortingNew = new System.Windows.Forms.ToolStripMenuItem();
            this.SortingOld = new System.Windows.Forms.ToolStripMenuItem();
            this.mLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageRu = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageEn = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageDe = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Update = new System.Windows.Forms.ToolStripMenuItem();
            this.mCurrentTime = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Timer(this.components);
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.CloseSearchPanel = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.Window;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.optionsToolStripMenuItem,
            this.mHelp,
            this.Update});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(518, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "MainMenu";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUpdate,
            this.fToolStripMenuItem,
            this.mExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(48, 20);
            this.mFile.Text = "Файл";
            // 
            // mUpdate
            // 
            this.mUpdate.Image = ((System.Drawing.Image)(resources.GetObject("mUpdate.Image")));
            this.mUpdate.Name = "mUpdate";
            this.mUpdate.Size = new System.Drawing.Size(152, 22);
            this.mUpdate.Text = "Обновить";
            this.mUpdate.Click += new System.EventHandler(this.mUpdate_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(125, 6);
            // 
            // mExit
            // 
            this.mExit.Image = ((System.Drawing.Image)(resources.GetObject("mExit.Image")));
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(128, 22);
            this.mExit.Text = "Выход";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSearch,
            this.sepToolStripMenuItem,
            this.mSettings});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "Опции";
            // 
            // mSearch
            // 
            this.mSearch.Image = ((System.Drawing.Image)(resources.GetObject("mSearch.Image")));
            this.mSearch.Name = "mSearch";
            this.mSearch.Size = new System.Drawing.Size(152, 22);
            this.mSearch.Text = "Поиск";
            this.mSearch.Click += new System.EventHandler(this.mSearch_Click);
            // 
            // sepToolStripMenuItem
            // 
            this.sepToolStripMenuItem.Name = "sepToolStripMenuItem";
            this.sepToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // mSettings
            // 
            this.mSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSorting,
            this.mLanguage});
            this.mSettings.Image = ((System.Drawing.Image)(resources.GetObject("mSettings.Image")));
            this.mSettings.Name = "mSettings";
            this.mSettings.Size = new System.Drawing.Size(152, 22);
            this.mSettings.Text = "Настройки";
            this.mSettings.ToolTipText = "Для применения нажать \"Обновить\"";
            // 
            // mSorting
            // 
            this.mSorting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortingDefault,
            this.SortingRating,
            this.SortingNew,
            this.SortingOld});
            this.mSorting.Image = ((System.Drawing.Image)(resources.GetObject("mSorting.Image")));
            this.mSorting.Name = "mSorting";
            this.mSorting.Size = new System.Drawing.Size(152, 22);
            this.mSorting.Text = "Сортировка";
            // 
            // SortingDefault
            // 
            this.SortingDefault.Checked = true;
            this.SortingDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SortingDefault.Name = "SortingDefault";
            this.SortingDefault.Size = new System.Drawing.Size(165, 22);
            this.SortingDefault.Text = "Стандартная";
            this.SortingDefault.Click += new System.EventHandler(this.SortingDefault_Click);
            // 
            // SortingRating
            // 
            this.SortingRating.Name = "SortingRating";
            this.SortingRating.Size = new System.Drawing.Size(165, 22);
            this.SortingRating.Text = "Рейтинг";
            this.SortingRating.Click += new System.EventHandler(this.SortingRating_Click);
            // 
            // SortingNew
            // 
            this.SortingNew.Name = "SortingNew";
            this.SortingNew.Size = new System.Drawing.Size(165, 22);
            this.SortingNew.Text = "Новые фильмы";
            this.SortingNew.Click += new System.EventHandler(this.SortingNew_Click);
            // 
            // SortingOld
            // 
            this.SortingOld.Name = "SortingOld";
            this.SortingOld.Size = new System.Drawing.Size(165, 22);
            this.SortingOld.Text = "Старые фильмы";
            this.SortingOld.Click += new System.EventHandler(this.SortingOld_Click);
            // 
            // mLanguage
            // 
            this.mLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageRu,
            this.LanguageEn,
            this.LanguageDe});
            this.mLanguage.Image = ((System.Drawing.Image)(resources.GetObject("mLanguage.Image")));
            this.mLanguage.Name = "mLanguage";
            this.mLanguage.Size = new System.Drawing.Size(152, 22);
            this.mLanguage.Text = "Язык";
            // 
            // LanguageRu
            // 
            this.LanguageRu.Checked = true;
            this.LanguageRu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LanguageRu.Name = "LanguageRu";
            this.LanguageRu.Size = new System.Drawing.Size(141, 22);
            this.LanguageRu.Text = "Русский";
            this.LanguageRu.Click += new System.EventHandler(this.LanguageRu_Click);
            // 
            // LanguageEn
            // 
            this.LanguageEn.Name = "LanguageEn";
            this.LanguageEn.Size = new System.Drawing.Size(141, 22);
            this.LanguageEn.Text = "Английский";
            this.LanguageEn.Click += new System.EventHandler(this.LanguageEn_Click);
            // 
            // LanguageDe
            // 
            this.LanguageDe.Name = "LanguageDe";
            this.LanguageDe.Size = new System.Drawing.Size(141, 22);
            this.LanguageDe.Text = "Немецкий";
            this.LanguageDe.Click += new System.EventHandler(this.LanguageDe_Click);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mInfo,
            this.toolStripMenuItem2,
            this.mAbout});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(68, 20);
            this.mHelp.Text = "Помощь";
            // 
            // mInfo
            // 
            this.mInfo.Image = ((System.Drawing.Image)(resources.GetObject("mInfo.Image")));
            this.mInfo.Name = "mInfo";
            this.mInfo.Size = new System.Drawing.Size(152, 22);
            this.mInfo.Text = "Информация";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // mAbout
            // 
            this.mAbout.Image = ((System.Drawing.Image)(resources.GetObject("mAbout.Image")));
            this.mAbout.Name = "mAbout";
            this.mAbout.Size = new System.Drawing.Size(152, 22);
            this.mAbout.Text = "О программе";
            // 
            // Update
            // 
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(73, 20);
            this.Update.Text = "Обновить";
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // mCurrentTime
            // 
            this.mCurrentTime.AutoSize = true;
            this.mCurrentTime.BackColor = System.Drawing.SystemColors.Window;
            this.mCurrentTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mCurrentTime.Location = new System.Drawing.Point(470, 4);
            this.mCurrentTime.Name = "mCurrentTime";
            this.mCurrentTime.Size = new System.Drawing.Size(49, 16);
            this.mCurrentTime.TabIndex = 3;
            this.mCurrentTime.Text = "00 : 00";
            // 
            // CurrentTime
            // 
            this.CurrentTime.Enabled = true;
            this.CurrentTime.Interval = 10;
            this.CurrentTime.Tick += new System.EventHandler(this.CurrentTime_Tick);
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.SystemColors.Window;
            this.SearchPanel.Controls.Add(this.CloseSearchPanel);
            this.SearchPanel.Controls.Add(this.Search);
            this.SearchPanel.Controls.Add(this.SearchText);
            this.SearchPanel.Location = new System.Drawing.Point(0, 23);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(519, 21);
            this.SearchPanel.TabIndex = 4;
            this.SearchPanel.Visible = false;
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(139, 0);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(125, 20);
            this.SearchText.TabIndex = 5;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(270, -1);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(123, 21);
            this.Search.TabIndex = 5;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CloseSearchPanel
            // 
            this.CloseSearchPanel.Image = ((System.Drawing.Image)(resources.GetObject("CloseSearchPanel.Image")));
            this.CloseSearchPanel.Location = new System.Drawing.Point(498, 0);
            this.CloseSearchPanel.Name = "CloseSearchPanel";
            this.CloseSearchPanel.Size = new System.Drawing.Size(21, 22);
            this.CloseSearchPanel.TabIndex = 5;
            this.CloseSearchPanel.UseVisualStyleBackColor = true;
            this.CloseSearchPanel.Click += new System.EventHandler(this.CloseSearchPanel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(518, 344);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.mCurrentTime);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "INFILM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mUpdate;
        private System.Windows.Forms.ToolStripSeparator fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem mInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mAbout;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSettings;
        private System.Windows.Forms.ToolStripMenuItem mSearch;
        private System.Windows.Forms.ToolStripSeparator sepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSorting;
        private System.Windows.Forms.ToolStripMenuItem mLanguage;
        private System.Windows.Forms.Label mCurrentTime;
        private System.Windows.Forms.Timer CurrentTime;
        private System.Windows.Forms.ToolStripMenuItem SortingDefault;
        private System.Windows.Forms.ToolStripMenuItem SortingRating;
        private System.Windows.Forms.ToolStripMenuItem SortingNew;
        private System.Windows.Forms.ToolStripMenuItem SortingOld;
        private System.Windows.Forms.ToolStripMenuItem LanguageRu;
        private System.Windows.Forms.ToolStripMenuItem LanguageEn;
        private System.Windows.Forms.ToolStripMenuItem LanguageDe;
        private System.Windows.Forms.ToolStripMenuItem Update;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button CloseSearchPanel;




    }
}

