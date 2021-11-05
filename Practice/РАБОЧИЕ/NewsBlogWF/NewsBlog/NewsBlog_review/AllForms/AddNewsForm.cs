using System;
using System.Drawing;
using System.Windows.Forms;
using NewsBlog_review.NewsControls;
using NewsBlog_review.UserControls;

namespace NewsBlog_review
{
    public partial class AddNewsForm : Form
    {
        private News ActiveNews { get; set; }
        public AddNewsForm()
        {
            InitializeComponent();
            button1.Text = "add";
            button1.Tag = "add";
        }
        public AddNewsForm(Label editBtn)
        {
            InitializeComponent();
            button1.Text = "edit";
            button1.Tag = "edit";
        }
        private void LabelExeption()
        {
            label1.Visible = true;
            if (textBox1.Text.Length < 5)
                label1.Text = $"Длинна заголовка {textBox1.Text.Length} < 5!";
            else if (textBox2.Text.Length < 10)
                label1.Text = $"Длинна новости {textBox2.Text.Length} < 10!";
            else label1.Visible = false;
        }
        private void AddNews()
        {
            LabelExeption();
            if (!label1.Visible)
            {
                Color color = Color.Black;
                if (checkBox1.Checked == true) color = Color.Red;
                var nw = new TestNews(textBox1.Text, textBox2.Text)
                {
                    Athtor = MyUser<Label>.ActiveUser.Login,
                    ForeColorTitle = color
                };
            }
        }
        private void EditNews()
        {
            ActiveNews.Title = textBox1.Text;
            ActiveNews.Text = textBox2.Text;
            ActiveNews.Athtor += $", edit:{MyUser<Label>.ActiveUser.Login}";
            if (!checkBox1.Checked) ActiveNews.ForeColorTitle = Color.Black;
            if (checkBox1.Checked) ActiveNews.ForeColorTitle = Color.Red;
            News.SetEditNews(ActiveNews);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "add") AddNews(); //TODO: сделай обработчик отправки нормальный!!!!
            if (button1.Text == "edit") EditNews();
            else textBox1.Text = "Ошибка";
            Close();
        }

        private void AddNewsForm_Load(object sender, EventArgs e)
        {
            if (button1.Tag.ToString().Equals("edit"))
            {
                ActiveNews = News.GetNews();
                textBox1.Text = ActiveNews.Title;
                textBox2.Text = ActiveNews.Text;
            }
        }
    }
}
