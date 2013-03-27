namespace MusicFilesCorrection
{
    partial class MusicFileCorrector
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonGo = new System.Windows.Forms.Button();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.textBoxArtistName = new System.Windows.Forms.TextBox();
            this.textBoxAlbumName = new System.Windows.Forms.TextBox();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.labelAlbumNamesInFolder = new System.Windows.Forms.Label();
            this.listBoxAlbumNamesIfFolder = new System.Windows.Forms.ListBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelFolderOpened = new System.Windows.Forms.Label();
            this.textBoxFolderOpen = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxFileFolder = new System.Windows.Forms.GroupBox();
            this.radioButtonFolderRecursive = new System.Windows.Forms.RadioButton();
            this.radioButtonFolder = new System.Windows.Forms.RadioButton();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelCurrentFileTitle = new System.Windows.Forms.Label();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.labelFailedToUpdate = new System.Windows.Forms.Label();
            this.listBoxFailedToUpdate = new System.Windows.Forms.ListBox();
            this.groupBoxFileFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(686, 367);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // labelArtistName
            // 
            this.labelArtistName.AutoSize = true;
            this.labelArtistName.Location = new System.Drawing.Point(15, 109);
            this.labelArtistName.Name = "labelArtistName";
            this.labelArtistName.Size = new System.Drawing.Size(64, 13);
            this.labelArtistName.TabIndex = 1;
            this.labelArtistName.Text = "Artist Name:";
            // 
            // textBoxArtistName
            // 
            this.textBoxArtistName.Location = new System.Drawing.Point(86, 109);
            this.textBoxArtistName.Name = "textBoxArtistName";
            this.textBoxArtistName.Size = new System.Drawing.Size(285, 20);
            this.textBoxArtistName.TabIndex = 2;
            // 
            // textBoxAlbumName
            // 
            this.textBoxAlbumName.Location = new System.Drawing.Point(85, 141);
            this.textBoxAlbumName.Name = "textBoxAlbumName";
            this.textBoxAlbumName.Size = new System.Drawing.Size(286, 20);
            this.textBoxAlbumName.TabIndex = 4;
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Location = new System.Drawing.Point(14, 144);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(70, 13);
            this.labelAlbumName.TabIndex = 3;
            this.labelAlbumName.Text = "Album Name:";
            // 
            // labelAlbumNamesInFolder
            // 
            this.labelAlbumNamesInFolder.AutoSize = true;
            this.labelAlbumNamesInFolder.Location = new System.Drawing.Point(15, 210);
            this.labelAlbumNamesInFolder.Name = "labelAlbumNamesInFolder";
            this.labelAlbumNamesInFolder.Size = new System.Drawing.Size(119, 13);
            this.labelAlbumNamesInFolder.TabIndex = 5;
            this.labelAlbumNamesInFolder.Text = "Album Names In Folder:";
            // 
            // listBoxAlbumNamesIfFolder
            // 
            this.listBoxAlbumNamesIfFolder.FormattingEnabled = true;
            this.listBoxAlbumNamesIfFolder.Location = new System.Drawing.Point(12, 226);
            this.listBoxAlbumNamesIfFolder.Name = "listBoxAlbumNamesIfFolder";
            this.listBoxAlbumNamesIfFolder.Size = new System.Drawing.Size(359, 147);
            this.listBoxAlbumNamesIfFolder.TabIndex = 6;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(18, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 7;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelFolderOpened
            // 
            this.labelFolderOpened.AutoSize = true;
            this.labelFolderOpened.Location = new System.Drawing.Point(101, 21);
            this.labelFolderOpened.Name = "labelFolderOpened";
            this.labelFolderOpened.Size = new System.Drawing.Size(77, 13);
            this.labelFolderOpened.TabIndex = 8;
            this.labelFolderOpened.Text = "Folder Open ->";
            // 
            // textBoxFolderOpen
            // 
            this.textBoxFolderOpen.Location = new System.Drawing.Point(185, 21);
            this.textBoxFolderOpen.Name = "textBoxFolderOpen";
            this.textBoxFolderOpen.Size = new System.Drawing.Size(614, 20);
            this.textBoxFolderOpen.TabIndex = 9;
            // 
            // groupBoxFileFolder
            // 
            this.groupBoxFileFolder.Controls.Add(this.radioButtonFolderRecursive);
            this.groupBoxFileFolder.Controls.Add(this.radioButtonFolder);
            this.groupBoxFileFolder.Controls.Add(this.radioButtonFile);
            this.groupBoxFileFolder.Location = new System.Drawing.Point(18, 51);
            this.groupBoxFileFolder.Name = "groupBoxFileFolder";
            this.groupBoxFileFolder.Size = new System.Drawing.Size(353, 52);
            this.groupBoxFileFolder.TabIndex = 10;
            this.groupBoxFileFolder.TabStop = false;
            this.groupBoxFileFolder.Text = "Choose File or Folder to open";
            // 
            // radioButtonFolderRecursive
            // 
            this.radioButtonFolderRecursive.AutoSize = true;
            this.radioButtonFolderRecursive.Location = new System.Drawing.Point(182, 19);
            this.radioButtonFolderRecursive.Name = "radioButtonFolderRecursive";
            this.radioButtonFolderRecursive.Size = new System.Drawing.Size(111, 17);
            this.radioButtonFolderRecursive.TabIndex = 2;
            this.radioButtonFolderRecursive.TabStop = true;
            this.radioButtonFolderRecursive.Text = "Folder (Recursive)";
            this.radioButtonFolderRecursive.UseVisualStyleBackColor = true;
            // 
            // radioButtonFolder
            // 
            this.radioButtonFolder.AutoSize = true;
            this.radioButtonFolder.Location = new System.Drawing.Point(98, 19);
            this.radioButtonFolder.Name = "radioButtonFolder";
            this.radioButtonFolder.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFolder.TabIndex = 1;
            this.radioButtonFolder.TabStop = true;
            this.radioButtonFolder.Text = "Folder";
            this.radioButtonFolder.UseVisualStyleBackColor = true;
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Checked = true;
            this.radioButtonFile.Location = new System.Drawing.Point(7, 20);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(41, 17);
            this.radioButtonFile.TabIndex = 0;
            this.radioButtonFile.TabStop = true;
            this.radioButtonFile.Text = "File";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(17, 176);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 11;
            this.labelGenre.Text = "Genre:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(85, 173);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(286, 20);
            this.textBoxGenre.TabIndex = 12;
            // 
            // labelCurrentFileTitle
            // 
            this.labelCurrentFileTitle.AutoSize = true;
            this.labelCurrentFileTitle.Location = new System.Drawing.Point(12, 419);
            this.labelCurrentFileTitle.Name = "labelCurrentFileTitle";
            this.labelCurrentFileTitle.Size = new System.Drawing.Size(72, 13);
            this.labelCurrentFileTitle.TabIndex = 13;
            this.labelCurrentFileTitle.Text = "Current File ->";
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.AutoSize = true;
            this.labelCurrentFile.Location = new System.Drawing.Point(91, 419);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentFile.TabIndex = 14;
            // 
            // labelFailedToUpdate
            // 
            this.labelFailedToUpdate.AutoSize = true;
            this.labelFailedToUpdate.Location = new System.Drawing.Point(378, 210);
            this.labelFailedToUpdate.Name = "labelFailedToUpdate";
            this.labelFailedToUpdate.Size = new System.Drawing.Size(128, 13);
            this.labelFailedToUpdate.TabIndex = 15;
            this.labelFailedToUpdate.Text = "Files that failed to update:";
            // 
            // listBoxFailedToUpdate
            // 
            this.listBoxFailedToUpdate.FormattingEnabled = true;
            this.listBoxFailedToUpdate.Location = new System.Drawing.Point(381, 227);
            this.listBoxFailedToUpdate.Name = "listBoxFailedToUpdate";
            this.listBoxFailedToUpdate.Size = new System.Drawing.Size(290, 147);
            this.listBoxFailedToUpdate.TabIndex = 16;
            // 
            // MusicFileCorrector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 456);
            this.Controls.Add(this.listBoxFailedToUpdate);
            this.Controls.Add(this.labelFailedToUpdate);
            this.Controls.Add(this.labelCurrentFile);
            this.Controls.Add(this.labelCurrentFileTitle);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.groupBoxFileFolder);
            this.Controls.Add(this.textBoxFolderOpen);
            this.Controls.Add(this.labelFolderOpened);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.listBoxAlbumNamesIfFolder);
            this.Controls.Add(this.labelAlbumNamesInFolder);
            this.Controls.Add(this.textBoxAlbumName);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.textBoxArtistName);
            this.Controls.Add(this.labelArtistName);
            this.Controls.Add(this.buttonGo);
            this.Name = "MusicFileCorrector";
            this.Text = "Music File Corrector";
            this.groupBoxFileFolder.ResumeLayout(false);
            this.groupBoxFileFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.TextBox textBoxArtistName;
        private System.Windows.Forms.TextBox textBoxAlbumName;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.Label labelAlbumNamesInFolder;
        private System.Windows.Forms.ListBox listBoxAlbumNamesIfFolder;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelFolderOpened;
        private System.Windows.Forms.TextBox textBoxFolderOpen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBoxFileFolder;
        private System.Windows.Forms.RadioButton radioButtonFolder;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.RadioButton radioButtonFolderRecursive;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelCurrentFileTitle;
        private System.Windows.Forms.Label labelCurrentFile;
        private System.Windows.Forms.Label labelFailedToUpdate;
        private System.Windows.Forms.ListBox listBoxFailedToUpdate;
    }
}

