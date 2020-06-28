using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManager
{
    public partial class EnterPage : Form
    {
        public EnterPage()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
              string pass = "1234", username = "oriya";

            if (textBoxUserName.Text == username && textBoxPassword.Text == pass)
            {
                this.Hide();
                Options optionsPage = new Options();
                optionsPage.ShowDialog();
            }
            else
                MessageBox.Show("Error! user name OR password are wrong.");            
        }

        private void buttonMainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
    }
   
}
