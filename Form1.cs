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

        private void surname_Click(object sender, EventArgs e)
        {

        }

        private void randomNo_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string name, surname, positionRole = "", all;
            name = nameTextBox.Text;
            surname = surnameTextBox.Text;
            if (adminRadioButton.Checked) positionRole = "adm";

            if (studentRadioButton.Checked) positionRole = "stu";

            all = name + surname + positionRole;
            output.Text = all;

           
        }
    }
}
