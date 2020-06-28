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
    public partial class SearchForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Berlin\source\repos\PrisonManager\PrisonManager\prisonersTable.mdf;Integrated Security=True;Connect Timeout=30");
        

        public SearchForm()
        {
            InitializeComponent();
        }

         private void Display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from [Table]",con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridViewSearch.Rows.Clear();

            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridViewSearch.Rows.Add();
                dataGridViewSearch.Rows[n].Cells[0].Value = item["Fname"].ToString();
                dataGridViewSearch.Rows[n].Cells[1].Value = item["Lname"].ToString();
                dataGridViewSearch.Rows[n].Cells[2].Value = item["ID_num"].ToString();
                dataGridViewSearch.Rows[n].Cells[3].Value = item["gender"].ToString();
                dataGridViewSearch.Rows[n].Cells[4].Value = item["crime"].ToString();
                dataGridViewSearch.Rows[n].Cells[5].Value = item["penalty"].ToString();
                dataGridViewSearch.Rows[n].Cells[6].Value = item["date"].ToString();
            }
        }


        private void TextBoxSearchForm_Load(object sender, EventArgs e)
        {
            Display();
        }


        private void buttonAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string  CalculateFreedom(string date,int penalty)
        {
            int years, months,total_months;
            int castingMonths = int.Parse("" + date[3]+date[4]);
            int castingYears = int.Parse(""+ date[6]+date[7]+date[8]+date[9]);
            int castingDays = int.Parse("" + date[0]+date[1]);

            total_months = castingMonths + penalty;

            if(total_months <= 12)
                years = castingYears;
            else
                years = castingYears + (total_months / 12);

            if (total_months > 12)            
                months = total_months % 12;                           
            else
                months = total_months;

            return castingDays+"/"+months+"/"+years;
        }


        private void dataGridViewSearch_MouseClick(object sender, MouseEventArgs e)
        {

            textBoxID.Text =  dataGridViewSearch.SelectedRows[0].Cells[2].Value.ToString();
            string date = dataGridViewSearch.SelectedRows[0].Cells[6].Value.ToString();
            int penalty = int.Parse(dataGridViewSearch.SelectedRows[0].Cells[5].Value.ToString());
            textBox1.Text = CalculateFreedom(date,penalty); // only test

               /*
            string id = string.Format(dataGridViewSearch.SelectedRows[0].Cells[2].Value.ToString());           
            SqlCommand cmd = new SqlCommand("SELECT front_img FROM [Table] WHERE (ID_num = '" + id + "%')", con);
            var da = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count==1)
            {
                byte[] data = new byte[0];
                data = (byte[])(ds.Tables[0].Rows[0]["front_img"]);
                MemoryStream ms = new MemoryStream(data);
                pictureBoxSearchFront.Image = Image.FromStream(ms);
            }

            */           
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [Table] WHERE Fname like ('" + textBoxSearch.Text+ "%') or Lname like ('" + textBoxSearch.Text + "%') or ID_num like ('" + textBoxSearch.Text + "%') or crime like ('" + textBoxSearch.Text + "%') ", con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            dataGridViewSearch.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridViewSearch.Rows.Add();
                dataGridViewSearch.Rows[n].Cells[0].Value = row["Fname"].ToString();
                dataGridViewSearch.Rows[n].Cells[1].Value = row["Lname"].ToString();
                dataGridViewSearch.Rows[n].Cells[2].Value = row["ID_num"].ToString();
                dataGridViewSearch.Rows[n].Cells[3].Value = row["gender"].ToString();
                dataGridViewSearch.Rows[n].Cells[4].Value = row["crime"].ToString();
                dataGridViewSearch.Rows[n].Cells[5].Value = row["penalty"].ToString();
                dataGridViewSearch.Rows[n].Cells[6].Value = row["date"].ToString();
            }
        }


        private void buttonDeletePrisoner_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM [Table] WHERE (ID_num = '"+ textBoxID.Text + "')",con);
            cmd.ExecuteNonQuery();
            con.Close();            
            MessageBox.Show("Prisoner has been DELETED successfully!");
            Display();
        }
    }
}
