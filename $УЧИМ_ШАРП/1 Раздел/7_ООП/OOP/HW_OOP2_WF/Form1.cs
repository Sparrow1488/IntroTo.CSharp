using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_OOP2_WF
{
    public partial class Form1 : Form
    {
        Profile prof = new Profile();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _setName = null;
            string _setSecondName = null;
            string _phoneNumber = null;
            errorLabel.Text = "Error label:";
            errorLabel.ForeColor = Color.Black ;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = "Error label: не введено имя";
            }
            else if(string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = "Error label: не введена фамилия";
            }
            else if(string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = "Error label: не введен номер";
            }
            else
            {
                _setName = textBox1.Text;
                _setSecondName = textBox2.Text;
                _phoneNumber = textBox3.Text;
            }
            prof.StartCreateProfile(_setName, _setSecondName, _phoneNumber);
            //button1.Enabled = false;
        }
    }
}
