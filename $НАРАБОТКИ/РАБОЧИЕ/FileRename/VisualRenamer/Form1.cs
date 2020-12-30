using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace VisualRenamer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void getFilesButton_Click(object sender, EventArgs e)
        {
            correctExtensionTextBox.Enabled = false;
            Data.findExtension = correctExtensionTextBox.Text;
            if (!string.IsNullOrWhiteSpace(pathTextBox.Text))
            {
                GetDirectoryFiles(filesList, correctExtensionTextBox, pathTextBox);
                getFilesButton.Enabled = false;
                VisiableRenamePanel(renamePanel, true);
            }
        }
        private static void GetDirectoryFiles(ListBox filesList, TextBox correctExtensionTextBox, TextBox pathTextBox)
        {
            Data.findPath = pathTextBox.Text;
            DirectoryInfo dirInfo = new DirectoryInfo(Data.findPath);
            Data.findFiles = dirInfo.GetFiles();
            foreach (var file in Data.findFiles)
            {
                if (file.Extension.Equals(correctExtensionTextBox.Text.Trim()) || correctExtensionTextBox.Text.Equals("".Trim()))
                {
                    Data.filesInList.Add(file);
                    filesList.Items.Add(file.Name);
                }
            }
        }

        private static void VisiableRenamePanel(Panel renamePanel, bool visiable)
        {
            renamePanel.Visible = visiable;
        }

        private void filesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rename.FileInfo(Data.filesInList[filesList.SelectedIndex]);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pathTextBox.Text = "";
            correctExtensionTextBox.Text = "";
            filesList.Items.Clear();
            getFilesButton.Enabled = true;
            renamePanel.Visible = false;
            correctExtensionTextBox.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want rename all find files in directory " + Data.findPath + "?", "Warning!", MessageBoxButtons.YesNo);
            if(!newNameTextBox.Text.Equals("".Trim()))
                Data.mainName = newNameTextBox.Text;
            //<!--FAST RENAME-->
            if (result == DialogResult.Yes)
            {
                foreach (var file in Data.filesInList)
                {
                    if (file.Extension.Equals(Data.findExtension) || correctExtensionTextBox.Text.Equals("".Trim()))
                        Rename.RenameComplete(file);
                }
            }
            filesList.Items.Clear();
            GetDirectoryFiles(filesList, correctExtensionTextBox, pathTextBox);
            this.Name += " - Complete!";

        }
    }
}
