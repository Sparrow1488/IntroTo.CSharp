using System;
using System.Windows.Forms;
using NewsBlog.newsDir;

namespace NewsBlog
{
    public partial class AddNewsForm : Form
    {
        private int X = 0; //получаем координаты формы
        private int Y = 0; //получаем координаты формы
        public AddNewsForm(Button btn)
        {
            
            InitializeComponent();
            //в зависимости от полученной кнопки, разрешаем доступ к определенным инструментам
            if (btn.Name == "editNewsButton")
            {
                VisiableButtonsCreator(editButton);
                News.SetEditsNews(textBox1, textBox2);
            }
            if (btn.Name == "addNewsButton1") VisiableButtonsCreator(addButton);
        }

        public static void VisiableButtonsCreator(Button visiableButton)
        {
            visiableButton.Visible = true;
            visiableButton.Enabled = true;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                var news = new AddNews(textBox1.Text, textBox2.Text);
                this.Close();
            }
            else{ exeptionLabel1.Visible = true; }
        }

        private void AddNewsForm_MouseDown(object sender, MouseEventArgs e)
        {
            exeptionLabel1.Visible = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            News.NewsEditor(textBox1, textBox2);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X; Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - X), this.Location.Y + (e.Y - Y));
            }
        }
    }
}
