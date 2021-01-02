using System;
using System.IO;
using System.Windows.Forms;
using VisualRenamer.Files;

namespace VisualRenamer
{
    public partial class RenameForm : Form
    {
        
        public RenameForm()
        {
            InitializeComponent();
        }
        private void RenameForm_Load(object sender, EventArgs e)
        {
            var baseTags = MyTag.CreateStandartTags();
            new TagCollection(baseTags, "Базовые теги");

            TagCollection.ShowAll(collectionsListBox);
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetAllControls();
        }
        private void exceptionAcceptBtn_Click(object sender, EventArgs e)
        {
            exceptionPanel.Visible = false;
        }


        #region GetFilesControls
        private void getFilesButton_Click(object sender, EventArgs e)
        {
            try
            {
                MyFile.findExtension = correctExtensionTextBox.Text;
                if (!string.IsNullOrWhiteSpace(pathTextBox.Text))
                {
                    var recieveCorrect = GetFilesFrom(pathTextBox, filesList, correctExtensionTextBox);
                    if (recieveCorrect && MyFile.receivedFiles.Count > 0)
                    {
                        HideFindControls(false);
                        collectionsListBox.Visible = true;
                        tagsListBox.Visible = true;
                        imagePanel.BackgroundImage = null;
                    }
                }
            }
            catch (Exception)
            {
                Data.ShowExceptionPanel("Вы ввели некорректный путь или несуществующее расширение, " +
                "либо папка пустая", exceptionPanel);
            }
        }
        #endregion

        #region RenamePanel
        private void fastRenameBtn_Click(object sender, EventArgs e) //<!--FAST RENAME-->
        {
            if (!newNameTextBox.Text.Equals("".Trim()))
            {
                var result = MessageBox.Show("Are you sure you want rename all find files in directory " + pathTextBox.Text + "?", "Warning!", MessageBoxButtons.YesNo);
                MyFile.SetNewName(newNameTextBox.Text);
                if (result == DialogResult.Yes)
                    Rename.FastRename(correctExtensionTextBox);

                GetFilesFrom(pathTextBox, filesList, correctExtensionTextBox);
                Name += " - Complete!";
            }
        }
        private void modeBtn_Click(object sender, EventArgs e)
        {
            Data.ModeControlActive(modeBtn, modeListBox);
        }
        private void modeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void selectiveRenameBtn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region TagsAndCollectionsPanel
        private void label9_Click(object sender, EventArgs e)
        {
            TagCollection.ShowAll(collectionsListBox);
        }
        private void collectionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (collectionsListBox.SelectedItem != null)
            {
                MyTag.ShowTagCollection(tagsListBox, TagCollection.FindCollectionByName(collectionsListBox.SelectedItem.ToString()));
            }
        }
        private void tagsListBox_DoubleClick(object sender, EventArgs e)
        {
            newNameTextBox.Text += tagsListBox.SelectedItem.ToString();
        }
        #endregion

        #region ToolStripMenu
        private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хм, и для чего же оно?", "Справка");
        }

        private void миниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Size = MinimumSize;
        }

        private void максимальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Size = MaximumSize;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            открытьToolStripMenuItem.Click += getFilesButton_Click;
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTagForm addTagForm = new AddTagForm();
            addTagForm.ShowDialog();
        }
        #endregion

        #region FilesControls
        private void filesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var imagePanel = Rename.FileInfoImage(MyFile.receivedFiles[filesList.SelectedIndex], nameTextBox, extensionTextBox, fullNameTextBox, dateCreateTextBox, this.imagePanel);
            if (imagePanel)
                ActiveForm.Size = MaximumSize;
            else ActiveForm.Size = MinimumSize;
        }
        #endregion

        #region OtherMethods
        private void HideFindControls(bool mode)
        {
            getFilesButton.Enabled = mode;
            renamePanel.Visible = !mode;
            correctExtensionTextBox.Enabled = mode;
            открытьToolStripMenuItem.Enabled = mode;
        }
        private void ResetInfoFile()
        {
            nameTextBox.Text = "";
            extensionTextBox.Text = "";
            fullNameTextBox.Text = "";
            dateCreateTextBox.Text = "";
        }
        private void ResetFindControls()
        {
            pathTextBox.Text = "";
            correctExtensionTextBox.Text = "";
        }
        private void HideTagControls()
        {
            tagsListBox.Visible = false;
            collectionsListBox.Visible = false;
        }
        private void ResetAllControls()
        {
            ResetFindControls();
            HideFindControls(true);
            ResetInfoFile();
            HideTagControls();
            filesList.Items.Clear();
            exceptionPanel.Visible = false;
            ActiveForm.Size = MinimumSize;
            imagePanel.Visible = false;
        }
        private bool GetFilesFrom(TextBox pathTextBox, ListBox filesList, TextBox correctExtensionTextBox)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(pathTextBox.Text);

            var findFiles = dirInfo.GetFiles();
            filesList.Items.Clear();
            MyFile.receivedFiles.Clear();
            foreach (var file in findFiles)
            {
                if (file.Extension.Equals(correctExtensionTextBox.Text.Trim()) || correctExtensionTextBox.Text.Equals("".Trim()))
                    filesList.Items.Add(new MyFile(file).name);
            }
            return true;
        }
        #endregion

    }
}
