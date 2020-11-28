using System;
using System.Windows.Forms;
using NewsBlog_review.UserControls;
using NewsBlog_review.Controls;
using NewsBlog_review.NewsControls;

namespace NewsBlog_review.AllForms
{
    public partial class MainForm : Form
    {
        public static void CreateStandartNews()
        {
            new TestNews("Заголовок1", "МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА ");
            new TestNews("Заголовок2", "МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА ");
            new TestNews("Заголовок3", "МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА ");
            new TestNews("Заголовок4", "МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА ");
            new TestNews("Заголовок5", "МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА МНОГО ТЕКСТА ");
        }
        public MainForm()
        {
            InitializeComponent();
        }
        private void moveLeftNews_Click(object sender, EventArgs e)
        {
            Controls<TextBox>.ScrollNewsLeft(textBox1, textBox2);
        }

        private void moveRightNews_Click(object sender, EventArgs e)
        {
            Controls<TextBox>.ScrollNewsRight(textBox1, textBox2);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateStandartNews();
            Controls<TextBox>.PrintNews(textBox1, textBox2);
            loginLabel.Text = MyUser.ActiveUser.Login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyProfile myProfile = new MyProfile();
            myProfile.ShowDialog();
        }
    }
}
