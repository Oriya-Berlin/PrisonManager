using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PrisonManager
{
    public partial class AddForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Berlin\source\repos\PrisonManager\PrisonManager\prisonersTable.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        public string front_path = "";
        public string side_path = "";

        public AddForm()
        {
            InitializeComponent();
        }

        
        private void buttonSavePrisoner_Click(object sender, EventArgs e)
        {
            string path_destination = @"C:\Users\Berlin\source\repos\PrisonManager\PrisonManager\Pictures";
            string source_path_front = front_path;
            string source_path_side = side_path;
            CopyImage(source_path_front,path_destination);
            CopyImage(source_path_side,path_destination);


            con.Open();           
            SqlCommand cmd = new SqlCommand("INSERT INTO [Table] " +
                "(Fname,Lname,ID_num,gender,crime,penalty,date,front_img,side_img) VALUES" +
                "('"+textBoxFname.Text+ "','" + textBoxLname.Text + "','" + textBoxID_num.Text + "','" + comboBoxGender.Text + "','" + textBoxCrime.Text + "','" + textBoxPenalty.Text + "','" + dateTimePicker1.Text + "','"+pictureBoxFront.Image+"','"+pictureBoxSide.Image+"')", con);          
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Prisoner has been saved successfully!");
            cleanTheForm();
            side_path = "";
            front_path = "";
        }

        
         private void buttonAddFront_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp;)|*.jpg; *.jpeg; *.bmp; ";
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFront.Image = new Bitmap(open.FileName);
            }
            front_path = open.FileName;
        }
       

        private void buttonAddSide_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp;)|*.jpg; *.jpeg; *.bmp; ";
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxSide.Image = new Bitmap(open.FileName);
            }
            side_path = open.FileName;
        }


         private void cleanTheForm()
         {
            textBoxFname.Clear();
            textBoxLname.Clear();
            comboBoxGender.SelectedIndex = -1;
            textBoxID_num.Clear();
            textBoxCrime.Clear();
            textBoxPenalty.Clear();
            pictureBoxFront.Image = new Bitmap(@"C:\Users\Berlin\source\repos\PrisonManager\PrisonManager\Pictures\front.jpg");
            pictureBoxSide.Image = new Bitmap(@"C:\Users\Berlin\source\repos\PrisonManager\PrisonManager\Pictures\side.jpg");
         }

        private void buttonAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CopyImage(string source,string dest)
        {
            //string sourceFile = Path.Combine();
            //string destFile = Path.Combine();
            File.Copy(source, dest, true);
        }
        
    }
}
