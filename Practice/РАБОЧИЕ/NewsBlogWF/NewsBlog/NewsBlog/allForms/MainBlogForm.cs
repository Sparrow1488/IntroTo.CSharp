using System;
using System.Windows.Forms;
using NewsBlog.autorizationDir;
using NewsBlog.newsDir;
using NewsBlog.allForms;

namespace NewsBlog
{
    public partial class MainBlogForm : Form
    {
        public static void StandartNews()
        {
            var news = new DefaultNews("Платформа Microsoft .NET", "Это комплекс программ, устанавливаемый поверх операционной системы и обеспечивающий выполнение программ, написанных специально для .NET. .NET-программы компактны, пользуются единым набором типов данных и библиотек. Компания Microsoft активно развивает платформу .NET, выпуская новые версии с расширенными возможностями. На момент начала 2019 г. последней версией является .NET 4.7.1.", "Anon");
            var news1 = new DefaultNews("Преимущества PascalABC.NET", "Язык PascalABC.NET включает в себя практически весь стандартный язык Паскаль, а также большинство языковых расширений языка Delphi. Однако, этих средств недостаточно для современного программирования. Именно поэтому PascalABC.NET расширен рядом конструкций, а его стандартный модуль - рядом подпрограмм, типов и классов, что позволяет создавать легко читающиеся приложения средней сложности.", "Anon");
            var news2 = new DefaultNews("Простая и мощная среда разработки", "Интегрированная среда разработки PascalABC.NET ориентирована на создание проектов малой и средней сложности. Она достаточно легковесна и в то же время обеспечивает разработчика всеми необходимыми средствами, такими как встроенный отладчик, средства Intellisense (подсказка по точке, подсказка по параметрам, всплывающая подсказка по имени), переход к определению и реализации подпрограммы, шаблоны кода, автоформатирование кода.", "Anon");
            var news3 = new DefaultNews("PascalABC.NET", "это система программирования и язык Pascal нового поколения для платформы Microsoft .NET. Язык PascalABC.NET содержит все основные элементы современных языков программирования: модули, классы, перегрузку операций, интерфейсы, исключения, обобщенные классы, сборку мусора, лямбда-выражения, а также некоторые средства параллельности, в том числе директивы OpenMP. Система PascalABC.NET включает в себя также простую интегрированную среду, ориентированную на эффективное обучение современному программированию.", "Anon");
        }

        public MainBlogForm()
        {
            InitializeComponent();
            StandartNews();
        }
        private int X = 0; //координаты формы
        private int Y = 0; //координаты формы
        private void button3_Click(object sender, EventArgs e)
        {
            ControlNews.ScrollNewsRight(titleTextBox1, descriptionTextBox1, AthtorTextBox);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ControlNews.ScrollNewsLeft(titleTextBox1, descriptionTextBox1, AthtorTextBox);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            News.indexCounter = News.NewsDBList.Count - 1;
            GetPrintNews();
        }

        private void MainBlogForm_Load(object sender, EventArgs e)
        {
            if (Autorization.loginCreator)
            {
                SetCreatorOptions(addNewsButton1, editNewsButton);
            }
            GetPrintNews();
            label4.Text = Autorization.NowActive;
        }
        private static void SetCreatorOptions(Button addN, Button editN)
        {
            //addN.Enabled = true;
            addN.Visible = true;

            //editN.Enabled = true;
            editN.Visible = true;
        }

        private void addNewsButton1_Click(object sender, EventArgs e)
        {
            AddNewsForm addNewsForm = new AddNewsForm();
            addNewsForm.ShowDialog();
        }
        private void closeFormButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            EditNewsForm editNewsForm = new EditNewsForm();
            editNewsForm.ShowDialog();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            GetPrintNews();
        }

        //ПЕРЕМЕЩАЕМ СВОЕ ОКНО
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X; Y = e.Y;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - X), this.Location.Y + (e.Y - Y));
            }
        }

        public void GetPrintNews()
        {
            ControlNews.PrintNews(titleTextBox1, descriptionTextBox1, AthtorTextBox);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
