using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    tagsListBox.Visible = true;
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
            Rename.FileInfo(MyFile.receivedFiles[filesList.SelectedIndex], nameTextBox, extensionTextBox, fullNameTextBox, dateCreateTextBox);
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want rename all find files in directory " + pathTextBox.Text + "?", "Warning!", MessageBoxButtons.YesNo);
            if (!newNameTextBox.Text.Equals("".Trim()))
                MyFile.SetNewName(newNameTextBox.Text);

            if (result == DialogResult.Yes)
                Rename.FastRename(correctExtensionTextBox);

            GetFilesFrom(pathTextBox, filesList, correctExtensionTextBox);
            Name += " - Complete!";
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
            Data.CreateStandartTags();
            Data.ShowTags(tagsListBox);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Data.ShowTags(tagsListBox);
        }
    }
}
