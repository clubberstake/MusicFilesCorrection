using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MusicFileEditor;
using TagLib.Riff;
using System.Threading.Tasks;

namespace MusicFilesCorrection
{
    public partial class MusicFileCorrector : Form
    {
        public MusicFileCorrector()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            this.listBoxFailedToUpdate.Items.Clear();

            if (radioButtonFile.Checked)
            {
                UpdateMP3(this.textBoxFolderOpen.Text);
            }
            else if (radioButtonFolder.Checked)
            {
                String[] fileCollection = Directory.GetFiles(this.textBoxFolderOpen.Text);
                UpdateMP3z(fileCollection.ToList());
            }
            else if (radioButtonFolderRecursive.Checked)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(this.textBoxFolderOpen.Text);
                RecursiveTree recursiveTree = new RecursiveTree();
                Action<String> updateMusicFile = s => UpdateMP3(s);
                CallbackParams callbackParams = new CallbackParams()
                {
                    RootDirectory = dirInfo,
                    DelegateMethod = updateMusicFile
                };
                ThreadPool.QueueUserWorkItem(new WaitCallback(recursiveTree.WalkDirectoryTreeCallback), (Object)callbackParams);
            }
        }

        private void UpdateMP3z(List<String> fileCollection)
        {
            Parallel.For(0, fileCollection.Count, x =>
            {
                UpdateMP3(fileCollection[x]);
            });           
        }

        private void UpdateMP3(String file)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<String>(UpdateMP3), file);
            }

            try
            {
                if (file.IndexOf(".mp3") < 0)
                {
                    return;
                }

                this.labelCurrentFile.Text = file;

                TagLib.File mp3File = TagLib.File.Create(file);
                if (mp3File == null || mp3File.Tag == null)
                {
                    return;
                }

                if (!String.IsNullOrEmpty(this.textBoxAlbumName.Text))
                {
                    mp3File.Tag.Album = this.textBoxAlbumName.Text;
                }

                if (!String.IsNullOrEmpty(this.textBoxArtistName.Text))
                {
                    List<String> artists = new List<string>();
                    artists.Add(this.textBoxArtistName.Text);
                    mp3File.Tag.Performers = artists.ToArray();
                }

                if (!String.IsNullOrEmpty(this.textBoxGenre.Text))
                {
                    List<String> genres = new List<string>();
                    genres.Add(this.textBoxGenre.Text);
                    mp3File.Tag.Genres = genres.ToArray();
                }

                mp3File.Save();
            }
            catch (Exception ex)
            {
                //this.listBoxFailedToUpdate.Items.Add(Path.GetFileName(file));
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (radioButtonFile.Checked)
            {
                openFileDialog.ShowDialog();
                this.textBoxFolderOpen.Text = openFileDialog.FileName;
            }
            else if (radioButtonFolder.Checked || radioButtonFolderRecursive.Checked)
            {
                folderBrowserDialog.ShowDialog();
                this.textBoxFolderOpen.Text = folderBrowserDialog.SelectedPath;
                SetAlbumNames();
            }
        }

        private void SetAlbumNames()
        {
            if (String.IsNullOrEmpty(this.textBoxFolderOpen.Text))
            {
                return;
            }

            this.listBoxAlbumNamesIfFolder.Items.Clear();

            DirectoryInfo directoryInfo = new DirectoryInfo(this.textBoxFolderOpen.Text);
            FileInfo[] files = directoryInfo.GetFiles("*.mp3");
            List<String> albumNames = new List<String>();
            foreach (FileInfo file in files)
            {
                TagLib.File mp3File = TagLib.File.Create(file.FullName);
                if (String.IsNullOrEmpty(mp3File.Tag.Album) || String.IsNullOrEmpty(mp3File.Tag.Album.Trim()))
                {
                    continue;
                }
                // Only add the album if it's unique
                if (String.IsNullOrEmpty(albumNames.FirstOrDefault(f => f.Equals(mp3File.Tag.Album))))
                {
                    albumNames.Add(mp3File.Tag.Album);
                }
            }

            foreach (String album in albumNames)
            {
                this.listBoxAlbumNamesIfFolder.Items.Add(album);
            }
        }
    }
}
