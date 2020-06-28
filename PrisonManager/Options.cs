using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PrisonManager
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void buttonAddPrisoner_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();          
            Application.OpenForms[0].Close(); // form '0' is the enter page
            /* 
              we can also use this loop to close all forms:
             
              for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
               {
                  if (Application.OpenForms[i].Name != "Menu")
                  Application.OpenForms[i].Close();
               }
             */
        }

        private void buttonSearchAndDelete_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.ShowDialog();           
        }

    }
}
