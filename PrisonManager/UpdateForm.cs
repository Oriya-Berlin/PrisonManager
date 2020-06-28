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
using System.Data.SqlClient;
using System.Threading;

namespace PrisonManager
{
    public partial class UpdateForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Berlin\source\repos\PrisonManager\PrisonManager\prisonersTable.mdf;Integrated Security=True;Connect Timeout=30");

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void CleanTheForm()
        {
            textBoxSearchUpdateForm.Clear();
            textBoxFnameUpdateForm.Clear();
            textBoxLnameUpdateForm.Clear();
            textBoxPenaltyUpdateForm.Clear();
            pictureBoxFrontUpdateForm.Image = new Bitmap(@"C:\Users\Berlin\source\repos\PrisonManager\PrisonManager\Pictures\front.jpg");
            pictureBoxSideUpdateForm.Image = new Bitmap(@"C:\Users\Berlin\source\repos\PrisonManager\PrisonManager\Pictures\side.jpg");
            textBoxSearchUpdateForm.Focus();
        }

        private void Display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from [Table]", con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridViewUpdate.Rows.Clear();

            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridViewUpdate.Rows.Add();
                dataGridViewUpdate.Rows[n].Cells[0].Value = item["Fname"].ToString();
                dataGridViewUpdate.Rows[n].Cells[1].Value = item["Lname"].ToString();
                dataGridViewUpdate.Rows[n].Cells[2].Value = item["ID_num"].ToString();
                dataGridViewUpdate.Rows[n].Cells[3].Value = item["gender"].ToString();
                dataGridViewUpdate.Rows[n].Cells[4].Value = item["crime"].ToString();
                dataGridViewUpdate.Rows[n].Cells[5].Value = item["penalty"].ToString();
                dataGridViewUpdate.Rows[n].Cells[6].Value = item["date"].ToString();
            }
        }

        private void buttonExitUpdateForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            Display();
            //textBoxSearchUpdateForm.Focus();
        }

        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxFrontUpdateForm.Image.Save(ms,pictureBoxFrontUpdateForm.Image.RawFormat);
            pictureBoxSideUpdateForm.Image.Save(ms,pictureBoxSideUpdateForm.Image.RawFormat);
            byte[] f_img = ms.ToArray();
            byte[] s_img = ms.ToArray();

            con.Open();
            string cmdText = "UPDATE [Table] SET Fname = @fn, Lname = @ln, penalty = @py, front_img = @fimg,side_img = @simg  WHERE ID_num = '" + textBoxIDNumberUpdateForm.Text+"'";
            SqlCommand cmd = new SqlCommand(cmdText,con);
            cmd.Parameters.AddWithValue("@fn",textBoxFnameUpdateForm.Text); // , front_img = @fimg, side_img = @simg
            cmd.Parameters.AddWithValue("@ln",textBoxLnameUpdateForm.Text);
            cmd.Parameters.AddWithValue("@py",textBoxPenaltyUpdateForm.Text);
            cmd.Parameters.AddWithValue("@fimg",f_img);
            cmd.Parameters.AddWithValue("@simg",s_img);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Contact member has been UPDATED successfully!");
            CleanTheForm();
        }

        private void buttonAddFront_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp;)|*.jpg; *.jpeg; *.bmp; ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFrontUpdateForm.Image = new Bitmap(open.FileName);
            }
        }

        private void buttonAddSide_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp;)|*.jpg; *.jpeg; *.bmp; ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxSideUpdateForm.Image = new Bitmap(open.FileName);
            }
        }

        private void textBoxSearchUpdateForm_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [Table] WHERE Fname like ('" + textBoxSearchUpdateForm.Text + "%') or Lname like ('" + textBoxSearchUpdateForm.Text + "%') or ID_num like ('" + textBoxSearchUpdateForm.Text + "%') or crime like ('" + textBoxSearchUpdateForm.Text + "%') ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewUpdate.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridViewUpdate.Rows.Add();
                dataGridViewUpdate.Rows[n].Cells[0].Value = row["Fname"].ToString();
                dataGridViewUpdate.Rows[n].Cells[1].Value = row["Lname"].ToString();
                dataGridViewUpdate.Rows[n].Cells[2].Value = row["ID_num"].ToString();
                dataGridViewUpdate.Rows[n].Cells[3].Value = row["gender"].ToString();
                dataGridViewUpdate.Rows[n].Cells[4].Value = row["crime"].ToString();
                dataGridViewUpdate.Rows[n].Cells[5].Value = row["penalty"].ToString();
                dataGridViewUpdate.Rows[n].Cells[6].Value = row["date"].ToString();
            }
        }

        

        private void dataGridViewUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxIDNumberUpdateForm.Text = dataGridViewUpdate.SelectedRows[0].Cells[2].Value.ToString();
            textBoxFnameUpdateForm.Text = dataGridViewUpdate.SelectedRows[0].Cells[0].Value.ToString();
            textBoxLnameUpdateForm.Text = dataGridViewUpdate.SelectedRows[0].Cells[1].Value.ToString();
            textBoxPenaltyUpdateForm.Text = dataGridViewUpdate.SelectedRows[0].Cells[5].Value.ToString();

            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT front_img FROM [Table] WHERE ID_num = '"+textBoxIDNumberUpdateForm.Text+"'",con);
            byte[] img = (byte[])cmd.ExecuteScalar();
            MemoryStream ms = new MemoryStream(img);
            pictureBoxFrontUpdateForm.Image = Image.FromStream(ms);
            con.Close();
        }
    
    }
}