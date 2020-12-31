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

        private void getFilesButton_Click(object sender, EventArgs e)
        {
            MyFile.findExtension = correctExtensionTextBox.Text;
            if (!string.IsNullOrWhiteSpace(pathTextBox.Text))
            {
                var recieveCorrect = GetFilesFrom(pathTextBox, filesList, correctExtensionTextBox);
                if (recieveCorrect && MyFile.receivedFiles.Count > 0)
                {
                    getFilesButton.Enabled = false;
                    renamePanel.Visible = true;
                    correctExtensionTextBox.Enabled = false;
                    collectionsListBox.Visible = true;
                    tagsListBox.Visible = true;
                    
                    panel14.BackgroundImage = null;
                }
                else Data.ShowExceptionPanel("Вы ввели некорректный путь или несуществующее расширение, " +
                    "либо папка пустая", exceptionPanel);
            }
        }
        private static bool GetFilesFrom(TextBox pathTextBox, ListBox filesList, TextBox correctExtensionTextBox)
        {
            try
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
            catch (DirectoryNotFoundException) 
            {
                Control[] controls = ActiveForm.Controls.Find("exceptionPanel", true);
                Data.ShowExceptionPanel("Ошибка директории", (Panel)controls[0]);
                return false;
            }
        }
        private void filesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var imagePanel = Rename.FileInfoImage(MyFile.receivedFiles[filesList.SelectedIndex], nameTextBox, extensionTextBox, fullNameTextBox, dateCreateTextBox, panel14);
            if (imagePanel)
                ActiveForm.Size = MaximumSize;
            else ActiveForm.Size = MinimumSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pathTextBox.Text = "";
            correctExtensionTextBox.Text = "";
            filesList.Items.Clear();
            getFilesButton.Enabled = true;
            renamePanel.Visible = false;
            correctExtensionTextBox.Enabled = true;
            exceptionPanel.Visible = false;
            tagsListBox.Visible = false;
            collectionsListBox.Visible = false;
            ActiveForm.Size = MinimumSize;
            panel14.Visible = false;
            nameTextBox.Text = "";
            extensionTextBox.Text = "";
            fullNameTextBox.Text = "";
            dateCreateTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) //<!--FAST RENAME-->
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

        private void exceptionAcceptBtn_Click(object sender, EventArgs e)
        {
            exceptionPanel.Visible = false;
        }

        private void tagsListBox_DoubleClick(object sender, EventArgs e)
        {
            newNameTextBox.Text += tagsListBox.SelectedItem.ToString();
        }

        private void addTagBtn_Click(object sender, EventArgs e)
        {
            AddTagForm addTagForm = new AddTagForm();
            addTagForm.ShowDialog();
        }

        private void RenameForm_Load(object sender, EventArgs e)
        {
            var baseTags = MyTag.CreateStandartTags();
            new TagCollection(baseTags, "Базовые теги");

            TagCollection.ShowAll(collectionsListBox);
        }

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

        private void button4_Click(object sender, EventArgs e)
        {
            Data.ModeControl(modeBtn, modeListBox);
        }

        private void modeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
