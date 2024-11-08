using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace email_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int GetRandomNo() 
        {
            Random rnd = new Random();
            int randomNo = rnd.Next(100, 900);
            return Convert.ToInt32(randomNo);
        }

        private void surname_Click(object sender, EventArgs e)
        {

        }

        private void randomNo_Click(object sender, EventArgs e)
        {

        }



        private void generateButton_Click(object sender, EventArgs e)
        {
        
            string name, surname, position = "", all;
            name = nameTextBox.Text;
            surname = surnameTextBox.Text;
            if (adminRadioButton.Checked) position = "adm";
            if (studentRadioButton.Checked) position = "stu";

           // all = name + surname + position;
            //output.Text = all;

            Generator generatorEmail = new Generator();
            generatorEmail.name = name;
            generatorEmail.surname = surname;
            generatorEmail.position = position;
            generatorEmail.randomNo = GetRandomNo();

            //int r = GetRandomNo();
           // output.Text = r.ToString();

            output.Text = generatorEmail.Generate();
        }

       
    }
}
