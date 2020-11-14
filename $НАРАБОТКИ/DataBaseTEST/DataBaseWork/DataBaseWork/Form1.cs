using System;

//подключаем две сборки
using System.Data;
using System.Data.SqlClient;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseWork
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectingString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DOM\Desktop\HTML\C#\The-basis-of-CScharp\DataBaseTEST\DataBaseWork\DataBaseWork\Database1.mdf;Integrated Security=True";
            //коннектимся к базе данных
            sqlConnection = new SqlConnection(connectingString);
            //открываем соединение с БД
            await sqlConnection.OpenAsync();
        }
    }
}
