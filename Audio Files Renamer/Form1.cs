using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using TagLib;

namespace Audio_Files_Renamer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private string GetSelectedFolder()
		{
            string folder = null;
            FolderBrowserDialog folderSelector = new FolderBrowserDialog();
            folderSelector.Description = "Choose folder with audio files";
            folderSelector.ShowNewFolderButton = false;
            DialogResult isFolderSelected = folderSelector.ShowDialog();
            if(isFolderSelected == DialogResult.OK)
			{
                folder = folderSelector.SelectedPath;
			}

            return folder;
		}

        private List<TagLib.File> PopulateListWithFiles(string folder)
		{
            string[] filePaths = Directory.GetFiles(folder);
            List<TagLib.File> audioFiles = new List<TagLib.File>();

			foreach (string file in filePaths)
			{
                TagLib.File f = TagLib.File.Create(file);
                if (f.Properties.MediaTypes == MediaTypes.Audio)
                {
                    audioFiles.Add(f);
                    ListViewItem song = listView1.Items.Add(audioFiles[audioFiles.Count - 1].Name.Substring(audioFiles[audioFiles.Count - 1].Name.LastIndexOf('\\') + 1));//name
                    song.SubItems.Add(audioFiles[audioFiles.Count - 1].Tag.Title);//title
                    song.SubItems.Add(string.Join(", ", audioFiles[audioFiles.Count - 1].Tag.Performers));//artist
                    song.SubItems.Add(audioFiles[audioFiles.Count - 1].Tag.Album);//album
                    song.SubItems.Add(string.Join(", ", audioFiles[audioFiles.Count - 1].Tag.Genres));//genre
                }
            }
            return audioFiles.Count == 0 ? null : audioFiles;
        }

		private void button1_Browse_Click(object sender, EventArgs e)
		{
            string folderWithFiles = GetSelectedFolder();
            List<TagLib.File> audioFiles = PopulateListWithFiles(folderWithFiles);
        }
	}
}
