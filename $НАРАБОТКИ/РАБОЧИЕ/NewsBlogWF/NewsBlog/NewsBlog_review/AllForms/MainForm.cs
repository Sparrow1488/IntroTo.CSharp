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
            new TestNews("Common Language Runtime", "Исполняющая среда для байт-кода CIL (MSIL), в который компилируются программы, написанные на .NET-совместимых языках программирования (C#, Managed C++, Visual Basic .NET, F# и прочие). CLR является одним из основных компонентов пакета Microsoft .NET Framework.");
            new TestNews("C#", "Объектно-ориентированный язык программирования. Разработан в 1998—2001 годах группой инженеров компании Microsoft под руководством Андерса Хейлсберга и Скотта Вильтаумота[8] как язык разработки приложений для платформы Microsoft .NET Framework. Впоследствии был стандартизирован как ECMA-334 и ISO/IEC 23270.");
            new TestNews("Java", "Строго типизированный объектно-ориентированный язык программирования общего назначения, разработанный компанией Sun Microsystems (в последующем приобретённой компанией Oracle). Разработка ведётся сообществом, организованным через Java Community Process; язык и основные реализующие его технологии распространяются по лицензии GPL. Права на торговую марку принадлежат корпорации Oracle.");
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
            button1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyProfile myProfile = new MyProfile();
            myProfile.ShowDialog();
        }
    }
}
