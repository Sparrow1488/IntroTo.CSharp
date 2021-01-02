using System;
using System.Windows.Forms;
using VisualRenamer.Files;

namespace VisualRenamer
{
    public partial class AddTagForm : Form
    {
        public AddTagForm()
        {
            InitializeComponent();
        }

        private void AddTagForm_Load(object sender, EventArgs e)
        {
            TagCollection.ShowAll(listBox2);
        }

        private void addTagBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text.Trim()) || MyTag.HasTag(textBox1.Text))
                    throw new ArgumentException("Вы вели некорректный тэг, либо он уже существует");
                else
                {
                    var newTag = new MyTag(textBox1.Text);
                    TagCollection.Add(TagCollection.FindCollectionByName(listBox2.SelectedItem?.ToString()), newTag);
                    MyTag.ShowTagCollection(listBox1, TagCollection.FindCollectionByName(listBox2.SelectedItem.ToString()));
                }
            }
            catch (Exception ex)
            {
                Data.ShowExceptionPanel(ex.Message, exceprionPanel);
            }
            finally { textBox1.Text = ""; }
        }

        private void exceptionAcceptBtn_Click(object sender, EventArgs e)
        {
            exceprionPanel.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0)
            {
                deleteBtn.Enabled = true;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var deleteTag = listBox1.SelectedItem.ToString();
            MyTag.Delete(deleteTag);
            MyTag.ShowTagCollection(listBox1, TagCollection.allCollections[listBox2.SelectedIndex]);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox2.SelectedItem != null)
            {
                MyTag.ShowTagCollection(listBox1, TagCollection.FindCollectionByName(listBox2.SelectedItem.ToString()));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
                Data.ShowExceptionPanel("Вы не можете создать коллекцию без названия", exceprionPanel);
            else 
                new TagCollection(textBox4.Text.Trim());
            TagCollection.ShowAll(listBox2);
        }
    }
}
