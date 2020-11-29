using System;
using System.Windows.Forms;
using NewsBlog_review.UserControls;
using NewsBlog_review.Controls;
using NewsBlog_review.NewsControls;

namespace NewsBlog_review.AllForms
{
    public partial class MainForm : Form
    {
        private static int X = 0;
        private static int Y = 0;
        public static void CreateStandartNews()
        {
            new TestNews("Common Language Runtime", "Исполняющая среда для байт-кода CIL (MSIL), в который компилируются программы, написанные на .NET-совместимых языках программирования (C#, Managed C++, Visual Basic .NET, F# и прочие). CLR является одним из основных компонентов пакета Microsoft .NET Framework.");
            new TestNews("C#", "Объектно-ориентированный язык программирования. Разработан в 1998—2001 годах группой инженеров компании Microsoft под руководством Андерса Хейлсберга и Скотта Вильтаумота[8] как язык разработки приложений для платформы Microsoft .NET Framework. Впоследствии был стандартизирован как ECMA-334 и ISO/IEC 23270.");
            new TestNews("Java", "Строго типизированный объектно-ориентированный язык программирования общего назначения, разработанный компанией Sun Microsystems (в последующем приобретённой компанией Oracle). Разработка ведётся сообществом, организованным через Java Community Process; язык и основные реализующие его технологии распространяются по лицензии GPL. Права на торговую марку принадлежат корпорации Oracle.");
            new TestNews("Срочное обращение!", "Блять, а я ведь так подумал, хентай - культура как для истинных ценителей эстетики, так и для 'подрочить пойдет'. А что вот эта ваша irl хуета может, кроме оформи мою подписку на onlyFans и будь первым в курсе событий, м? Ну получается давайте альбомчик я создам, но на показ я этот стыд выставлять не буду получается. Отписывайтесь");
        }
        public MainForm()
        {
            InitializeComponent();
        }
        private void moveLeftNews_Click(object sender, EventArgs e)
        {
            Controls<TextBox>.ScrollNewsLeft(textBox1, textBox2, label3);
            label1.Text = (News.indexCounter + 1).ToString();
        }
        private void moveRightNews_Click(object sender, EventArgs e)
        {
            Controls<TextBox>.ScrollNewsRight(textBox1, textBox2, label3);
            label1.Text = (News.indexCounter + 1).ToString();
        }
        private void HideAllSubMenu()
        {
            subPanelProfileMenu.Visible = false;
            creatorSubMenuPanel.Visible = false;
        }
        private void ShowCreatorElements()
        {
            creatorButton.Visible = true;
            editNewsLabel.Visible = true;
        }
        private void HideCreatorElements()
        {
            creatorButton.Visible = false;
            editNewsLabel.Visible = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            HideCreatorElements();
            if (MyUser<Label>.ActiveUser.Access == "Creator")
            {
                ShowCreatorElements();
            }
            label1.Text = (News.indexCounter + 1).ToString();
            HideAllSubMenu();
            CreateStandartNews();
            Controls<TextBox>.PrintNews(textBox1, textBox2, label3);
            loginLabel.Text = MyUser<Label>.ActiveUser.Login;
            profileButton.Select();
        }
        private void ShowProfileSubMenu()
        {
            if (subPanelProfileMenu.Visible == false) subPanelProfileMenu.Visible = true;
            else if (subPanelProfileMenu.Visible == true) subPanelProfileMenu.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowProfileSubMenu();
        }
        private void profileButton_Click(object sender, EventArgs e)
        {
            MyProfile myProfile = new MyProfile();
            myProfile.Show();
        }
        private void ShowCreatorSubMenu()
        {
            if (creatorSubMenuPanel.Visible == false) creatorSubMenuPanel.Visible = true;
            else if (creatorSubMenuPanel.Visible == true) creatorSubMenuPanel.Visible = false;
        }
        private void creatorButton_Click(object sender, EventArgs e)
        {
            ShowCreatorSubMenu();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X; Y = e.Y;
        }
        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - X), this.Location.Y + (e.Y - Y));
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AddNewsForm addNewsForm = new AddNewsForm();
            addNewsForm.ShowDialog();
        }
        private void editNewsLabel_MouseHover(object sender, EventArgs e)
        {
            //label4.ForeColor = Color.Blue;
            //TODO: реализуй!
        }

        private void editNewsLabel_Click(object sender, EventArgs e)
        {
            AddNewsForm addNewsForm = new AddNewsForm(editNewsLabel);
            addNewsForm.ShowDialog();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            MyProfile myProfile = new MyProfile();
            myProfile.Show();
        }
    }
}
