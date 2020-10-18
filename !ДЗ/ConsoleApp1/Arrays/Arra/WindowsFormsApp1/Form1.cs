using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string[] arr = new string[4] {"this", "is", "new", "array"};
        public string boxText = "пустое значение";
        //uint valueNumStr;
        //string valueTextStr;
        uint indexArr;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            for (uint i = 0; i < arr.Length; i++)
            {
                label2.Text += arr[i] + $"({i + 1})" + " ";
            }
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            boxText = textBox1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //очищаю строку ошибок вначале
            label4.BackColor = Color.White;
            label4.Text = "Обработчик ошибок: 0";
            
            try
            {
                if (textBox2.Text == "" || indexArr > arr.Length || indexArr < 1)
                {
                    throw new Exception("вы ввели неверный номер слова или ввели его некорректно!");
                }

                arr[indexArr - 1] = textBox1.Text;
            }
            catch (Exception ex)
            {
                label4.Text = ex.Message;
                label4.BackColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                indexArr = uint.Parse(textBox2.Text);
        }
        
    }
}
