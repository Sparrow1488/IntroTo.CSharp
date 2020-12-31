using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Data.ShowTags(listBox1);
        }

        private void addTagBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) || Data.HasTag(textBox1.Text))
                Data.ShowExceptionPanel("Возможно, Вы вели некорректный тэг, либо он уже существует", exceprionPanel);
            else
                Data.tagsList.Add(textBox1.Text);
            Data.ShowTags(listBox1);
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
            var deleteTag = listBox1.Items[listBox1.SelectedIndex].ToString();
            Data.tagsList.Remove(deleteTag);
            Data.ShowTags(listBox1);
        }
    }
}
