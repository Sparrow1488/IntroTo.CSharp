using System;
using System.Windows.Forms;
using NewsBlog.autorizationDir;
using NewsBlog.newsDir;

namespace NewsBlog
{
    public partial class MainBlogForm : Form
    {
        public static void StandartNews()
        {
            var news = new AddNews("Платформа Microsoft .NET", "Это комплекс программ, устанавливаемый поверх операционной системы и обеспечивающий выполнение программ, написанных специально для .NET. .NET-программы компактны, пользуются единым набором типов данных и библиотек. Компания Microsoft активно развивает платформу .NET, выпуская новые версии с расширенными возможностями. На момент начала 2019 г. последней версией является .NET 4.7.1.");
            var news1 = new AddNews("Преимущества PascalABC.NET", "Язык PascalABC.NET включает в себя практически весь стандартный язык Паскаль, а также большинство языковых расширений языка Delphi. Однако, этих средств недостаточно для современного программирования. Именно поэтому PascalABC.NET расширен рядом конструкций, а его стандартный модуль - рядом подпрограмм, типов и классов, что позволяет создавать легко читающиеся приложения средней сложности.");
            var news2 = new AddNews("Простая и мощная среда разработки", "Интегрированная среда разработки PascalABC.NET ориентирована на создание проектов малой и средней сложности. Она достаточно легковесна и в то же время обеспечивает разработчика всеми необходимыми средствами, такими как встроенный отладчик, средства Intellisense (подсказка по точке, подсказка по параметрам, всплывающая подсказка по имени), переход к определению и реализации подпрограммы, шаблоны кода, автоформатирование кода.");
            var news3 = new AddNews("PascalABC.NET", "это система программирования и язык Pascal нового поколения для платформы Microsoft .NET. Язык PascalABC.NET содержит все основные элементы современных языков программирования: модули, классы, перегрузку операций, интерфейсы, исключения, обобщенные классы, сборку мусора, лямбда-выражения, а также некоторые средства параллельности, в том числе директивы OpenMP. Система PascalABC.NET включает в себя также простую интегрированную среду, ориентированную на эффективное обучение современному программированию.");
        }

        public MainBlogForm()
        {
            InitializeComponent();
            News.PrintNews(textBox2, textBox1);
            StandartNews();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            News.ScrollNewsRight(textBox2, textBox1);
            label3.Text = $"{News.indexCounter}";
            label1.Text = $"{News.NewsDBList.Count}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            News.ScrollNewsLeft(textBox2, textBox1);
            label3.Text = $"{News.indexCounter}";
            label1.Text = $"{News.NewsDBList.Count}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            News.indexCounter = News.NewsDBList.Count - 1;
            News.PrintNews(textBox2, textBox1);
            label3.Text = $"{News.indexCounter}";
            label1.Text = $"{News.NewsDBList.Count}";
        }

        private void MainBlogForm_Load(object sender, EventArgs e)
        {
            if (Autorization.loginCreator)
            {
                addNewsButton1.Enabled = true;
                addNewsButton1.Visible = true;
            }
        }

        private void addNewsButton1_Click(object sender, EventArgs e)
        {
            AddNewsForm addNewsForm = new AddNewsForm();
            addNewsForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
