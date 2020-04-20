﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretNest.ImageStore.SimilarFile
{
    internal partial class SimilarFilesManager : Form
    {
        List<Tuple<Guid, List<ImageStoreSimilarFile>>> allRecords;
        Dictionary<Guid, int> indicesOfListViewItems;
        Func<Guid, Image> loadImage;
        public SimilarFilesManager(HashSet<Guid> selectedFiles, Dictionary<Guid, FileInfo> allFileInfo, Func<Guid, Image> loadImage,
            List<Tuple<Guid, List<ImageStoreSimilarFile>>> allRecords, //fileId, similarRecords
            Func<Guid, IgnoredMode, bool> markIgnoreCallback)
        {
            InitializeComponent();
            similarFileCheck1.Initialize(selectedFiles, allFileInfo, markIgnoreCallback, true);
            this.allRecords = allRecords;
            this.loadImage = loadImage;
            similarFileCheck1.AutoResizePictures = checkBox3.Checked;
            similarFileCheck1.AutoMoveNext = checkBox4.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            similarFileCheck1.AutoMoveNext = checkBox4.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            similarFileCheck1.AutoResizePictures = checkBox3.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            LoadMainFiles();
        }

        public void LoadMainFiles()
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();
            indicesOfListViewItems = new Dictionary<Guid, int>();
            var fileCount = allRecords.Count;

            if (fileCount > 0) //cannot be 1 due to relation is two-way.
            {
                groupBox1.Text += string.Format(" {0} files", fileCount);
            }
            else
            {
                listView1.EndUpdate();
                return;
            }

            List<Image> images = new List<Image>();
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            var showHidden = checkBox2.Checked;

            int indexOfListView = 0;
            for (int indexOfAllRecords = 0; indexOfAllRecords < allRecords.Count; indexOfAllRecords++)
            {
                var file = allRecords[indexOfAllRecords];
                if (showHidden || file.Item2.Any(i => i.IgnoredMode == IgnoredMode.Effective))
                {
                    images.Add(loadImage(file.Item1));
                    listViewItems.Add(new ListViewItem(string.Format("{0} files", file.Item2.Count), indexOfListView) { Tag = indexOfAllRecords });
                    indicesOfListViewItems.Add(file.Item1, indexOfListView++);
                }
            }

            imageList1.Images.AddRange(images.ToArray());
            images = null;
            listView1.Items.AddRange(listViewItems.ToArray());

            listView1.EndUpdate();

            listView1.Items[0].Selected = true;

            Focus();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    int index = (int)item.Tag;
                    var selected = allRecords[index];
                    similarFileCheck1.LoadFile(selected.Item1, selected.Item2);
                    return;
                }
            }
            similarFileCheck1.ClearFile();
        }

        private void similarFileCheck1_RequestingGotoFile(object sender, RequestingGotoFileEventArgs e)
        {
            var index = indicesOfListViewItems[e.TargetFileId];
            listView1.Items[index].Selected = true;
        }

        private void SimilarFilesManager_Load(object sender, EventArgs e)
        {
            LoadMainFiles();
        }
    }
}
